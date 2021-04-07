using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace Ecommerce
{
    public class DBConnection
    {
        public QueryFactory Connet()
        {
            var name = Thread.CurrentThread.CurrentCulture.Name;





            SqlConnection sqlConn = new SqlConnection(ConnectionStrings.DefaultConnection);            
            string sql = "SELECT * FROM world.city;";
            SqlConnection  conn = new SqlConnection(ConnectionStrings.DefaultConnection);

            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();




            var connection = new MySqlConnection(ConnectionStrings.DefaultConnection);
            var compiler = new MySqlCompiler();
            QueryFactory queryFactory = new QueryFactory(connection, compiler);
            DefaultTypeMap.MatchNamesWithUnderscores = true;           
            return queryFactory;
        }
        public MySqlConnection DapperConnection()
        {
            MySqlConnection Connection = new MySqlConnection(ConnectionStrings.DefaultConnection);
            return Connection;
        }
    }
}
