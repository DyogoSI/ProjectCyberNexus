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
    public partial class FrmAddTipo1 : Form
    {
        public FrmAddTipo1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFechatipo_Click(object sender, EventArgs e)
        {
            Sistema FormSistema = new Sistema();
            FormSistema.ShowDialog();
            this.Close();
        }

        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Produto novoProduto = new Produto();
            bool retorno = con.insereTipo(txtaddTipo.Text);
            if (retorno == false)
            {
                MessageBox.Show(con.mensagem);
            }
            else
            {
                MessageBox.Show("--Tipo adicionado com sucesso!--");
            }
            txtaddTipo.Clear();
            txtaddTipo.Focus();
        }
            
    }
}
