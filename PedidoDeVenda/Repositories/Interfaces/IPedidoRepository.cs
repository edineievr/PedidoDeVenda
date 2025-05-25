using PedidoDeVenda.Entities;

namespace PedidoDeVenda.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        void CriaPedido(Pedido pedido);
        List<Pedido> ListarTodos();
        void RemoverPedido(Pedido pedido);
        Pedido BuscaPorId(int id);
    }
}
