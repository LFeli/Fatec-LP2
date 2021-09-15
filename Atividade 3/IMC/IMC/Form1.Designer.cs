
namespace IMC
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
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAlt = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblImc = new System.Windows.Forms.Label();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.Transparent;
            this.lblPeso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPeso.Location = new System.Drawing.Point(40, 78);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(35, 15);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso:";
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.BackColor = System.Drawing.Color.Transparent;
            this.lblAlt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAlt.Location = new System.Drawing.Point(40, 123);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(42, 15);
            this.lblAlt.TabIndex = 1;
            this.lblAlt.Text = "Altura:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(110, 75);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(93, 23);
            this.txtPeso.TabIndex = 2;
            // 
            // txtAlt
            // 
            this.txtAlt.Location = new System.Drawing.Point(110, 115);
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.Size = new System.Drawing.Size(93, 23);
            this.txtAlt.TabIndex = 3;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(13, 217);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(69, 26);
            this.btnCal.TabIndex = 4;
            this.btnCal.Text = "Calcular";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(110, 217);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(69, 26);
            this.btnLimp.TabIndex = 5;
            this.btnLimp.Text = "Limpar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(206, 217);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(69, 26);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.BackColor = System.Drawing.Color.Transparent;
            this.lblImc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblImc.Location = new System.Drawing.Point(40, 160);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(32, 15);
            this.lblImc.TabIndex = 7;
            this.lblImc.Text = "IMC:";
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(110, 152);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.ReadOnly = true;
            this.txtIMC.Size = new System.Drawing.Size(93, 23);
            this.txtIMC.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IMC.Properties.Resources.corredor_longo_e_escuro_1353_133;
            this.ClientSize = new System.Drawing.Size(287, 270);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.lblImc);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtAlt);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblAlt);
            this.Controls.Add(this.lblPeso);
            this.Name = "Form1";
            this.Text = "Calcular IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAlt;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblImc;
        private System.Windows.Forms.TextBox txtIMC;
    }
}

