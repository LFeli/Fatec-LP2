using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PContato0030482113001
{
    public partial class frmContato : Form
    {

        private BindingSource bnContato = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsContato = new DataSet();
        private DataSet dsCidade = new DataSet();


        public frmContato()
        {
            InitializeComponent();
        }

        private void frmContato_Load(object sender, EventArgs e)
        {
            try
            {
                Contato Con = new Contato();
                dsContato.Tables.Add(Con.Listar());
                bnContato.DataSource = dsContato.Tables["Contato"];
                dgvContato.DataSource = bnContato;
                bnvContato.BindingSource = bnContato;

                txtIdContato.DataBindings.Add("TEXT", bnContato, "id_contato");
                txtNomeContato.DataBindings.Add("TEXT", bnContato, "nome_contato");
                txtEndContato.DataBindings.Add("TEXT", bnContato, "end_contato");
                txtCelContato.DataBindings.Add("TEXT", bnContato, "cel_contato");
                txtEmailContato.DataBindings.Add("TEXT", bnContato, "email_contato");
                dtpDtCadastroContato.DataBindings.Add("TEXT", bnContato, "dtcadastro_contato");

                // carrega dados da cidade
                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());

                cbxCidadeContato.DataSource = dsCidade.Tables["Cidade"];

                //CAMPO QUE SERÁ MOSTRADO PARA O USUÁRIO

                cbxCidadeContato.DisplayMember = "nome_cidade";

                //CAMPO QUE É A CHAVE DA TABELA CIDADE E QUE LIGA COM A TABELA DE ALUNO

                cbxCidadeContato.ValueMember = "id_cidade";

                //No momento de linkar os componentes com o Binding Source linkar também o combox da cidade

                cbxCidadeContato.DataBindings.Add("SelectedValue", bnContato, "cidade_id_cidade"); // AJUSTAR DROPDOWNSTYLE PARA DropDownList PARA NAO DEIXAR

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (tbContato.SelectedIndex == 0)
            {
                tbContato.SelectTab(1);
            }

            bnContato.AddNew();
            txtNomeContato.Enabled = true;
            txtEndContato.Enabled = true;
            cbxCidadeContato.Enabled = true;
            cbxCidadeContato.SelectedIndex = 0;
            txtCelContato.Enabled = true;
            txtEmailContato.Enabled = true;
            dtpDtCadastroContato.Enabled = true;

            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            bInclusao = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // validar os dados
            if (txtNomeContato.Text == "")
            {
                MessageBox.Show("Nome inválido!");
            }
            else if (txtEndContato.Text == "")
            {
                MessageBox.Show("Endereço inválido!");
            }
            else if (cbxCidadeContato.SelectedIndex == -1)
            {
                MessageBox.Show("Cidade inválida!");
            }
            else if (txtCelContato.Text == "")
            {
                MessageBox.Show("Celular inválido!");
            }
            else if (txtEmailContato.Text == "")
            {
                MessageBox.Show("Celular inválido!");
            }
            else
            {
                Contato RegCon = new Contato();

                RegCon.Nomecontato = txtNomeContato.Text;
                RegCon.Endcontato = txtEndContato.Text;
                RegCon.Cidadeidcontato = Convert.ToInt32(cbxCidadeContato.SelectedValue.ToString());
                RegCon.Celcontato = txtCelContato.Text;
                RegCon.Emailcontato = txtEmailContato.Text;
                RegCon.Dtcadastrocontato = dtpDtCadastroContato.Value;

                if (bInclusao)
                {
                    if (RegCon.Salvar() > 0)
                    {
                        MessageBox.Show("Contato adicionado com sucesso!");

                        txtNomeContato.Enabled = false;
                        txtEndContato.Enabled = false;
                        cbxCidadeContato.Enabled = false;
                        txtCelContato.Enabled = false;
                        txtEmailContato.Enabled = false;
                        dtpDtCadastroContato.Enabled = false;

                        btnNovo.Enabled = true;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;

                        // recarrega o grid
                        dsContato.Tables.Clear();
                        dsContato.Tables.Add(RegCon.Listar());
                        bnContato.DataSource = dsContato.Tables["Contato"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar contato!");
                    }
                }
                else
                {
                    RegCon.Idcontato = Convert.ToInt32(txtIdContato.Text);

                    if (RegCon.Alterar() > 0)
                    {
                        MessageBox.Show("Contato alterado com sucesso!");

                        txtNomeContato.Enabled = false;
                        txtEndContato.Enabled = false;
                        cbxCidadeContato.Enabled = false;
                        txtCelContato.Enabled = false;
                        txtEmailContato.Enabled = false;
                        dtpDtCadastroContato.Enabled = false;

                        btnNovo.Enabled = true;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;

                        // recarrega o grid
                        dsContato.Tables.Clear();
                        dsContato.Tables.Add(RegCon.Listar());
                        bnContato.DataSource = dsContato.Tables["Contato"];

                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar contato!");
                    }

                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbContato.SelectedIndex == 0)
            {
                tbContato.SelectTab(1);
            }

            txtNomeContato.Enabled = true;
            txtEndContato.Enabled = true;
            cbxCidadeContato.Enabled = true;
            txtCelContato.Enabled = true;
            txtEmailContato.Enabled = true;
            dtpDtCadastroContato.Enabled = true;

            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            bInclusao = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbContato.SelectedIndex == 0)
            {
                tbContato.SelectTab(1);
            }


            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Contato RegCon = new Contato();
                RegCon.Idcontato = Convert.ToInt32(txtIdContato.Text);
                if (RegCon.Excluir() > 0)
                {
                    MessageBox.Show("Contato excluído com sucesso!");

                    // recarrega o grid
                    dsContato.Tables.Clear();
                    dsContato.Tables.Add(RegCon.Listar());
                    bnContato.DataSource = dsContato.Tables["Contato"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir contato!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnContato.CancelEdit();

            txtNomeContato.Enabled = false;
            txtEndContato.Enabled = false;
            cbxCidadeContato.Enabled = false;
            txtCelContato.Enabled = false;
            txtEmailContato.Enabled = false;
            dtpDtCadastroContato.Enabled = false;

            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;

            bInclusao = false;
        }
    }
}