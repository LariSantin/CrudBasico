using CrudBasico.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudBasico.Domain
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Person?> People { get; set; }
    }
}