namespace SistemaCadastro
{
    partial class FrmAddTipo1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechatipo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaddTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnConfirmaCadastro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btnFechatipo);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 79);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnFechatipo
            // 
            this.btnFechatipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechatipo.Image = global::SistemaCadastro.Properties.Resources.fechar;
            this.btnFechatipo.Location = new System.Drawing.Point(778, 11);
            this.btnFechatipo.Name = "btnFechatipo";
            this.btnFechatipo.Size = new System.Drawing.Size(75, 65);
            this.btnFechatipo.TabIndex = 0;
            this.btnFechatipo.UseVisualStyleBackColor = true;
            this.btnFechatipo.Click += new System.EventHandler(this.btnFechatipo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adinionar um novo tipo";
            // 
            // txtaddTipo
            // 
            this.txtaddTipo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtaddTipo.Location = new System.Drawing.Point(239, 225);
            this.txtaddTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtaddTipo.Name = "txtaddTipo";
            this.txtaddTipo.Size = new System.Drawing.Size(389, 34);
            this.txtaddTipo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome do tipo";
            // 
            // BtnConfirmaCadastro
            // 
            this.BtnConfirmaCadastro.FlatAppearance.BorderSize = 0;
            this.BtnConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BtnConfirmaCadastro.ForeColor = System.Drawing.Color.Black;
            this.BtnConfirmaCadastro.Image = global::SistemaCadastro.Properties.Resources.adicionar;
            this.BtnConfirmaCadastro.Location = new System.Drawing.Point(342, 331);
            this.BtnConfirmaCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfirmaCadastro.Name = "BtnConfirmaCadastro";
            this.BtnConfirmaCadastro.Size = new System.Drawing.Size(175, 60);
            this.BtnConfirmaCadastro.TabIndex = 14;
            this.BtnConfirmaCadastro.Text = "&Cadastrar";
            this.BtnConfirmaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmaCadastro.UseVisualStyleBackColor = true;
            this.BtnConfirmaCadastro.Click += new System.EventHandler(this.BtnConfirmaCadastro_Click);
            // 
            // FrmAddTipo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 456);
            this.Controls.Add(this.BtnConfirmaCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtaddTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddTipo1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddTipo1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaddTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFechatipo;
        private System.Windows.Forms.Button BtnConfirmaCadastro;
    }
}