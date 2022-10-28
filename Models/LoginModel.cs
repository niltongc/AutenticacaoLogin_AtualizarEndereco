using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProAuto.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o seu cpf")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite a placa do seu veículo")]
        public string Senha { get; set; }
    }
}