using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projeto_carla
{
    public class CarroECambio : Entidade, IEntidade
    {
        public String nome;
        public String placa;
        public String cor;
        public int ano;
        public String motor;
        public int codCli;

        private void adicionarParametros()
        {
            this.bancoDeDados.adicionarParametros(
                new MySqlParameter("@cod", cod),
                new MySqlParameter("@nome", nome),
                new MySqlParameter("@placa", placa),
                new MySqlParameter("@cor", cor),
                new MySqlParameter("@ano", ano),
                new MySqlParameter("@motor", motor),
                new MySqlParameter("@codCli", codCli));
        }

        public bool cadastrar()
        {
            this.adicionarParametros(); /* Isso precisa necessariamente estar aqui, pois se você fizer antes, corre o risco dos valores ainda não estarem preenchidos, deixando os registros vazios */
            return bancoDeDados.executarComando("INSERT INTO `databasecarla`.`carroecambio`(`codcec`,`nomecarro`,`placacarro`,`corcarro`,`anocarro`,`motorcarro`,`codclifk`) VALUES " +
            "(@cod,@nome,@placa,@cor,@ano,@motor,@codCli);");
        }

        public bool modificar()
        {
            this.adicionarParametros(); /* Isso precisa necessariamente estar aqui, pois se você fizer antes, corre o risco dos valores ainda não estarem preenchidos, deixando os registros vazios */
            return bancoDeDados.executarComando("UPDATE `databasecarla`.`carroecambio` SET `codcec` = @cod, `nomecarro` = '@nome', `placacarro` = '@placa', `corcarro` = '@cor', `anocarro` = '@ano', `motorcarro` = '@motor'"+
            "`codclifk` = @codcli WHERE `codcec` = @cod;");
        }

        public bool excluir()
        {
            this.adicionarParametros(); /* Isso precisa necessariamente estar aqui, pois se você fizer antes, corre o risco dos valores ainda não estarem preenchidos, deixando os registros vazios */
            return bancoDeDados.executarComando("DELETE FROM carroecambio WHERE codcec = "+cod);
        }
    }
}
