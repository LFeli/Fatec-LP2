
namespace Ptestemetodos
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarCrtlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarCrtlVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercicioToolStripMenuItem,
            this.exercicioToolStripMenuItem1,
            this.exercicio4ToolStripMenuItem,
            this.exercicio5ToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exercicioToolStripMenuItem
            // 
            this.exercicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarCrtlCToolStripMenuItem,
            this.colarCrtlVToolStripMenuItem});
            this.exercicioToolStripMenuItem.Name = "exercicioToolStripMenuItem";
            this.exercicioToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.exercicioToolStripMenuItem.Text = "Exercicio &2";
            this.exercicioToolStripMenuItem.Click += new System.EventHandler(this.exercicioToolStripMenuItem_Click);
            // 
            // copiarCrtlCToolStripMenuItem
            // 
            this.copiarCrtlCToolStripMenuItem.Name = "copiarCrtlCToolStripMenuItem";
            this.copiarCrtlCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarCrtlCToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.copiarCrtlCToolStripMenuItem.Text = "Copiar          ";
            this.copiarCrtlCToolStripMenuItem.Click += new System.EventHandler(this.copiarCrtlCToolStripMenuItem_Click);
            // 
            // colarCrtlVToolStripMenuItem
            // 
            this.colarCrtlVToolStripMenuItem.Name = "colarCrtlVToolStripMenuItem";
            this.colarCrtlVToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.colarCrtlVToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.colarCrtlVToolStripMenuItem.Text = "Colar            ";
            this.colarCrtlVToolStripMenuItem.Click += new System.EventHandler(this.colarCrtlVToolStripMenuItem_Click);
            // 
            // exercicioToolStripMenuItem1
            // 
            this.exercicioToolStripMenuItem1.Name = "exercicioToolStripMenuItem1";
            this.exercicioToolStripMenuItem1.Size = new System.Drawing.Size(75, 20);
            this.exercicioToolStripMenuItem1.Text = "Exercicio &3";
            this.exercicioToolStripMenuItem1.Click += new System.EventHandler(this.exercicioToolStripMenuItem1_Click);
            // 
            // exercicio4ToolStripMenuItem
            // 
            this.exercicio4ToolStripMenuItem.Name = "exercicio4ToolStripMenuItem";
            this.exercicio4ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.exercicio4ToolStripMenuItem.Text = "Exercicio &4";
            this.exercicio4ToolStripMenuItem.Click += new System.EventHandler(this.exercicio4ToolStripMenuItem_Click);
            // 
            // exercicio5ToolStripMenuItem
            // 
            this.exercicio5ToolStripMenuItem.Name = "exercicio5ToolStripMenuItem";
            this.exercicio5ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.exercicio5ToolStripMenuItem.Text = "Exercicio &5";
            this.exercicio5ToolStripMenuItem.Click += new System.EventHandler(this.exercicio5ToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.editorDeTextoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 48);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // editorDeTextoToolStripMenuItem
            // 
            this.editorDeTextoToolStripMenuItem.Name = "editorDeTextoToolStripMenuItem";
            this.editorDeTextoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.editorDeTextoToolStripMenuItem.Text = "Editor de texto";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Form principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exercicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exercicio4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicio5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarCrtlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarCrtlVToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorDeTextoToolStripMenuItem;
    }
}

