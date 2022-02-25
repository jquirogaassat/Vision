using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALEstadistica : BE.ICrud<BE.Estadistica>
    {
        #region singleton
        private DALEstadistica()
        { }
        private static DALEstadistica instancia;
        public static DALEstadistica GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new DALEstadistica();
            }
            return instancia;
        } 
        #endregion

        public bool Add(Estadistica entAlta)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Estadistica entAlta)
        {
            throw new NotImplementedException();
        }

        public IList<Estadistica> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Estadistica entAlta)
        {
            throw new NotImplementedException();
        }
    }
}
