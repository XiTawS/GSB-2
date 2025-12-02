using GSB_2.Models;
using MySql.Data.MySqlClient;
     using System;
using System.Data;

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
                    myCommand.CommandText = @"SELECT id_patient, id_user, name, firstname, age, gender 
                                      FROM Patient 
                                      WHERE id_patient = @id";
                    myCommand.Parameters.AddWithValue("@id", idPatient);

                    using var myReader = myCommand.ExecuteReader();
                    {
                        if (myReader.Read())
                        {
                            id_patient = myReader.GetInt32("id_patient");
                            id_user = myReader.GetInt32("id_user");
                            name = myReader.GetString("name");
                            firstname = myReader.GetString("firstname");
                            age = myReader.GetInt32("age");
                            gender = myReader.GetString("gender");

                            return new Patient(id_patient, id_user, name, age, firstname, gender);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur GetById Patient : " + ex.Message);
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
        public bool CreatePatient(int id_user, string name, string firstname, int age, string gender)
        {
            string query = @"INSERT INTO Patient 
                     (id_user, name, firstname, age, gender) 
                     VALUES 
                     (@id_user, @name, @firstname, @age, @gender)";

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", id_user);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@gender", gender);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool Update(Patient patient)
        {
            string sql = @"UPDATE Patient 
                           SET name = @name, 
                               firstname = @firstname, 
                               age = @age, 
                               gender = @gender 
                           WHERE id_patient = @id";

            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", patient.IdPatient);
                    cmd.Parameters.AddWithValue("@name", patient.Name);
                    cmd.Parameters.AddWithValue("@firstname", patient.Firstname);
                    cmd.Parameters.AddWithValue("@age", patient.Age);
                    cmd.Parameters.AddWithValue("@gender", string.IsNullOrEmpty(patient.Gender) ? (object)DBNull.Value : patient.Gender);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool Delete(int idPatient)
        {
            string sql = "DELETE FROM Patient WHERE id_patient = @id";

            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idPatient);

                    try
                    {
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (MySqlException ex) when (ex.Number == 1451) // Contrainte FK
                    {
                        return false;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
        }
    }
}
