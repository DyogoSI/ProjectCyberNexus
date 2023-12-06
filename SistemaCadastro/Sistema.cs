using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace SistemaCadastro
{
    public partial class Sistema : Form
    {
        int idAlterar;
        public Sistema()
        {
            InitializeComponent();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            marcador.Height = btnCadastra.Height;
            marcador.Top = btnCadastra.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }
        

        private void btnBusca_Click(object sender, EventArgs e)
        {
            marcador.Height = btnBusca.Height;
            marcador.Top = btnBusca.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }







        private void Sistema_Load(object sender, EventArgs e)
        {
            listaCBTipo();
            lista_gridProdutos();
        }

        void lista_gridProdutos()
        {
            ConectaBanco con = new ConectaBanco();
            dgProduto.DataSource = con.liataProdutos();
        }

        public void listaCBTipo()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaTipo();
            cbTipo.DataSource = tabelaDados;
            cbTipo.DisplayMember = "tipo";
            cbTipo.ValueMember = "id_tipo";


            cbAlteraTipo.DataSource = tabelaDados;
            cbAlteraTipo.DisplayMember = "tipo";
            cbAlteraTipo.ValueMember = "id_tipo";
        }


        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgProduto.DataSource as DataTable).DefaultView.RowFilter = string.Format("nome like '{0}%'", txtBusca.Text);

        }

        private void btnRemoveBanda_Click(object sender, EventArgs e)
        {
            int linha = dgProduto.CurrentRow.Index;
            int id = Convert.ToInt32(
                    dgProduto.Rows[linha].Cells["id_Produto"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?",
                "Remove Produto", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaProduto(id); 
                if (retorno == true)
                {
                    MessageBox.Show("Produto excluido com sucesso!");
                    lista_gridProdutos();
                }// fim if retorno true
                else
                    MessageBox.Show(con.mensagem);
            }// fim if Ok Cancela
            else
                MessageBox.Show("Exclusão cancelada");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int linha = dgProduto.CurrentRow.Index;// pega a linha selecionada
            idAlterar = Convert.ToInt32(
              dgProduto.Rows[linha].Cells["id_produto"].Value.ToString());
            txtAlteraNome.Text =
                 dgProduto.Rows[linha].Cells["nome"].Value.ToString();
            cbAlteraTipo.Text =
                dgProduto.Rows[linha].Cells["tipo"].Value.ToString();
            txtAlteraQuantidade.Text =
                dgProduto.Rows[linha].Cells["quantidade"].Value.ToString();
            txtAlteraPreco.Text=
                dgProduto.Rows[linha].Cells["preco"].Value.ToString();
            tabControl1.SelectedTab = tabAlterar;// muda aba
        }

        private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Produto novoProduto = new Produto();
            novoProduto.Nome = txtAlteraNome.Text;
            novoProduto.Tipo = cbAlteraTipo.SelectedValue.ToString();
            novoProduto.Quantidade = Convert.ToInt32(txtAlteraQuantidade.Text);
            novoProduto.Preco = Convert.ToDouble(txtAlteraPreco.Text);
            bool retorno = con.alteraProduto(novoProduto, idAlterar);
            if (retorno == false)
            {
                MessageBox.Show(con.mensagem);

            }else{
                MessageBox.Show("Alteração concluída com sucesso!");
            }    
                lista_gridProdutos();

        }

        private void bntAddGenero_Click(object sender, EventArgs e)
        {
            FrmAddTipo1 formTipo = new FrmAddTipo1();
            this.Hide();
            formTipo.ShowDialog();
            this.Close();

        }

        public void limpaCampos()
        {
            txtnome.Clear();
            cbTipo.Text = "";
            txtquantidades.Clear();
            txtpreco.Clear();
            txtnome.Focus();
        }
        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Produto novoProduto = new Produto();
            novoProduto.Nome = txtnome.Text;
            novoProduto.Tipo = cbTipo.SelectedValue.ToString();
            novoProduto.Quantidade = Convert.ToInt32(txtquantidades.Text);
            novoProduto.Preco = Convert.ToDouble(txtpreco.Text);
            bool retorno = con.insereProduto(novoProduto); 
            if(retorno == false)
            {
                MessageBox.Show(con.mensagem);
               
            }
            else
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            limpaCampos();
            lista_gridProdutos();

        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
