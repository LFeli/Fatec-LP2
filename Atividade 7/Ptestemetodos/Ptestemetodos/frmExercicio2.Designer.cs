
namespace Ptestemetodos
{
    partial class frmExercicio2
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
            this.btnIguais = new System.Windows.Forms.Button();
            this.btnInserir2 = new System.Windows.Forms.Button();
            this.btnInserir1 = new System.Windows.Forms.Button();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIguais
            // 
            this.btnIguais.Location = new System.Drawing.Point(143, 316);
            this.btnIguais.Name = "btnIguais";
            this.btnIguais.Size = new System.Drawing.Size(103, 50);
            this.btnIguais.TabIndex = 0;
            this.btnIguais.Text = "Verificar se são iguais :";
            this.btnIguais.UseVisualStyleBackColor = true;
            this.btnIguais.Click += new System.EventHandler(this.btnIguais_Click);
            // 
            // btnInserir2
            // 
            this.btnInserir2.Location = new System.Drawing.Point(335, 316);
            this.btnInserir2.Name = "btnInserir2";
            this.btnInserir2.Size = new System.Drawing.Size(105, 50);
            this.btnInserir2.TabIndex = 1;
            this.btnInserir2.Text = "Inseriri 1° no meio do 2° :";
            this.btnInserir2.UseVisualStyleBackColor = true;
            this.btnInserir2.Click += new System.EventHandler(this.btnInserir2_Click);
            // 
            // btnInserir1
            // 
            this.btnInserir1.Location = new System.Drawing.Point(515, 316);
            this.btnInserir1.Name = "btnInserir1";
            this.btnInserir1.Size = new System.Drawing.Size(104, 50);
            this.btnInserir1.TabIndex = 2;
            this.btnInserir1.Text = "Inserir * no meio do 1° :";
            this.btnInserir1.UseVisualStyleBackColor = true;
            this.btnInserir1.Click += new System.EventHandler(this.btnInserir1_Click);
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(310, 71);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(171, 23);
            this.txtPalavra1.TabIndex = 3;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(310, 129);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(171, 23);
            this.txtPalavra2.TabIndex = 4;
            this.txtPalavra2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(209, 74);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(60, 15);
            this.lblPalavra1.TabIndex = 5;
            this.lblPalavra1.Text = "Palavra 1 :";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(209, 129);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(60, 15);
            this.lblPalavra2.TabIndex = 6;
            this.lblPalavra2.Text = "Palavra 2 :";
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.btnInserir1);
            this.Controls.Add(this.btnInserir2);
            this.Controls.Add(this.btnIguais);
            this.Name = "frmExercicio2";
            this.Text = "Exercicio 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIguais;
        private System.Windows.Forms.Button btnInserir2;
        private System.Windows.Forms.Button btnInserir1;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
    }
}