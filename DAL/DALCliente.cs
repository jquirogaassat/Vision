using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCliente : BE.ICrud<BE.Cliente>
    {
        #region singleton
        private DALCliente()
        {

        }
        private static DALCliente instancia;
        public static DALCliente GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new DALCliente();
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
