using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verificar_Triângulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtValorA.Clear();
            txtValorB.Clear();
            txtValorC.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerif_Click(object sender, EventArgs e)
        {
            double Valor_A;
            double Valor_B;
            double Valor_C;

                if(!double.TryParse(txtValorA.Text, out Valor_A) ||
                    !double.TryParse(txtValorB.Text, out Valor_B) ||
                    !double.TryParse(txtValorC.Text, out Valor_C))
                {
                    MessageBox.Show("Valores devem ser númericos");
                }
                else
            {
                if (Valor_A < (Valor_B + Valor_C) && Valor_A > Math.Abs(Valor_B - Valor_C) &&   Valor_B < (Valor_A + Valor_C) &&
                    Valor_B > Math.Abs(Valor_A - Valor_C ) && Valor_C < (Valor_A + Valor_B) && Valor_C > Math.Abs(Valor_A - Valor_B))
                {
                    if ( Valor_A == Valor_B && Valor_B == Valor_C )
                    {
                        MessageBox.Show("Os valores refere-se a um Triângulo Equilátero");
                    }
                    else
                    {
                        if ( Valor_A == Valor_B || Valor_A == Valor_C || Valor_B == Valor_C)
                        {
                            MessageBox.Show("Os valores refere-se a um Triângulo Isósceles");
                        }
                        else
                        {
                            MessageBox.Show("Os valores refere-se a um Triângulo Escaleno");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Os valores não formam um triângulo");
                }
            }
        }
    }
}
