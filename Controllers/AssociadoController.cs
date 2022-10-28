using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAuto.Context;
using ProAuto.Models;

namespace ProAuto.Controllers
{
    public class AssociadoController : Controller
    {
        private readonly AssociadoContext _context;
        public AssociadoController(AssociadoContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var associado = _context.Associados.ToList();
            return View(associado);
        }

        public IActionResult Editar(int id)
        {
            AssociadoModel associado = _context.Associados.Find(id);
            if(associado == null)
            {
                return NotFound();
            }
            return View(associado);
        }
        [HttpPost]
        public IActionResult Atualizar(AssociadoModel associado)
        {
            var associadoDB = _context.Associados.Find(associado.Id);

            associadoDB.Endereco = associado.Endereco;

            _context.Associados.Update(associadoDB);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}