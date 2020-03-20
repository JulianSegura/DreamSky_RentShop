using System;
using System.Collections.Generic;

namespace DreamSkyEntities
{
    public class clsRenta
    {
        public int Id { get; set; }
        public string codigoContrato { get; set; }
        public DateTime fechaRenta { get; set; }
        public string idCliente { get; set; }
        public DateTime contratoDesde { get; set; }
        public DateTime contratoHasta { get; set; }
        public double Monto { get; set; }
        public double? Descuento { get; set; }
        public int? tipoNCF { get; set; }
        public string NCF { get; set; }
        public string RNCCliente { get; set; }
        public string Estado { get; set; }
        public List<clsRentaDetalle> items { get; set; }

        public clsRenta()
        {
            items = new List<clsRentaDetalle>();
        }
    }
}
