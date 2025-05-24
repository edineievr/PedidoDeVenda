using PedidoDeVenda.Entities.Exceptions;
using PedidoDeVenda.Enums;

namespace PedidoDeVenda.Entities
{
    public class Pedido
    {

        public int Id { get; private set; }
        public List<PedidoItem> Itens { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public decimal ValorTotalItens { get; private set; }
        public StatusPedido Status { get; private set; }

        public Pedido(int id)
        {
            Id = id;
            Itens = new List<PedidoItem>();
            DataCriacao = DateTime.Now;
            Status = StatusPedido.Pendente;
        }

        public List<PedidoItem> ListarItens()
        {
            return Itens;
        }

        public PedidoItem BuscaPorId(int id)
        {
            var item = Itens.FirstOrDefault(x => x.Id == id);

            if (item == null)
            {
                throw new DomainException("Item não encontrado.");
            }

            return item;
        }

        public void AdicionaItem(PedidoItem item)
        {
            if (item == null)
            {
                throw new DomainException("Item não pode ser nulo.");
            }

            Itens.Add(item);
        }

        public void RemoveItem(int id)
        {
            var item = BuscaPorId(id);

            Itens.Remove(item);
        }

        public decimal CalculaTotalPedido()
        {
            decimal total = 0;

            foreach (PedidoItem item in Itens)
            {
                total += item.TotalItem();
            }

            return total;
        }

        public void CancelaPedido()
        {
            Status = StatusPedido.Cancelado;
        }

        public void FinalizaPedido()
        {
            Status = StatusPedido.Finalizado;
        }
    }
}
