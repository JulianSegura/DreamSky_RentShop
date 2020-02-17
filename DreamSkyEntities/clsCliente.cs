using System;
using System.Collections.Generic;
using System.Text;

namespace DreamSkyEntities
{
    public  class clsCliente
    {
        public int Id { get;}
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
