using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soFifaRobo.Dao
{
    public class AplicacaoDao
    {
        private SqlConnection conn = Conexao.conectaBanco();




        public  void addJogador(string nomeJogador)
        {
            string insertIntoQuery = String.Format("INSERT INTO jogador(nome_jogador) VALUES('{0}')",nomeJogador);
            SqlCommand cmdComandoInsert = new SqlCommand(insertIntoQuery, conn);
            try
            {
                cmdComandoInsert.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Console.WriteLine("Não foi possivel adicionar o jogador");
                throw;
            }
           
        }

        public void BuscaJogadorBD()
        {
            using (conn)
            {
                using (SqlCommand command = new SqlCommand("SELECT  * FROM jogador", conn))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}", reader.GetString(1));

                       
                    }
                }
            }

        }


    }
}
