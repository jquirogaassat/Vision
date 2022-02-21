using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLRol : BE.ICrud<BE.Usuario>
    {
        #region singleton
        private BLLRol()
        {

        }
        private static BLLRol instancia;
        public static BLLRol getInstancia()
        {
            if (instancia == null)
            {
                instancia = new BLLRol();
            }
            return instancia;
        } 
        #endregion
        public bool Add(Usuario entAlta)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Usuario entAlta)
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Usuario entAlta)
        {
            throw new NotImplementedException();
        }
    }
}
