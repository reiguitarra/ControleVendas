﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace ControleVendas.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
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
