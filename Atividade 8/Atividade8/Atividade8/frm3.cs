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
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        private void frm3_Load(object sender, EventArgs e)
        {

        }

        private void btnFunfa_Click(object sender, EventArgs e)
        {
            string s;
            string s2;
            int tamanho;

            s = txtpalavra.Text;
            tamanho = s.Length;

            if (tamanho <= 50)
            {
                s = s.Replace(" ", "");
                s = s.ToLower();
                s2 = s;

                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                s = "";
                foreach(char c in arr)
                {
                    s = s + c.ToString();
                }

                if (String.Compare(s2,s,true) == 0){
                    MessageBox.Show("A palavra e um palíndro :) ");
                }
                else
                {
                    MessageBox.Show("A palavra não e um palíndro :( ");
                }
            }
            else
            {
                MessageBox.Show("A palavra excedeu o limite de 50 caracteres ");
            }
        }
    }
}
