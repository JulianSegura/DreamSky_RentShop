using System;
using System.Collections.Generic;
using System.Text;

namespace DreamSkyEntities
{
    public  class clsCliente
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public string Nacionalidad { get; set; }
        public string Correo { get; set; }
    }
}
