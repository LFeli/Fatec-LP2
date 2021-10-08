using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptestemetodos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void exercicioToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copiarCrtlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aoba chamou o Menu copiar");
        }

        private void colarCrtlVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ahow meu chamou? Menu colar ta aqui");
        }
    }
}
