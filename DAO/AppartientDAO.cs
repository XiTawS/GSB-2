using GSB_2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace GSB_2.DAO
{
    internal class AppartientDAO
    {
        private readonly Database db = new Database();

        // Récupère toutes les associations (medicines ↔ prescriptions) pour une prescription donnée
        public List<Appartient> GetByPrescriptionId(int idPrescription)
        {
            var list = new List<Appartient>();

            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();

                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"SELECT * FROM appartient WHERE id_prescription = @id;";
                    myCommand.Parameters.AddWithValue("@id", idPrescription);

                    using var myReader = myCommand.ExecuteReader();
                    {
                        while (myReader.Read())
                        {
                            int id_medicine = myReader.GetInt32("id_medicine");
                            int id_prescription = myReader.GetInt32("id_prescription");
                            int quantity = myReader.GetInt32("quantity");

                            list.Add(new Appartient(id_medicine, id_prescription, quantity));
                        }

                        connection.Close();
                        return list;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return list;
                }
            }
        }
        public bool AddMedicineToPrescription(int id_prescription, int id_medicine, int quantity)
        {
            string query = @"INSERT INTO Appartient 
                     (id_prescription, id_medicine, quantity) 
                     VALUES 
                     (@id_prescription, @id_medicine, @quantity)";

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_prescription", id_prescription);
                    cmd.Parameters.AddWithValue("@id_medicine", id_medicine);
                    cmd.Parameters.AddWithValue("@quantity", quantity);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
