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
                IMC = Peso / (Math.Pow(Altura, 2));
                IMC = Math.Round(IMC, 0);

                txtIMC.Text = IMC.ToString("N1");

                if (IMC < 18.5)
                MessageBox.Show("Magreza");
                    else if (IMC <= 24.9)
                    MessageBox.Show("Normal");
                        else if (IMC <= 29.9)
                        MessageBox.Show("Sobrepeso");
                            else if (IMC <= 39.9)
                            MessageBox.Show("Obesidade");
                                else if (IMC > 40)
                                MessageBox.Show("Obesidade garve");


            }
            else
                MessageBox.Show("Valores inválidos");
       }
    }
}
