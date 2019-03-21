using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using soFifaRobo.Util;
using System.Threading;

namespace soFifaRobo
{
    class Program
    {
        static void Main(string[] args)
        {
            CampoJogador consulta = new CampoJogador();
            consulta.Idade("16","20");
            Thread.Sleep(3000);
            consulta.Potencial("85","");
            Thread.Sleep(3000);
            consulta.search();
            Thread.Sleep(3000);








        }
    }
}
