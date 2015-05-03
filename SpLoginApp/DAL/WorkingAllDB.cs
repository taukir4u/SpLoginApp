using System;
using System.Data;
using System.Data.SqlClient;

namespace SpLoginApp.DAL
{
    public class WorkingAllDb
    {
        //
        public  bool SaveChanges(string dbquery)
        {
            using (var connection = ConnectDb.GetSqlConnection())
            {
                var query = dbquery;
                using (var sqlcmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    try
                    {
                        sqlcmd.ExecuteNonQuery();
                    }catch(SqlException exception)
                    {
                        exception.Errors.ToString();
                        return false;
                    }
                    connection.Close();
                    connection.Dispose();
                    return true;
                }
            }
            
        }

        public bool Delete(string dbquery)
        {
            using (var connection = ConnectDb.GetSqlConnection())
            {
                var query = dbquery;
                using (var sqlcmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    if (sqlcmd.ExecuteNonQuery() <= 0) return false;
                    connection.Close();
                    connection.Dispose();
                    return true;
                }
            }

        }

        //Check Existing value by using Existing Validation Message
        public virtual bool Existing_Validation(string dbquery)
        {
            using (var connection = ConnectDb.GetSqlConnection())
            {
                using (var sqlcmd = new SqlCommand(dbquery, connection))
                {
                    connection.Open();
                    string text;
                    using (var reader = sqlcmd.ExecuteReader())
                    {
                        reader.Read();
                        {
                            try
                            {
                                text = reader.GetString(0);
                            }
                            catch (Exception)
                            {
                                text = "";
                            }
                            
                        }
                        reader.Close();
                        reader.Dispose();
                    }
                    var isValid = string.IsNullOrEmpty(text);
                    connection.Close();
                    connection.Dispose();
                    return isValid;
                }
            }
            
        }

        public virtual SqlDataReader DataReader(string dbquery)
        {
            using (var connection = ConnectDb.GetSqlConnection())
            {
                using (var sqlcmd = new SqlCommand(dbquery, connection))
                {
                    connection.Open();
                    using (var reader = sqlcmd.ExecuteReader())
                    {
                        reader.Read();
                        {
                        }
                        reader.Close();
                        reader.Dispose(); 
                        connection.Close();
                        connection.Dispose();
                        return reader;
                    }
                    
                }
            }

        }

        //Get Data for DataTable
        public virtual DataTable GetData(string dbquery)
        {
            using (var connection = ConnectDb.GetSqlConnection())
            {
                connection.Open();
                var dt = new DataTable();
                using (var ad = new SqlDataAdapter(dbquery, connection))
                {
                    ad.Fill(dt);
                }
                connection.Close();
                connection.Dispose();
                return dt;
            }
            
        }


    }
}