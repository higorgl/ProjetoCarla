using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projeto_carla
{
    public class Orcamentos : Entidade, IEntidade
    {
        public String quilometragem;
        public String dataOrcamento;
        public String dataOs;
        public String aprovacao;
        public String previsaoEntrega;

        public bool cadastrar()
        {
            return this.bancoDeDados.executarComando("INSERT INTO `databasecarla`.`orcamentoeos`(`codorcamento`,`quilometragem`,`dataorcamento`,`aprovacaoorcamento`,`dataos`,`previsaodatadeentrega`) VALUES "+
            "(@cod,@quilometragem,@dataOrcamento,@aprovacao,@dataOs,@previsaoEntrega;",
            new MySqlParameter("@cod",cod),
            new MySqlParameter("@quilometragem",quilometragem),
            new MySqlParameter("@dataOrcamento",dataOrcamento),
            new MySqlParameter("@aprovacao",aprovacao),
            new MySqlParameter("@dataOs",dataOs),
            new MySqlParameter("@previsaoEntrega",previsaoEntrega)
            );
        }

        public bool modificar()
        {
            return this.bancoDeDados.executarComando("UPDATE `databasecarla`.`orcamentoeos` SET `quilometragem` = @quilometragem,`dataorcamento` = @dataOrcamento,`aprovacaoorcamento` = @aprovacao,`dataos` = @dataos,"+
            "`previsaodatadeentrega` = @previsaodatadeentrega WHERE `codorcamento` = @cod;",
            new MySqlParameter("@cod", cod),
            new MySqlParameter("@quilometragem", quilometragem),
            new MySqlParameter("@dataOrcamento", dataOrcamento),
            new MySqlParameter("@aprovacao", aprovacao),
            new MySqlParameter("@dataOs", dataOs),
            new MySqlParameter("@previsaoEntrega", previsaoEntrega)
            );
        }

        public bool excluir()
        {
            return this.bancoDeDados.executarComando("DELETE FROM `databasecarla`.`orcamentoeos` WHERE <{where_expression}>;", new MySqlParameter("@cod",cod));
        }
    }
}
