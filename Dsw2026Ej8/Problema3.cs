using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int valorCopi= originalValue;
            valorCopi++;
            Product productoCopiado = product;
            productoCopiado.ModificarDescripcion("Modificado");
            return $"{originalValue}-{valorCopi}-{product.Descripcion}";

        }

        public class  Product
        {
            public string _descripcion;
            public string Descripcion
            {
                get { return _descripcion; }
                private set {_descripcion = value;}
            }
            public Product (string descripcion) 
            {
               Descripcion = descripcion;
            }

            public void ModificarDescripcion(string nuevaDescripcion)
            {
                Descripcion = nuevaDescripcion;
            }
        }
    }
}
