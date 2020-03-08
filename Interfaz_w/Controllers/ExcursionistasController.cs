using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interfaz_w.Controllers
{
    public class ExcursionistasController : Controller
    {
        // GET: Excursionistas
        public ActionResult Index()
        {
            return View();
        }

        // GET: Excursionistas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Excursionistas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Excursionistas/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Excursionistas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Excursionistas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Excursionistas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Excursionistas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
