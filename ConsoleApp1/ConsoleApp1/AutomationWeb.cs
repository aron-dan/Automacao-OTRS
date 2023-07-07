using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApp1
{
    public class AutomationWeb
    {
        ColetaDadosUsuario coletaDadosUsuario = new ColetaDadosUsuario();
        ErroForm erroForm = new ErroForm();
        Program program = new Program();
        public IWebDriver driver;


        public void login()
        {


                string email = coletaDadosUsuario.RetornaEmail();
                string senha = coletaDadosUsuario.RetornaSenha();
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://atende.sempre.net.br/portal/index.html?RequestedURL=Action%3DAgentTicketEmail");
                driver.FindElement(By.Id("User")).SendKeys(email);
                driver.FindElement(By.Id("Password")).SendKeys(senha);
                driver.FindElement(By.Id("LoginButton")).Click();


            //Feito a logica inversa do try cath
            //ainda não consegui usar o webdrive pra esperar sem dar erro de nosuchelemente
            //linhas comentadas pois ainda espero poder usa-los
            bool sucess = true;
            try
            {
                driver.FindElement(By.Id("loginFailed"));
                driver.Close();
                login();
                //new WebDriverWait(driver, TimeSpan.FromSeconds(3)).Until(driver => driver.FindElement(By.Id("ToolBar")));
                
            }
            
            catch (NoSuchElementException e)
            {
                sucess = false;
            }
            //driver.Close();

        }
    
    
    }
}
