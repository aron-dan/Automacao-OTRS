using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        AutomationWeb automationWeb = new AutomationWeb();
            automationWeb.WebTest();

        }
    }
}
