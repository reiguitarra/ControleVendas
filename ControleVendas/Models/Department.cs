using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleVendas.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Vendedor> Vendedor { get; set; } = new List<Vendedor>();


        public Department()
        {

        }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Vendedor vendedor)
        {
            Vendedor.Add(vendedor);
        }

        public void RemoveSeller(Vendedor vendedor)
        {
            Vendedor.Remove(vendedor);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Vendedor.Sum(vend => vend.TotalSales(initial, final));
        }
    }
}
