using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionPizza.DTO.DTO
{
    public class CreaPizzaDTO
    {
        [Required(ErrorMessage = "Ingrese nombre del ingrediente")]
        public string? Nombre { get; set; }

        public bool PizzaPersonalizada { get; set; }        

        public decimal Precio { get; set; }
        public virtual List<IngreditePersonalizadaDTO>? DetalleIngredientes { get; set; } = new List<IngreditePersonalizadaDTO>();
    }
}
