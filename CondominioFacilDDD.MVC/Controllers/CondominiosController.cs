using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CondominioFacilDDD.MVC.Controllers
{
    public class CondominiosController : Controller
    {
        // GET: Condominios
        public ActionResult Index()
        {
            return View();
        }

        // GET: Condominios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Condominios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Condominios/Create
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

        // GET: Condominios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Condominios/Edit/5
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

        // GET: Condominios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Condominios/Delete/5
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
