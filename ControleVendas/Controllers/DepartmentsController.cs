using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ControleVendas.Models;

namespace ControleVendas.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department(1, "Eletronics"));
            list.Add(new Department(2, "Fashion"));
            list.Add(new Department(3, "Entertainment"));

            return View(list);
        }
    }
}
