using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_carla
{
    public interface IEntidade
    {
        bool cadastrar();
        bool modificar();
        bool excluir();
    }
}
