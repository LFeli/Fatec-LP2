using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PContato0030482113001
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=DESKTOP-HFDGN14\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True;Pooling=False");
                conexao.Open();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/ " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros erros =/ " + ex.Message);
            }

        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmContato"];

            if (fc != null)
                fc.Close();


            frmContato FRMC = new frmContato();
            FRMC.MdiParent = this;
            FRMC.WindowState = FormWindowState.Maximized;
            FRMC.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.MdiParent = this;
            sobre.WindowState = FormWindowState.Maximized;
            sobre.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
