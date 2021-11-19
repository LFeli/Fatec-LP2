
namespace P0030482113001
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
            this.btnFuncao = new System.Windows.Forms.Button();
            this.lstbxEntrada = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnFuncao
            // 
            this.btnFuncao.Location = new System.Drawing.Point(312, 348);
            this.btnFuncao.Name = "btnFuncao";
            this.btnFuncao.Size = new System.Drawing.Size(199, 44);
            this.btnFuncao.TabIndex = 0;
            this.btnFuncao.Text = "Executar a função :";
            this.btnFuncao.UseVisualStyleBackColor = true;
            this.btnFuncao.Click += new System.EventHandler(this.btnFuncao_Click);
            // 
            // lstbxEntrada
            // 
            this.lstbxEntrada.FormattingEnabled = true;
            this.lstbxEntrada.ItemHeight = 15;
            this.lstbxEntrada.Location = new System.Drawing.Point(248, 140);
            this.lstbxEntrada.Name = "lstbxEntrada";
            this.lstbxEntrada.Size = new System.Drawing.Size(325, 94);
            this.lstbxEntrada.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbxEntrada);
            this.Controls.Add(this.btnFuncao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFuncao;
        private System.Windows.Forms.ListBox lstbxEntrada;
    }
}

