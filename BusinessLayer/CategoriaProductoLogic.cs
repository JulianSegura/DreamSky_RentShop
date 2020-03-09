using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using DreamSkyEntities;
using System.Data;

namespace BusinessLayer
{
    public class CategoriaProductoLogic: clsCategoriaProducto
    {
        DatabaseManager dataManager = new DatabaseManager();

        public string Insert()
        {
            string result = "";
            List<DataParameter> parameters = new List<DataParameter>();

            try
            {
                //Parametros de entrada

                parameters.Add(new DataParameter("@Nombre", this.Nombre));
                parameters.Add(new DataParameter("@Activo", this.Activo));
                //parametros de salida
                parameters.Add(new DataParameter("@Resultado", SqlDbType.VarChar, 100));

                dataManager.ExecuteStoreProc("uspInserProductCategory", parameters);
                result = parameters[2].Value.ToString();
            }
            catch (Exception ex)
            {

                result=ex.Message;
            }

            return result;
        }

        public string Update()
        {
            string result = "";

            List<DataParameter> parameters = new List<DataParameter>();

            try
            {
                //Parametros de entrada

                parameters.Add(new DataParameter("@Nombre", this.Nombre));
                parameters.Add(new DataParameter("@Activo", this.Activo));
                //parametros de salida
                parameters.Add(new DataParameter("@Resultado", SqlDbType.VarChar, 100));

                dataManager.ExecuteStoreProc("uspUpdateProductCategory", parameters);
                result = parameters[2].Value.ToString();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            return result;
        }
        public DataTable GetAll()
        {
            return dataManager.ExecuteQuery("uspGetAllProductCategories", null);
        }

    }
}
