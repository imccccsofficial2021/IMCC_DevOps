using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTAccess
{
    public class DataAccess : IDataAccess
    {
        public List<T> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            MySqlConnection mySql = new MySqlConnection(connectionString);
            using IDbConnection connection = new MySqlConnection(connectionString);
                List<T> rows = connection.Query(sql, parameters).ToList();

                return rows;
            
        }

        public void SaveData<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Query(sql, parameters);
            }
        }
    }
}
