using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BLL;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SecondHandWeb.Controllers
{
    public class AlunoController : Controller
    {

        private readonly BusinesFacade _businesFacade;

        public AlunoController(BusinesFacade businesFacade)
        {
            _businesFacade = businesFacade;
        }

        public ActionResult Create()
        {
            ViewData["AulaPresencialNome"] = new SelectList(_businesFacade.EaulasIEnumerable(), "AulaPresencialId", "Turma");
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Index(long AlunoVagaId, 
                                               String NomeAluno)
        {
            var categoriaQuery = _businesFacade.vagasIEnumerable();
            return View(categoriaQuery);
        }

        [HttpPost]

        public async Task<ActionResult> Create([Bind("AlunoVagaId, NomeAluno, AulaPresencialId")] AlunoVaga alunoVaga)
        {

            if (ModelState.IsValid)
            {
                _businesFacade.CadNovaVaga(alunoVaga);
                return RedirectToAction(nameof(Create));
            }

            ViewData["AulaPresencialNome"] = new SelectList(_businesFacade.EaulasIEnumerable(), "AulaPresencialId", "Turma", alunoVaga.AulaPresencialId);
            
            return View(alunoVaga);

        }

        /*
        public async Task<ActionResult> Create()
        {
            ViewData["AulaPresencialNome"] = new SelectList(_businesFacade.EaulasIEnumerable(), "AulaPresencialId", "Turma", alunoVaga.AulaPresencialId);

            var aluno = await 

            AlunoVaga novo = new AlunoVaga()
            {
                NomeAluno = AlunoVaga.

            }
        }
        */
    }


}
