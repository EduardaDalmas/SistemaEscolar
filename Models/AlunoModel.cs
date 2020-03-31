using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaEscolar.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }

        [Display(Name = "Nome do Responsável")]
        public string NomeResponsável { get; set; }

        [Display(Name = "CPF do Responsável")]
        public string CPFResponsavel { get; set; }
        
    }
}