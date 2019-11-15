using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Entidades.Enums
{
    enum StatusPedidos : int
    {
        Pagamento_Pendente = 0,
        Processando = 1,
        Enviado = 2,
        Entregue = 3

    }
}
