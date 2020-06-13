using ContosoUniversityASPNET.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversityASPNET.Data
{
    public class ContosoDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        public ContosoDbContext(DbContextOptions<ContosoDbContext> options) : base(options) { }

        public ContosoDbContext() { } // Permite criar migrações sem adicionar IoC no Startup.cs

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ContosoUniversityASPNET;Trusted_Connection=True;");
        }
    }
}
