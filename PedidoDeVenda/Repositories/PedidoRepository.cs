using PedidoDeVenda.Entities;
using PedidoDeVenda.Entities.Exceptions;
using PedidoDeVenda.Repositories.Interfaces;

namespace PedidoDeVenda.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly List<Pedido> _pedidos;

        public PedidoRepository() {

            _pedidos = new List<Pedido>();
        }

        public void CriaPedido(Pedido pedido)
        {
            _pedidos.Add(pedido);
        }

        public void RemoverPedido(Pedido pedido)
        {
            _pedidos.Remove(pedido);
        }

        public List<Pedido> ListarTodos()
        {
            return _pedidos;
        }

        public Pedido BuscaPorId(int id)
        {
            var pedido = _pedidos.FirstOrDefault(x => x.Id == id);
            
            return pedido;
        }


    }
}
