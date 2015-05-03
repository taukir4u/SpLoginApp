using System;
using System.Data.SqlClient;
using SpLoginApp.Enitities;

namespace SpLoginApp.DAL
{
    public class LoginLogDAL:WorkingAllDb
    {

        #region Save
        public bool Save(LoginLog loginLog)
        {
            var query = @"INSERT INTO LoginLog(UserId) VALUES ('"+loginLog.UserId+"')";
            return SaveChanges(query);
        }
        #endregion



        #region LoginTry
        public bool ClearLog(int id)
        {
            var query = @"DELETE LoginLog WHERE UserId = " + id;
            return SaveChanges(query);
        }
        #endregion






        #region LoginTry
        public int LoginTry(int id)
        {
            int loginTry = 0;
            using (var connection = ConnectDb.GetSqlConnection())
            {
                var query = @"SELECT COUNT(Id) AS LoginId FROM LoginLog WHERE UserId = " + id;

                var cmd = new SqlCommand(query, connection);
                connection.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        loginTry = Convert.ToInt32(reader["LoginId"].ToString());
                    }

                    connection.Close();
                }
            }
            return loginTry;
        }
        #endregion



    }
}