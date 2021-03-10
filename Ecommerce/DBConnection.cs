using System;
using System.Collections.Generic;
using System.Linq;
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
            var connection = new MySqlConnection(ConnectionStrings.DefaultConnection);
            var compiler = new MySqlCompiler();
            QueryFactory queryFactory = new QueryFactory(connection, compiler);
            DefaultTypeMap.MatchNamesWithUnderscores = true;           
            return queryFactory;
        }
    }
}
