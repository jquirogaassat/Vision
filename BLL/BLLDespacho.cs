using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLDespacho : BE.ICrud<BE.Factura>
    {
        #region singleton
        private BLLDespacho()
        {

        }
        private static BLLDespacho instancia;
        public static BLLDespacho getInstancia()
        {
            if (instancia == null)
            {
                instancia = new BLLDespacho();
            }
            return instancia;
        } 
        #endregion
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
    }
}
