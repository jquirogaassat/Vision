using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALArticulo : BE.ICrud<BE.Articulo>
    {

        #region singleton
        private DALArticulo()
        {

        }
        private static DALArticulo instnacia;
        public static DALArticulo GetInstnacia()
        {
            if (instnacia == null)
            {
                instnacia = new DALArticulo();
            }
            return instnacia;
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
