
namespace Ptestemetodos
{
    partial class frmExercicio4
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
            this.rtxtInsirir = new System.Windows.Forms.RichTextBox();
            this.lblInserir = new System.Windows.Forms.Label();
            this.btnNum = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtInsirir
            // 
            this.rtxtInsirir.Location = new System.Drawing.Point(318, 118);
            this.rtxtInsirir.Name = "rtxtInsirir";
            this.rtxtInsirir.Size = new System.Drawing.Size(117, 20);
            this.rtxtInsirir.TabIndex = 0;
            this.rtxtInsirir.Text = "";
            this.rtxtInsirir.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lblInserir
            // 
            this.lblInserir.AutoSize = true;
            this.lblInserir.Location = new System.Drawing.Point(245, 121);
            this.lblInserir.Name = "lblInserir";
            this.lblInserir.Size = new System.Drawing.Size(67, 15);
            this.lblInserir.TabIndex = 1;
            this.lblInserir.Text = "Insira algo :";
            // 
            // btnNum
            // 
            this.btnNum.Location = new System.Drawing.Point(99, 306);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(117, 43);
            this.btnNum.TabIndex = 2;
            this.btnNum.Text = "Mostrar quantos numeros tem :";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(318, 306);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(117, 43);
            this.btnBranco.TabIndex = 3;
            this.btnBranco.Text = "Mostrar o espaço em branco :";
            this.btnBranco.UseVisualStyleBackColor = true;
            // 
            // btnLetras
            // 
            this.btnLetras.Location = new System.Drawing.Point(522, 306);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(104, 43);
            this.btnLetras.TabIndex = 4;
            this.btnLetras.Text = "Mostrar quantas letras tem :";
            this.btnLetras.UseVisualStyleBackColor = true;
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLetras);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.lblInserir);
            this.Controls.Add(this.rtxtInsirir);
            this.Name = "frmExercicio4";
            this.Text = "Exercicio 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtInsirir;
        private System.Windows.Forms.Label lblInserir;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnLetras;
    }
}