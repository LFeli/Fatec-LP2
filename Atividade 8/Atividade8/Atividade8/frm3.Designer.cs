
namespace Atividade8
{
    partial class frm3
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
            this.lblpalavra = new System.Windows.Forms.Label();
            this.txtpalavra = new System.Windows.Forms.TextBox();
            this.btnFunfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpalavra
            // 
            this.lblpalavra.AutoSize = true;
            this.lblpalavra.Location = new System.Drawing.Point(143, 173);
            this.lblpalavra.Name = "lblpalavra";
            this.lblpalavra.Size = new System.Drawing.Size(114, 15);
            this.lblpalavra.TabIndex = 0;
            this.lblpalavra.Text = "Escreva sua palavra :";
            // 
            // txtpalavra
            // 
            this.txtpalavra.Location = new System.Drawing.Point(314, 170);
            this.txtpalavra.Name = "txtpalavra";
            this.txtpalavra.Size = new System.Drawing.Size(196, 23);
            this.txtpalavra.TabIndex = 1;
            // 
            // btnFunfa
            // 
            this.btnFunfa.Location = new System.Drawing.Point(292, 276);
            this.btnFunfa.Name = "btnFunfa";
            this.btnFunfa.Size = new System.Drawing.Size(133, 48);
            this.btnFunfa.TabIndex = 2;
            this.btnFunfa.Text = "Executar função :";
            this.btnFunfa.UseVisualStyleBackColor = true;
            this.btnFunfa.Click += new System.EventHandler(this.btnFunfa_Click);
            // 
            // frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFunfa);
            this.Controls.Add(this.txtpalavra);
            this.Controls.Add(this.lblpalavra);
            this.Name = "frm3";
            this.Text = "frm3";
            this.Load += new System.EventHandler(this.frm3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpalavra;
        private System.Windows.Forms.TextBox txtpalavra;
        private System.Windows.Forms.Button btnFunfa;
    }
}