
namespace SalesSystemUI.Formularios.MateriaPrima
{
    partial class frmCadastrarMateriaPrima
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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPesoEmKg = new System.Windows.Forms.Label();
            this.nudPesoEmKgs = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblValor = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
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
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(34, 82);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria:";
            this.lblCategoria.Click += new System.EventHandler(this.label1_Click);
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
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(92, 76);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(284, 21);
            this.cbCategoria.TabIndex = 7;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(396, 80);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Marca:";
            this.lblMarca.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(442, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 9;
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
            this.lblValor.Location = new System.Drawing.Point(34, 159);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(41, 13);
            this.lblValor.TabIndex = 14;
            this.lblValor.Text = "Preço: ";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(76, 154);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 20);
            this.tbValor.TabIndex = 15;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(204, 157);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(67, 13);
            this.lblFornecedor.TabIndex = 16;
            this.lblFornecedor.Text = "Fornecedor: ";
            this.lblFornecedor.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(277, 151);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(457, 21);
            this.cbFornecedor.TabIndex = 17;
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
            // frmCadastrarMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.nudPesoEmKgs);
            this.Controls.Add(this.lblPesoEmKg);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.dtpDataDeValidade);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lblDataDeValidade);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCadastrarMateriaPrima";
            this.Text = "Cadastrar Matéria Prima";
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
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPesoEmKg;
        private System.Windows.Forms.NumericUpDown nudPesoEmKgs;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Button btnCadastrar;
    }
}