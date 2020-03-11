using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DreamSkyEntities;
using DataAccessLayer;
using System.Linq;

namespace BusinessLayer
{
    public class RolLogic
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

        public List<clsRol> GetAll()
        {
            List<clsRol> lst = new List<clsRol>();
            DataTable dt = dataManager.ExecuteQuery("uspGetAllRoles", null);

            lst = (from DataRow row in dt.Rows
                   select new clsRol
                   { Id = Convert.ToInt32(row["Id"]), Nombre = row["Nombre"].ToString(), limiteEmpleados=Convert.ToInt32(row["LimiteEmpleados"]),limiteEnDemanda= Convert.ToInt32(row["LimiteEnDemanda"]), Activo = Convert.ToBoolean(row["Activo"]) }
                   ).ToList();

            return lst;
        }

        public DataTable GetBasicInfo()
        {
            DataTable dt=new DataTable();
            dt.Columns.Add("Id",typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            var lst = GetAll().Where(r => r.Activo = true);
            dt.Rows.Add(0, "Seleccione");
            foreach (clsRol rol in lst)
            {
                dt.Rows.Add(rol.Id,rol.Nombre);
            }
            return dt;
        }
    }
}
