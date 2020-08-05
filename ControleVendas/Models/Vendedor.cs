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
        [Required(ErrorMessage ="{0} é Requerido!")]
        [StringLength(60, MinimumLength =3, ErrorMessage = "O nome {0} deve ter de {2} a {1} Caracteres!")]
        public string Name { get; set; }

        [Display(Name = "E-Mail")]
        [EmailAddress(ErrorMessage ="Entre com um e-mail válido!")]
        [Required(ErrorMessage = "{0} é Requerido!")]
        public string Email { get; set; }

        [Display(Name = "Nascimento")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} é Requerido!")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Salário")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        [Required(ErrorMessage = "{0} é Requerido!")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} Precisa ser entre {1} to {2}")]
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
