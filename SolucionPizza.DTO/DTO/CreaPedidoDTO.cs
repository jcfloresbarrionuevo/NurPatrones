using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionPizza.DTO.DTO
{
    public class CreaPedidoDTO
    {
        public string? NombreCliente { get; set; }

        public virtual List<DetallePizzasPedido>? DetallePizzas { get; set; } = new List<DetallePizzasPedido>();
    }
}
