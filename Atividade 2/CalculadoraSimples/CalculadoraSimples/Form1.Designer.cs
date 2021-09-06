
namespace CalculadoraSimples
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblResul = new System.Windows.Forms.Label();
            this.txtResul = new System.Windows.Forms.TextBox();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(12, 22);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(105, 15);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Primeiro Número :";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(12, 53);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(107, 15);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Segundo Número :";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(138, 19);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(111, 23);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(138, 50);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(111, 23);
            this.txtNum2.TabIndex = 3;
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Location = new System.Drawing.Point(12, 87);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(65, 15);
            this.lblResul.TabIndex = 4;
            this.lblResul.Text = "Resultado :";
            // 
            // txtResul
            // 
            this.txtResul.Location = new System.Drawing.Point(138, 84);
            this.txtResul.Name = "txtResul";
            this.txtResul.ReadOnly = true;
            this.txtResul.Size = new System.Drawing.Size(111, 23);
            this.txtResul.TabIndex = 5;
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(12, 196);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(75, 23);
            this.btnMais.TabIndex = 6;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(93, 196);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(75, 23);
            this.btnMenos.TabIndex = 7;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnVezes
            // 
            this.btnVezes.Location = new System.Drawing.Point(174, 196);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(75, 23);
            this.btnVezes.TabIndex = 8;
            this.btnVezes.Text = "*";
            this.btnVezes.UseVisualStyleBackColor = true;
            this.btnVezes.Click += new System.EventHandler(this.btnVezes_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(255, 196);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 9;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(390, 196);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair :";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(390, 154);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(75, 23);
            this.btnLimp.TabIndex = 11;
            this.btnLimp.Text = "Limpar :";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalculadoraSimples.Properties.Resources.nazare_tedesco_vila_de_senhora_do_destino_2004_vira_meme_mundial_1476485254931_300x200;
            this.ClientSize = new System.Drawing.Size(493, 249);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnVezes);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.txtResul);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.TextBox txtResul;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnVezes;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimp;
    }
}

