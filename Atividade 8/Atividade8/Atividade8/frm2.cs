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
            double H = 0;
            double N;
            double i;

            if ((txtNum.Text == ""))
            {
                MessageBox.Show("Número em branco :/ ");
            }
            else
            {
                if ((double.TryParse(txtNum.Text, out N)))
                {
                    if (N > 0)
                    {
                        for (i = 1; i < N + 1; i++)
                        {
                            H = H + 1 / i;

                        }
                        MessageBox.Show("O Resultado será :" + H.ToString());
                    }
                    else
                        MessageBox.Show("Valor invalido ;-; ");
                }
            }
        }

    }
}
