using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? n1, int? n2, int? n3)
        {
            var notasValidadas = new List<int>();
            AgregarNota(notasValidadas, n1);
            AgregarNota(notasValidadas, n2);
            AgregarNota(notasValidadas, n3);

            if (notasValidadas.Count == 0)
            {
                return 0;
            }
            double suma = 0;
            
            foreach (var nota in notasValidadas)
            {
                suma += nota;
            }

            return suma / notasValidadas.Count;
        }
        private void AgregarNota(List<int> lista, int? nota)
        {
            if (nota.HasValue && nota.Value >= 0 && nota.Value <=10)
            {
                lista.Add(nota.Value);
            }
        }
    }
}