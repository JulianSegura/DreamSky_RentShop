using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DatabaseManager
    {
        private SqlConnection Connection = new SqlConnection("Server = JULIANSEGURA-PC; Database=DreamSky-RentShop;Trusted_Connection=True;");


        //Metodos para abrir y cerrar conexion a la BD
        private void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        private void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        //Metodo para ejecuar Store Procedure(Insert, Update, Delete)
        public void ExecuteStoreProc(string storeProcName,List<DataParameter>parameters)
        {
            SqlCommand command;
            try
            {
                OpenConnection();
                command = new SqlCommand(storeProcName, Connection);
                command.CommandType = CommandType.StoredProcedure;
                
                //Agregamos los parametros al Store Procedure
                if (parameters != null)
                {
                    foreach (DataParameter parameter in parameters)
                    {
                        if (parameter.Direction == ParameterDirection.Input)
                        {
                            command.Parameters.AddWithValue(parameter.Name,parameter.Value);
                        }
                        if (parameter.Direction == ParameterDirection.Output)
                        {
                            command.Parameters.Add(parameter.Name, parameter.DataType, parameter.Size).Direction = ParameterDirection.Output;
                        }
                    }
                    
                    command.ExecuteNonQuery();
                    CloseConnection();

                    //Leemos la informacion que retorna el Store Procedure
                    foreach (DataParameter outputParameter in parameters)
                    {
                        int listIndex = parameters.IndexOf(outputParameter);
                        //int commandParamIndex = command.Parameters.IndexOf(outputParameter);

                        if (command.Parameters[listIndex].Direction == ParameterDirection.Output)
                        {
                            parameters[listIndex].Value = command.Parameters[listIndex].Value.ToString();
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        //Metodo para consultas (Select -- From)
        public DataTable ExecuteQuery(string storeProcName, List<DataParameter> parameters)
        {
            DataTable dt=new DataTable();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(storeProcName, Connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                
                //Agregamos los parametros en caso de que hayan
                if (parameters != null)
                {
                    foreach (DataParameter parameter in parameters)
                    {
                        da.SelectCommand.Parameters.AddWithValue(parameter.Name, parameter.Value);
                    }
                }
                da.Fill(dt);
            }
            catch (Exception ex)
            {

               /* throw ex;*/
            }

            return dt;
        }

    }
}
