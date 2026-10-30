using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    public class PedidoFechadoException : InvalidOperationException
    {
        public PedidoFechadoException():
            base("Pedido fechado. Não pode ser alterado.")
        {

        }
    }
}
