using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFinanciero
    {
        #region singleton
        private BLLFinanciero()
        {

        }
        private static BLLFinanciero instancia;
        public static BLLFinanciero getInstancia()
        {
            if (instancia == null)
            {
                instancia = new BLLFinanciero();
            }
            return instancia;
        } 
        #endregion
        public static int bordero()
        {
            return 1; 
        }

        public static int inversion ()
        {
            return 1;
        }
    }
}
