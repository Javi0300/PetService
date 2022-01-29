using System;
using System.Collections.Generic;

#nullable disable

namespace PetService.Models
{
    public partial class Municipio
    {
        public int IdMunicipio { get; set; }
        public string NombreMunicipio { get; set; }

        public virtual Propietario Propietario { get; set; }
    }
}
