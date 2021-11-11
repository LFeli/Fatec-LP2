
namespace Atividade8
{
    partial class frm2
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
            this.lblInserir = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnFunfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInserir
            // 
            this.lblInserir.AutoSize = true;
            this.lblInserir.Location = new System.Drawing.Point(52, 61);
            this.lblInserir.Name = "lblInserir";
            this.lblInserir.Size = new System.Drawing.Size(107, 15);
            this.lblInserir.TabIndex = 0;
            this.lblInserir.Text = "Insira um numero :";
            this.lblInserir.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(215, 58);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(126, 23);
            this.txtNum.TabIndex = 1;
            // 
            // btnFunfa
            // 
            this.btnFunfa.Location = new System.Drawing.Point(135, 136);
            this.btnFunfa.Name = "btnFunfa";
            this.btnFunfa.Size = new System.Drawing.Size(145, 66);
            this.btnFunfa.TabIndex = 2;
            this.btnFunfa.Text = "Executar a função";
            this.btnFunfa.UseVisualStyleBackColor = true;
            this.btnFunfa.Click += new System.EventHandler(this.btnFunfa_Click);
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 260);
            this.Controls.Add(this.btnFunfa);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblInserir);
            this.Name = "frm2";
            this.Text = "frm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInserir;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnFunfa;
    }
}