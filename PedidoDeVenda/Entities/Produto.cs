using PedidoDeVenda.Entities.Exceptions;

namespace PedidoDeVenda.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; private set; }

        public decimal Preco { get; private set; }

        public Produto()
        {

        }

        public Produto(int id, string nome, int quantidade, decimal preco)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new DomainException("Nome não pode ser vazio.");
            }

            if (quantidade < 0)
            {
                throw new DomainException("Quantidade não pode ser menor que o.");
            }

            if (preco < 0)
            {
                throw new DomainException("Preço não pode ser negativo.");
            }

            Id = id;
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        public void AdicionaQuantidade(int quantidade)
        {
            if (quantidade < 0)
            {
                throw new DomainException("Não é possível adicionar quantidade negativa.");
            }

            Quantidade += quantidade;
        }

        public void RemoveQuantidade(int quantidade)
        {
            if (quantidade <= 0)
            {
                throw new DomainException("Quantidade para remover deve ser maior que 0.");
            }

            if (Quantidade < quantidade)
            {
                throw new DomainException("Saldo insuficiente.");
            }

            Quantidade -= quantidade;
            
        }

        public void AtualizaNomeProduto(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new DomainException("Nome não pode ser vazio.");
            }

            Nome = nome;
        }

        public void AlteraValorProduto(decimal preco)
        {
            if (preco < 0)
            {
                throw new DomainException("Preço não pode ser negativo.");
            }

            Preco = preco;
        }


    }
}
