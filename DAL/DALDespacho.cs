using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DALDespacho : BE.ICrud<BE.Factura>
    {

        #region singleton
        private DALDespacho()
        {

        }
        private static DALDespacho instancia;
        public static DALDespacho GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new DALDespacho();
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
