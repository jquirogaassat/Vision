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
    internal class DAOCliente : BE.ICrud<BE.Cliente>
    {
        private string connstring = ""; //direccion de la db 
        private SqlConnection conn;
        private string spInsert = "AgregarCliente"; // storeprocedure en la db
        private string spDelete = "EliminarCliente"; // storeprocedure en la db
        private string spUpdate = "Actualizar Cliente"; //storeprocedure en la  db
        private string spSelectAll = "ClienteSelectAll"; // storeprocedure en la db

        private DataSet ds;
        private SqlDataAdapter da;
        private SqlCommand comm;

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
