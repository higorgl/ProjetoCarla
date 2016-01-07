using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projeto_carla
{
    public class Usuario : Entidade, IEntidade
    {
        public String tipo;
        public String nome;
        public String login;
        public String senha;
        public String perguntaSecreta;
        public String respostaSecreta;

        public bool cadastrar()
        {
            this.login = Criptografia.getMD5Hash(this.login);
            this.senha = Criptografia.getMD5Hash(this.senha);
            return this.bancoDeDados.executarComando("INSERT INTO `databasecarla`.`usuario`(`tipousuario`,`nomeusuario`,`loginusuario`,`senhausuario`,`perguntasecreta`,`respostasecreta`) "+
                "VALUES (@tipo,@nome,@login,@senha,@pergunta,@resposta);",
                new MySqlParameter("@tipo",tipo),
                new MySqlParameter("@nome",nome),
                new MySqlParameter("@login",login),
                new MySqlParameter("@senha",senha),
                new MySqlParameter("@pergunta",perguntaSecreta),
                new MySqlParameter("@resposta",respostaSecreta)
                );
        }

        public bool modificar()
        {
            this.login = Criptografia.getMD5Hash(this.login);
            this.senha = Criptografia.getMD5Hash(this.senha);
            return this.bancoDeDados.executarComando("UPDATE `databasecarla`.`usuario` SET `tipousuario` = @tipo,`nomeusuario` = @nome,`loginusuario` = @login,`senhausuario` = @senha,`perguntasecreta` = @pergunta"+
                ",`respostasecreta` = @resposta WHERE `codusuario` = @cod;",
                new MySqlParameter("@cod",cod),
                new MySqlParameter("@tipo",tipo),
                new MySqlParameter("@nome",nome),
                new MySqlParameter("@login",login),
                new MySqlParameter("@senha",senha),
                new MySqlParameter("@perguntaSecreta",perguntaSecreta),
                new MySqlParameter("@respostaSecreta",respostaSecreta)
            );
        }

        public bool excluir()
        {
            return this.bancoDeDados.executarComando("DELETE FROM `databasecarla`.`usuario` WHERE `codusuario` = @cod;", new MySqlParameter("@cod", cod));
        }
    }
}
