using System;
using System.Collections.Generic;
using System.Text;

namespace DreamSkyEntities
{
    public class clsUsuario
    {
        public int Id { get; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int  Rol { get; set; }
        public bool Activo { get; set; }
        public DateTime fechaCreacion { get; set; }

    }
}
