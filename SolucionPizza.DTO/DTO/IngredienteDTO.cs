using System.ComponentModel.DataAnnotations;

namespace SolucionPizza.DTO.DTO
{
    public class IngredienteDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Ingrese nombre del ingrediente")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese el precio")]
        public decimal Precio { get; set; }
    }
}
