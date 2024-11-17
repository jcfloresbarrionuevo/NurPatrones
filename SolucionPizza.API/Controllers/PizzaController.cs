using Microsoft.AspNetCore.Mvc;
using SolucionPizza.DTO.Common;
using SolucionPizza.DTO.DTO;
using SolucionPizza.Models.Entities;
using SolucionPizza.Services.Interfaces;

namespace SolucionPizza.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaFactory _pizzaFactory;

        public PizzaController(IPizzaFactory pizzaFactory)
        {
            _pizzaFactory = pizzaFactory;
        }

        [HttpPost("CrearPizza")]
        public async Task<IActionResult> CrearPizza([FromBody] CreaPizzaDTO modelo)
        {
            var response = new ResponseDTO<CreaPizzaDTO>();
            try
            {
                response.EsCorrecto = true;
                response.Resutado = await _pizzaFactory.CrearPizzaFactory(modelo);
                response.Mensaje = Resources.Resources.MensajeInsert;
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }

            return Ok(response);
        }

        [HttpGet("ListaPizzas")]
        public async Task<IActionResult> ListaPizzas()
        {
            var response = new ResponseDTO<List<PizzaDTO>>();

            try
            {
                response.EsCorrecto = true;
                response.Resutado = await _pizzaFactory.Lista();
                response.Resutado = response.Resutado.Where(x =>x.PizzaPersonalizada==false).ToList();
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
