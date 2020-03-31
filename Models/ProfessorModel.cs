using System;

namespace SistemaEscolar.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string CPF { get; set; }
    }
}