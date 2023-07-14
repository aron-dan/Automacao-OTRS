using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConsoleApp1
{
    public partial class ColetaUserESenhaForm : Form
    {
        
        public ColetaUserESenhaForm()
        {
            InitializeComponent();
            InitializeMyControl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        public Tuple<string, string> RetornaUserESenha()
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            return new Tuple<string, string>(username, password);
        }
        

        private void InitializeMyControl()
        {
            textBox2.PasswordChar = '*';
        }


    }
}
