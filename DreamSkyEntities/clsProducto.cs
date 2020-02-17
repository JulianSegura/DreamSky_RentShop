using System;
using System.Collections.Generic;
using System.Text;

namespace DreamSkyEntities
{
    public class clsProducto
    {
        public int Id { get;}
        public string codigoProducto { get; set; }
        public string Descripcion { get; set; }
        public int CategoriaProducto { get; set; }
        public double costoAlquiler { get; set; }
        public DateTime fechaCreacion { get; set; }
        public bool Activo { get; set; }
    }
}
