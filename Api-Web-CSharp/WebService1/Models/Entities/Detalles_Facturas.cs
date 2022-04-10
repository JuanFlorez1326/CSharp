using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService1.Models.Entities
{
    public class Detalles_Facturas
    {
        public int id_detalle { set; get; }
        public int id_factura { set; get; }
        public string descripcion { set; get; }
        public string valor { set; get; }
    }
}
