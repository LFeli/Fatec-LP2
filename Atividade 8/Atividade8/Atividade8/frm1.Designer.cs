
namespace Atividade8
{
    partial class frm1
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
            this.lblFrase = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.btnNumEspaVazio = new System.Windows.Forms.Button();
            this.btnFraseR = new System.Windows.Forms.Button();
            this.btnParLetra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Location = new System.Drawing.Point(157, 173);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(96, 15);
            this.lblFrase.TabIndex = 0;
            this.lblFrase.Text = "Insira uma frase :";
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(283, 173);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(231, 23);
            this.txtPalavra.TabIndex = 1;
            // 
            // btnNumEspaVazio
            // 
            this.btnNumEspaVazio.Location = new System.Drawing.Point(89, 322);
            this.btnNumEspaVazio.Name = "btnNumEspaVazio";
            this.btnNumEspaVazio.Size = new System.Drawing.Size(144, 53);
            this.btnNumEspaVazio.TabIndex = 2;
            this.btnNumEspaVazio.Text = "Verificar quantos espaços vazios contém na frase";
            this.btnNumEspaVazio.UseVisualStyleBackColor = true;
            this.btnNumEspaVazio.Click += new System.EventHandler(this.btnNumEspaVazio_Click);
            // 
            // btnFraseR
            // 
            this.btnFraseR.Location = new System.Drawing.Point(314, 322);
            this.btnFraseR.Name = "btnFraseR";
            this.btnFraseR.Size = new System.Drawing.Size(144, 53);
            this.btnFraseR.TabIndex = 3;
            this.btnFraseR.Text = "Verificar quantas vezes aparece a letra \"R\" na frase";
            this.btnFraseR.UseVisualStyleBackColor = true;
            this.btnFraseR.Click += new System.EventHandler(this.btnFraseR_Click);
            // 
            // btnParLetra
            // 
            this.btnParLetra.Location = new System.Drawing.Point(546, 322);
            this.btnParLetra.Name = "btnParLetra";
            this.btnParLetra.Size = new System.Drawing.Size(144, 53);
            this.btnParLetra.TabIndex = 4;
            this.btnParLetra.Text = "Verificar quantas vezes aparece um par de letras";
            this.btnParLetra.UseVisualStyleBackColor = true;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParLetra);
            this.Controls.Add(this.btnFraseR);
            this.Controls.Add(this.btnNumEspaVazio);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.lblFrase);
            this.Name = "frm1";
            this.Text = "frm1";
            this.Load += new System.EventHandler(this.frm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Button btnNumEspaVazio;
        private System.Windows.Forms.Button btnFraseR;
        private System.Windows.Forms.Button btnParLetra;
    }
}