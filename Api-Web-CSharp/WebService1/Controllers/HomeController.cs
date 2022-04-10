using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebService1.Models;
using WebService1.Models.Entities;


namespace WebService1.Controllers
{
    public class HomeController : Controller
    {
        BaseDatos db = new BaseDatos();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------

        //Insertar una factura con los detalles de factura.
        public List<Factura> insertarFacturaConDetalles([FromBody] List<Factura> fac)
        {
            string sql = "INSERT INTO factura (id,idcliente,cod) VALUES(" + fac[0].id_factura + "," + fac[0].idcliente + ",'" + fac[0].cod + "');";
            sql += "SELECT @@identity AS id;";
            foreach (Detalles_Facturas id in fac[0].listaDetalles)
            {
                sql += "INSERT INTO detalles_facturas (id,idfactura, descripcion, valor) values ('" + id.id_detalle + "',@@identity,'" + id.descripcion + "'," + id.valor + ");";
            }
            string resultado = db.consultaSQL(sql);
            return fac;
        }

        //Mostrar la factura con detalles de factura.
        public List<Factura> mostrarFacturaConDetalles([FromBody] List<Factura> f)
        {

            string sql = "SELECT f.*, df.* FROM factura f INNER JOIN detalles_facturas df on f.id = df.id_factura WHERE f.id = " + f[0].id_factura;
            DataTable datos = db.getTabla(sql);
            List<Factura> listFactura = new List<Factura>();
            List<Detalles_Facturas> listDetalles = new List<Detalles_Facturas>();

            listDetalles = (from DataRow fDatos in datos.Rows
                            select new Detalles_Facturas()
                            {
                                id_detalle = Convert.ToInt32(fDatos["id"]),
                                id_factura = Convert.ToInt32(fDatos["id_factura"]),
                                descripcion = fDatos["descripcion"].ToString(),
                                valor = fDatos["valor"].ToString()

                            }).ToList();

            listFactura = (from DataRow filasDatos in datos.Rows
                           select new Factura()
                           {
                               id_factura = Convert.ToInt32(filasDatos["id"]),
                               idcliente = Convert.ToInt32(filasDatos["idcliente"]),
                               cod = filasDatos["cod"].ToString(),
                               listaDetalles = listDetalles

                           }).ToList();

            return listFactura;
        }

        //Insertar un cliente a la base de datos.
        public List<Cliente>insertarCliente([FromBody] List<Cliente> client)
        {
            string sql = "INSERT INTO dbfacturas.cliente (id, nombre, apellido,documento) VALUES ('" + client[0].id + "','" + client[0].nombre + "','" + client[0].apellido + "','" + client[0].documento + "')";      
            string result = db.consultaSQL(sql);
            return client;        
        }

        //Mostrar un cliente de la base de datos.
        public List<Cliente> todosClientesId([FromBody] List<Cliente> client)
        {
            string sql = "SELECT * FROM cliente WHERE id = " + client[0].id;
            DataTable dt = db.getTabla(sql);
            List<Cliente> clientList = new List<Cliente>();
            clientList = (from DataRow dr in dt.Rows
                          select new Cliente()
                          {
                              id = Convert.ToInt32(dr["id"]),
                              nombre = dr["nombre"].ToString(),
                              apellido = dr["apellido"].ToString(),
                              documento = dr["documento"].ToString()

                          }).ToList();

            return clientList;
        }

        //Mostrar todos los clientes de la base de datos
        public IEnumerable<Cliente> todosClientes()
        {
            string sql = "SELECT * FROM cliente";
            DataTable dt = db.getTabla(sql);
            List<Cliente> clientList = new List<Cliente>();
            clientList = (from DataRow dr in dt.Rows
                          select new Cliente()
                          {
                              id = Convert.ToInt32(dr["id"]),
                              nombre = dr["nombre"].ToString(),
                              apellido = dr["apellido"].ToString(),
                              documento = dr["documento"].ToString()

                          }).ToList();

            return clientList;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
