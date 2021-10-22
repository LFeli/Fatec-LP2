using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptestemetodos
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnGerador_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;

            if ((int.TryParse(txtNum1.Text, out num1)) &&
               (int.TryParse(txtNum2.Text, out num2)))

            {
                Random random = new Random();
                double r = random.Next(num1, num2);
                MessageBox.Show(r.ToString());
            }
            else
            {
                MessageBox.Show("Valores invalidos");
            }
        }
    }
}
