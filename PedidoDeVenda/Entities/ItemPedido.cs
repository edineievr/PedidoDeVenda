using PedidoDeVenda.Entities.Exceptions;

namespace PedidoDeVenda.Entities
{
    public class PedidoItem
    {

        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int ItemQuantidade { get; set; } 

        public PedidoItem(Produto produto, int itemQuantidade)
        {
            if (produto == null)
            {
                throw new DomainException("Produto não pode ser nulo.");
            }

            if (itemQuantidade <= 0)
            {
                throw new DomainException("Quantidade deve ser maior que 0.");
            }
            
            Produto = produto;
            ItemQuantidade = itemQuantidade;
        }

        public decimal TotalItem()
        {          

            decimal total = ItemQuantidade * Produto.Preco;

            return total;
        }




    }
}
