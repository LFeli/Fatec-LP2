using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1 FRM1 = new frm1();
            FRM1.MdiParent = this;
            FRM1.WindowState = FormWindowState.Maximized;
            FRM1.Show();
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm2 FRM2 = new frm2();
            FRM2.MdiParent = this;
            FRM2.WindowState = FormWindowState.Maximized;
            FRM2.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm3 FRM3 = new frm3();
            FRM3.MdiParent = this;
            FRM3.WindowState = FormWindowState.Maximized;
            FRM3.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm4 FRM4 = new frm4();
            FRM4.MdiParent = this;
            FRM4.WindowState = FormWindowState.Maximized;
            FRM4.Show();
        }
    }
}
