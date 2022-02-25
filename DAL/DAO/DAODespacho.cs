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
    internal class DAODespacho : BE.ICrud<BE.Factura>
    {
        private string connstring = ""; //dir de la bd
        private SqlConnection conn;
        private string spInsert = "AgregarDespacho"; // storeprocedure en la bd
        private string spUpdate = "ActualizarDespacho"; // storeprocedure en la bd
        private string spDelete = "EliminarDespacho"; // storeprocedure en la bd
        private string spSelectAll = "DespachoSelectAll"; // storeprocedure en la bd

        private DataSet ds;
        private SqlDataAdapter da;
        private SqlCommand comm;


        public bool Add(Factura entAlta)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Factura entAlta)
        {
            throw new NotImplementedException();
        }

        public IList<Factura> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Factura entAlta)
        {
            throw new NotImplementedException();
        }
    }
}
