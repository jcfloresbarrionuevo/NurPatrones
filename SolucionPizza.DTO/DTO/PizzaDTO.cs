using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionPizza.DTO.DTO
{
    public class PizzaDTO
    {
        public int ID { get; set; }
        public string? Nombre { get; set; }
        public bool PizzaPersonalizada { get; set; }
        public decimal Precio { get; set; }
    }
}
