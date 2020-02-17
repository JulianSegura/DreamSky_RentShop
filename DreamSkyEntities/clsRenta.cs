using System;
using System.Collections.Generic;
using System.Text;

namespace DreamSkyEntities
{
    public class clsRenta
    {
        public int Id { get;}
        public string codigoContrato { get; set; }
        public DateTime fechaRenta { get; set; }
        public int  idCliente { get; set; }
        public DateTime contratoDesde{ get; set; }
        public DateTime contratoHasta { get; set; }
        public  double Monto { get; set; }
        public double Descuento { get; set; }
        public int tipoNCF { get; set; }
        public string NCF { get; set; }
        public string RNCCliente { get; set; }
    }
}
