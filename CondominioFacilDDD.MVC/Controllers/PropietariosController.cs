using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using CondominioFacilDDD.Application.Interface;
using CondominioFacilDDD.Domain.Entities;
using CondominioFacilDDD.MVC.ViewModels;

namespace CondominioFacilDDD.MVC.Controllers
{
    public class PropietariosController : Controller
    {
        private readonly IPropietarioAppService _propietarioApp;

        public PropietariosController(IPropietarioAppService propietarioApp)
        {
            _propietarioApp = propietarioApp;
        }

        // GET: Propietarios
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarPropietarios()
        {
            var propietarioViewModel = Mapper.Map<IEnumerable<Propietario>, IEnumerable<PropietarioViewModel>>(_propietarioApp.GetAll());
            return View(propietarioViewModel);
        }
        [HttpPost]
        public ActionResult BuscarNome(string nome)
        {
            var propietarioViewModel = Mapper.Map<IEnumerable<Propietario>, IEnumerable<PropietarioViewModel>>(_propietarioApp.BuscarPorNome(nome));
            return View(propietarioViewModel);
        }
        public ActionResult Especiais()
        {
            var propietarioViewModel =
                Mapper.Map<IEnumerable<Propietario>, IEnumerable<PropietarioViewModel>>(_propietarioApp.ObterPropietariosEspeciais());

            return View(propietarioViewModel);
        }

        // GET: Propietarios/Details/5
        public ActionResult Details(int id)
        {
            var propietario = _propietarioApp.GetById(id);
            var propietarioViewModel = Mapper.Map<Propietario, PropietarioViewModel>(propietario);
            return View(propietarioViewModel);
        }

        // GET: Propietarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Propietarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PropietarioViewModel propietario)
        {
            if (ModelState.IsValid)
            {
                var propietarioDomain = Mapper.Map<PropietarioViewModel, Propietario>(propietario);
                _propietarioApp.Add(propietarioDomain);

                return RedirectToAction("Index");
            }
            return View(propietario);
        }

        // GET: Propietarios/Edit/5
        public ActionResult Edit(int id)
        {
            var propietario = _propietarioApp.GetById(id);
            var propietarioViewModel = Mapper.Map<Propietario, PropietarioViewModel>(propietario);

            return View(propietarioViewModel);
        }

        // POST: Propietarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PropietarioViewModel propietario)
        {
            if (ModelState.IsValid)
            {
                var propietarioDomain = Mapper.Map<PropietarioViewModel, Propietario>(propietario);
                _propietarioApp.Update(propietarioDomain);
                return RedirectToAction("Index");
            }
            return View(propietario);
        }


        // GET: Propietarios/Delete/5
        public ActionResult Delete(int id)
        {
            var propietario = _propietarioApp.GetById(id);
            var propietarioViewModel = Mapper.Map<Propietario, PropietarioViewModel>(propietario);

            return View(propietarioViewModel);
        }

        // POST: Propietarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var propietario = _propietarioApp.GetById(id);
            _propietarioApp.Remove(propietario);

            return RedirectToAction("Index");
        }
    }
}
