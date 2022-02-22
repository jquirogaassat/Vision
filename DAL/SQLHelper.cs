using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class SQLHelper
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private DataSet ds;
        private DataTable dt;


        public string connstring { get; private set; }

        private SQLHelper(string connStr)
        {
            this.connstring = connStr;  
        }
        private static SQLHelper instancia;
        public static SQLHelper getInstancia(string connString)
        {
            if(instancia==null)
            {
                instancia = new SQLHelper(connString);
            }
            return instancia;
        }


        public bool ExecuteQuery(string query)
        {
            bool returnValue= false;

            try
            {
                using (conn = new SqlConnection(this.connstring))
                {
                    using (command = new SqlCommand())
                    {
                        command.CommandType = CommandType.Text;
                        command.CommandText = query;
                        command.Connection = conn;

                        conn.Open();

                        if (command.ExecuteNonQuery() > 0)
                        {
                            returnValue = true;
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return returnValue; 
        }

        public bool ExecuteQuery(string storeprocedure, List<SqlParameter>parametros)
        {
            bool returnValue = false;

            try
            {
                using(conn= new SqlConnection(this.connstring))
                {
                    using(command = new SqlCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Connection = conn;
                        command.CommandText = storeprocedure;

                        if (parametros!=null)
                        {
                            foreach(SqlParameter parametro in parametros)
                            {
                                command.Parameters.Add(parametro);
                            }
                        }
                        conn.Open();

                        if (command.ExecuteNonQuery()>0)
                        {
                            returnValue = true;
                        }
                        conn.Close();
                    }
                }   

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnValue;
        }

        public bool ExecuteQuery(string storeprocedure, List<SqlParameter>parametros, params SqlParameter[] parametrosArray)
        {
            bool returnValue = false;


            try
            {
                using(conn = new SqlConnection(this.connstring))
                {
                    using(command= new SqlCommand()) 
                    {
                        command.CommandType= CommandType.StoredProcedure;
                        command.Connection = conn;
                        command.CommandText= storeprocedure;

                        if (parametros !=null)
                        {
                            foreach(SqlParameter parameter in parametros)
                            {
                                command.Parameters.Add(parameter);
                            }
                        }

                        if (parametrosArray != null)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddRange(parametrosArray);
                        }
                        conn.Open();

                        if (command.ExecuteNonQuery()>0)
                        {
                            returnValue = true;
                        }
                        conn.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnValue;
        }

        public DataTable ExecuteReader(string query)
        {
            ds= new DataSet();

            using(conn= new SqlConnection(this.connstring))
            {
                using(command = new SqlCommand())
                {
                    adapter = new SqlDataAdapter();
                    command.CommandText= query;
                    command.CommandType = CommandType.Text;
                    command.Connection = conn;

                    adapter.SelectCommand = command;
                    adapter.Fill(ds);
                }
            }
            return ds.Tables[0];
        }

        public DataTable ExecuteReader( string storeprocedure, List<SqlParameter>parametros)
        {
            ds= new DataSet();
            
            using (conn= new SqlConnection(this.connstring))
            {
                using(command= new SqlCommand())
                {
                    adapter= new SqlDataAdapter();
                    
                    command.CommandText = storeprocedure;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = conn;

                    if (parametros != null)
                    {
                        command.Parameters.AddRange(parametros.ToArray());
                    }
                    adapter.SelectCommand= command;
                    adapter.Fill(ds);
                }
            }
            return ds.Tables[0];
        }

        public DataTable ExecuteReader (string storeprocedure, List<SqlParameter>parametros, params SqlParameter[]parametrosArray)
        {
            ds= new DataSet();  
            using(conn= new SqlConnection(this.connstring))
            {
                using(command = new SqlCommand())
                {
                    adapter = new SqlDataAdapter();

                    command.CommandType= CommandType.StoredProcedure;
                    command.CommandText= storeprocedure;
                    command.Connection= conn;

                    if(parametros != null)
                    {
                        command.Parameters.AddRange(parametros.ToArray());
                    }

                    if(parametrosArray != null)
                    {
                        command.Parameters.AddRange(parametrosArray);
                    }
                    adapter.SelectCommand = command;
                    adapter.Fill(ds);
                }
            }

            return ds.Tables[0];
        }
    }
}
