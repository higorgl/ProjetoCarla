using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace projeto_carla
{
    public class BancoDeDados
    {
        private MySqlConnection conexao = new MySqlConnection();
        private MySqlConnectionStringBuilder stringConexao = new MySqlConnectionStringBuilder();
        private MySqlCommand SQL = new MySqlCommand();

        public BancoDeDados()
        {
            this.stringConexao.Database = "databasecarla";
            this.stringConexao.UserID = "root";
            this.stringConexao.Password = "1234";
            this.stringConexao.Server = "localhost";
            this.stringConexao.Port = 3307;

            this.conexao.ConnectionString = stringConexao.ConnectionString;
        }

        private void construirComandoSQL(String SQL, params MySqlParameter[] parametros)
        {
            this.SQL = new MySqlCommand();
            this.SQL.Connection = conexao;
            this.SQL.CommandText = SQL;
            foreach (MySqlParameter parametro in parametros)
            {
                this.SQL.Parameters.Add(parametro);
            }
        }

        public bool executarComando(String SQL, params MySqlParameter[] parametros)
        {
            bool resultado;

            this.conexao.Open();

            this.construirComandoSQL(SQL, parametros);

            if (this.SQL.ExecuteNonQuery() > 0) resultado = true;
            else resultado = false;

            this.conexao.Close();
            return resultado;
        }

        public Object consultarUnicoRegistro(String SQL, params MySqlParameter[] parametros)
        {
            Object resultado;

            this.conexao.Open();
            this.construirComandoSQL(SQL, parametros);

            resultado = this.SQL.ExecuteScalar();

            this.conexao.Close();
            return resultado;
        }

        public DataGridView preencherTabelaComConsulta(DataGridView tabela, String SQL, params MySqlParameter[] parametros)
        {
            MySqlDataReader leitorDeDados;
            DataTable tabelaVirtual = new DataTable();
                
            this.conexao.Open();

            this.construirComandoSQL(SQL,parametros);

            leitorDeDados = this.SQL.ExecuteReader();
            leitorDeDados.Read();

            tabela.DataSource = tabelaVirtual;

            leitorDeDados.Close();
            this.conexao.Close();
            return tabela;
        }
    }
}
