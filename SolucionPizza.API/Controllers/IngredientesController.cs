using Microsoft.AspNetCore.Mvc;
using SolucionPizza.DTO.Common;
using SolucionPizza.DTO.DTO;
using SolucionPizza.Services.Interfaces;

namespace SolucionPizza.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientesController : ControllerBase
    {
        private readonly IIngredienteServicio _ingredientes;

        public IngredientesController(IIngredienteServicio ingredientes)
        {
            _ingredientes = ingredientes;
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert([FromBody] IngredienteDTO modelo)
        {
            var response = new ResponseDTO<IngredienteDTO>();
            try
            {
                response.EsCorrecto = true;
                response.Resutado = await _ingredientes.Insert(modelo);
                response.Mensaje = Resources.Resources.MensajeInsert;
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }

            return Ok(response);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] IngredienteDTO modelo)
        {
            var response = new ResponseDTO<bool>();

            try
            {
                response.EsCorrecto = true;
                response.Resutado = await _ingredientes.Update(modelo);
                response.Mensaje = Resources.Resources.MensajeUpdate;
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }

            return Ok(response);
        }

        [HttpDelete("Delete/{Id:int}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var response = new ResponseDTO<bool>();

            try
            {
                response.EsCorrecto = true;
                response.Resutado = await _ingredientes.Delete(Id);
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }

            return Ok(response);
        }

        [HttpGet("Obtener/{Id:int}")]
        public async Task<IActionResult> Obtener(int Id)
        {
            var response = new ResponseDTO<IngredienteDTO>();

            try
            {
                response.EsCorrecto = true;
                response.Resutado = await _ingredientes.Obtener(Id);
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }

            return Ok(response);
        }

        [HttpGet("Lista")]
        public async Task<IActionResult> Lista()
        {
            var response = new ResponseDTO<List<IngredienteDTO>>();

            try
            {
                response.EsCorrecto = true;
                response.Resutado = await _ingredientes.Lista();
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
