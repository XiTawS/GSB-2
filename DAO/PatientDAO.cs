using GSB_2.Models;
using MySql.Data.MySqlClient;
     using System;

namespace GSB_2.DAO
{
    internal class PatientDAO
    {
        private readonly Database db = new Database();

        public Patient? GetById(int idPatient)
        {
            int id_patient;
            int id_user;
            string name;
            int age;
            string firstname;
            string gender;

            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();

                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"SELECT * FROM Patient";

                    using var myReader = myCommand.ExecuteReader();
                    {
                        if (myReader.Read())
                        {
                            id_patient = myReader.GetInt32("id_patient");
                            id_user = myReader.GetInt32("id_user");
                            name = myReader.GetString("name");
                            age = myReader.GetInt32("age");
                            firstname = myReader.GetString("firstname");
                            gender = myReader.GetString("gender");

                            return new Patient(id_patient, id_user, name, age, firstname, gender);
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
        public List<Patient> GetAll()
        {
            List<Patient> listPatient = new List<Patient>();

            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();

                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"SELECT * FROM Patient;";

                    using var myReader = myCommand.ExecuteReader();
                    {
                        while (myReader.Read())
                        {
                            Patient patient = new Patient(
                                myReader.GetInt32("id_patient"),
                                myReader.GetInt32("id_user"),
                                myReader.GetString("name"), 
                                myReader.GetInt32("age"), 
                                myReader.GetString("firstname"), 
                                myReader.GetString("gender"));
                            listPatient.Add(patient);
                        }
                    }
                    return listPatient;
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
