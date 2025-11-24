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
    }
}
