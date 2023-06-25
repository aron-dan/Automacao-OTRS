using OpenQA.Selenium.DevTools.V112.Emulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ColetaDadosUsuario
    {
        ColetaUserESenhaForm ColetaUserESenhaForm = new ColetaUserESenhaForm();

        public string RetornaEmail()
        {
            ColetaUserESenhaForm.ShowDialog();
            var coletaDados = ColetaUserESenhaForm.RetornaUserESenha();
            string email = coletaDados.Item1;
            RetornaSenha();
            return email;
        }
        public string RetornaSenha()
        {
            var coletaDados = ColetaUserESenhaForm.RetornaUserESenha();
            string senha = coletaDados.Item2;
            return senha;
        }


    }
}
