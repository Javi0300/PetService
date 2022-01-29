using System;
using System.Collections.Generic;

#nullable disable

namespace PetService.Models
{
    public partial class Cita
    {
        public int IdCitas { get; set; }
        public int IdPropietario { get; set; }
        public int IdPerro { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }

        public virtual Perro IdPerroNavigation { get; set; }
        public virtual Propietario IdPropietarioNavigation { get; set; }
    }
}
