using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Entities.Models;
using BLL;


namespace SecondHandWeb.Controllers
{
    public class AulaPresencialController : Controller
    {

        private readonly BusinesFacade _businesFacade;

        public AulaPresencialController(BusinesFacade businesFacade)
        {
            _businesFacade = businesFacade;
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create([Bind("Id, CodCred, Turma, Data, Aluno")] AulaPresencial aulaPresencial)
        {
            if (ModelState.IsValid)
            {
                _businesFacade.CadNovaAula(aulaPresencial);
                return RedirectToAction(nameof(Create));
            }
            return View(aulaPresencial);
        }

        [HttpGet]
        public async Task<IActionResult> Index(long Id, int CodCred,
                                               String Turma, DateTime Data)
        {
            var categoriaQuery = _businesFacade.aulasTesteIEnumerable();

            return View(categoriaQuery);
        }

    }
}
