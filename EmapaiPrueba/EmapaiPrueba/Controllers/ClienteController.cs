using EmapaiPrueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace EmapaiPrueba.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            List<ClienteExterno> ListCliente;
            using (DbConexion db = new DbConexion())
            {
                ListCliente = db.ClienteExternoes.Take(5).ToList();

            }
            return View(ListCliente);
        }
    }
}