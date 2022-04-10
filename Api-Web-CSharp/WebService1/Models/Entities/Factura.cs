using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService1.Models.Entities
{
    public class Factura
    {
        public int id_factura { set; get; }
        public int idcliente { set; get; }
        public string cod { set; get; }

        public List<Detalles_Facturas> listaDetalles { set; get; }
    }
}
