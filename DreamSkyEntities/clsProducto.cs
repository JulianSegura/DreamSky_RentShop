using System;
using System.Collections.Generic;
using System.Text;

namespace DreamSkyEntities
{
    public class clsProducto
    {
        public int Id { get; set; }
        public string codigoProducto { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public int CategoriaProducto { get; set; }
        public double costoAlquiler { get; set; }
        public bool Activo { get; set; }
    }
}
