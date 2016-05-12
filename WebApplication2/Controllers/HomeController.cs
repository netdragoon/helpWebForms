using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet()]
        public ActionResult Item()
        {
            var obj = new object[] { new { Value = 1, Name = "Sim" }, new { Value = 2, Name = "Não" } };
            ViewData["Status"] = new RadioButtonList(obj, "Value", "Name", 1);
            return View(new Items());
        }

        [HttpPost()]
        public ActionResult Item(int? Status, Items items)
        {

            return View();
        }

        [HttpGet()]
        public ActionResult ClienteItems()
        {
            IList<Client> clients = null;
            using (myDataBaseEntities db = new myDataBaseEntities())
            {
                clients = db.Client.ToList();
            }                
            ViewData["Clientes"] = new RadioButtonList(clients, "Id", "Name", 6);
            return View();
        }

        [HttpPost()]
        public ActionResult ClienteItems(int Clientes)
        {
            int c = Clientes;
            return View();
        }


        [HttpGet()]
        public ActionResult Pessoas()
        {
            var obj = new object[] {
                new { Sexo = "Masculino", Sigla = "M" },
                new { Sexo = "Feminino", Sigla = "F" }
            };
            ViewData["Sexo"] = new RadioButtonList(obj, "Sigla", "Sexo", "M");
            return View(new Pessoa() {  Id = 0, Nome = "Fulvio", Sexo = 'M'});
        }

        [HttpPost()]
        public ActionResult Pessoas(Pessoa p)
        {
            var c = p;
            var obj = new object[] {
                new { Sexo = "Masculino", Sigla = "M" },
                new { Sexo = "Feminino", Sigla = "F" }
            };
            ViewData["Sexo"] = new RadioButtonList(obj, "Sigla", "Sexo", p.Sexo);
            return View(c);
        }
    }
}