using PedidoDeVenda.Entities;

namespace PedidoDeVenda.Repositories.Interfaces
{
    public interface IProdutoRepository 
    {
        void AdicionarProduto(Produto produto);
        void RemoverProduto(Produto produto);
        Produto BuscaPorId(int id);
        List<Produto> ListarTodos();
    }
}
