using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using soFifaRobo.Dao;
using soFifaRobo.Util;
using System;
using System.Data.SqlClient;
using System.Threading;

namespace soFifaRobo
{
    class Program
    {
        static void Main(string[] args)
        {
            AplicacaoDao aplica = new AplicacaoDao();
            CampoJogador consulta = new CampoJogador();

            consulta.Login();
            Thread.Sleep(5000);
            consulta.Idade("16", "20");
            Thread.Sleep(3000);
            consulta.Potencial("85", "");
            Thread.Sleep(3000);
            consulta.search();
            Thread.Sleep(3000);
            consulta.ordenaPotencial();
            Thread.Sleep(3000);
            consulta.buscaJovensPromessas();
            Thread.Sleep(3000);
            consulta.cadastraJogadoresNaLista();
            foreach (var item in consulta.listaDeJogadores)
            {
                aplica.addJogador(item);
            }
            aplica.BuscaJogadorBD();




        }





    }
    }

