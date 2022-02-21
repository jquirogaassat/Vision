using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFactura : BE.ICrud<BE.Factura>
    {
        private BLLFactura()
        {

        }
        private static BLLFactura instancia;
        public static BLLFactura getInstancia()
        {
            if(instancia==null)
            {
                instancia= new BLLFactura();
            }
            return instancia;
        }
        public bool Add(Factura entAlta)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Factura entAlta)
        {
            throw new NotImplementedException();
        }

        public IList<Factura> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Factura entAlta)
        {
            throw new NotImplementedException();
        }

        public decimal obtenerTotal()
        {
            return 0;
        }
    }
}
