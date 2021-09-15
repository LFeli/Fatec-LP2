using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
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
            txtIMC.Clear();
            txtPeso.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double Peso;
            double Altura;
            double IMC;

            if ((double.TryParse(txtPeso.Text, out Peso)) &&
                (double.TryParse(txtAlt.Text, out Altura)))
            {
                if (Peso == 0 || Altura == 0 || Peso >= 596 || Altura >= 2.52)
                {
                    MessageBox.Show("Valores inválidos ou excederam os valores sobre peso ou altura cedido pelo guinesbook ");
                }
                else
                {
                    IMC = Peso / (Math.Pow(Altura, 2));
                    IMC = Math.Round(IMC, 0);

                    txtIMC.Text = IMC.ToString("N1");

                    if (IMC < 18.5)
                        MessageBox.Show("Sua classificação é Magreza, seu grau de obesidade e 0");
                    else if (IMC <= 24.9)
                        MessageBox.Show("Sua classificação é Normal, seu grau de obesidade e 0");
                    else if (IMC <= 29.9)
                        MessageBox.Show("Sua classificação é Sobrepeso, seu grau de obesidade e 1 ");
                    else if (IMC <= 39.9)
                        MessageBox.Show("Sua classificação é Obesidade, seu grau de obesidade e 2");
                    else
                        MessageBox.Show("Sua classificação é Obesidade garve, seu grau de obesidade e 3");

                }
            }
            else
                MessageBox.Show("Valores inválidos");
       }
    }
}
