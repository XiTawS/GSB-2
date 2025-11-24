using GSB_2.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_2.DAO
{
    internal class PrescriptionDAO
    {
        private readonly Database db = new Database();

        public Prescription? GetById(int idPrescription)
        {
            int id_prescription;
            int id_user;
            string validity;
            int id_patient;

            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();

                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"SELECT * FROM prescriptions WHERE id_prescription = @id;";
                    myCommand.Parameters.AddWithValue("@id", idPrescription);

                    using var myReader = myCommand.ExecuteReader();
                    {
                        if (myReader.Read())
                        {
                            id_prescription = myReader.GetInt32("id_prescription");
                            id_user = myReader.GetInt32("id_user");
                            validity = myReader.GetString("validity");
                            id_patient = myReader.GetInt32("id_patient");

                            return new Prescription(id_prescription, id_user, validity, id_patient);
                        }
                        else
                        {
                            connection.Close();
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }
        public List<Prescription> GetAll()
        {
            List<Prescription> listPrescription = new List<Prescription>();

            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();

                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"SELECT id_prescription, validity, id_patient  FROM Prescription;";

                    using var myReader = myCommand.ExecuteReader();
                    {
                        while (myReader.Read())
                        {
                            Prescription prescription = new Prescription(

                                myReader.GetInt32("id_prescription"),
                                myReader.GetInt32("id_user"),
                                myReader.GetString("validity"),
                                myReader.GetInt32("id_patient"));

                            listPrescription.Add(prescription);
                        }
                    }
                    return listPrescription;
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
