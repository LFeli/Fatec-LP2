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
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmHorista_Load(object sender, EventArgs e)
        {
            Horista ObjHorista = new Horista();

            ObjHorista.NomeDoEmpregado = txtNome.Text;
            ObjHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            ObjHorista.SalarioHora = Convert.ToInt32(txtSalaHora.Text);
            ObjHorista.NumeroHora = Convert.ToInt32(txtNumDeHoras.Text);
            ObjHorista.DataDaEmpresa = Convert.ToDateTime(txtDataEntraEmpresa.Text);
            ObjHorista.DiasFalta = Convert.ToInt32(txtDiasFalta.Text);

            MessageBox.Show("Nome:" + ObjHorista.NomeDoEmpregado +
                "\n" + "Mátricula:" + ObjHorista.Matricula + "\n" +
                "Tempo trabalho:" + ObjHorista.TempoTrabalho().ToString()
                + "\n" + "Salario:" + ObjHorista.SalarioBruto().ToString("N2"));



        }
    }
}
