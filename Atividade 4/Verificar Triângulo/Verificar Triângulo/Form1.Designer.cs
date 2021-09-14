
namespace Verificar_Triângulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnVerif = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblValorA = new System.Windows.Forms.Label();
            this.lblValorB = new System.Windows.Forms.Label();
            this.lblValorC = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.txtValorC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVerif
            // 
            this.btnVerif.ForeColor = System.Drawing.Color.Black;
            this.btnVerif.Location = new System.Drawing.Point(34, 203);
            this.btnVerif.Name = "btnVerif";
            this.btnVerif.Size = new System.Drawing.Size(75, 23);
            this.btnVerif.TabIndex = 0;
            this.btnVerif.Text = "Verificar";
            this.btnVerif.UseVisualStyleBackColor = true;
            this.btnVerif.Click += new System.EventHandler(this.btnVerif_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(141, 203);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(75, 23);
            this.btnLimp.TabIndex = 1;
            this.btnLimp.Text = "Limpar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(255, 203);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblValorA
            // 
            this.lblValorA.AutoSize = true;
            this.lblValorA.BackColor = System.Drawing.Color.Transparent;
            this.lblValorA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblValorA.Location = new System.Drawing.Point(34, 35);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(50, 15);
            this.lblValorA.TabIndex = 3;
            this.lblValorA.Text = "Valor A :";
            // 
            // lblValorB
            // 
            this.lblValorB.AutoSize = true;
            this.lblValorB.BackColor = System.Drawing.Color.Transparent;
            this.lblValorB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblValorB.Location = new System.Drawing.Point(34, 87);
            this.lblValorB.Name = "lblValorB";
            this.lblValorB.Size = new System.Drawing.Size(49, 15);
            this.lblValorB.TabIndex = 4;
            this.lblValorB.Text = "Valor B :";
            // 
            // lblValorC
            // 
            this.lblValorC.AutoSize = true;
            this.lblValorC.BackColor = System.Drawing.Color.Transparent;
            this.lblValorC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblValorC.Location = new System.Drawing.Point(34, 135);
            this.lblValorC.Name = "lblValorC";
            this.lblValorC.Size = new System.Drawing.Size(50, 15);
            this.lblValorC.TabIndex = 5;
            this.lblValorC.Text = "Valor C :";
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(141, 32);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(189, 23);
            this.txtValorA.TabIndex = 6;
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(141, 87);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(189, 23);
            this.txtValorB.TabIndex = 7;
            // 
            // txtValorC
            // 
            this.txtValorC.Location = new System.Drawing.Point(141, 135);
            this.txtValorC.Name = "txtValorC";
            this.txtValorC.Size = new System.Drawing.Size(189, 23);
            this.txtValorC.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(387, 263);
            this.Controls.Add(this.txtValorC);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.lblValorC);
            this.Controls.Add(this.lblValorB);
            this.Controls.Add(this.lblValorA);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnVerif);
            this.Name = "Form1";
            this.Text = "Verificar Triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerif;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.Label lblValorB;
        private System.Windows.Forms.Label lblValorC;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.TextBox txtValorC;
    }
}

