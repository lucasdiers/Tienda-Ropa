using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Articulos
    {
        public int IdArticulo{ get; set; }
        public int IdCategoria { get; set; }
        public int IdMarca { get; set; }
        public int IdTalle { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public string Color { get; set; }

    }
}
