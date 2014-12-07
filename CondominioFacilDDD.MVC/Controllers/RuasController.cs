using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using CondominioFacilDDD.Application.Interface;
using CondominioFacilDDD.Domain.Entities;
using CondominioFacilDDD.MVC.ViewModels;

namespace CondominioFacilDDD.MVC.Controllers
{
    public class RuasController : Controller
    {
        private readonly IRuaAppService _ruaApp;

        public RuasController(IRuaAppService ruaApp)
        {
            _ruaApp = ruaApp;
        }


        public ActionResult Index()
        {
            return View();
        }

        // GET: Ruas
        public ActionResult ListarRuas()
        {
            var ruaViewModel = Mapper.Map<IEnumerable<Rua>, IEnumerable<RuaViewModel>>(_ruaApp.GetAll());
            return View(ruaViewModel);
        }

        [HttpPost]
        public ActionResult BuscarNome(string nome)
        {
            var ruaViewModel = Mapper.Map<IEnumerable<Rua>, IEnumerable<RuaViewModel>>(_ruaApp.BuscarPorNome(nome));
            return View(ruaViewModel);
        }

        // GET: Ruas/Details/5
        public ActionResult Details(int id)
        {
            var rua = _ruaApp.GetById(id);
            var ruaViewModel = Mapper.Map<Rua, RuaViewModel>(rua);
            return View(ruaViewModel);
        }

        // GET: Ruas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ruas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RuaViewModel rua)
        {
            if (ModelState.IsValid)
            {
                var ruaDomain = Mapper.Map<RuaViewModel, Rua>(rua);
                _ruaApp.Add(ruaDomain);

                return RedirectToAction("Index");
            }
            return View(rua);
        }


        // GET: Ruas/Edit/5
        public ActionResult Edit(int id)
        {
            var rua = _ruaApp.GetById(id);
            var ruaViewModel = Mapper.Map<Rua, RuaViewModel>(rua);

            return View(ruaViewModel);
        }


        // POST: Ruas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RuaViewModel rua)
        {
            if (ModelState.IsValid)
            {
                var ruaDomain = Mapper.Map<RuaViewModel, Rua>(rua);
                _ruaApp.Update(ruaDomain);
                return RedirectToAction("Index");
            }
            return View(rua);
        }

        // GET: Ruas/Delete/5
        public ActionResult Delete(int id)
        {
            var rua = _ruaApp.GetById(id);
            var ruaViewModel = Mapper.Map<Rua, RuaViewModel>(rua);

            return View(ruaViewModel);
        }

        // POST: Ruas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var rua = _ruaApp.GetById(id);
            _ruaApp.Remove(rua);

            return RedirectToAction("Index");
        }
    }
}
