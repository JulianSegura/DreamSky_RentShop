using DataAccessLayer;
using DreamSkyEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BusinessLayer
{
    public class TipoIdentificacionLogic
    {
        DatabaseManager dataManager = new DatabaseManager();
        public string Insert(clsTipoIdentificacion newIdentificacion)
        {
            string result;
            List<DataParameter> parameters = new List<DataParameter>();

            try
            {
                parameters.Add(new DataParameter("@Nombre", newIdentificacion.Nombre));
                parameters.Add(new DataParameter("@Activo", newIdentificacion.Activo));
                parameters.Add(new DataParameter("@Resultado", SqlDbType.VarChar, 100));

                dataManager.ExecuteStoreProc("uspInsertTipoIdentificacion", parameters);
                result = parameters[2].Value.ToString();
            }
            catch (Exception ex)
            {

                result = ex.Message;
            }
            return result;
        }

        public string Update(clsTipoIdentificacion updateIdentificacion)
        {
            string result;

            List<DataParameter> parameters = new List<DataParameter>();

            try
            {
                //Parametros de entrada
                parameters.Add(new DataParameter("@Id", updateIdentificacion.Id));
                parameters.Add(new DataParameter("@Nombre", updateIdentificacion.Nombre));
                parameters.Add(new DataParameter("@Activo", updateIdentificacion.Activo));
                //parametros de salida
                parameters.Add(new DataParameter("@Resultado", SqlDbType.VarChar, 100));

                dataManager.ExecuteStoreProc("uspUpdateTipoIdentificacion", parameters);
                result = parameters[3].Value.ToString();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        public List<clsTipoIdentificacion> GetAll()
        {
            List<clsTipoIdentificacion> lst = new List<clsTipoIdentificacion>();
            DataTable dt = dataManager.ExecuteQuery("uspGetAllTiposIdentificacion", null);

            lst = (from DataRow row in dt.Rows
                   select new clsTipoIdentificacion
                   { Id = Convert.ToInt32(row["Id"]), Nombre = row["Nombre"].ToString(), Activo = Convert.ToBoolean(row["Activo"]) }
                   ).ToList();

            return lst;
        }

        public DataTable GetBasicInfo()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Rows.Add(0, "Seleccione");
            var lst = GetAll().Where(t => t.Activo == true);
            foreach (clsTipoIdentificacion id in lst)
            {
                dt.Rows.Add(id.Id, id.Nombre);
            }
            return dt;
        }
    }
}
