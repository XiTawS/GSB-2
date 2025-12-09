// GSB_2/DAO/PrescriptionDAO.cs
using GSB_2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace GSB_2.DAO
{
    internal class PrescriptionDAO
    {
        private readonly Database db = new Database();

        // PrescriptionDAO.cs → remplace toute la méthode Create par ÇA
        public bool Create(Prescription prescription, Dictionary<int, int> medicines)
        {
            using var conn = db.GetConnection();
            MySqlTransaction transaction = null;
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // 1. Insertion de la prescription
                var cmdPres = new MySqlCommand(@"
            INSERT INTO Prescription (id_user, id_patient, validity) 
            VALUES (@id_user, @id_patient, @validity);
            SELECT LAST_INSERT_ID();", conn, transaction);

                cmdPres.Parameters.AddWithValue("@id_user", prescription.IdUser);
                cmdPres.Parameters.AddWithValue("@id_patient", prescription.IdPatient);
                cmdPres.Parameters.AddWithValue("@validity", prescription.Validity.Date); // .Date pour éviter l'heure

                int newPrescriptionId = Convert.ToInt32(cmdPres.ExecuteScalar());

                // 2. Insertion des médicaments (seulement s'il y en a)
                if (medicines != null && medicines.Count > 0)
                {
                    var valuesList = new List<string>();
                    var parameters = new List<MySqlParameter>();

                    int i = 0;
                    foreach (var med in medicines)
                    {
                        if (med.Value <= 0) continue;

                        string pId = $"@idmed{i}";
                        string pQty = $"@qty{i}";

                        valuesList.Add($"({newPrescriptionId}, {pId}, {pQty})");

                        parameters.Add(new MySqlParameter(pId, med.Key));
                        parameters.Add(new MySqlParameter(pQty, med.Value));
                        i++;
                    }

                    if (valuesList.Count > 0)
                    {
                        string sqlAppartient = $"INSERT INTO Appartient (id_prescription, id_medicine, quantity) VALUES {string.Join(",", valuesList)};";
                        var cmdApp = new MySqlCommand(sqlAppartient, conn, transaction);
                        cmdApp.Parameters.AddRange(parameters.ToArray());
                        cmdApp.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
                return true;
            }
            catch (MySqlException ex)
            {
                transaction?.Rollback();
                // CETTE LIGNE VA TE SAUVER LA VIE
                MessageBox.Show($"ERREUR MySQL pendant la création :\n{ex.Message}\n\nCode : {ex.Number}\n\nRequête concernée : {ex.SqlState}",
                    "Erreur base de données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show($"ERREUR inattendue :\n{ex.Message}\n\n{ex.StackTrace}",
                    "Erreur critique", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Bonus : tu pourras l'utiliser plus tard pour afficher les ordonnances
        // Dans PrescriptionDAO.cs → remplace ou ajoute cette méthode
        public List<Prescription> GetAll()
        {
            var prescriptions = new List<Prescription>();

            string sql = @"
        SELECT 
            p.id_prescription,
            p.id_user,
            p.id_patient,
            p.validity,
            pat.name AS pat_nom,
            pat.firstname AS pat_prenom,
            u.name AS med_nom,
            u.firstname AS med_prenom,
            m.name AS med_name,
            m.dosage,
            a.quantity
        FROM Prescription p
        JOIN Patient pat ON p.id_patient = pat.id_patient
        JOIN User u ON p.id_user = u.id_user
        LEFT JOIN Appartient a ON p.id_prescription = a.id_prescription
        LEFT JOIN Medicine m ON a.id_medicine = m.id_medicine
        ORDER BY p.id_prescription DESC";

            using var conn = db.GetConnection();
            conn.Open();
            using var cmd = new MySqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            var dict = new Dictionary<int, Prescription>();

            while (reader.Read())
            {
                int id = reader.GetInt32("id_prescription");

                if (!dict.TryGetValue(id, out Prescription pres))
                {
                    pres = new Prescription(
                        id,
                        reader.GetInt32("id_user"),
                        reader.GetInt32("id_patient"),
                        reader.GetDateTime("validity")
                    );

                    pres.Patient = $"{reader.GetString("pat_nom")} {reader.GetString("pat_prenom")}";
                    pres.Médecin = $"{reader.GetString("med_nom")} {reader.GetString("med_prenom")}";
                    pres.Médicaments = ""; // on va remplir après

                    dict.Add(id, pres);
                    prescriptions.Add(pres);
                }

                // Ajout du médicament (si présent)
                if (!reader.IsDBNull(reader.GetOrdinal("med_name")))
                {
                    string med = $"{reader.GetString("med_name")} {reader.GetString("dosage")} ×{reader.GetInt32("quantity")}";
                    if (!string.IsNullOrEmpty(pres.Médicaments))
                        pres.Médicaments += "  •  ";
                    pres.Médicaments += med;
                }
            }

            return prescriptions;
        }
        public bool UpdatePrescription(int idPrescription, int idPatient, DateTime validity, Dictionary<int, int> newMedicines)
{
    using var conn = db.GetConnection();
    MySqlTransaction trans = null;
    try
    {
        conn.Open();
        trans = conn.BeginTransaction();

        // 1. Mettre à jour la prescription
        var cmd = new MySqlCommand(@"
            UPDATE Prescription 
            SET id_patient = @id_patient, validity = @validity 
            WHERE id_prescription = @id", conn, trans);
        cmd.Parameters.AddWithValue("@id_patient", idPatient);
        cmd.Parameters.AddWithValue("@validity", validity);
        cmd.Parameters.AddWithValue("@id", idPrescription);
        cmd.ExecuteNonQuery();

        // 2. Supprimer les anciens médicaments
        new MySqlCommand($"DELETE FROM Appartient WHERE id_prescription = {idPrescription}", conn, trans).ExecuteNonQuery();

        // 3. Ajouter les nouveaux
        if (newMedicines.Count > 0)
        {
            var values = new List<string>();
            foreach (var m in newMedicines)
                values.Add($"({idPrescription}, {m.Key}, {m.Value})");

            new MySqlCommand($"INSERT INTO Appartient (id_prescription, id_medicine, quantity) VALUES {string.Join(",", values)}", conn, trans)
                .ExecuteNonQuery();
        }

        trans.Commit();
        return true;
    }
    catch
    {
        trans?.Rollback();
        return false;
    }
}

public bool DeletePrescription(int idPrescription)
{
    using var conn = db.GetConnection();
    try
    {
        conn.Open();
        new MySqlCommand($"DELETE FROM Prescription WHERE id_prescription = {idPrescription}", conn).ExecuteNonQuery();
        return true;
    }
    catch
    {
        return false;
    }
}
    }
}