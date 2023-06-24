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

        public void buttonLogin_Click(object sender, EventArgs e)
        {
            
            Close();
        }
        private void InitializeMyControl()
        {
            textBoxSenha.PasswordChar = '*';
        }
    }
}
