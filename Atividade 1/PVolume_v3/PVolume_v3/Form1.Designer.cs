
namespace PVolume_v3
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
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnFech = new System.Windows.Forms.Button();
            this.lbltAlt = new System.Windows.Forms.Label();
            this.lblRaio = new System.Windows.Forms.Label();
            this.lblVol = new System.Windows.Forms.Label();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtVol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(237, 254);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(88, 30);
            this.btnLimp.TabIndex = 0;
            this.btnLimp.Text = "Limpar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(70, 254);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(88, 30);
            this.btnCal.TabIndex = 1;
            this.btnCal.Text = "Calcular";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnFech
            // 
            this.btnFech.Location = new System.Drawing.Point(385, 254);
            this.btnFech.Name = "btnFech";
            this.btnFech.Size = new System.Drawing.Size(88, 30);
            this.btnFech.TabIndex = 2;
            this.btnFech.Text = "Fechar";
            this.btnFech.UseVisualStyleBackColor = true;
            this.btnFech.Click += new System.EventHandler(this.btnFech_Click);
            // 
            // lbltAlt
            // 
            this.lbltAlt.AutoSize = true;
            this.lbltAlt.Location = new System.Drawing.Point(70, 47);
            this.lbltAlt.Name = "lbltAlt";
            this.lbltAlt.Size = new System.Drawing.Size(45, 15);
            this.lbltAlt.TabIndex = 3;
            this.lbltAlt.Text = "Altura :";
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Location = new System.Drawing.Point(70, 97);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(36, 15);
            this.lblRaio.TabIndex = 4;
            this.lblRaio.Text = "Raio :";
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.Location = new System.Drawing.Point(70, 142);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(53, 15);
            this.lblVol.TabIndex = 5;
            this.lblVol.Text = "Volume :";
            // 
            // txtAlt
            // 
            this.txtAlt.Location = new System.Drawing.Point(169, 47);
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.Size = new System.Drawing.Size(304, 23);
            this.txtAlt.TabIndex = 6;
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(169, 97);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(304, 23);
            this.txtRaio.TabIndex = 7;
            // 
            // txtVol
            // 
            this.txtVol.Location = new System.Drawing.Point(169, 142);
            this.txtVol.Name = "txtVol";
            this.txtVol.Size = new System.Drawing.Size(304, 23);
            this.txtVol.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 302);
            this.Controls.Add(this.txtVol);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.txtAlt);
            this.Controls.Add(this.lblVol);
            this.Controls.Add(this.lblRaio);
            this.Controls.Add(this.lbltAlt);
            this.Controls.Add(this.btnFech);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnLimp);
            this.Name = "Form1";
            this.Text = "Calcular o volume do cilindro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnFech;
        private System.Windows.Forms.Label lbltAlt;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.TextBox txtAlt;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtVol;
    }
}

