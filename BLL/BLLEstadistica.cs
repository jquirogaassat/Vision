using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLEstadistica
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
    }
}
