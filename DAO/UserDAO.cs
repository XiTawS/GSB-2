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
        public User? GetById(int idUser)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT id_user, name, firstname, email, password, role 
                       FROM User 
                       WHERE id_user = @id";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idUser);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Id = reader.GetInt32("id_user"),
                                Name = reader.GetString("name"),
                                Firstname = reader.GetString("firstname"),
                                Email = reader.GetString("email"),
                                Password = reader.GetString("password"),
                                Role = reader.GetBoolean("role")       
                            };
                        }
                    }
                }
            }
            return null;
        }
        public bool Update(int idUser, string name, string firstname, string email, string plainPassword, bool role)
        {
            // Si le mot de passe est vide → on ne le change pas
            string sql = string.IsNullOrEmpty(plainPassword)
                ? "UPDATE User SET name = @name, firstname = @firstname, email = @email, role = @role WHERE id_user = @id"
                : "UPDATE User SET name = @name, firstname = @firstname, email = @email, password = @password, role = @role WHERE id_user = @id";

            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idUser);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@role", role);

                    if (!string.IsNullOrEmpty(plainPassword))
                    {
                        string hashedPassword = HashPassword(plainPassword);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                    }

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool Delete(int idUser)
        {
            string sql = "DELETE FROM User WHERE id_user = @id";

            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idUser);

                    try
                    {
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (MySqlException ex) when (ex.Number == 1451) // Contrainte de clé étrangère
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
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
            }
        }
    }
}