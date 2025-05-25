using PedidoDeVenda.Repositories.Interfaces;
using PedidoDeVenda.Entities;
using PedidoDeVenda.Entities.Exceptions;

namespace PedidoDeVenda.Services
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void CriarProduto(Produto produto)
        {
            if(produto == null)
            {
                throw new DomainException("Produto não pode ser nulo.");
            }

            _produtoRepository.CriarProduto(produto);
        }

        public void RemoveProduto(Produto produto)
        {
            if (produto == null)
            {
                throw new DomainException("Produto não pode ser nulo.");
            }

            _produtoRepository.RemoverProduto(produto);
        }

        public List<Produto> ListarTodos()
        {
            return _produtoRepository.ListarTodos();
        }

        public Produto BuscaPorId(int id)
        {
            var p = _produtoRepository.BuscaPorId(id);

            if (p == null)
            {
                throw new DomainException("Produto não encontrado.");
            }

            return p;
        }


    }
}
