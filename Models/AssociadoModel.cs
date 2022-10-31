using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProAuto.Models
{
    public class AssociadoModel
    {
        public int Id {get; set;}
        [Required]
        public string Nome { get; set; }
        [Required]
        [StringLength(11, MinimumLength = 11)]
        [RegularExpression("\\d{11}",ErrorMessage = "O campo cpf deve conter somente números")]
        public string CPF {get; set;}
        [Required]
        public string Placa { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public string Telefone {get; set;}

    }
}