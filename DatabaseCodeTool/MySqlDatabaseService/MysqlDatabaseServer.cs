using IDatabaseService;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlDatabaseService
{
    public class MysqlDatabaseServer : IDatabase
    {
        public List<string> GetColumns(string databaseName, string tableName, string connection)
        {
            string sql = "select column_name from information_schema.columns where table_schema='"+ databaseName + "' and table_name='" + tableName + "';";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Connection = con;
            con.Open();
            List<string> list = new List<string>();
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    list.Add(dr[0].ToString());
                }
            }
            con.Close();
            return list;
        }

        public List<string> GetTables(string databaseName, string connection)
        {
            string sql = "select table_name from information_schema.tables where table_schema='"+ databaseName + "' and table_type='base table';";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Connection = con;
            con.Open();
            List<string> list = new List<string>();
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    list.Add(dr[0].ToString());
                }
            }
            con.Close();
            return list;
        }
    }
}
