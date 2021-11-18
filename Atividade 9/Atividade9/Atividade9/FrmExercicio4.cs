using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Atividade9
{
    public partial class FrmExercicio4 : Form
    {
        public FrmExercicio4()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            ArrayList lista  = new ArrayList();
            lista.Add("Ana");
            lista.Add("André");
            lista.Add("Débora");
            lista.Add("Fátima");
            lista.Add("João");
            lista.Add("Ótavio");
            lista.Add("Marcelo");
            lista.Add("Pedro");
            lista.Add("Thais");

            lista.Remove("Otávio");

            foreach (string  seila in lista)
            {
                MessageBox.Show("Os nomes: " + seila.ToString());
            }
        }
    }
}
