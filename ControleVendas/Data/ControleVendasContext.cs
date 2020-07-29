using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<ControleVendas.Models.Department> Department { get; set; }
    }
}
