using System;
using System.Collections.Generic;

#nullable disable

namespace PetService.Models
{
    public partial class Propietario
    {
        public Propietario()
        {
            Cita = new HashSet<Cita>();
            Direcciones = new HashSet<Direcciones>();
        }

        public int IdPropietario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string IdUsuario { get; set; }
        public int IdMunicipio { get; set; }

        public virtual Municipio IdPropietarioNavigation { get; set; }
        public virtual Perro Perro { get; set; }
        public virtual Venta Venta { get; set; }
        public virtual ICollection<Cita> Cita { get; set; }
        public virtual ICollection<Direcciones> Direcciones { get; set; }
    }
}
