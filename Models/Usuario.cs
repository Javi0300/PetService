using System;
using System.Collections.Generic;

#nullable disable

namespace PetService.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Propietarios = new HashSet<Propietario>();
        }

        public int IdUsuario { get; set; }
        public string Correo { get; set; }
        public string FotoUsuario { get; set; }
        public string Usuario1 { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual ICollection<Propietario> Propietarios { get; set; }
    }
}
