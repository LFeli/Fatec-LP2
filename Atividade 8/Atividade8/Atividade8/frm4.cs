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
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
        }

        private void frm4_Load(object sender, EventArgs e)
        {

        }

        private void btnFun_Click(object sender, EventArgs e)
        {
            double salario;
            double producao;
            double B = 0;
            double C = 0;
            double D = 0;
            double salarioBruto;



            if ((double.TryParse(txtSalario.Text, out salario)) &&
                (double.TryParse(txtProdu.Text, out producao)))
            {
                if ( txtCargo.Text == "" || txtMatri.Text == "" || txtNome.Text == "" || txtProdu.Text == "" || txtSalario.Text == "" || salario < 0 
                    || producao < 0)
                {
                    MessageBox.Show("Algum valor está incorreto, por favor verfique todos os campos");
                }
                else
                {
                    if(producao >= 100)
                    {
                        B = 1;
                    }
                     if (producao >= 120)
                    {
                        C = 1;
                    }
                     if ( producao >= 150)
                    {
                        D = 1; 
                    }

                    if (cbxGrati.Checked && salario > 7000 && producao >= 150 )
                    {
                        salarioBruto = salario + (salario * ((0.05 * B) + (0.1 * C) + (0.1 * D)));
                        MessageBox.Show("O salario bruto será :" + salarioBruto.ToString());
                    }
                    else if (!cbxGrati.Checked && salario <= 7000)
                    {
                        salarioBruto = salario + (salario * ((0.05 * B) + (0.1 * C) + (0.1 * D)));
                        MessageBox.Show("O salario bruto será :" + salarioBruto.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Algo está errado :( , por favor verifique todos os campos");
                    }
                }
                    
            }
                else
                {
                    MessageBox.Show("Valores invalidos ;-;");
                }
        }
    }
}
