using System;
using System.Collections.Generic;

#nullable disable

namespace PetService.Models
{
    public partial class Servicio
    {
        public Servicio()
        {
            VentaDetalles = new HashSet<VentaDetalle>();
        }

        public int IdServicio { get; set; }
        public string NombreServicio { get; set; }

        public virtual ICollection<VentaDetalle> VentaDetalles { get; set; }
    }
}
