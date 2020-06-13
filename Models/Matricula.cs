namespace ContosoUniversityASPNET.Models
{
    public enum Conceito
    {
        ND, D, DL, DML
    }

    public class Matricula
    {
        public int Id { get; set; }

        public int CursoId { get; set; }
        public int AlunoId { get; set; }
        public Conceito? Conceito { get; set; }

        public Curso Curso { get; set; }
        public Aluno Aluno { get; set; }
    }
}