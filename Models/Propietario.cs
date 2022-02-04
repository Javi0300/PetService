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
            Direcciones = new HashSet<Direccione>();
            Perros = new HashSet<Perro>();
        }

        public int IdPropietario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public int IdMunicipio { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual Venta Venta { get; set; }
        public virtual ICollection<Cita> Cita { get; set; }
        public virtual ICollection<Direccione> Direcciones { get; set; }
        public virtual ICollection<Perro> Perros { get; set; }
    }
}
