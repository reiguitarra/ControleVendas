using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace ControleVendas.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        [Display(Name = "Vendedor")]
        public string Name { get; set; }

        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Nascimento")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Salário")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double BaseSalary { get; set; }

        [Display(Name = "Departamento")]
        public Department Department { get; set; }

        public int DepartmentId { get; set; }
        public ICollection<VendasRegistro> Sales { get; set; } = new List<VendasRegistro>();

        public Vendedor()
        {

        }

        public Vendedor(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(VendasRegistro sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(VendasRegistro sr)
        {
            Sales.Remove(sr);
        }


        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
