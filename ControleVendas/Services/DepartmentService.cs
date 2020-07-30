﻿using ControleVendas.Data;
using ControleVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleVendas.Services
{
    public class DepartmentService
    {
        private readonly ControleVendasContext _context;

        public DepartmentService(ControleVendasContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
