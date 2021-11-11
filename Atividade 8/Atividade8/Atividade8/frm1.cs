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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void frm1_Load(object sender, EventArgs e)
        {
         
        }

        private void btnNumEspaVazio_Click(object sender, EventArgs e)
        {
            string s;

        }

        private void btnFraseR_Click(object sender, EventArgs e)
        {
            string s;
            string r = "R";
            int i;
            int R = 0;

            s = txtPalavra.Text;

            for ( i = 0; i < s.Length ; i++)
            {
                if (String.Equals(r, s))
                {
                    R +=  1;
                }
            }
            MessageBox.Show("A frase contém " + R + " letras R");

            

        }
    }
}
