using System;
using System.Collections.Generic;

#nullable disable

namespace PetService.Models
{
    public partial class Perro
    {
        public Perro()
        {
            Cita = new HashSet<Cita>();
        }

        public int IdPerro { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? IdPropietario { get; set; }

        public virtual Propietario IdPerroNavigation { get; set; }
        public virtual ICollection<Cita> Cita { get; set; }
    }
}
