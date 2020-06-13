using System;
using System.Collections.Generic;

namespace ContosoUniversityASPNET.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataMatricula { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }
    }
}
