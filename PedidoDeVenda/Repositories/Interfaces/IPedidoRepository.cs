using PedidoDeVenda.Entities;

namespace PedidoDeVenda.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        void AdicionarItem(PedidoItem item);
        void RemoverItem(PedidoItem item);
        void CriarPedido(Pedido pedido);
        List<Pedido> ListarTodos();
        void RemoverPedido(Pedido pedido);
        Pedido BuscaPorId(int id);
    }
}
