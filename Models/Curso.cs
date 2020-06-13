using System.Collections.Generic;

namespace ContosoUniversityASPNET.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Creditos { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }
    }
}