using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALFinanciero : BE.ICrud<BE.Financiero>
    {
        #region singleton
        private DALFinanciero()
        { }
        private static DALFinanciero instancia;
        public static DALFinanciero GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new DALFinanciero();
            }
            return instancia;
        } 
        #endregion

        public bool Add(Financiero entAlta)   
        {
            throw new NotImplementedException();
        }

        public bool Delete(Financiero entAlta)
        {
            throw new NotImplementedException();
        }

        public IList<Financiero> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Financiero entAlta)
        {
            throw new NotImplementedException();
        }
    }
}
