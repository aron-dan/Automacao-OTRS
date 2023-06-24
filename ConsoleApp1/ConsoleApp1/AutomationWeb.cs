﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AutomationWeb
    {
        ColetaDadosUsuario coletaDadosUsuario = new ColetaDadosUsuario();
        Program program = new Program();
        public IWebDriver driver;
        public AutomationWeb()
        {
            driver = new ChromeDriver();
        }

        public void login()
        {
            string email = coletaDadosUsuario.ColetaDadosEmail();
            string senha = coletaDadosUsuario.ColetaDadosSenha();
            driver.Navigate().GoToUrl("https://atende.sempre.net.br/portal/index.html?RequestedURL=Action%3DAgentTicketEmail");
            driver.FindElement(By.Id("User")).SendKeys(email);
            driver.FindElement(By.Id("Password")).SendKeys(senha);
            driver.FindElement(By.Id("LoginButton")).Click();
        }
    
    
    }
}