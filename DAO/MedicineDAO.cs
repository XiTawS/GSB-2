using GSB_2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace GSB_2.DAO
{
    internal class MedicineDAO
    {
        private readonly Database db = new Database();

        public List<Medicine> GetAll()
        {
            var listMedicine = new List<Medicine>();

            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    string sql = @"SELECT id_medicine, id_user, name, dosage, molecule, description 
                           FROM Medicine 
                           ORDER BY name";

                    using (var cmd = new MySqlCommand(sql, connection))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var med = new Medicine
                            {
                                IdMedicine = reader.GetInt32("id_medicine"),
                                IdUser = reader.GetInt32("id_user"),
                                Name = reader.GetString("name"),
                                Dosage = "Inconnu",           // valeur par défaut
                                Molecule = "Inconnu",
                                Description = null
                            };

                            if (!reader.IsDBNull(reader.GetOrdinal("dosage")))
                                med.Dosage = reader.GetString("dosage");

                            if (!reader.IsDBNull(reader.GetOrdinal("molecule")))
                                med.Molecule = reader.GetString("molecule");

                            if (!reader.IsDBNull(reader.GetOrdinal("description")))
                                med.Description = reader.GetString("description");

                            listMedicine.Add(med);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des médicaments : " + ex.Message);
                }
            }
            return listMedicine;
        }
        public bool CreateMedicine(int id_user, string name, string molecule, string dosage, string description)
        {
            string query = @"INSERT INTO Medicine 
                     (id_user, name, molecule, dosage, description) 
                     VALUES 
                     (@id_user, @name, @molecule, @dosage, @description)";

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", id_user);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@molecule", molecule);
                    cmd.Parameters.AddWithValue("@dosage", dosage);
                    cmd.Parameters.AddWithValue("@description", description ?? (object)DBNull.Value);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public Medicine? GetById(int idMedicine)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT id_medicine, id_user, name, dosage, molecule, description 
                               FROM Medicine WHERE id_medicine = @id";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idMedicine);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Medicine
                            {
                                IdMedicine = reader.GetInt32("id_medicine"),
                                IdUser = reader.GetInt32("id_user"),
                                Name = reader.GetString("name"),
                                Dosage = reader.GetString("dosage"),
                                Molecule = reader.GetString("molecule"),
                                Description = reader.IsDBNull("description") ? null : reader.GetString("description")
                            };
                        }
                    }
                }
            }
            return null;
        }

        // Met à jour un médicament
        public bool Update(Medicine med)
        {
            string sql = @"UPDATE Medicine 
                           SET name = @name, 
                               dosage = @dosage, 
                               molecule = @molecule, 
                               description = @desc 
                           WHERE id_medicine = @id";

            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", med.IdMedicine);
                    cmd.Parameters.AddWithValue("@name", med.Name);
                    cmd.Parameters.AddWithValue("@dosage", med.Dosage);        
                    cmd.Parameters.AddWithValue("@molecule", med.Molecule);
                    cmd.Parameters.AddWithValue("@desc", (object)med.Description ?? DBNull.Value);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool Delete(int idMedicine)
        {
            string sql = "DELETE FROM Medicine WHERE id_medicine = @id";

            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idMedicine);
                    try
                    {
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (MySqlException ex) when (ex.Number == 1451) // erreur de contrainte FK
                    {
                        return false; // le médicament est utilisé dans une ordonnance → on bloque
                    }
                }
            }
        }
    }
}
