using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda
{
    public class ProductoCarrito
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
        public string imagen_url { get; set; }
        public int cantidad { get; set; }
    }
}