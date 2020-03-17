using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using DreamSkyEntities;
using System.Data;
using System.Linq;

namespace BusinessLayer
{
    public class CategoriaProductoLogic
    {
        DatabaseManager dataManager = new DatabaseManager();

        public string Insert(clsCategoriaProducto categoriaProducto)
        {
            string result = "";
            List<DataParameter> parameters = new List<DataParameter>();

            try
            {
                //Parametros de entrada

                parameters.Add(new DataParameter("@Nombre", categoriaProducto.Nombre));
                parameters.Add(new DataParameter("@Activo", categoriaProducto.Activo));
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

        public string Update(clsCategoriaProducto categoriaProducto)
        {
            string result = "";

            List<DataParameter> parameters = new List<DataParameter>();

            try
            {
                //Parametros de entrada
                parameters.Add(new DataParameter("@Id", categoriaProducto.Id));
                parameters.Add(new DataParameter("@Nombre", categoriaProducto.Nombre));
                parameters.Add(new DataParameter("@Activo", categoriaProducto.Activo));
                //parametros de salida
                parameters.Add(new DataParameter("@Resultado", SqlDbType.VarChar, 100));

                dataManager.ExecuteStoreProc("uspUpdateProductCategory", parameters);
                result = parameters[3].Value.ToString();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            return result;
        }
        public List<clsCategoriaProducto> GetAll()
        {
            List<clsCategoriaProducto> list = new List<clsCategoriaProducto>();
            DataTable dt= dataManager.ExecuteQuery("uspGetAllProductCategories", null);

            list = (from DataRow row in dt.Rows
                    select new clsCategoriaProducto()
                    {
                        Id=Convert.ToInt32(row["Id"]),
                        Nombre=row["Nombre"].ToString(),
                        Activo=Convert.ToBoolean(row["Activo"])
                    }).ToList();

            return list;
        }

        public DataTable GetBasicInfo()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            var lst = GetAll().Where(c => c.Activo == true);
            dt.Rows.Add(0, "Seleccione");
            foreach (clsCategoriaProducto cprod in lst)
            {
                dt.Rows.Add(cprod.Id, cprod.Nombre);
            }
            return dt;
        }

    }
}
