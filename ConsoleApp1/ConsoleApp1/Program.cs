using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        AutomationWeb automationWeb = new AutomationWeb();
        ColetaDadosUsuario coletaDadosUsuario = new ColetaDadosUsuario();
        ColetaUserESenhaForm coletaUserESenhaForm = new ColetaUserESenhaForm();
        

            //coletaUserESenhaForm.ShowDialog();
            automationWeb.login();
            Console.ReadKey();
            
            


        }
    }
}
