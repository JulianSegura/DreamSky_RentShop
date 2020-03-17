using System;
using System.Collections.Generic;
using DreamSkyEntities;
using DataAccessLayer;
using System.Linq;
using System.Data;

namespace BusinessLayer
{
    public class PermisoLogic
    {
        DatabaseManager dataManager = new DatabaseManager();
        public List<clsPermiso> GetAll()
        {
            List<clsPermiso> lst = new List<clsPermiso>();
            DataTable dt = dataManager.ExecuteQuery("uspGetAllPermisos", null);

            lst = (from DataRow row in dt.Rows
                   select new clsPermiso
                   {
                       Id = Convert.ToInt32(row["Id"]),
                       Formulario = row["Formulario"].ToString(),
                       Activo = Convert.ToBoolean(row["Activo"])
                   }).Where(p => p.Activo == true).ToList();
            return lst;
        }

        public List<clsPermiso>GetByRol(int rolID)
        {
            List<clsPermiso> lst = new List<clsPermiso>();
            DataTable dt = dataManager.ExecuteQuery("uspGetAllPermisosRoles", null);

            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["IdRol"]) == rolID)
                {
                    clsPermiso newPermiso = GetAll().Where(r => r.Id == Convert.ToInt32(row["IdPermiso"])).FirstOrDefault();
                    lst.Add(newPermiso);
                }
            }

            return lst.Where(p=>p.Activo==true).ToList();
        }

        public string AsociarARol(string operacion,int rolId,List<int>permisos)
        {
            string result="";
            List<DataParameter> parameters = new List<DataParameter>();

            foreach (int permiso in permisos)
            {
                parameters.Clear();
             
                try
                {
                    parameters.Add(new DataParameter("@Operacion", operacion));
                    parameters.Add(new DataParameter("@IdRol", rolId));
                    parameters.Add(new DataParameter("@IdPermiso", permiso));

                    if (permiso == permisos.Last())
                    {
                        parameters.Add(new DataParameter("@Resultado", SqlDbType.VarChar, 100));
                    }

                    dataManager.ExecuteStoreProc("uspAsignarPermisosRol", parameters);
                    
                }
                catch (Exception ex)
                {

                    result=ex.Message;
                }
            }

            result = parameters[3].Value.ToString();
            return result;
        }
    }
}
