
namespace XulambsFoods
{
    [Serializable]
    public class PedidoCheioException : InvalidOperationException
    {
        private PedidoEntrega _pedido;
        public PedidoCheioException(PedidoEntrega pedido): 
            base("Pedido cheio.")
        {
            _pedido = pedido;
        }

        public void FecharPedido()
        {
            _pedido.FecharPedido();
        }

        
    }
}