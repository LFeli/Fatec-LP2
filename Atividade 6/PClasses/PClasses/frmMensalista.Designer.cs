
namespace PClasses
{
    partial class frmMensalista
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalaMensal = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.btnInstaMensali = new System.Windows.Forms.Button();
            this.btnInstaMensaPassaParamet = new System.Windows.Forms.Button();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDataDaEmpresa = new System.Windows.Forms.TextBox();
            this.txtSalaMensal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(58, 42);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(63, 15);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matricula :";
            this.lblMatricula.Click += new System.EventHandler(this.lblMatricula_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(58, 91);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome :";
            // 
            // lblSalaMensal
            // 
            this.lblSalaMensal.AutoSize = true;
            this.lblSalaMensal.Location = new System.Drawing.Point(58, 132);
            this.lblSalaMensal.Name = "lblSalaMensal";
            this.lblSalaMensal.Size = new System.Drawing.Size(89, 15);
            this.lblSalaMensal.TabIndex = 2;
            this.lblSalaMensal.Text = "Sálario Mensal :";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(58, 172);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(160, 15);
            this.lblDataEntrada.TabIndex = 3;
            this.lblDataEntrada.Text = "Data de entrada na empresa: ";
            this.lblDataEntrada.Click += new System.EventHandler(this.lblDataEntrada_Click);
            // 
            // btnInstaMensali
            // 
            this.btnInstaMensali.Location = new System.Drawing.Point(111, 277);
            this.btnInstaMensali.Name = "btnInstaMensali";
            this.btnInstaMensali.Size = new System.Drawing.Size(194, 75);
            this.btnInstaMensali.TabIndex = 4;
            this.btnInstaMensali.Text = "Instanciar Mensalista: ";
            this.btnInstaMensali.UseVisualStyleBackColor = true;
            this.btnInstaMensali.Click += new System.EventHandler(this.btnInstaMensali_Click);
            // 
            // btnInstaMensaPassaParamet
            // 
            this.btnInstaMensaPassaParamet.Location = new System.Drawing.Point(443, 277);
            this.btnInstaMensaPassaParamet.Name = "btnInstaMensaPassaParamet";
            this.btnInstaMensaPassaParamet.Size = new System.Drawing.Size(207, 75);
            this.btnInstaMensaPassaParamet.TabIndex = 5;
            this.btnInstaMensaPassaParamet.Text = "Instanciar mensalista passando parâmetros";
            this.btnInstaMensaPassaParamet.UseVisualStyleBackColor = true;
            this.btnInstaMensaPassaParamet.Click += new System.EventHandler(this.btnInstaMensaPassaParamet_Click);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(291, 42);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 23);
            this.txtMatricula.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(291, 91);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 7;
            // 
            // txtDataDaEmpresa
            // 
            this.txtDataDaEmpresa.Location = new System.Drawing.Point(291, 169);
            this.txtDataDaEmpresa.Name = "txtDataDaEmpresa";
            this.txtDataDaEmpresa.Size = new System.Drawing.Size(100, 23);
            this.txtDataDaEmpresa.TabIndex = 8;
            // 
            // txtSalaMensal
            // 
            this.txtSalaMensal.Location = new System.Drawing.Point(291, 129);
            this.txtSalaMensal.Name = "txtSalaMensal";
            this.txtSalaMensal.Size = new System.Drawing.Size(100, 23);
            this.txtSalaMensal.TabIndex = 9;
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSalaMensal);
            this.Controls.Add(this.txtDataDaEmpresa);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.btnInstaMensaPassaParamet);
            this.Controls.Add(this.btnInstaMensali);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblSalaMensal);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalaMensal;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Button btnInstaMensali;
        private System.Windows.Forms.Button btnInstaMensaPassaParamet;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDataDaEmpresa;
        private System.Windows.Forms.TextBox txtSalaMensal;
    }
}