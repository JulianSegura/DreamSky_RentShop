using System;
using System.Data;
using System.Data.SqlClient;
using DreamSkyEntities;

namespace DataAccessLayer
{
    public class DataCategoriaProducto
    {
        private SqlCommand command = new SqlCommand();
        private string msj = "";

        public string Registrar(clsCategoriaProducto newProductCategory)
        {
            if (newProductCategory == null)
            {
                msj = "Complete todos los datos";
            }
            else
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "uspInserProductCategory";
                command.Connection = Connection.sqlConnection;

                command.Parameters.AddWithValue("@Nombre", newProductCategory.Nombre);
                command.Parameters.AddWithValue("@Activo", newProductCategory.Activo);

                try
                {
                    Connection.OpenConnection();
                    int result = command.ExecuteNonQuery();
                    if (result != 0) msj = "Categoria insertada correctamente";
                    Connection.CloseConnection();
                }
                catch (Exception ex)
                {
                    msj = ex.Message;
                }
            }
                   
            return msj;
        }

        public string Actualizar(clsCategoriaProducto existingCategory)
        {
            if (existingCategory == null)
            {
                msj = "Seleccione la categoria a modificar";
            }
            else
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "uspUpdateProductCategory";
                command.Connection = Connection.sqlConnection;

                command.Parameters.AddWithValue("@Id", existingCategory.Id);
                command.Parameters.AddWithValue("@Nombre", existingCategory.Nombre);
                command.Parameters.AddWithValue("@Activo", existingCategory.Activo);

                try
                {
                    Connection.OpenConnection();
                    int result = command.ExecuteNonQuery();
                    if (result != 0) msj = "Categoria actualizada correctamente";
                    Connection.CloseConnection();
                }
                catch (Exception ex)
                {

                    msj = ex.Message;
                }
            }
            return msj;
        }

        public DataTable ConsultarTodas()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("uspGetAllProductCategories", Connection.sqlConnection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }
    }
}
