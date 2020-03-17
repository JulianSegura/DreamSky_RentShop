using System;
using System.Collections.Generic;
using System.Text;
using DreamSkyEntities;
using DataAccessLayer;
using System.Linq;
using System.Data;

namespace BusinessLayer
{
    public class ClienteLogic
    {
        DatabaseManager dataManager = new DatabaseManager();
        public string Insert(clsCliente newCustomer)
        {
            string result = "";
            List<DataParameter> parameters = new List<DataParameter>();

            try
            {
                parameters.Add(new DataParameter("@Nombres", newCustomer.Nombres));
                parameters.Add(new DataParameter("@Apellidos", newCustomer.Apellidos));
                parameters.Add(new DataParameter("@IdTipoIdentificacion", newCustomer.TipoIdentificacion));
                parameters.Add(new DataParameter("@Identificacion", newCustomer.Identificacion));
                parameters.Add(new DataParameter("@Activo", newCustomer.Activo));
                parameters.Add(new DataParameter("@Telefono", newCustomer.Telefono));
                parameters.Add(new DataParameter("@Celular", newCustomer.Celular));
                parameters.Add(new DataParameter("@Direccion", newCustomer.Direccion));
                parameters.Add(new DataParameter("@Nacionalidad", newCustomer.Nacionalidad));

                parameters.Add(new DataParameter("@Resultado", SqlDbType.VarChar, 100));

                dataManager.ExecuteStoreProc("uspInsertCliente", parameters);
                result = parameters[9].Value.ToString();
            }
            catch (Exception ex)
            {

                result = ex.Message;
            }

            return result;
        }
        public string Update(clsCliente updateCustomer)
        {
            string result = "";
            List<DataParameter> parameters = new List<DataParameter>();

            try
            {
                parameters.Add(new DataParameter("@Id", updateCustomer.Id));
                parameters.Add(new DataParameter("@Nombres", updateCustomer.Nombres));
                parameters.Add(new DataParameter("@Apellidos", updateCustomer.Apellidos));
                parameters.Add(new DataParameter("@IdTipoIdentificacion", updateCustomer.TipoIdentificacion));
                parameters.Add(new DataParameter("@Identificacion", updateCustomer.Identificacion));
                parameters.Add(new DataParameter("@Activo", updateCustomer.Activo));
                parameters.Add(new DataParameter("@Telefono", updateCustomer.Telefono));
                parameters.Add(new DataParameter("@Celular", updateCustomer.Celular));
                parameters.Add(new DataParameter("@Direccion", updateCustomer.Direccion));
                parameters.Add(new DataParameter("@Nacionalidad", updateCustomer.Nacionalidad));

                parameters.Add(new DataParameter("@Resultado", SqlDbType.VarChar, 100));

                dataManager.ExecuteStoreProc("uspUpdateCliente", parameters);
                result = parameters[10].Value.ToString();
            }
            catch (Exception ex)
            {

                result=ex.Message;
            }
            
            return result;

        }
        public List<clsCliente> GetAll()
        {
            List<clsCliente> lst = new List<clsCliente>();
            DataTable dt = dataManager.ExecuteQuery("uspGetAllClientes", null);

            lst = (from DataRow row in dt.Rows
                   select new clsCliente
                   {
                       Id = Convert.ToInt32(row["Id"]),
                       Nombres = row["Nombres"].ToString(),
                       Apellidos = row["Apellidos"].ToString(),
                       TipoIdentificacion = Convert.ToInt32(row["IdTipoIdentificacion"]),
                       Identificacion = row["Identificacion"].ToString(),
                       Activo=Convert.ToBoolean(row["Activo"]),
                       FechaCreacion=Convert.ToDateTime(row["FechaCreacion"]),
                       Telefono=row["Telefono"].ToString(),
                       Celular=row["Celular"].ToString(),
                       Direccion=row["Direccion"].ToString(),
                       Nacionalidad=row["Nacionalidad"].ToString()
                   }).ToList();

            return lst;
        }
        public clsCliente GetById(string identificacion="",int customerId=0)
        {
            clsCliente customer = new clsCliente();
            
            if (identificacion != "")
            {
                customer=GetAll().Where(c => c.Identificacion == identificacion).FirstOrDefault();
            }
            else if (customerId!=0)
            {
                customer= GetAll().Where(c => c.Id == customerId).FirstOrDefault();
            }
            
            return customer;
        }
    }
}
