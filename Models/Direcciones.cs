using System;
using System.Collections.Generic;

#nullable disable

namespace PetService.Models
{
    public partial class Direcciones
    {
        public int IdDireccion { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string CodigoPostal { get; set; }
        public string Ciudad { get; set; }
        public int? IdPropietario { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Propietario IdPropietarioNavigation { get; set; }
    }
}
