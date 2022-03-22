
namespace SalesSystemUI.Formularios.MateriaPrima
{
    partial class frmReposicaoMateriaPrima
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
            this.lblDataDeValidade = new System.Windows.Forms.Label();
            this.dtpDataDeValidade = new System.Windows.Forms.DateTimePicker();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.lblPesoEmKg = new System.Windows.Forms.Label();
            this.nudPesoEmKgs = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblValor = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoEmKgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataDeValidade
            // 
            this.lblDataDeValidade.AutoSize = true;
            this.lblDataDeValidade.Location = new System.Drawing.Point(560, 38);
            this.lblDataDeValidade.Name = "lblDataDeValidade";
            this.lblDataDeValidade.Size = new System.Drawing.Size(89, 13);
            this.lblDataDeValidade.TabIndex = 0;
            this.lblDataDeValidade.Text = "Data de Validade";
            // 
            // dtpDataDeValidade
            // 
            this.dtpDataDeValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDeValidade.Location = new System.Drawing.Point(655, 35);
            this.dtpDataDeValidade.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtpDataDeValidade.Name = "dtpDataDeValidade";
            this.dtpDataDeValidade.Size = new System.Drawing.Size(79, 20);
            this.dtpDataDeValidade.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(34, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome: ";
            // 
            // tbNome
            // 
            this.tbNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbNome.Location = new System.Drawing.Point(76, 35);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(454, 20);
            this.tbNome.TabIndex = 4;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(37, 347);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(97, 26);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(280, 78);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Marca:";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(326, 75);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(408, 20);
            this.tbMarca.TabIndex = 9;
            // 
            // lblPesoEmKg
            // 
            this.lblPesoEmKg.AutoSize = true;
            this.lblPesoEmKg.Location = new System.Drawing.Point(34, 122);
            this.lblPesoEmKg.Name = "lblPesoEmKg";
            this.lblPesoEmKg.Size = new System.Drawing.Size(81, 13);
            this.lblPesoEmKg.TabIndex = 10;
            this.lblPesoEmKg.Text = "Peso (em Kgs): ";
            // 
            // nudPesoEmKgs
            // 
            this.nudPesoEmKgs.Location = new System.Drawing.Point(120, 117);
            this.nudPesoEmKgs.Name = "nudPesoEmKgs";
            this.nudPesoEmKgs.Size = new System.Drawing.Size(256, 20);
            this.nudPesoEmKgs.TabIndex = 11;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(399, 120);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(68, 13);
            this.lblQuantidade.TabIndex = 12;
            this.lblQuantidade.Text = "Quantidade: ";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(473, 115);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(261, 20);
            this.nudQuantidade.TabIndex = 13;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(34, 80);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(41, 13);
            this.lblValor.TabIndex = 14;
            this.lblValor.Text = "Preço: ";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(76, 75);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(177, 20);
            this.tbValor.TabIndex = 15;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(633, 347);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(97, 26);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // frmReposicaoMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.nudPesoEmKgs);
            this.Controls.Add(this.lblPesoEmKg);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dtpDataDeValidade);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lblDataDeValidade);
            this.Controls.Add(this.lblNome);
            this.Name = "frmReposicaoMateriaPrima";
            this.Text = "Reposição Matéria Prima";
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoEmKgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataDeValidade;
        private System.Windows.Forms.DateTimePicker dtpDataDeValidade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label lblPesoEmKg;
        private System.Windows.Forms.NumericUpDown nudPesoEmKgs;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

  