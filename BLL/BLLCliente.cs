using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCliente : BE.ICrud<BE.Cliente>
    {

        #region singleton
        private BLLCliente()
        {

        }
        private static BLLCliente instancia;
        public static BLLCliente getInstancia()
        {
            if (instancia == null)
            {
                instancia = new BLLCliente();
            }
            return instancia;
        } 
        #endregion
        public bool Add(Cliente entAlta)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Cliente entAlta)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Cliente entAlta)
        {
            throw new NotImplementedException();
        }
    }
}
