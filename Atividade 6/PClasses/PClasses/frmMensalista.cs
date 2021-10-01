using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void lblDataEntrada_Click(object sender, EventArgs e)
        {

        }

        private void lblMatricula_Click(object sender, EventArgs e)
        {

        }

        private void btnInstaMensali_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();

                objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
                objMensalista.NomeDoEmpregado = txtNome.Text;
                objMensalista.DataDaEmpresa = Convert.ToDateTime(txtDataDaEmpresa.Text);
                objMensalista.SalarioMensal = Convert.ToDouble(txtSalaMensal.Text);

                objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
                objMensalista.NomeDoEmpregado = txtNome.Text;
                objMensalista.DataDaEmpresa = Convert.ToDateTime(txtDataDaEmpresa.Text);
                objMensalista.SalarioMensal = Convert.ToDouble(txtSalaMensal.Text); 
                MessageBox.Show("Matrícula : " + objMensalista.Matricula + "\n" +
                "Nome : " + objMensalista.NomeDoEmpregado + "\n" +
                "Data Entrada : " + objMensalista.DataDaEmpresa.ToShortDateString() +
                "\n" +
                "Salário Bruto : " + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                "Tempo Empresa (dias): " + objMensalista.TempoTrabalho());


        }

        private void btnInstaMensaPassaParamet_Click(object sender, EventArgs e)
        {
            Mensalista mensalista = new Mensalista(
                Convert.ToInt32(txtMatricula.Text),
                txtNome.Text,
                Convert.ToDateTime(txtDataDaEmpresa.Text),
                Convert.ToDouble(txtSalaMensal.Text));

            MessageBox.Show("Nome =" + mensalista.NomeDoEmpregado + "\n" +
                "Matrícula =" + mensalista.Matricula + "\n" +
                "Salário Final =" +
                mensalista.SalarioBruto().ToString("N2")
                + "\n" +
                "Tempo Empresa =" +
                mensalista.TempoTrabalho().ToString());
        }
    }
}
