using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALFactura : BE.ICrud<BE.Factura>
    {
        #region singleton
        private DALFactura()
        {

        }
        private static DALFactura instancia;
        public static DALFactura GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new DALFactura();
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
