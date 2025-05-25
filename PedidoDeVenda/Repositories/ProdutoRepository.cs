using PedidoDeVenda.Entities;
using PedidoDeVenda.Repositories.Interfaces;

namespace PedidoDeVenda.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly List<Produto> _produtos;

        public ProdutoRepository() {

            _produtos = new List<Produto>();
        }

        public List<Produto> ListarTodos()
        {
            return _produtos;
        }

        public void CriarProduto(Produto produto)
        {
            _produtos.Add(produto);
        }

        public Produto BuscaPorId(int id)
        {
            var produto = _produtos.FirstOrDefault(x => x.Id == id);

            return produto;
        }

        public void RemoverProduto(Produto produto)
        {
            _produtos.Remove(produto);
        }




    }
}
