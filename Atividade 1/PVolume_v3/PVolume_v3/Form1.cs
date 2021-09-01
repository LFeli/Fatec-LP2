using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume_v3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtAlt.Clear();
            txtRaio.Clear();
            txtVol.Clear();
        }

        private void btnFech_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double altura, raio;
            if ((double.TryParse(txtAlt.Text, out altura)) &&
                    (double.TryParse(txtRaio.Text, out raio)))
                    {
                double volume;
                volume = Math.PI * Math.Pow(raio, 2) * altura;
                txtVol.Text = volume.ToString("N2");

            }
            else
                MessageBox.Show("Valores inválidos");
        }
    }
}
