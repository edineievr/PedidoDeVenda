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

        public void RemoverPedido(int id)
        {
            var p = _pedidos.BuscaPorId(id);

            if (p == null)
            {
                throw new DomainException("Pedido não encontrado");
            }

            _pedidos.RemoverPedido(id);
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

            var p = _pedidos.BuscaPorId(id);

            if (p == null)
            {
                throw new DomainException("Pedido não encontrado.");
            }

            p.AdicionaItem(item);
        }

        public void RemoverItem(int id, int idItem)
        {
            var p = BuscarPorId(id);

            if (p == null)
            {
                throw new DomainException("Pedido não encontrado.");
            }

            p.RemoveItem(idItem);
        }

    }
}

