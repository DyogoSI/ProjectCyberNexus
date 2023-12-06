namespace SistemaCadastro
{
    partial class Sistema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            this.panel1 = new System.Windows.Forms.Panel();
            this.marcador = new System.Windows.Forms.Panel();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnCadastra = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtquantidades = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgProduto = new System.Windows.Forms.DataGridView();
            this.tabAlterar = new System.Windows.Forms.TabPage();
            this.cbAlteraTipo = new System.Windows.Forms.ComboBox();
            this.txtAlteraPreco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlteraQuantidade = new System.Windows.Forms.TextBox();
            this.txtAlteraNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bntAddGenero = new System.Windows.Forms.Button();
            this.BtnConfirmaCadastro = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemoveProduto = new System.Windows.Forms.Button();
            this.btnConfirmaAlteracao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.tabBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).BeginInit();
            this.tabAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.marcador);
            this.panel1.Controls.Add(this.btnBusca);
            this.panel1.Controls.Add(this.btnCadastra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 535);
            this.panel1.TabIndex = 0;
            // 
            // marcador
            // 
            this.marcador.BackColor = System.Drawing.Color.Black;
            this.marcador.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.marcador.Location = new System.Drawing.Point(1, 105);
            this.marcador.Margin = new System.Windows.Forms.Padding(4);
            this.marcador.Name = "marcador";
            this.marcador.Size = new System.Drawing.Size(13, 44);
            this.marcador.TabIndex = 8;
            // 
            // btnBusca
            // 
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBusca.ForeColor = System.Drawing.Color.White;
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.Location = new System.Drawing.Point(21, 158);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(175, 60);
            this.btnBusca.TabIndex = 5;
            this.btnBusca.Text = "&Buscar";
            this.btnBusca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnCadastra
            // 
            this.btnCadastra.FlatAppearance.BorderSize = 0;
            this.btnCadastra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCadastra.ForeColor = System.Drawing.Color.White;
            this.btnCadastra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastra.Location = new System.Drawing.Point(13, 100);
            this.btnCadastra.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(175, 60);
            this.btnCadastra.TabIndex = 3;
            this.btnCadastra.Text = "&Cadastrar";
            this.btnCadastra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastra.UseVisualStyleBackColor = true;
            this.btnCadastra.Click += new System.EventHandler(this.btnCadastra_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(207, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 218);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(277, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "CyberNexus";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCadastrar);
            this.tabControl1.Controls.Add(this.tabBuscar);
            this.tabControl1.Controls.Add(this.tabAlterar);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tabControl1.Location = new System.Drawing.Point(207, 193);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 342);
            this.tabControl1.TabIndex = 9;
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.BackColor = System.Drawing.Color.White;
            this.tabCadastrar.Controls.Add(this.bntAddGenero);
            this.tabCadastrar.Controls.Add(this.cbTipo);
            this.tabCadastrar.Controls.Add(this.txtpreco);
            this.tabCadastrar.Controls.Add(this.label6);
            this.tabCadastrar.Controls.Add(this.BtnConfirmaCadastro);
            this.tabCadastrar.Controls.Add(this.txtquantidades);
            this.tabCadastrar.Controls.Add(this.txtnome);
            this.tabCadastrar.Controls.Add(this.label3);
            this.tabCadastrar.Controls.Add(this.label2);
            this.tabCadastrar.Controls.Add(this.label4);
            this.tabCadastrar.Location = new System.Drawing.Point(4, 29);
            this.tabCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(4);
            this.tabCadastrar.Size = new System.Drawing.Size(888, 309);
            this.tabCadastrar.TabIndex = 0;
            this.tabCadastrar.Text = "Cadastrar";
            // 
            // cbTipo
            // 
            this.cbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTipo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(176, 65);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(639, 36);
            this.cbTipo.TabIndex = 10;
            // 
            // txtpreco
            // 
            this.txtpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtpreco.Location = new System.Drawing.Point(176, 161);
            this.txtpreco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(639, 30);
            this.txtpreco.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Preço:";
            // 
            // txtquantidades
            // 
            this.txtquantidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtquantidades.Location = new System.Drawing.Point(176, 112);
            this.txtquantidades.Margin = new System.Windows.Forms.Padding(4);
            this.txtquantidades.Name = "txtquantidades";
            this.txtquantidades.Size = new System.Drawing.Size(639, 30);
            this.txtquantidades.TabIndex = 11;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtnome.Location = new System.Drawing.Point(176, 11);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(639, 34);
            this.txtnome.TabIndex = 9;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome:";
            // 
            // tabBuscar
            // 
            this.tabBuscar.BackColor = System.Drawing.Color.White;
            this.tabBuscar.Controls.Add(this.btnAlterar);
            this.tabBuscar.Controls.Add(this.btnRemoveProduto);
            this.tabBuscar.Controls.Add(this.label5);
            this.tabBuscar.Controls.Add(this.txtBusca);
            this.tabBuscar.Controls.Add(this.dgProduto);
            this.tabBuscar.Location = new System.Drawing.Point(4, 29);
            this.tabBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.tabBuscar.Size = new System.Drawing.Size(888, 309);
            this.tabBuscar.TabIndex = 1;
            this.tabBuscar.Text = "Buscar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Produto:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBusca.Location = new System.Drawing.Point(109, 12);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(347, 30);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // dgProduto
            // 
            this.dgProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProduto.BackgroundColor = System.Drawing.Color.White;
            this.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduto.Location = new System.Drawing.Point(56, 68);
            this.dgProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgProduto.Name = "dgProduto";
            this.dgProduto.ReadOnly = true;
            this.dgProduto.RowHeadersWidth = 51;
            this.dgProduto.RowTemplate.Height = 29;
            this.dgProduto.Size = new System.Drawing.Size(797, 233);
            this.dgProduto.TabIndex = 0;
            // 
            // tabAlterar
            // 
            this.tabAlterar.Controls.Add(this.cbAlteraTipo);
            this.tabAlterar.Controls.Add(this.txtAlteraPreco);
            this.tabAlterar.Controls.Add(this.label7);
            this.tabAlterar.Controls.Add(this.txtAlteraQuantidade);
            this.tabAlterar.Controls.Add(this.txtAlteraNome);
            this.tabAlterar.Controls.Add(this.label8);
            this.tabAlterar.Controls.Add(this.label9);
            this.tabAlterar.Controls.Add(this.label10);
            this.tabAlterar.Controls.Add(this.btnConfirmaAlteracao);
            this.tabAlterar.Location = new System.Drawing.Point(4, 29);
            this.tabAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAlterar.Name = "tabAlterar";
            this.tabAlterar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAlterar.Size = new System.Drawing.Size(888, 309);
            this.tabAlterar.TabIndex = 2;
            this.tabAlterar.Text = "Alterar";
            this.tabAlterar.UseVisualStyleBackColor = true;
            // 
            // cbAlteraTipo
            // 
            this.cbAlteraTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbAlteraTipo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbAlteraTipo.FormattingEnabled = true;
            this.cbAlteraTipo.Location = new System.Drawing.Point(171, 75);
            this.cbAlteraTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAlteraTipo.Name = "cbAlteraTipo";
            this.cbAlteraTipo.Size = new System.Drawing.Size(639, 36);
            this.cbAlteraTipo.TabIndex = 23;
            // 
            // txtAlteraPreco
            // 
            this.txtAlteraPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAlteraPreco.Location = new System.Drawing.Point(171, 177);
            this.txtAlteraPreco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlteraPreco.Name = "txtAlteraPreco";
            this.txtAlteraPreco.Size = new System.Drawing.Size(639, 30);
            this.txtAlteraPreco.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Preço:";
            // 
            // txtAlteraQuantidade
            // 
            this.txtAlteraQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAlteraQuantidade.Location = new System.Drawing.Point(171, 128);
            this.txtAlteraQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlteraQuantidade.Name = "txtAlteraQuantidade";
            this.txtAlteraQuantidade.Size = new System.Drawing.Size(639, 30);
            this.txtAlteraQuantidade.TabIndex = 19;
            // 
            // txtAlteraNome
            // 
            this.txtAlteraNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAlteraNome.Location = new System.Drawing.Point(171, 27);
            this.txtAlteraNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlteraNome.Name = "txtAlteraNome";
            this.txtAlteraNome.Size = new System.Drawing.Size(639, 34);
            this.txtAlteraNome.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(11, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Quantidade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(11, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tipo:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(11, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nome:";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(725, 32);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 16);
            this.lblMensagem.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1067, 31);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "X";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bntAddGenero
            // 
            this.bntAddGenero.FlatAppearance.BorderSize = 0;
            this.bntAddGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAddGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bntAddGenero.ForeColor = System.Drawing.Color.DimGray;
            this.bntAddGenero.Image = global::SistemaCadastro.Properties.Resources.botao_adicionar__1_;
            this.bntAddGenero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntAddGenero.Location = new System.Drawing.Point(821, 62);
            this.bntAddGenero.Margin = new System.Windows.Forms.Padding(4);
            this.bntAddGenero.Name = "bntAddGenero";
            this.bntAddGenero.Size = new System.Drawing.Size(57, 43);
            this.bntAddGenero.TabIndex = 15;
            this.bntAddGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntAddGenero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntAddGenero.UseVisualStyleBackColor = true;
            this.bntAddGenero.Click += new System.EventHandler(this.bntAddGenero_Click);
            // 
            // BtnConfirmaCadastro
            // 
            this.BtnConfirmaCadastro.FlatAppearance.BorderSize = 0;
            this.BtnConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BtnConfirmaCadastro.ForeColor = System.Drawing.Color.Black;
            this.BtnConfirmaCadastro.Image = global::SistemaCadastro.Properties.Resources.adicionar;
            this.BtnConfirmaCadastro.Location = new System.Drawing.Point(380, 213);
            this.BtnConfirmaCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfirmaCadastro.Name = "BtnConfirmaCadastro";
            this.BtnConfirmaCadastro.Size = new System.Drawing.Size(175, 60);
            this.BtnConfirmaCadastro.TabIndex = 13;
            this.BtnConfirmaCadastro.Text = "&Cadastrar";
            this.BtnConfirmaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmaCadastro.UseVisualStyleBackColor = true;
            this.BtnConfirmaCadastro.Click += new System.EventHandler(this.BtnConfirmaCadastro_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.ForeColor = System.Drawing.Color.DimGray;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(643, 6);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(149, 57);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnRemoveProduto
            // 
            this.btnRemoveProduto.FlatAppearance.BorderSize = 0;
            this.btnRemoveProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemoveProduto.ForeColor = System.Drawing.Color.DimGray;
            this.btnRemoveProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveProduto.Image")));
            this.btnRemoveProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveProduto.Location = new System.Drawing.Point(484, 6);
            this.btnRemoveProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveProduto.Name = "btnRemoveProduto";
            this.btnRemoveProduto.Size = new System.Drawing.Size(163, 57);
            this.btnRemoveProduto.TabIndex = 14;
            this.btnRemoveProduto.Text = "Remover";
            this.btnRemoveProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveProduto.UseVisualStyleBackColor = true;
            this.btnRemoveProduto.Click += new System.EventHandler(this.btnRemoveBanda_Click);
            // 
            // btnConfirmaAlteracao
            // 
            this.btnConfirmaAlteracao.FlatAppearance.BorderSize = 0;
            this.btnConfirmaAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmaAlteracao.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmaAlteracao.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmaAlteracao.Image")));
            this.btnConfirmaAlteracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracao.Location = new System.Drawing.Point(389, 217);
            this.btnConfirmaAlteracao.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmaAlteracao.Name = "btnConfirmaAlteracao";
            this.btnConfirmaAlteracao.Size = new System.Drawing.Size(175, 60);
            this.btnConfirmaAlteracao.TabIndex = 22;
            this.btnConfirmaAlteracao.Text = "Confirmar Alteração";
            this.btnConfirmaAlteracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmaAlteracao.UseVisualStyleBackColor = true;
            this.btnConfirmaAlteracao.Click += new System.EventHandler(this.btnConfirmaAlteracao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaCadastro.Properties.Resources.jogos;
            this.pictureBox1.Location = new System.Drawing.Point(32, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 535);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Sistema_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.tabCadastrar.PerformLayout();
            this.tabBuscar.ResumeLayout(false);
            this.tabBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).EndInit();
            this.tabAlterar.ResumeLayout(false);
            this.tabAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCadastra;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCadastrar;
        private System.Windows.Forms.TabPage tabBuscar;
        private System.Windows.Forms.Button BtnConfirmaCadastro;
        private System.Windows.Forms.TextBox txtquantidades;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel marcador;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgProduto;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnRemoveProduto;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TabPage tabAlterar;
        private System.Windows.Forms.TextBox txtAlteraPreco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConfirmaAlteracao;
        private System.Windows.Forms.TextBox txtAlteraQuantidade;
        private System.Windows.Forms.TextBox txtAlteraNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button bntAddGenero;
        private System.Windows.Forms.ComboBox cbAlteraTipo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}