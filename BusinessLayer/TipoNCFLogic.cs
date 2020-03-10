using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataAccessLayer;
using DreamSkyEntities;
using System.Data;

namespace BusinessLayer
{
    public class TipoNCFLogic
    {
        DatabaseManager dataManager = new DatabaseManager();
        public string Insert(clsTipoNCF newTipoNCF)
        {
            string result;
            List<DataParameter> parameters = new List<DataParameter>();

            try
            {
                parameters.Add(new DataParameter("@Nombre", newTipoNCF.Nombre));
                parameters.Add(new DataParameter("@Activo", newTipoNCF.Activo));
                parameters.Add(new DataParameter("@Resultado", SqlDbType.VarChar, 100));

                dataManager.ExecuteStoreProc("uspInsertTipoNCF", parameters);
                result = parameters[2].Value.ToString();
            }
            catch (Exception ex)
            {

                result = ex.Message;
            }
            return result;
        }

        public string Update(clsTipoNCF updateNCF)
        {
            string result;

            List<DataParameter> parameters = new List<DataParameter>();

            try
            {
                //Parametros de entrada
                parameters.Add(new DataParameter("@Id", updateNCF.Id));
                parameters.Add(new DataParameter("@Nombre", updateNCF.Nombre));
                parameters.Add(new DataParameter("@Activo", updateNCF.Activo));
                //parametros de salida
                parameters.Add(new DataParameter("@Resultado", SqlDbType.VarChar, 100));

                dataManager.ExecuteStoreProc("uspUpdateTipoNCF", parameters);
                result = parameters[3].Value.ToString();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        public List<clsTipoNCF> GetAll()
        {
            List<clsTipoNCF> lst = new List<clsTipoNCF>();
            DataTable dt = dataManager.ExecuteQuery("uspGetAllTiposNCF", null);

            lst = (from DataRow row in dt.Rows
                   select new clsTipoNCF
                   { Id = Convert.ToInt32(row["Id"]), Nombre = row["Nombre"].ToString(), Activo = Convert.ToBoolean(row["Activo"]) }
                   ).ToList();

            return lst;
        }
    }
}
