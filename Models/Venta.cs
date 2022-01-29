using System;
using System.Collections.Generic;

#nullable disable

namespace PetService.Models
{
    public partial class Venta
    {
        public int IdVenta { get; set; }
        public int IdPropietario { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Propietario IdVentaNavigation { get; set; }
        public virtual VentaDetalle VentaDetalle { get; set; }
    }
}
