using Livraria.Models.Domain;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Livraria
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }

        public DbSet<Autor> Autores { get; set; }

        public DbSet<Livro> Livros { get; set; }

    }
}