using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using CondominioFacilDDD.Application.Interface;
using CondominioFacilDDD.Domain.Entities;
using CondominioFacilDDD.MVC.ViewModels;

namespace CondominioFacilDDD.MVC.Controllers
{
    public class CondominiosController : Controller
    {
        private readonly ICondominioAppService _condominioApp;
        private readonly IPropietarioAppService _propietarioApp;
        private readonly IResidenciaAppService _residenciaApp;

        public CondominiosController(ICondominioAppService condominioApp, IPropietarioAppService propietarioApp, IResidenciaAppService residenciaApp)
        {
            _condominioApp = condominioApp;
            _propietarioApp = propietarioApp;
            _residenciaApp = residenciaApp;
        }

        // GET: Condominios
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarCondominios()
        {
            var condominioViewModel = Mapper.Map<IEnumerable<Condominio>, IEnumerable<CondominioViewModel>>(_condominioApp.GetAll());
            return View(condominioViewModel);
        }

        // GET: Condominios/Details/5
        public ActionResult Details(int id)
        {
            var condominio = _condominioApp.GetById(id);
            var condominioViewModel = Mapper.Map<Condominio, CondominioViewModel>(condominio);
            return View(condominioViewModel);
        }

        // GET: Condominios/Create
        public ActionResult Create()
        {
            ViewBag.ResidenciaId = new SelectList(_residenciaApp.GetAll(), "ResidenciaId", "NResidencia");
            ViewBag.PropietarioId = new SelectList(_propietarioApp.GetAll(), "PropietarioId", "Nome");
            return View();
        }

        // POST: Condominios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CondominioViewModel condominio)
        {

            if (ModelState.IsValid)
            {
                var condominioDomain = Mapper.Map<CondominioViewModel, Condominio>(condominio);
                _condominioApp.Add(condominioDomain);

                return RedirectToAction("Index");
            }

            ViewBag.ResidenciaId = new SelectList(_residenciaApp.GetAll(), "ResidenciaId", "NResidencia", condominio.ResidenciaId);
            ViewBag.PropietarioId = new SelectList(_propietarioApp.GetAll(), "PropietarioId", "Nome", condominio.PropietarioId);
            return View(condominio);
        }

        // GET: Condominios/Edit/5
        public ActionResult Edit(int id)
        {
            var condominio = _condominioApp.GetById(id);
            var condominioViewModel = Mapper.Map<Condominio, CondominioViewModel>(condominio);

            ViewBag.ResidenciaId = new SelectList(_residenciaApp.GetAll(), "ResidenciaId", "NResidencia");
            ViewBag.PropietarioId = new SelectList(_propietarioApp.GetAll(), "PropietarioId", "Nome");

            return View(condominioViewModel);
        }

        // POST: Condominios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CondominioViewModel condominio)
        {
            if (ModelState.IsValid)
            {
                var condominioDomain = Mapper.Map<CondominioViewModel, Condominio>(condominio);
                _condominioApp.Update(condominioDomain);
                return RedirectToAction("Index");
            }
            ViewBag.ResidenciaId = new SelectList(_residenciaApp.GetAll(), "ResidenciaId", "NResidencia", condominio.ResidenciaId);
            ViewBag.PropietarioId = new SelectList(_propietarioApp.GetAll(), "PropietarioId", "Nome", condominio.PropietarioId);
            return View(condominio);
        }

        // GET: Condominios/Delete/5
        public ActionResult Delete(int id)
        {
            var condominio = _condominioApp.GetById(id);
            var condominioViewModel = Mapper.Map<Condominio, CondominioViewModel>(condominio);

            return View(condominioViewModel);
        }

        // POST: Condominios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var condominio = _condominioApp.GetById(id);
            _condominioApp.Remove(condominio);

            return RedirectToAction("Index");
        }
    }
}
