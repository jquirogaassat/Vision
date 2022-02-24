using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    internal class DAOArticulo : BE.ICrud<BE.Articulo>
    {
        private string connstring = "";// dir bd
        private SqlConnection conn;
        private string spInsert = "AgregarArticulo";// storeprocedure de la bd
        private string spUpdate = "ActualizarArticulo";// storeprocedure de la bd
        private string spDelete = "EliminarArticulo"; // storeprocedure de la bd
        private string spSelectAll = "ArticuloSelectAll"; // storeprocedure de la bd 
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlCommand comm;

        #region SINGLETON
        private DAOArticulo()
        {

        }

        private static DAOArticulo instancia;
        public static DAOArticulo getInstancia()
        {
            if (instancia == null)
            {
                instancia = new DAOArticulo();
            }
            return instancia;
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
