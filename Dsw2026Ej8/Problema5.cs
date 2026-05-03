using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            return sale.CalcularTotal();
        }

        public class Sale
        {
            public decimal _amount;
            public decimal Amount 
            {
                get { return _amount; }
                set { _amount = value; }
            }
            public Sale(decimal amount)
            {
                _amount = amount;
            }

            public virtual decimal CalcularTotal() 
            {
                return Amount;
            }


        }
        public class RetailSale : Sale
        {
            public RetailSale(decimal amount) : base(amount){ }
            public override decimal CalcularTotal()
            {
                return Amount;
            }
        }

        public class WholesaleSale : Sale
        {
            public WholesaleSale(decimal amount) : base(amount ) { }

            public override decimal CalcularTotal()
            {
                return Amount * 0.9m; // Aplicamos un descuento del 10%
            }
        } 
    }
}
