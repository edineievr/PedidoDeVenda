using PedidoDeVenda.Entities;
using PedidoDeVenda.Entities.Exceptions;
using PedidoDeVenda.Repositories.Interfaces;

namespace PedidoDeVenda.Services
{
    public class PedidoService
    {
        private readonly IPedidoRepository _pedidos;

        public PedidoService(IPedidoRepository repository)
        {
            _pedidos = repository;
        }

        public void CriarPedido(Pedido pedido)
        {
            if (pedido == null)
            {
                throw new DomainException("Pedido não pode ser nulo");
            }

            _pedidos.CriarPedido(pedido);
        }

        public void RemoverPedido(int id, Pedido pedido)
        {
            if (pedido == null)
            {
                throw new DomainException("Pedido não pode ser nulo");
            }

            _pedidos.RemoverPedido(pedido);
        }

        public Pedido BuscarPorId(int id)
        {
            var p = _pedidos.BuscaPorId(id);

            if (p == null)
            {
                throw new DomainException("Pedido não encontrado.");
            }

            return p;
        }

        public void AdicionarItem(int id, ItemPedido item)
        {
            
            if (item == null)
            {
                throw new DomainException("Item não pode ser nulo.");
            }

            _pedidos.AdicionarItem();
        }

        public void RemoverItem(int id, ItemPedido item)
        {
            if (item == null)
            {
                throw new DomainException("Item não pode ser nulo.");
            }

            _pedidos.RemoverItem(item);
        }

    }
}

