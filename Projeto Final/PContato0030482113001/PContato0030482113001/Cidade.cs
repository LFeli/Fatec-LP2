using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PContato0030482113001
{
    class Cidade
    {
        private int idCidade;
        private string nomeCidade;
        private string ufCidade;

        //propriedades

        public int Idcidade
        {
            get
            {
                return idCidade;
            }

            set
            {
                idCidade = value;
            }
        }

        public string Nomecidade
        {
            get
            {
                return nomeCidade;
            }

            set
            {
                nomeCidade = value;
            }
        }

        public string Ufcidade
        {
            get
            {
                return ufCidade;
            }

            set
            {
                ufCidade = value;
            }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daCidade;

            DataTable dtCidade = new DataTable();

            try
            {
                daCidade = new SqlDataAdapter("SELECT * FROM CIDADE", frmPrincipal.conexao);
                daCidade.Fill(dtCidade);
                daCidade.FillSchema(dtCidade, SchemaType.Source);
            }

            catch (Exception)
            {
                throw;
            }
            return dtCidade;
        }



    }
}
