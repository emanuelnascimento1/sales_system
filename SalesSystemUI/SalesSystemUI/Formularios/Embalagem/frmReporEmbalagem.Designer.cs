
namespace SalesSystemUI.Formularios.Embalagem
{
    partial class frmReporEmbalagem
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
            this.lblNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblPacote = new System.Windows.Forms.Label();
            this.nudPesoEmKgs = new System.Windows.Forms.NumericUpDown();
            this.lblUnidadePacote = new System.Windows.Forms.Label();
            this.nudUnidadePacote = new System.Windows.Forms.NumericUpDown();
            this.lblValor = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoEmKgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnidadePacote)).BeginInit();
            this.SuspendLayout();
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
            // lblPacote
            // 
            this.lblPacote.AutoSize = true;
            this.lblPacote.Location = new System.Drawing.Point(34, 80);
            this.lblPacote.Name = "lblPacote";
            this.lblPacote.Size = new System.Drawing.Size(64, 13);
            this.lblPacote.TabIndex = 10;
            this.lblPacote.Text = "Qtd Pacote:";
            // 
            // nudPesoEmKgs
            // 
            this.nudPesoEmKgs.Location = new System.Drawing.Point(120, 75);
            this.nudPesoEmKgs.Name = "nudPesoEmKgs";
            this.nudPesoEmKgs.Size = new System.Drawing.Size(256, 20);
            this.nudPesoEmKgs.TabIndex = 11;
            // 
            // lblUnidadePacote
            // 
            this.lblUnidadePacote.AutoSize = true;
            this.lblUnidadePacote.Location = new System.Drawing.Point(399, 78);
            this.lblUnidadePacote.Name = "lblUnidadePacote";
            this.lblUnidadePacote.Size = new System.Drawing.Size(45, 13);
            this.lblUnidadePacote.TabIndex = 12;
            this.lblUnidadePacote.Text = "Un/Pct:";
            // 
            // nudUnidadePacote
            // 
            this.nudUnidadePacote.Location = new System.Drawing.Point(473, 73);
            this.nudUnidadePacote.Name = "nudUnidadePacote";
            this.nudUnidadePacote.Size = new System.Drawing.Size(261, 20);
            this.nudUnidadePacote.TabIndex = 13;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(540, 37);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(41, 13);
            this.lblValor.TabIndex = 14;
            this.lblValor.Text = "Preço: ";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(582, 32);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(152, 20);
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
            // frmReporEmbalagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.nudUnidadePacote);
            this.Controls.Add(this.lblUnidadePacote);
            this.Controls.Add(this.nudPesoEmKgs);
            this.Controls.Add(this.lblPacote);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmReporEmbalagem";
            this.Text = "Repor Embalagem";
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoEmKgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnidadePacote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblPacote;
        private System.Windows.Forms.NumericUpDown nudPesoEmKgs;
        private System.Windows.Forms.Label lblUnidadePacote;
        private System.Windows.Forms.NumericUpDown nudUnidadePacote;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Button btnCadastrar;
    }
}
