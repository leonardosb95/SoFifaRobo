using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace soFifaRobo.Util
{
    public class CampoJogador
    {
        private IWebDriver chrome = new ChromeDriver();
        public List<string> listaDeJogadores = new List<string>();

        public CampoJogador()
        {
           
            chrome.Navigate().GoToUrl("https:sofifa.com");
            chrome.Manage().Window.Maximize();


        }

        public void Login()
        {
            chrome.FindElement(By.XPath("/html/body/header/nav[1]/div[2]/div[2]/a")).Click();
            Thread.Sleep(5000);
            chrome.FindElement(By.XPath("/html/body/header/nav[1]/div[2]/div[2]/div/a[2]")).Click();
            Thread.Sleep(8000);
            chrome.FindElement(By.XPath("//*[@id='identifierId']")).SendKeys("leonardosantosbispo@gmail.com");
            Thread.Sleep(5000);
            chrome.FindElement(By.XPath("//*[@id='identifierNext']")).Click();
            Thread.Sleep(5000);
            chrome.FindElement(By.XPath("//*[@id='password']/div[1]/div/div[1]/input")).SendKeys("leonike10");
            Thread.Sleep(5000);
            chrome.FindElement(By.XPath("//*[@id='passwordNext']")).Click();
          
        }

        public void Idade(String min, String max)
        {
            var campoIdadeMin=chrome.FindElement(By.XPath("//*[@id='ael']"));
            var cammpoIdadeMax= chrome.FindElement(By.XPath("//*[@id='aeh']"));
           
                campoIdadeMin.SendKeys(min);
                cammpoIdadeMax.SendKeys(max);
            
       
            
        }

        public void Overall(String min, String max)
        {
            var overalMin = chrome.FindElement(By.XPath("//*[@id='oal']"));
            var overalMax = chrome.FindElement(By.XPath("//*[@id='oah']"));
           
                overalMin.SendKeys(min);
                overalMax.SendKeys(max);
           

            
        }

        public void Potencial(String min, String max)
        {
            var potencialMin = chrome.FindElement(By.XPath("//*[@id='ptl']"));
             var potencialMax = chrome.FindElement(By.XPath("//*[@id='pth']"));
           
                potencialMin.SendKeys(min);
                potencialMax.SendKeys(max);
            
            
        }

        public void search()
        {
            var search = chrome.FindElement(By.XPath("/html/body/div[1]/div/aside/form/div[1]/div/div[1]/button"));
            search.Click();

        }

        public void ordenaPotencial()
        {
            var ordenaDesc = chrome.FindElement(By.XPath("//*[@id='content-target']/table/thead/tr[2]/th[5]/div/div/a"));
            ordenaDesc.Click(); 
        }

        public void buscaJovensPromessas()
        {
            listaDeJogadores.Clear();
            bool jaClicou = false;
            for (int i=1; i <= 61; i++)
            {
                try
                {
                    var jogador =  chrome.FindElement(By.XPath("//*[@id='content-target']/table/tbody/tr[" + i + "]"));
                    String[] quebraNome = jogador.Text.Split('\n');
                    string nomeJogador = quebraNome[0].Replace("\r", "");
                    string[] quebraNomeAbreviado = nomeJogador.Split(' ');
                    string nomeReal;
                    try
                    {

                        if (quebraNomeAbreviado[1].Length <= 2)
                        {
                            nomeReal = quebraNomeAbreviado[2];
                        }
                        else
                        {
                            nomeReal = quebraNomeAbreviado[1];
                        }
                    }
                    catch (Exception e)
                    {
                        nomeReal = quebraNomeAbreviado[0];
                    }
                    

                    listaDeJogadores.Add(nomeReal);
                }
                catch (Exception e)
                {
                    break;
                }
                
                
                

                if (i==61)
                {
                    i = 1;
                    if (!jaClicou)
                    {
                        chrome.FindElement(By.XPath("//*[@id='content-target']/div[3]/a")).Click();
                        Thread.Sleep(5000);
                        jaClicou = true;
                    }
                    else
                    {
                        chrome.FindElement(By.XPath("//*[@id='content-target']/div[3]/a[2]")).Click();
                    }
                    
                }

            }

            foreach (var item in listaDeJogadores)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(listaDeJogadores.Count());



        }

      
        public void cadastraJogadoresNaLista()
        {
            chrome.FindElement(By.XPath("/html/body/header/nav[1]/a[5]")).Click();


            var url= chrome.Url;

            if (url.Equals("https://sofifa.com/shortlists"))
            {
                chrome.FindElement(By.XPath("/html/body/div/div/aside/a")).Click();
                Thread.Sleep(5000);

                foreach (var item in listaDeJogadores)
                {
                    var input = chrome.FindElement(By.XPath("//*[@id='edit-shortlist']/div/div[2]/div[1]/ul/li/div/input"));
                    input.SendKeys(item);
                    Thread.Sleep(5000);
                    input.SendKeys(Keys.Down);
                    Thread.Sleep(5000);
                    chrome.FindElement(By.XPath("/html/body/div[2]/ul/li[1]")).Click();
                    Thread.Sleep(5000);
                }

            }




        }




    }
}
