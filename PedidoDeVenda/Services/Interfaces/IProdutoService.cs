﻿using PedidoDeVenda.Entities;

namespace PedidoDeVenda.Services.Interfaces
{
    public interface IProdutoService
    {
        void CriarProduto(Produto produto);
        void RemoverProduto(int id);
        List<Produto> ListarTodos();
        Produto BuscaPorId(int id);
        void AtualizaPrecoProduto(int id, decimal precoAlterado);
        void AtualizaNomeProduto(int id, string nome);
    }
}
