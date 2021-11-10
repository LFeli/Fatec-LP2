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
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFunfa_Click(object sender, EventArgs e)
        {
            double N;
            float H = 0;
            int X = 1;

            if (double.TryParse(txtNum.Text, out N))
            {
                if (N <= 0)
            {
                MessageBox.Show("Valores invalidos :( ");
            }
                else
            {
                for (int i = 0; i < N; i++)
                {
                    H = H + 1/X  ;
                    X++;

                }
                
                MessageBox.Show(H.ToString("N2"));
            }
            }
            else
            {
                MessageBox.Show("Valores invalidos ;-; ");
            }
        }

    }
}
