
namespace PClasses
{
    partial class frmHorista
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
            this.lblSalaHora = new System.Windows.Forms.Label();
            this.lblNumHoras = new System.Windows.Forms.Label();
            this.lblDataEntraEmpresa = new System.Windows.Forms.Label();
            this.lblDiasDeFaltas = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDataEntraEmpresa = new System.Windows.Forms.TextBox();
            this.txtSalaHora = new System.Windows.Forms.TextBox();
            this.txtNumDeHoras = new System.Windows.Forms.TextBox();
            this.txtDiasFalta = new System.Windows.Forms.TextBox();
            this.btnInstancia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(104, 31);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(63, 15);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Mátricula :";
            this.lblMatricula.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(121, 60);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome :";
            // 
            // lblSalaHora
            // 
            this.lblSalaHora.AutoSize = true;
            this.lblSalaHora.Location = new System.Drawing.Point(71, 90);
            this.lblSalaHora.Name = "lblSalaHora";
            this.lblSalaHora.Size = new System.Drawing.Size(96, 15);
            this.lblSalaHora.TabIndex = 2;
            this.lblSalaHora.Text = "Salário por hora :";
            // 
            // lblNumHoras
            // 
            this.lblNumHoras.AutoSize = true;
            this.lblNumHoras.Location = new System.Drawing.Point(62, 124);
            this.lblNumHoras.Name = "lblNumHoras";
            this.lblNumHoras.Size = new System.Drawing.Size(105, 15);
            this.lblNumHoras.TabIndex = 3;
            this.lblNumHoras.Text = "Número de horas :";
            // 
            // lblDataEntraEmpresa
            // 
            this.lblDataEntraEmpresa.AutoSize = true;
            this.lblDataEntraEmpresa.Location = new System.Drawing.Point(7, 155);
            this.lblDataEntraEmpresa.Name = "lblDataEntraEmpresa";
            this.lblDataEntraEmpresa.Size = new System.Drawing.Size(160, 15);
            this.lblDataEntraEmpresa.TabIndex = 4;
            this.lblDataEntraEmpresa.Text = "Data de entrada na empresa :";
            // 
            // lblDiasDeFaltas
            // 
            this.lblDiasDeFaltas.AutoSize = true;
            this.lblDiasDeFaltas.Location = new System.Drawing.Point(71, 194);
            this.lblDiasDeFaltas.Name = "lblDiasDeFaltas";
            this.lblDiasDeFaltas.Size = new System.Drawing.Size(82, 15);
            this.lblDiasDeFaltas.TabIndex = 5;
            this.lblDiasDeFaltas.Text = "Dias de faltas :";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(202, 28);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(229, 23);
            this.txtMatricula.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(202, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(229, 23);
            this.txtNome.TabIndex = 7;
            // 
            // txtDataEntraEmpresa
            // 
            this.txtDataEntraEmpresa.Location = new System.Drawing.Point(202, 155);
            this.txtDataEntraEmpresa.Name = "txtDataEntraEmpresa";
            this.txtDataEntraEmpresa.Size = new System.Drawing.Size(229, 23);
            this.txtDataEntraEmpresa.TabIndex = 8;
            // 
            // txtSalaHora
            // 
            this.txtSalaHora.Location = new System.Drawing.Point(202, 90);
            this.txtSalaHora.Name = "txtSalaHora";
            this.txtSalaHora.Size = new System.Drawing.Size(229, 23);
            this.txtSalaHora.TabIndex = 8;
            // 
            // txtNumDeHoras
            // 
            this.txtNumDeHoras.Location = new System.Drawing.Point(202, 121);
            this.txtNumDeHoras.Name = "txtNumDeHoras";
            this.txtNumDeHoras.Size = new System.Drawing.Size(229, 23);
            this.txtNumDeHoras.TabIndex = 9;
            // 
            // txtDiasFalta
            // 
            this.txtDiasFalta.Location = new System.Drawing.Point(202, 191);
            this.txtDiasFalta.Name = "txtDiasFalta";
            this.txtDiasFalta.Size = new System.Drawing.Size(229, 23);
            this.txtDiasFalta.TabIndex = 10;
            // 
            // btnInstancia
            // 
            this.btnInstancia.Location = new System.Drawing.Point(188, 264);
            this.btnInstancia.Name = "btnInstancia";
            this.btnInstancia.Size = new System.Drawing.Size(111, 39);
            this.btnInstancia.TabIndex = 11;
            this.btnInstancia.Text = " Instanciar Horista";
            this.btnInstancia.UseVisualStyleBackColor = true;
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(557, 336);
            this.Controls.Add(this.btnInstancia);
            this.Controls.Add(this.txtDiasFalta);
            this.Controls.Add(this.txtNumDeHoras);
            this.Controls.Add(this.txtSalaHora);
            this.Controls.Add(this.txtDataEntraEmpresa);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDiasDeFaltas);
            this.Controls.Add(this.lblDataEntraEmpresa);
            this.Controls.Add(this.lblNumHoras);
            this.Controls.Add(this.lblSalaHora);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.Load += new System.EventHandler(this.frmHorista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalaHora;
        private System.Windows.Forms.Label lblNumHoras;
        private System.Windows.Forms.Label lblDataEntraEmpresa;
        private System.Windows.Forms.Label lblDiasDeFaltas;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDataEntraEmpresa;
        private System.Windows.Forms.TextBox txtSalaHora;
        private System.Windows.Forms.TextBox txtNumDeHoras;
        private System.Windows.Forms.TextBox txtDiasFalta;
        private System.Windows.Forms.Button btnInstancia;
    }
}