using System;
using System.Collections.Generic;
using System.Text;
using DreamSkyEntities;
using DataAccessLayer;
using System.Linq;
using System.Data;

namespace BusinessLayer
{
    public class InventoryLogic
    {
        DatabaseManager dataManager = new DatabaseManager();
        public List<clsInventario> GetAll()
        {
            List<clsInventario> lst = new List<clsInventario>();
            DataTable dt = dataManager.ExecuteQuery("uspGetInventory", null);

            lst = (from DataRow row in dt.Rows
                   select new clsInventario
                   {
                       CodigoProducto = row["CodigoProducto"].ToString(),
                       Disponible = int.Parse(row["Disponible"].ToString())
                   }).ToList();

            return lst;
        }

        public clsInventario GetByCodigoProducto(string codigoProducto)
        {
            return GetAll().Where(i => i.CodigoProducto == codigoProducto).FirstOrDefault();

        }
    }
}
