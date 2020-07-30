using ControleVendas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleVendas.Models;

namespace ControleVendas.Services
{
    public class SellerService
    {
        private readonly ControleVendasContext _context;

        public SellerService(ControleVendasContext context)
        {
            _context = context;
        }


        public List<Vendedor> FindAll()
        {
            return _context.Saller.ToList();
        }

        public void Insert(Vendedor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
