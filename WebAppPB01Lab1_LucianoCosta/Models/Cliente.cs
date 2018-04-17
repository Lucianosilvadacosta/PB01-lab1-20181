using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPB01Lab1_LucianoCosta.Models
{
    public class Cliente
    {
        // Primary key
        public int ClienteId { get; set; }

        [Required (ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "CPF é obrigatório")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Data de cadastro é obrigatório")]
        public DateTime DataCadastro { get; set; }
    }
}
