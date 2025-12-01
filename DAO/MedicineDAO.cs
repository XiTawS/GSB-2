using GSB_2.Models;
using MySql.Data.MySqlClient;
using System;

namespace GSB_2.DAO
{
    internal class MedicineDAO
    {
        private readonly Database db = new Database();

        public List<Medicine> GetAll()
        {
            List<Medicine> listMedicine = new List<Medicine>();

            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();

                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"SELECT * FROM Medicine;";

                    using var myReader = myCommand.ExecuteReader();
                    {
                        while (myReader.Read())
                        {
                            Medicine medicine = new Medicine(myReader.GetInt32("id_medicine"), myReader.GetInt32("id_user"), myReader.GetInt32("dosage"), myReader.GetString("name"), myReader.GetString("description"), myReader.GetString("molecule"));
                            listMedicine.Add(medicine);
                        }
                    }
                    return listMedicine;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }
        public bool CreateMedicine(int id_user, string name, string molecule, int dosage, string description)
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
    }
}
