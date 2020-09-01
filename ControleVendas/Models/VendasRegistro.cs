using ControleVendas.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class VendasRegistro
    {
        public int Id { get; set; }

        [Display(Name ="Data")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; }
        public StatusVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public VendasRegistro()
        {

        }

        public VendasRegistro(int id, DateTime date, double amount, StatusVenda status, Vendedor vendedor)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
