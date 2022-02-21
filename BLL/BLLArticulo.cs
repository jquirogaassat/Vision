using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLArticulo : BE.ICrud<BE.Articulo>
    {
        #region singleton
        private BLLArticulo()
        {

        }
        private static BLLArticulo instancia;
        public static BLLArticulo getInstancia()
        {
            if (instancia == null)
            {
                instancia = new BLLArticulo();
            }
            return instancia;
        } 
        #endregion
        public bool Add(Articulo entAlta)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Articulo entAlta)
        {
            throw new NotImplementedException();
        }

        public IList<Articulo> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Articulo entAlta)
        {
            throw new NotImplementedException();
        }
    }
}
