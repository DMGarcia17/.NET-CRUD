using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using EfProject.Models;

namespace EfProject.Controllers
{
    public class CrudController : Controller
    {
        static EF_TESTEntities db = new EF_TESTEntities();

        // GET
        public ActionResult Index()
        {
            var cliList = from c in db.Clientes select c;
            List<Cliente> clientes = new List<Cliente>();
            foreach (var item in cliList)
            {
                clientes.Add(Cliente.GetClienteObj(item));
            }

            return View(clientes);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Cliente cli)
        {
            if (!ModelState.IsValid) return View(cli);
            try
            {
                db.Clientes.Add(Cliente.GetClientesObj(cli));
                if (TryUpdateModel(db.Clientes))
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return View(cli);
        }

        public ActionResult Delete(int id)
        {
            var cliente = db.Clientes.FirstOrDefault(c => c.ID == id);
            if (cliente == null)
            {
                return new HttpNotFoundResult(":'C");
            }

            return View(Cliente.GetClienteObj(cliente));
        }

        [HttpPost]
        public ActionResult Del(int id)
        {
            var cliente = db.Clientes.FirstOrDefault(c => c.ID == id);
            db.Clientes.Remove(cliente);
            db.SaveChanges();
            return Json(new {success=true,message="The row was deleted"});
        }

        public ActionResult Edit(int id)
        {
            var cliente = db.Clientes.FirstOrDefault(c => c.ID == id);
            return View(Cliente.GetClienteObj(cliente));
        }

        [HttpPost]
        public ActionResult Edit(Cliente cli)
        {
            if (!ModelState.IsValid) return View(cli);
            Clientes cliente = db.Clientes.Find(cli.ID);
            if (cliente != null)
            {
                cliente.nombre = cli.nombre;
                cliente.edad = cli.edad;
                cliente.fechaAlta = cli.fechaAlta;
                if (TryUpdateModel(cliente))
                {
                    db.Entry(cliente).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Edit", cliente);
        }
    }
}