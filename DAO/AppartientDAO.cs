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

                            list.Add(new Appartient(id_medicine, id_prescription));
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
    }
}
