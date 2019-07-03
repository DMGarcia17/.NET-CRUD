using System;
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
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Clientes cli)
        {
            if (!ModelState.IsValid) return View(Cliente.GetClienteObj(cli));
            try
            {
                db.Clientes.Add(cli);
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
            return View(Cliente.GetClienteObj(cli));
            
        }
    }
}