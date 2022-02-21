using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLReclamo : BE.ICrud<BE.Reclamo>
    {
        #region singleton
        private BLLReclamo()
        {

        }
        private static BLLReclamo instancia;
        public static BLLReclamo getInstancia()
        {
            if (instancia == null)
            {
                instancia = new BLLReclamo();
            }
            return instancia;
        } 
        #endregion
        public bool Add(Reclamo entAlta)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Reclamo entAlta)
        {
            throw new NotImplementedException();
        }

        public IList<Reclamo> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Reclamo entAlta)
        {
            throw new NotImplementedException();
        }
    }
}
