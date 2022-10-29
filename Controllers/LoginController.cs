using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAuto.Models;
using ProAuto.Context;
using System.Web;

namespace ProAuto.Controllers
{
    public class LoginController : Controller
    {

        private readonly AssociadoContext _context;
        public LoginController(AssociadoContext context)
        {
            _context = context;
        }
        public IActionResult BuscarPorLogin(AssociadoModel login)
        {
            AssociadoModel associado = _context.Associados.Find(login);
            return View(associado);
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel, string login, string senha)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var cpf = _context.Associados.FirstOrDefault(x => x.CPF.ToUpper() == login.ToUpper());
                    var placa = _context.Associados.FirstOrDefault(x => x.Placa.ToUpper() == senha.ToUpper());

                    if (cpf != null && placa !=null)
                    {   
                        return RedirectToAction("Detalhes", "Associado", new {id = cpf.Id});
                                
                    }
                    TempData["MensagemErro"] = $"O seu CPF e/ou Placa estão errado(s).";
                }
                return View("Index");
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Não foi possível efetuar o Login. {erro.Message}";
                return RedirectToAction("Index");
            }
        }

    }
}