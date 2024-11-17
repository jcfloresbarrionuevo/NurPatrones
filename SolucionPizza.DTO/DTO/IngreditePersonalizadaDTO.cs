using System.ComponentModel.DataAnnotations;

namespace SolucionPizza.DTO.DTO
{
    public class IngreditePersonalizadaDTO
    {
        [Required(ErrorMessage = "Ingrese nombre del ingrediente")]
        public string? Nombre { get; set; }
    }
}
