﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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

            SQL.Connection = conexao;
        }

        public bool executarComando(String SQL)
        {
            bool resultado;

            this.conexao.Open();
            this.SQL.CommandText = SQL;

            if (this.SQL.ExecuteNonQuery() > 0) resultado = true;
            else resultado = false;

            this.conexao.Close();
            return resultado;
        }
    }
}
