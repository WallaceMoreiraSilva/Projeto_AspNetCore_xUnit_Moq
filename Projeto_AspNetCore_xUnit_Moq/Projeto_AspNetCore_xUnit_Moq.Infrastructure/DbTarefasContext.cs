using Projeto_AspNetCore_xUnit_Moq.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Projeto_AspNetCore_xUnit_Moq.Infrastructure
{
    public class DbTarefasContext : DbContext
    {
        public DbTarefasContext(DbContextOptions options) : base(options)
        {
        }

        public DbTarefasContext()
        {
        }

        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
