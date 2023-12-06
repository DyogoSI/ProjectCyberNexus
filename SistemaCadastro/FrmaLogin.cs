using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class FrmaLogin : Form
    {
        public FrmaLogin()
        {
            InitializeComponent();
        }

        private void FrmaLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           ConectaBanco conecta = new ConectaBanco();
            
            if (conecta.verifica(txtuseLogin.Text, txtsenhaLogin.Text) == true)
            {
                Sistema FormSistema = new Sistema();
                this.Hide();
                FormSistema.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalido" + conecta.mensagem);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
