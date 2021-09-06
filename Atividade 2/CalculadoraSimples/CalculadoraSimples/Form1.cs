using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResul.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            double num1=0 , num2=0 , resultado;

            if ((double.TryParse(txtNum1.Text, out num1)) &&
            (double.TryParse(txtNum2.Text, out num2)))
            {
                resultado = num1 + num2;
                txtResul.Text = resultado.ToString("N2");
            }
            else MessageBox.Show("Valores Invalidos");
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0, resultado;

            if ((double.TryParse(txtNum1.Text, out num1)) &&
            (double.TryParse(txtNum2.Text, out num2)))
            {
                resultado = num1 - num2;
                txtResul.Text = resultado.ToString("N2");
            }
            else MessageBox.Show("Valores Invalidos");
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0, resultado;

            if ((double.TryParse(txtNum1.Text, out num1)) &&
            (double.TryParse(txtNum2.Text, out num2)))
            {
                resultado = num1 * num2;
                txtResul.Text = resultado.ToString("N2");
            }
            else MessageBox.Show("Valores Invalidos");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0, resultado;

            if ((double.TryParse(txtNum1.Text, out num1)) &&
            (double.TryParse(txtNum2.Text, out num2)))
            {
                if (num2 == 0)
                    MessageBox.Show("Valores invalidos");
                else
                {
                resultado = num1 / num2;
                txtResul.Text = resultado.ToString("N2");
                }
            }
            else MessageBox.Show("Valores Invalidos");
        }
    }
}
