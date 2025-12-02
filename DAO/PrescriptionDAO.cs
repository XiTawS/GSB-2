using GSB_2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace GSB_2.DAO
{
    internal class PrescriptionDAO
    {
        private readonly Database db = new Database();

        public bool CreatePrescription(int id_user, int id_patient, DateTime validity, List<(int id_medicine, int quantity)> medicines)
        {
            // Construction du texte des médicaments : "Doliprane 500mg x2, Ibuprofène 20mg x1, ..."
            string medicinesText = "";

            for (int i = 0; i < medicines.Count; i++)
            {
                var (id_med, qty) = medicines[i];
                string nomEtDosage = GetNomEtDosageDuMedicament(id_med);

                if (i > 0) medicinesText += ", ";
                medicinesText += $"{nomEtDosage} x{qty}";
            }

            if (string.IsNullOrEmpty(medicinesText))
                medicinesText = "Aucun médicament";

            string query = @"INSERT INTO Prescription 
                             (id_user, id_patient, medicines, validity) 
                             VALUES (@id_user, @id_patient, @medicines, @validity)";

            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", id_user);
                    cmd.Parameters.AddWithValue("@id_patient", id_patient);
                    cmd.Parameters.AddWithValue("@medicines", medicinesText);
                    cmd.Parameters.AddWithValue("@validity", validity.Date);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Récupérer une ordonnance par ID
        public Prescription GetById(int idPrescription)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT id_prescription, id_user, id_patient, medicines, validity 
                               FROM Prescription 
                               WHERE id_prescription = @id";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idPrescription);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Prescription
                            {
                                IdPrescription = reader.GetInt32("id_prescription"),
                                IdUser = reader.GetInt32("id_user"),
                                idPatient = reader.GetInt32("id_patient"),
                                Medicines = reader.GetString("medicines"),
                                Validity = reader.GetDateTime("validity")  // DateTime, pas string
                            };
                        }
                    }
                }
            }
            return null;
        }

        // Récupérer toutes les ordonnances
        public List<Prescription> GetAll()
        {
            var liste = new List<Prescription>();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT id_prescription, id_user, id_patient, medicines, validity 
                               FROM Prescription 
                               ORDER BY validity DESC";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            liste.Add(new Prescription
                            {
                                IdPrescription = reader.GetInt32("id_prescription"),
                                IdUser = reader.GetInt32("id_user"),
                                idPatient = reader.GetInt32("id_patient"),
                                Medicines = reader.GetString("medicines"),
                                Validity = reader.GetDateTime("validity")
                            });
                        }
                    }
                }
            }
            return liste;
        }

        private string GetNomEtDosageDuMedicament(int id_medicine)
        {
            string sql = "SELECT name, dosage FROM Medicine WHERE id_medicine = @id";
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id_medicine);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nom = reader.GetString("name");
                            int dosage = reader.GetInt32("dosage");
                            return $"{nom} {dosage}mg";
                        }
                    }
                }
            }
            return "Médicament inconnu";
        }
        public bool Update(int idPrescription, int id_patient, DateTime validity, List<(int id_medicine, int quantity)> medicines)
        {
            string medicinesText = "";
            for (int i = 0; i < medicines.Count; i++)
            {
                var (id_med, qty) = medicines[i];
                string nomEtDosage = GetNomEtDosageDuMedicament(id_med);
                if (i > 0) medicinesText += ", ";
                medicinesText += $"{nomEtDosage} x{qty}";
            }
            if (string.IsNullOrEmpty(medicinesText))
                medicinesText = "Aucun médicament";

            string query = @"UPDATE Prescription
                     SET id_patient = @id_patient,
                         medicines = @medicines,
                         validity = @validity
                     WHERE id_prescription = @id";

            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idPrescription);
                    cmd.Parameters.AddWithValue("@id_patient", id_patient);
                    cmd.Parameters.AddWithValue("@medicines", medicinesText);
                    cmd.Parameters.AddWithValue("@validity", validity.Date);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool Delete(int idPrescription)
        {
            string query = "DELETE FROM Prescription WHERE id_prescription = @id";
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idPrescription);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}