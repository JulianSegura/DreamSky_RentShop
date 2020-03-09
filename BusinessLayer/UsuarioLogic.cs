﻿using System;
using System.Collections.Generic;
using System.Text;
using DreamSkyEntities;
using DataAccessLayer;
using System.Data;
using System.Linq;

namespace BusinessLayer
{
    public class UsuarioLogic
    {
        DatabaseManager dataManager = new DatabaseManager();

        public string Insert(clsUsuario newUser)
        {
            string result = "";
            List<DataParameter> parameters = new List<DataParameter>();

            try
            {
                //Parametros de entrada

                parameters.Add(new DataParameter("@Nombres", newUser.Nombres));
                parameters.Add(new DataParameter("@Apellidos", newUser.Apellidos));
                parameters.Add(new DataParameter("@Usuario", newUser.UserName));
                parameters.Add(new DataParameter("@Password", newUser.Password));
                parameters.Add(new DataParameter("@IdRol", newUser.Rol.Id));
                
                //parametros de salida
                parameters.Add(new DataParameter("@Resultado", SqlDbType.VarChar, 100));

                dataManager.ExecuteStoreProc("uspInsertUser", parameters);
                result = parameters[5].Value.ToString();
            }
            catch (Exception ex)
            {

                result = ex.Message;
            }

            return result;
        }

        public string Update(clsUsuario user)
        {
            string result = "";

            List<DataParameter> parameters = new List<DataParameter>();

            try
            {
                //Parametros de entrada

                parameters.Add(new DataParameter("@Id", user.Id));
                parameters.Add(new DataParameter("@Nombres", user.Nombres));
                parameters.Add(new DataParameter("@Apellidos", user.Apellidos));
                parameters.Add(new DataParameter("@Usuario", user.UserName));
                parameters.Add(new DataParameter("@Password", EncodeText(user.Password)));
                parameters.Add(new DataParameter("@IdRol", user.Rol.Id));
                parameters.Add(new DataParameter("@Estado", user.Activo));
                
                //parametros de salida
                parameters.Add(new DataParameter("@Resultado", SqlDbType.VarChar, 100));

                dataManager.ExecuteStoreProc("uspUpdatetUser", parameters);
                result = parameters[5].Value.ToString();
            }
            catch (Exception ex)
            {

                result = ex.Message;
            }

            return result;
        }
        
        public DataTable GetAll()
        {
            return dataManager.ExecuteQuery("uspGetAllUsers", null);
        }

        public clsUsuario Validate(string userName,string password)
        
        /* consulto el userName en BD (listo)
         * si existe, traigo el user completo (listo)
         * verifico el rolId y creo la entidad Rol , la entidad Rol trae los permisos.*/
        {
            DataTable dt;
            clsUsuario user= new clsUsuario();
            List<DataParameter> parameters = new List<DataParameter>();

            try
            {
                //Parametros de entrada
                parameters.Add(new DataParameter("@Usuario", userName));
                parameters.Add(new DataParameter("@Password", EncodeText(password)));
                
                //parametros de salida
                parameters.Add(new DataParameter("@Resultado", SqlDbType.VarChar, 100));

                dt= dataManager.ExecuteQuery("uspGetUserByUserName", parameters);
                
            }
            catch (Exception ex)
            {

                throw ex;
            }

            if (dt.Rows.Count == 0)
            {
                user = null;
            }
            else
            {
                user.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                user.Nombres = Convert.ToString(dt.Rows[0]["Nombres"]);
                user.Apellidos = Convert.ToString(dt.Rows[0]["Apellidos"]);
                user.Rol.Id = Convert.ToInt32(dt.Rows[0]["IdRol"]);
                user.Activo= Convert.ToBoolean(dt.Rows[0]["Activo"]);
                user.fechaCreacion= Convert.ToDateTime(dt.Rows[0]["fechaCreacion"]);
                //consultar el rol y asignar permisos
            }
            
            return user;
        } 

        private string EncodeText(string textToEncode)
        {
            byte[] textToEncodeBytes = ASCIIEncoding.ASCII.GetBytes(textToEncode);
            string encodedPass = Convert.ToBase64String(textToEncodeBytes);

            return encodedPass;
        }

        private string DecodeText(string textToDecode)
        {
            byte[] textToDecodeBytes = Convert.FromBase64String(textToDecode);
            string decodedPass = ASCIIEncoding.ASCII.GetString(textToDecodeBytes);

            return decodedPass;
        }

    }
}