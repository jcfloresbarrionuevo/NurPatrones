using Microsoft.AspNetCore.Mvc;
using SolucionPizza.DTO.Common;
using SolucionPizza.DTO.DTO;
using SolucionPizza.Services.Interfaces;

namespace SolucionPizza.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedido _pedido;

        public PedidoController(IPedido pedido) 
        {
            _pedido = pedido;
        }

        [HttpPost("CrearPedido")]
        public async Task<IActionResult> CrearPedido([FromBody] CreaPedidoDTO modelo) 
        {
            var response= new ResponseDTO<PedidoDTO>();
            try
            {
                response.EsCorrecto = true;
                response.Resutado = await _pedido.CrearPedido(modelo);
                response.Mensaje = Resources.Resources.MensajeInsert;
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }

            return Ok(response);
        }
    }
}
