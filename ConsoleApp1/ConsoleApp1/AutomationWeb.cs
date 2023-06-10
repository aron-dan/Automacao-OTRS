using OpenQA.Selenium.Chrome;
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
        public IWebDriver driver;
        public AutomationWeb()
        {
            driver = new ChromeDriver();
        }

        public void WebTest()
        {
            driver.Navigate().GoToUrl("https://google.com");
        }
    
    
    }
}
