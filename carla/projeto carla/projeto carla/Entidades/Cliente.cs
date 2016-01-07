using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projeto_carla
{
    public class Cliente : Entidade, IEntidade
    {
        public String nome;
        public String cpf;
        public String tel1;
        public String tel2;
        public String tel3;
        public String tel4;
        public String uf;
        public String cidade;
        public String bairro;
        public String logradouro;
        public String endereco;
        public String numero;
        public String complemento;
        public String cep;
        public String email;
        public String dataCriacao;

        public void preencherDataCriacaoComDataDeHoje()
        {
            this.dataCriacao = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
        }

        public bool cadastrar()
        {
            return this.bancoDeDados.executarComando("INSERT INTO `databasecarla`.`clientes`(`codcli`,`nomecli`,`cpfcli`,`tel1cli`,"+
                "`tel2cli`,`tel3cli`,`tel4cli`,`ufcli`,`cidadecli`,`bairrocli`,`tipodelogradourocli`,`enderecocli`,`numerocli`,"+
                "`complementocli`,`cepcli`,`emailcli`,`datacriacaocli`)VALUES(@cod,@nome,@cpf,@tel1,@tel2,@tel3,@tel4,@uf,@cidade,@bairro,@logradouro,@endereco,@numero,@complemento,@cep,@email,@dataCriacao);",
                new MySqlParameter("@cod", cod),
                new MySqlParameter("@nome", nome),
                new MySqlParameter("@cpf", cpf),
                new MySqlParameter("@tel1", tel1),
                new MySqlParameter("@tel2", tel2),
                new MySqlParameter("@tel3", tel3),
                new MySqlParameter("@tel4", tel4),
                new MySqlParameter("@uf", uf),
                new MySqlParameter("@cidade", cidade),
                new MySqlParameter("@bairro", bairro),
                new MySqlParameter("@logradouro", logradouro),
                new MySqlParameter("@endereco", endereco),
                new MySqlParameter("@numero", numero),
                new MySqlParameter("@complemento", complemento),
                new MySqlParameter("@cep", cep),
                new MySqlParameter("@email", email),
                new MySqlParameter("@dataCriacao", dataCriacao));
        }

        public bool modificar()
        {
            return this.bancoDeDados.executarComando("UPDATE `databasecarla`.`clientes` SET `nomecli` = @nome,`cpfcli` = @cpf,`tel1cli` = @tel1,`tel2cli` = @tel2,`tel3cli` = @tel3,`tel4cli` = @tel4,`ufcli` = @uf,"+
            "`cidadecli` = @cidade,`bairrocli` = @bairro,`tipodelogradourocli` = @logradouro,`enderecocli` = @endereco,`numerocli` = @numero,`complementocli` = @complemento,`cepcli` = @cep,`emailcli` = @email,"+
            "`datacriacaocli` = @dataCriacao WHERE `codcli` = @cod;",
                new MySqlParameter("@cod", cod),
                new MySqlParameter("@nome", nome),
                new MySqlParameter("@cpf", cpf),
                new MySqlParameter("@tel1", tel1),
                new MySqlParameter("@tel2", tel2),
                new MySqlParameter("@tel3", tel3),
                new MySqlParameter("@tel4", tel4),
                new MySqlParameter("@uf", uf),
                new MySqlParameter("@cidade", cidade),
                new MySqlParameter("@bairro", bairro),
                new MySqlParameter("@logradouro", logradouro),
                new MySqlParameter("@endereco", endereco),
                new MySqlParameter("@numero", numero),
                new MySqlParameter("@complemento", complemento),
                new MySqlParameter("@cep", cep),
                new MySqlParameter("@email", email),
                new MySqlParameter("@dataCriacao", dataCriacao));
        }

        public bool excluir()
        {
            return this.bancoDeDados.executarComando("DELETE FROM clientes WHERE codcli = @cod", new MySqlParameter("@cod", cod));
        }
    }
}

