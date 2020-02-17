using System;
using System.Collections.Generic;
using System.Text;
using DreamSkyEntities;
using DataAccessLayer;
using System.Linq;
using System.Data;

namespace BusinessLayer
{
    public class BsCategoriaProducto
    {
        public string AddCategoria(clsCategoriaProducto _newCategory)
        {
            string result = "";

            DataCategoriaProducto newCategory = new DataCategoriaProducto();
            result = newCategory.Registrar(_newCategory);

            return result;
        }

        public string UpdateCategory(clsCategoriaProducto _existingCategory)
        {
            string result = "";
            
            DataCategoriaProducto existingCategory = new DataCategoriaProducto();
            result = existingCategory.Actualizar(_existingCategory);

            return result;
        }


        public List<clsCategoriaProducto> GetAll()
        {
            List<clsCategoriaProducto> lstCategorias = new List<clsCategoriaProducto>();

            DataTable dt = new DataCategoriaProducto().ConsultarTodas();

            lstCategorias = (from DataRow row in dt.Rows
                             select new clsCategoriaProducto
                             {
                                 Id = Convert.ToInt32(row["Id"]),
                                 Nombre = row["Nombre"].ToString(),
                                 Activo = Convert.ToBoolean(row["Activo"])
                             }).ToList();

            return lstCategorias;
        }
    }
}
