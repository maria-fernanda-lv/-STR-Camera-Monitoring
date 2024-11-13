using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STR
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (senha_tb.Text == "1989" && admin_tb.Text == "admin")
            {
                FormsPrincipal form1 = new FormsPrincipal();
                form1.Show();
               

            }
            else
            {

                MessageBox.Show("Usuário ou senha incorretos. Tente novamente.", "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void explanation_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
