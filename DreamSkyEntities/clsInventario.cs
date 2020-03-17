using System;
using System.Collections.Generic;
using System.Text;

namespace DreamSkyEntities
{
    public class clsInventario
    {
        public int Id { get;}
        public string CodigoProducto { get; set; }
        public int Disponible { get; set; }
        public clsProducto Producto { get; set; }
        public clsCategoriaProducto CategoriaProducto { get; set; }
    }
}
