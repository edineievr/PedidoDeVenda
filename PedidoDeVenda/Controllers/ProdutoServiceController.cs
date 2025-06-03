using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PedidoDeVenda.Services;
using PedidoDeVenda.Entities;
using PedidoDeVenda.Repositories;
using PedidoDeVenda.Services.Interfaces;
using PedidoDeVenda.Entities.Exceptions;

namespace PedidoDeVenda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoServiceController : ControllerBase
    {
        private readonly IProdutoService _produtos;

        public ProdutoServiceController(IProdutoService pedidoService)
        {
            _produtos = pedidoService;            
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> ListarTodos()
        {
            var produtos = _produtos.ListarTodos();

            if (produtos == null)
            {
                return NoContent();
            }

            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            var produto = _produtos.BuscaPorId(id);

            if (produto == null)
            {
                return NoContent();
            }

            return Ok(produto);
        }


    }
}
