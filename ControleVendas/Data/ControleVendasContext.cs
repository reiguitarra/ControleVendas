
using Microsoft.EntityFrameworkCore;
using ControleVendas.Models;

namespace ControleVendas.Data
{
    public class ControleVendasContext : DbContext
    {
        public ControleVendasContext (DbContextOptions<ControleVendasContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Vendedor> Saller { get; set; }
        public DbSet<VendasRegistro> SalesRecord { get; set; }


    }
}
