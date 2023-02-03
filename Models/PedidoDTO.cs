using Microsoft.AspNetCore.Mvc;

namespace Repository_Pattern.Models
{
    public class PedidoDTO
    {
        public int Id { get; set; }
        public string Pedido { get; set; }
        public ClienteDTO ClienteId { get; set; }

    }
}
