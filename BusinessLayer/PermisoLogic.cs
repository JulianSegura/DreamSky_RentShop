using System;
using System.Collections.Generic;
using System.Text;
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
                    lst.Add(new clsPermiso 
                    {Id=Convert.ToInt32(row["IdRol"]),
                     Formulario=row["Formulario"].ToString(),   
                     Activo=Convert.ToBoolean(row["Activo"])}
                    );
                }
            }

            return lst.Where(p=>p.Activo==true).ToList();
        }
    }
}
