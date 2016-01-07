using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projeto_carla
{
    public class OrcamentosEEstoque : Entidade, IEntidade
    {
        public int codOrcamento;
        public int codProduto;

        public bool cadastrar()
        {
            return this.bancoDeDados.executarComando("INSERT INTO `databasecarla`.`orcamentoeoseestoque`(`codoose`,`codorcamentofk`,`codprodfk`) VALUES (@cod,@codOrcamento,@codProduto);",
                new MySqlParameter("@cod", cod),
                new MySqlParameter("@codOrcamento", codOrcamento),
                new MySqlParameter("@codProduto",codProduto)
                );
        }

        public bool modificar()
        {
            return this.bancoDeDados.executarComando("UPDATE `databasecarla`.`orcamentoeoseestoque` SET `codorcamentofk` = @codOrcamento,`codprodfk` = @codProduto WHERE `codoose` = @cod;", 
                new MySqlParameter("@cod", cod),
                new MySqlParameter("@codOrcamento", codOrcamento),
                new MySqlParameter("@codProduto", codProduto)
                );
        }

        public bool excluir()
        {
            return this.bancoDeDados.executarComando("DELETE FROM `databasecarla`.`orcamentoeoseestoque` WHERE <{where_expression}>;", new MySqlParameter("@cod",cod));
        }
    }
}
