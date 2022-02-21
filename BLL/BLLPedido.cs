using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLPedido : BE.ICrud<BE.Pedido>
    {
        #region singleton
        private BLLPedido()
        {

        }
        private static BLLPedido instancia;
        public static BLLPedido getInstancia()
        {
            if (instancia == null)
            {
                instancia = new BLLPedido();
            }
            return instancia;
        } 
        #endregion
        public bool Add(Pedido entAlta)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Pedido entAlta)
        {
            throw new NotImplementedException();
        }

        public IList<Pedido> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Pedido entAlta)
        {
            throw new NotImplementedException();
        }
    }
}
