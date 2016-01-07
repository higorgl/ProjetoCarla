using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projeto_carla
{
    public abstract class Entidade
    {
        protected BancoDeDados bancoDeDados = new BancoDeDados();
        public int cod;
    }
}
