using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaEscolar.Models
{
    public class Matricula
    {
        public int Id { get; set; }

        [Display(Name = "Data da Matrícula")]
        public DateTime DataMatricula { get; set; }
        public Aluno Aluno { get; set; }
        public Turma Turma { get; set; }
    }
}