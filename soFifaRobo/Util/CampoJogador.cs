using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace soFifaRobo.Util
{
    public class CampoJogador
    {
        private IWebDriver chrome = new ChromeDriver();

        public CampoJogador()
        {
           
            chrome.Navigate().GoToUrl("https:sofifa.com");
            chrome.Manage().Window.Maximize();


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

        


    }
}
