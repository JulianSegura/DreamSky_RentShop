using System;
using System.Collections.Generic;
using System.Text;

namespace DreamSkyEntities
{
    public class clsRentaDetalle
    {
        public int Id { get; }
        public int idRenta { get; set; }
        public int idProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
