using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PedidoDeVenda.Services;

namespace PedidoDeVenda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoServiceController : ControllerBase
    {
        private readonly PedidoService _pedidoService;

        public ProdutoServiceController(PedidoService pedidoService)
        {
            _pedidoService = pedidoService;            
        }


    }
}
