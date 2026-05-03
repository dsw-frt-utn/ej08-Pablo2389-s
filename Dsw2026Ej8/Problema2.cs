using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {

            decimal calculatedTotal = quantity <= 0 ? 0 : quantity * unitPrice;

            var resumen = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = calculatedTotal
            };

            return $"{resumen.Code}-{resumen.Description}-{resumen.Total}";

        }
    }
}
