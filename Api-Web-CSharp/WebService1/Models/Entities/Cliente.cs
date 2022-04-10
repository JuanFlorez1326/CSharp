using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService1.Models.Entities
{
    public class Cliente
    {
        public int id { set; get; }
        public string nombre { set; get; }
        public string apellido { set; get; }
        public string documento { set; get; }

        //public Factura GlobalFactura { set; get; }
        //public List<Factura> listaFacturas { set; get; }
    }
}
