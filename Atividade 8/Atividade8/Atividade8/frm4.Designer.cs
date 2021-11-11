
namespace Atividade8
{
    partial class frm4
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblMatri = new System.Windows.Forms.Label();
            this.lblProdu = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblGratif = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtMatri = new System.Windows.Forms.TextBox();
            this.txtProdu = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.cbxGrati = new System.Windows.Forms.CheckBox();
            this.btnFun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(100, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome :";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(100, 85);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(45, 15);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "Cargo :";
            // 
            // lblMatri
            // 
            this.lblMatri.AutoSize = true;
            this.lblMatri.Location = new System.Drawing.Point(100, 122);
            this.lblMatri.Name = "lblMatri";
            this.lblMatri.Size = new System.Drawing.Size(63, 15);
            this.lblMatri.TabIndex = 2;
            this.lblMatri.Text = "Mátricula :";
            // 
            // lblProdu
            // 
            this.lblProdu.AutoSize = true;
            this.lblProdu.Location = new System.Drawing.Point(100, 165);
            this.lblProdu.Name = "lblProdu";
            this.lblProdu.Size = new System.Drawing.Size(64, 15);
            this.lblProdu.TabIndex = 3;
            this.lblProdu.Text = "Produção :";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(100, 203);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(48, 15);
            this.lblSala.TabIndex = 4;
            this.lblSala.Text = "Salario :";
            // 
            // lblGratif
            // 
            this.lblGratif.AutoSize = true;
            this.lblGratif.Location = new System.Drawing.Point(100, 243);
            this.lblGratif.Name = "lblGratif";
            this.lblGratif.Size = new System.Drawing.Size(76, 15);
            this.lblGratif.TabIndex = 5;
            this.lblGratif.Text = "Gratificação :";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(285, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 6;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(285, 82);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 23);
            this.txtCargo.TabIndex = 7;
            // 
            // txtMatri
            // 
            this.txtMatri.Location = new System.Drawing.Point(285, 119);
            this.txtMatri.Name = "txtMatri";
            this.txtMatri.Size = new System.Drawing.Size(100, 23);
            this.txtMatri.TabIndex = 8;
            // 
            // txtProdu
            // 
            this.txtProdu.Location = new System.Drawing.Point(285, 162);
            this.txtProdu.Name = "txtProdu";
            this.txtProdu.Size = new System.Drawing.Size(100, 23);
            this.txtProdu.TabIndex = 9;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(285, 200);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 23);
            this.txtSalario.TabIndex = 10;
            // 
            // cbxGrati
            // 
            this.cbxGrati.AutoSize = true;
            this.cbxGrati.Location = new System.Drawing.Point(285, 243);
            this.cbxGrati.Name = "cbxGrati";
            this.cbxGrati.Size = new System.Drawing.Size(144, 19);
            this.cbxGrati.TabIndex = 11;
            this.cbxGrati.Text = "Contém a graficação ?";
            this.cbxGrati.UseVisualStyleBackColor = true;
            // 
            // btnFun
            // 
            this.btnFun.Location = new System.Drawing.Point(330, 322);
            this.btnFun.Name = "btnFun";
            this.btnFun.Size = new System.Drawing.Size(152, 58);
            this.btnFun.TabIndex = 12;
            this.btnFun.Text = "Executar a função ";
            this.btnFun.UseVisualStyleBackColor = true;
            this.btnFun.Click += new System.EventHandler(this.btnFun_Click);
            // 
            // frm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFun);
            this.Controls.Add(this.cbxGrati);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtProdu);
            this.Controls.Add(this.txtMatri);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblGratif);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblProdu);
            this.Controls.Add(this.lblMatri);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNome);
            this.Name = "frm4";
            this.Text = "frm4";
            this.Load += new System.EventHandler(this.frm4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblMatri;
        private System.Windows.Forms.Label lblProdu;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblGratif;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtMatri;
        private System.Windows.Forms.TextBox txtProdu;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.CheckBox cbxGrati;
        private System.Windows.Forms.Button btnFun;
    }
}