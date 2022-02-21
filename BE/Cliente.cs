using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoPostal { get; set; }
        public int Cuit { get; set; }
        public string Direccion { get; set; }
    }
}
