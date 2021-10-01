
namespace PClasses
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
            this.btnMensa = new System.Windows.Forms.Button();
            this.btnHorista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMensa
            // 
            this.btnMensa.Location = new System.Drawing.Point(204, 263);
            this.btnMensa.Name = "btnMensa";
            this.btnMensa.Size = new System.Drawing.Size(77, 23);
            this.btnMensa.TabIndex = 0;
            this.btnMensa.Text = "Mensalista : ";
            this.btnMensa.UseVisualStyleBackColor = true;
            this.btnMensa.Click += new System.EventHandler(this.btnMensa_Click);
            // 
            // btnHorista
            // 
            this.btnHorista.Location = new System.Drawing.Point(468, 263);
            this.btnHorista.Name = "btnHorista";
            this.btnHorista.Size = new System.Drawing.Size(75, 23);
            this.btnHorista.TabIndex = 1;
            this.btnHorista.Text = "Horista:";
            this.btnHorista.UseVisualStyleBackColor = true;
            this.btnHorista.Click += new System.EventHandler(this.btnHorista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHorista);
            this.Controls.Add(this.btnMensa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMensa;
        private System.Windows.Forms.Button btnHorista;
    }
}

