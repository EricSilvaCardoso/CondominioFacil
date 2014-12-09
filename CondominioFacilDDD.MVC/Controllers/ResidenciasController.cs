using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using CondominioFacilDDD.Application.Interface;
using CondominioFacilDDD.Domain.Entities;
using CondominioFacilDDD.MVC.ViewModels;

namespace CondominioFacilDDD.MVC.Controllers
{
    public class ResidenciasController : Controller
    {
        private readonly IResidenciaAppService _residenciaApp;
        private readonly IRuaAppService _ruaApp;

        public ResidenciasController(IResidenciaAppService residenciaApp, IRuaAppService ruaApp)
        {
            _ruaApp = ruaApp;
            _residenciaApp = residenciaApp;
        }


       
        public ActionResult Index()
        {
            return View();
        }

        // GET: Residencias
        public ActionResult ListarResidencias()
        {
            var residenciaViewModel =
                Mapper.Map<IEnumerable<Residencia>, IEnumerable<ResidenciaViewModel>>(_residenciaApp.GetAll());
            return View(residenciaViewModel);
        }

        // GET: Residencias/Details/5
        public ActionResult Details(int id)
        {
            var residencia = _residenciaApp.GetById(id);
            var residenciaViewModel = Mapper.Map<Residencia, ResidenciaViewModel>(residencia);
            return View(residenciaViewModel);
            
        }

        // GET: Residencias/Create
        public ActionResult Create()
        {
            ViewBag.RuaId = new SelectList(_ruaApp.GetAll(), "RuaId", "Nome");
            return View();
        }

        // POST: Residencias/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ResidenciaViewModel residencia)
        {
            if (ModelState.IsValid)
            {
                var residenciaDomain = Mapper.Map<ResidenciaViewModel, Residencia>(residencia);
                _residenciaApp.Add(residenciaDomain);

                return RedirectToAction("Index");
            }
            ViewBag.RuaId = new SelectList(_ruaApp.GetAll(), "RuaId", "Nome", residencia.RuaId);
            return View(residencia);
        }

        // GET: Residencias/Edit/5
        public ActionResult Edit(int id)
        {
            var residencia = _residenciaApp.GetById(id);
            var residenciaViewModel = Mapper.Map<Residencia, ResidenciaViewModel>(residencia);

            ViewBag.RuaId = new SelectList(_ruaApp.GetAll(), "RuaId", "Nome", residenciaViewModel.RuaId);

            return View(residenciaViewModel);
        }

        // POST: Residencias/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ResidenciaViewModel residencia)
        {
            if (ModelState.IsValid)
            {
                var residenciaDomain = Mapper.Map<ResidenciaViewModel, Residencia>(residencia);
                _residenciaApp.Update(residenciaDomain);
                return RedirectToAction("Index");
            }

            ViewBag.RuaId = new SelectList(_ruaApp.GetAll(), "RuaId", "Nome", residencia.RuaId);
            return View(residencia);
        }

        // GET: Residencias/Delete/5
        public ActionResult Delete(int id)
        {
            var residencia = _residenciaApp.GetById(id);
            var residenciaViewModel = Mapper.Map<Residencia, ResidenciaViewModel>(residencia);

            return View(residenciaViewModel);
        }

        // POST: Residencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var residencia = _residenciaApp.GetById(id);
            _residenciaApp.Remove(residencia);

            return RedirectToAction("Index");
        }
    }
}
