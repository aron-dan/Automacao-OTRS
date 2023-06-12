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
        string email, senha;
        public String ColetaDadosEmail()
        {
            Console.WriteLine("Digite o Email do OTRS:");
            email = Console.ReadLine();
            return email;
        }

        public String ColetaDadosSenha()
        {
            Console.WriteLine("Digite a senha do OTRS:");
            senha = Console.ReadLine();
            return senha;
        }
    }
}
