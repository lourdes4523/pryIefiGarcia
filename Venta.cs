using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryIefiGarcia
{
    internal class Venta
    {
        public int ID { get; set; }
        public string Producto { get; set; }
        public DateTime FechaVenta { get; set; }
        public int Cantidad { get; set; }
    }
}