using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SpLoginApp.Enitities;

namespace SpLoginApp.DAL
{
    public class UserDAL:WorkingAllDb
    {


        
        #region Login
        public User Login(string email, string password)
        {
            User users = null;
            using (var connection = ConnectDb.GetSqlConnection())
            {
                var query = @"SELECT [Id], [Email], [Password], [Status] FROM Users WHERE Email = '" + email + "' AND Password = '" + password + "'";
                
                var cmd = new SqlCommand(query, connection);
                connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users = new User
                        {
                            Id = Convert.ToInt32(reader["Id"].ToString()),
                            Email = reader["Email"].ToString(),
                            Password = reader["Password"].ToString(),
                            Status = reader["Status"].ToString()
                        };
                    }

                    connection.Close();
                }
            }
            return users;
        }
        #endregion




        #region BlockUser
        public bool BlockUser(int userId)
        {
            var query = @"UPDATE Users SET Status = 9 WHERE Id = " + userId;
            return SaveChanges(query);
        }
        #endregion



        #region EmailCheck
        public User EmailCheck(string email)
        {
            User users = null;
            using (var connection = ConnectDb.GetSqlConnection())
            {
                var query = @"SELECT [Id], [Email], [Password], [Status] FROM Users WHERE Email = '" + email + "'";

                var cmd = new SqlCommand(query, connection);
                connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users = new User
                        {
                            Id = Convert.ToInt32(reader["Id"].ToString()),
                            Email = reader["Email"].ToString(),
                            Password = reader["Password"].ToString(),
                            Status = reader["Status"].ToString()
                        };
                    }

                    connection.Close();
                }
            }
            return users;
        }
        #endregion


    }
}