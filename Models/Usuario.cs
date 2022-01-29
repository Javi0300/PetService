using System;
using System.Collections.Generic;

#nullable disable

namespace PetService.Models
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public DateTime? Edad { get; set; }
        public string Sexo { get; set; }
        public string Usuario1 { get; set; }
        public string Contraseña { get; set; }
    }
}
