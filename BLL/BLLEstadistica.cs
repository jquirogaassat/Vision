using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLEstadistica : BE.ICrud<BE.Estadistica>
    {
        #region singleton 
        private BLLEstadistica()
        {

        }
        private static BLLEstadistica instancia;
        public static BLLEstadistica getInstancia()
        {
            if (instancia == null)
            {
                instancia = new BLLEstadistica();
            }
            return instancia;
        } 
        #endregion
        public static int generarMetrica()
        {
            return 1;
        }

        public bool Add(Estadistica entAlta)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Estadistica entAlta)
        {
            throw new NotImplementedException();
        }

        public bool Update(Estadistica entAlta)
        {
            throw new NotImplementedException();
        }

        public IList<Estadistica> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
