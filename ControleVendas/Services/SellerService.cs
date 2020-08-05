using ControleVendas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleVendas.Models;
using Microsoft.EntityFrameworkCore;

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

        public Vendedor FindById(int id)
        {
            return _context.Saller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Saller.Find(id);
            _context.Saller.Remove(obj);
            _context.SaveChanges();

        }


    }
}
