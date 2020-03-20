using DataAccessLayer;
using DreamSkyEntities;
using System;
using System.Collections.Generic;
using System.Data;

namespace BusinessLayer
{
    public class RentaLogic
    {
        DatabaseManager dataManager = new DatabaseManager();
        public string Insert(clsRenta newRent)
        {
            string result = "";
            List<DataParameter> parameters = new List<DataParameter>();

            try
            {
                parameters.Add(new DataParameter("@IdCliente", newRent.idCliente));
                parameters.Add(new DataParameter("@FechaDesde", newRent.contratoDesde));
                parameters.Add(new DataParameter("@FechaHasta", newRent.contratoHasta));
                parameters.Add(new DataParameter("@Monto", newRent.Monto));
                parameters.Add(new DataParameter("@Descuento", newRent.Descuento));
                parameters.Add(new DataParameter("@IdTipoNCF", newRent.tipoNCF));
                parameters.Add(new DataParameter("@NCF", newRent.NCF));
                parameters.Add(new DataParameter("@RNCCliente", newRent.RNCCliente));
                parameters.Add(new DataParameter("@Estado", newRent.Estado));

                parameters.Add(new DataParameter("@Resultado", SqlDbType.VarChar, 100));
                parameters.Add(new DataParameter("@InsertedId", SqlDbType.Int, 4));

                dataManager.ExecuteStoreProc("uspInsertRenta", parameters);

                newRent.Id = Convert.ToInt32(parameters[10].Value);
                addDetails(newRent.items, newRent.Id);
                result = parameters[9].Value.ToString();

            }
            catch (Exception e)
            {
                result = e.Message;
            }

            return result;
        }

        public string Update(clsRenta updateRent)
        {
            string result = "";

            return result;
        }

        private void addDetails(List<clsRentaDetalle> lst, int idRenta)
        {
            foreach (clsRentaDetalle item in lst)
            {
                item.IdRenta = idRenta;
                List<DataParameter> parameters = new List<DataParameter>();

                try
                {
                    parameters.Add(new DataParameter("@IdRenta", item.IdRenta));
                    parameters.Add(new DataParameter("@CodigoProducto", item.CodProducto));
                    parameters.Add(new DataParameter("@Cantidad", item.Cantidad));

                    dataManager.ExecuteStoreProc("uspInsertDetalleRenta", parameters);
                    
                }
                catch (Exception ex)
                {
                    parameters.Clear();
                    parameters.Add(new DataParameter("@IdRenta", item.IdRenta));
                    dataManager.ExecuteStoreProc("uspDeleteRenta", parameters);
                    throw ex;
                }
            }
        }
    }
}
