using System;
using System.Collections.Generic;

#nullable disable

namespace PetService.Models
{
    public partial class Venta
    {
        public Venta()
        {
            VentaDetalles = new HashSet<VentaDetalle>();
        }

        public int IdVenta { get; set; }
        public int IdPropietario { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Propietario IdVentaNavigation { get; set; }
        public virtual ICollection<VentaDetalle> VentaDetalles { get; set; }
    }
}
