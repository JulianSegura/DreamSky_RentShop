using System.Collections.Generic;

namespace DreamSkyEntities
{
    public class clsRol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int limiteEmpleados { get; set; }
        public int limiteEnDemanda { get; set; }
        public bool Activo { get; set; }
        public List<clsPermiso> Permisos { get; set; }

    }
}
