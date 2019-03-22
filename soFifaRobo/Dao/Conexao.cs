using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soFifaRobo.Dao
{
    public class Conexao
    {

        public  static SqlConnection conectaBanco()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
           
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

    }
}





    

