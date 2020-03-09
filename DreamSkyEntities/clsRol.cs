using System;
using System.Collections.Generic;
using System.Text;

namespace DreamSkyEntities
{
    public class clsRol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        private int limiteEmpleados { get; set; }
        private int limiteEnDemanda { get; set; }
        public bool Activo { get; set; }
        public List<clsPermiso> Permisos { get; set; }

    }
}
