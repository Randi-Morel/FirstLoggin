using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FirstLoggin.Models
{
    class Connection
    {
        private string connectionString;

        public Connection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool GetUser(string userName, string password)
        {
            string query = "SELECT COUNT(*) FROM [Users] WHERE UserName = @UserName AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        public List<Users> users() 
        { 
            List<Users> users = new List<Users>();

            string query = "SELECT Id, UserName, Password FROM [Users]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try 
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Users user = new Users();
                            user.Id = reader.GetInt32(0);
                            user.UserName = reader.GetString(1);
                            user.Password = reader.GetString(2);
                            users.Add(user);
                        }
                        reader.Close();
                        connection.Close();
                    }
                    catch(Exception ex)
                    {
                        throw new Exception("Error: " + ex.Message);
                    }
                }

            }

            return users;
        }

        public Users users(int? id)
        {

            string query = "SELECT Id, UserName, Password FROM [Users] where Id=@Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                        
                        Users user = new Users();
                        user.Id = reader.GetInt32(0);
                        user.UserName = reader.GetString(1);
                        user.Password = reader.GetString(2);
                        
                        reader.Close();
                        connection.Close();
                        return user;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error: " + ex.Message);
                    }
                }

            }
        }


        public void Add ( string userName, string password ) 
        {
            string query = "insert into Users(UserName, Password) values(@UserName, @Password)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error: " + ex.Message);
                    }
                }

            }
        }

        public void Update(int id ,string userName, string password)
        {
            string query = "update Users set UserName = @UserName, Password = @Password where Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);


                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error: " + ex.Message);
                    }
                }

            }
        }

        public void Delete(int id)
        {
            string query = "delete from Users where Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error: " + ex.Message);
                    }
                }

            }
        }


        public class Users
        {
            public int Id { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}

