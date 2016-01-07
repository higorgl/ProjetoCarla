using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projeto_carla.Entidades
{
    public class Compra : Entidade, IEntidade
    {
        public String data;
        public String fornecedor;
        public String nf;

        public bool cadastrar()
        {
            return this.bancoDeDados.executarComando("INSERT INTO `databasecarla`.`compras` (`codcomp`,`datacomp`,`fornecedorcomp`,`nfcomp`) VALUES (@cod,@data,@fornecedor,@nf);",
            new MySqlParameter("@cod", cod),
            new MySqlParameter("@data", data),
            new MySqlParameter("@fornecedor", fornecedor),
            new MySqlParameter("@nf", nf)
            );
        }

        public bool modificar()
        {
            return this.bancoDeDados.executarComando("UPDATE `databasecarla`.`compras` SET `datacomp` = @data,`fornecedorcomp` = @fornecedor,`nfcomp` = @nf WHERE `codcomp` = @cod;",
            new MySqlParameter("@cod",cod),
            new MySqlParameter("@data",data),
            new MySqlParameter("@fornecedor",fornecedor),
            new MySqlParameter("@nf",nf)
            );
        }

        public bool excluir()
        {
            return this.bancoDeDados.executarComando("DELETE FROM `databasecarla`.`compras` WHERE `codcomp` = @cod;", new MySqlParameter("@cod",cod));
        }
    }
}
