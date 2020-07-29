using ControleVendas.Models.Enums;
using System;


namespace ControleVendas.Models
{
    public class VendasRegistro
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
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
