using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleVendas.Data;
using ControleVendas.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleVendas.Services
{
    public class SalesRecordService
    {

        private readonly ControleVendasContext _context;

        public SalesRecordService(ControleVendasContext context)
        {
            _context = context;
        }




        public async Task<List<VendasRegistro>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;

            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }


            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            return await result
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}
