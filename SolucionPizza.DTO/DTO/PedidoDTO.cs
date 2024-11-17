using System.ComponentModel.DataAnnotations;

namespace SolucionPizza.DTO.DTO
{
    public class PedidoDTO
    {
        public int ID { get; set; }        
        public string? NombreCliente { get; set; }
        [Required(ErrorMessage = "Ingrese la fecha del pedido")]
        public DateTime FechaPedido { get; set; }
        public decimal TotalPedido { get; set; }
        public bool IncluyeDelivery { get; set; }
        public decimal MontoDelivery { get; set; } = 0;
        public virtual List<PizzaDTO>? DetallePizzas { get; set; } = new List<PizzaDTO>();
    }
}
