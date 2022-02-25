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
    internal class DAOEstadistica : BE.ICrud<BE.Estadistica>
    {
        private string connstring = ""; //dir de la db
        private SqlConnection conn;
        private string spInsert = "AgregarEstadistica"; //storeprocedure en la db
        private string spDelete = "EliminarEstadistica"; //storeprocedure en la db
        private string spUpdate = "ActualizarEstadistica"; //storeprocedure en la db
        private string spSelectAll = "EstadisticasSelectAll"; //storeprocedure en la db

        private DataSet ds;
        private SqlDataAdapter da;
        private SqlCommand comm;

        #region singleton
        private DAOEstadistica()
        {

        }
        private static DAOEstadistica instancia;
        public static DAOEstadistica GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new DAOEstadistica();
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
