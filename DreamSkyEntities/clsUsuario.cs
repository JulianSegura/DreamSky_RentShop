using System;
using System.Collections.Generic;
using System.Text;

namespace DreamSkyEntities
{
    public class clsUsuario
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreCompleto { get => string.Format("{0} {1}", Nombres, Apellidos); }
        public string UserName { get; set; }
        public string Password { get; set; }
        //private int  rol { get; set; }
        public clsRol Rol { get; set; }
        public bool Activo { get; set; }
        public DateTime fechaCreacion { get; set; }

    }
}
