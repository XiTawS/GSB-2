using GSB_2.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace GSB_2.DAO
{
    internal class UserDAO
    {
        private readonly Database db = new Database();

        public User? Login(string email, string password)
        {
            int id;
            string name, firstname;
            bool role;

            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();

                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;

                    myCommand.CommandText = @"SELECT * FROM User WHERE email = @email AND password = @password ;";
                    myCommand.Parameters.AddWithValue("@email", email);
                    myCommand.Parameters.AddWithValue("@password", password);

                    using var myReader = myCommand.ExecuteReader();
                    {
                        if (myReader.Read())
                        {
                            id = myReader.GetInt32("id_user");
                            name = myReader.GetString("name");
                            firstname = myReader.GetString("firstname");
                            role = myReader.GetBoolean("role");
                            return new User(id, name, firstname, role);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur DAO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

        }
        public List<User> GetAll()
        {
            List<User> listUser = new List<User>();

            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();

                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"SELECT * FROM User;";

                    using var myReader = myCommand.ExecuteReader();
                    {
                        while (myReader.Read())
                        {
                            User user = new User(
                                myReader.GetInt32("id_user"),
                                myReader.GetString("name"),
                                myReader.GetString("firstname"),
                                myReader.GetBoolean("role"));
                            listUser.Add(user);
                        }
                    }
                    return listUser;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }
        public bool CreateUser(string name, string firstname, string email, string password, bool role)
        {
            string query = @"INSERT INTO User 
                     (name, firstname, email, password, role) 
                     VALUES 
                     (@name, @firstname, @email, @password, @role)";

            SHA256 sha256 = SHA256.Create();
            byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            string hashedPassword = BitConverter.ToString(hashValue).Replace("-", "").ToLowerInvariant();


            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@role", role ? 1 : 0);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}