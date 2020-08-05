using ControleVendas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleVendas.Models;
using ControleVendas.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace ControleVendas.Services
{
    public class SellerService
    {
        private readonly ControleVendasContext _context;

        public SellerService(ControleVendasContext context)
        {
            _context = context;
        }


        public async Task<List<Vendedor>> FindAllAsync()
        {
            return await _context.Saller.ToListAsync();
        }

        
        public async Task InsertAsync(Vendedor obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Vendedor> FindByIdAsync(int id)
        {
            return await _context.Saller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Saller.FindAsync(id);
            _context.Saller.Remove(obj);
            await _context.SaveChangesAsync();

        }

        public async Task UpdateAsync(Vendedor obj)
        {
            bool hasAny = await _context.Saller.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id não encontrado");
            }

            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {

                throw new DbConcurrencyException(e.Message);
            }
            
        }
    }
}
