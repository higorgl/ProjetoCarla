using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projeto_carla
{
    public class ProdutoEstoque : Entidade, IEntidade
    {
        public String descricaoProduto;
        public int quantidadeEstoque;
        public float valorCompra;
        public float porcentagemLucro;
        public float valorVenda;
        public String ncm;
        public int quantidadeMinimaEstoque;

        public float calcularPorcentagemDeLucro()
        {
            return (valorVenda - valorCompra) * 100 / valorCompra;
        }

        public bool cadastrar()
        {
            return this.bancoDeDados.executarComando("INSERT INTO `databasecarla`.`produtoestoque`(`codprod`,`descricaoprod`,`quantidadeestoque`,`valorcompra`,`porcentagemlucro`,`valorvenda`,`ncm`,`quantidadeMinimaNoEstoque`)"+
            "VALUES (@cod,@descricaoProduto,@quantidadeEstoque,@valorCompra,@porcentagemLucro,@valorVenda,@ncm,@quantidadeMinimaEstoque);",
                new MySqlParameter("@cod", cod),
                new MySqlParameter("@descricaoProduto", descricaoProduto),
                new MySqlParameter("@quantidadeEstoque", quantidadeEstoque),
                new MySqlParameter("@valorCompra", valorCompra),
                new MySqlParameter("@porcentagemLucro", porcentagemLucro),
                new MySqlParameter("@valorVenda", valorVenda),
                new MySqlParameter("@ncm", ncm),
                new MySqlParameter("@quantidadeMinimaEstoque", quantidadeMinimaEstoque)
            );
        }

        public bool modificar()
        {
            return this.bancoDeDados.executarComando("UPDATE `databasecarla`.`produtoestoque`SET` `descricaoprod` = @descricaoProduto,`quantidadeestoque` = @quantidadeEstoque,`valorcompra` = @valorCompra,"+
            "`porcentagemlucro` = @porcentagemLucro,`valorvenda` = @valorVenda,`ncm` = @ncm,`quantidadeMinimaNoEstoque` = @quantidadeMinimaEstoque WHERE `codprod` = @cod;",
                new MySqlParameter("@cod", cod),
                new MySqlParameter("@descricaoProduto", descricaoProduto),
                new MySqlParameter("@quantidadeEstoque", quantidadeEstoque),
                new MySqlParameter("@valorCompra", valorCompra),
                new MySqlParameter("@porcentagemLucro", porcentagemLucro),
                new MySqlParameter("@valorVenda", valorVenda),
                new MySqlParameter("@ncm", ncm),
                new MySqlParameter("@quantidadeMinimaEstoque", quantidadeMinimaEstoque)
            );
        }

        public bool excluir()
        {
            return this.bancoDeDados.executarComando("DELETE FROM `databasecarla`.`produtoestoque` WHERE `codprod` = @cod;",
                new MySqlParameter("@cod", cod)
            );
        }
    }
}
