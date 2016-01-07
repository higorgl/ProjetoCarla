using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projeto_carla
{
    public class CompraEProduto : Entidade, IEntidade
    {
        public int codProduto;
        public int codCompra;
        public int quantidade;
        public float desconto;

        public bool cadastrar()
        {
            return this.bancoDeDados.executarComando("INSERT INTO `databasecarla`.`compraeproduto`(`codcompeprod`,`codprodfk`,`codcompfk`,`quantidade`,`desconto`) VALUES (@cod,@codProduto,@codCompra,@quantidade,@desconto",
            new MySqlParameter("@cod",cod),
            new MySqlParameter("@codProduto",codProduto),
            new MySqlParameter("@codCompra",codCompra),
            new MySqlParameter("@quantidade",quantidade),
            new MySqlParameter("@desconto",desconto)
            );
        }

        public bool modificar()
        {
            return this.bancoDeDados.executarComando("UPDATE `databasecarla`.`compraeproduto` SET `codcompeprod` = @cod,`codprodfk` = @codProduto,`codcompfk` = @codCompra,`quantidade` = @quantidade,"+
            "`desconto` = @desconto WHERE `codcompeprod` = @cod;",
            new MySqlParameter("@cod",cod),
            new MySqlParameter("@codProduto",codProduto),
            new MySqlParameter("@codCompra",codCompra),
            new MySqlParameter("@quantidade",quantidade),
            new MySqlParameter("@desconto",desconto)
            );
        }

        public bool excluir()
        {
            return this.bancoDeDados.executarComando("DELETE FROM `databasecarla`.`compraeproduto` WHERE `codcompeprod` = @cod;", new MySqlParameter("@cod",cod));
        }
    }
}
