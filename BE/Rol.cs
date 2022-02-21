using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Rol
    {
        public static Usuario usuario;

        public int CodigoEmpleado { get; set; }

        public Rol()
        {
            CodigoEmpleado= usuario.CodigoEmpleado;
            
        }
    }
}
