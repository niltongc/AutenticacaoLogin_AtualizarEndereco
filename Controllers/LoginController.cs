using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAuto.Models;

namespace ProAuto.Controllers
{
    public class LoginController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (loginModel.Login == "adm" && loginModel.Senha == "123")
                    {
                        return RedirectToAction("Index", "Associado");

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