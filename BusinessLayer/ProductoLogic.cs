using DataAccessLayer;
using DreamSkyEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BusinessLayer
{
    public class ProductoLogic
    {
        DatabaseManager dataManager = new DatabaseManager();
        public List<clsProducto> GetAll()
        {
            List<clsProducto> lst = new List<clsProducto>();
            DataTable dt = dataManager.ExecuteQuery("uspGetAllProductos", null);

            lst = (from DataRow row in dt.Rows
                   select new clsProducto
                   {
                       Id = Convert.ToInt32(row["Id"]),
                       codigoProducto = row["CodigoProducto"].ToString(),
                       Nombre = row["Nombre"].ToString(),
                       Descripcion = row["Descripcion"].ToString(),
                       CategoriaProducto = Convert.ToInt32(row["IdCategoria"]),
                       costoAlquiler = Convert.ToDouble(row["CostoAlquiler"]),
                       Activo = Convert.ToBoolean(row["Activo"])
                   }).ToList();
            return lst;
        }

        public clsProducto GetById(int productoId)
        {
            clsProducto prod = GetAll().Where(p => p.Id == productoId).FirstOrDefault();
            return prod;
        }

        public string Insert(clsProducto newProducto)
        {
            string result = "";
            List<DataParameter> parameters = new List<DataParameter>();
            //uspInsertProducto
            try
            {
                parameters.Add(new DataParameter("@CodigoProducto", newProducto.codigoProducto));
                parameters.Add(new DataParameter("@Nombre", newProducto.Nombre));
                parameters.Add(new DataParameter("@Descripcion", newProducto.Descripcion));
                parameters.Add(new DataParameter("@IdCategoria", newProducto.CategoriaProducto));
                parameters.Add(new DataParameter("@CostoAlquiler", newProducto.costoAlquiler));
                parameters.Add(new DataParameter("@activo", newProducto.Activo));

                parameters.Add(new DataParameter("@Resultado", SqlDbType.VarChar, 100));

                dataManager.ExecuteStoreProc("uspInsertProducto", parameters);
                result = parameters[6].Value.ToString();

            }
            catch (Exception e)
            {

                result = e.Message;
            }
            return result;
        }

        public string Update(clsProducto productToUpdate)
        {
            string result = "";
            List<DataParameter> parameters = new List<DataParameter>();
            //[uspUpdateProducto]
            try
            {
                parameters.Add(new DataParameter("@IdProducto", productToUpdate.Id));
                parameters.Add(new DataParameter("@CodigoProducto", productToUpdate.codigoProducto));
                parameters.Add(new DataParameter("@Nombre", productToUpdate.Nombre));
                parameters.Add(new DataParameter("@Descripcion", productToUpdate.Descripcion));
                parameters.Add(new DataParameter("@IdCategoria", productToUpdate.CategoriaProducto));
                parameters.Add(new DataParameter("@CostoAlquiler", productToUpdate.costoAlquiler));
                parameters.Add(new DataParameter("@activo", productToUpdate.Activo));

                parameters.Add(new DataParameter("@Resultado", SqlDbType.VarChar, 100));

                dataManager.ExecuteStoreProc("uspUpdateProducto", parameters);
                result = parameters[7].Value.ToString();

            }
            catch (Exception e)
            {

                result = e.Message;
            }
            return result;

        }
    }
}
