using System;
using System.Collections.Generic;

#nullable disable

namespace PetService.Models
{
    public partial class VentaDetalle
    {
        public int IdVentaDetalle { get; set; }
        public int IdVenta { get; set; }
        public int? IdProducto { get; set; }
        public int? IdServicio { get; set; }
        public string Descripcion { get; set; }
        public int? Cantidad { get; set; }
        public double? Costo { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
        public virtual Servicio IdServicioNavigation { get; set; }
        public virtual Venta IdVentaNavigation { get; set; }
    }
}
