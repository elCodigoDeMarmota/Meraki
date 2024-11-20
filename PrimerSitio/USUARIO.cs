using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace PrimerSitio
{
    public class USUARIO
    {
        string conexion = WebConfigurationManager.ConnectionStrings["LOCAL"].ConnectionString;

        public string ProbarConexion()
        {
            string Resultado = null;
            try
            {
                SqlConnection conn = new SqlConnection(conexion);
                conn.Open();
                Resultado = "Conexión exitosa";
                return Resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable Autentificación(string user, string pass)
        {
            SqlDataReader dr = null;
            DataTable dt = new DataTable();
            try
            {
                #region Paso 1: Abrir Conecion
                SqlConnection conn = new SqlConnection(conexion); 
                conn.Open(); //Abrir conexion
                #endregion
                #region Paso 2: Llamar al procedimiento"
                SqlCommand cmd = new SqlCommand("autentificacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso 3: Pasar parametros
                cmd.Parameters.Add("@user", SqlDbType.VarChar, 60);
                cmd.Parameters["@user"].Value = user;

                cmd.Parameters.Add("@pass", SqlDbType.VarChar, 60);
                cmd.Parameters["@pass"].Value = pass;
                #endregion
                #region Paso 4: Ejecuto el prodecimiento
                dr = cmd.ExecuteReader();
                dt.Load(dr);// cargamos datatable
                #endregion
                #region cierro conexion y dr
                dr.Close();
                conn.Close();
                #endregion
                return dt; 

            }
            catch (Exception EX)
            {

                throw EX;
            }
        }

        public DataTable ListaRol()
        {
            DataTable dt = new DataTable();
            SqlDataReader dr = null;
            try
            {
                #region Paso 1: Abrir Conecion
                SqlConnection conn = new SqlConnection(conexion);
                conn.Open(); //Abrir conexion
                #endregion
                #region Paso 2: Llamar al procedimiento"
                SqlCommand cmd = new SqlCommand("ListaRol", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso 4: Ejecuto el prodecimiento
                dr = cmd.ExecuteReader();
                dt.Load(dr);// cargamos datatable
                #endregion
                #region cierro conexion y dr
                dr.Close();
                conn.Close();
                #endregion
                return dt;




            }
            catch (Exception)
            {

                throw;
            }
        }

        public void GuardaUsuario(string Nombre, string Email, string User, string Clave, int RolID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("GuardaUsuario", conn)) 
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregamos parámetros del procedimiento
                        cmd.Parameters.AddWithValue("@Nombre", Nombre);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@User", User);
                        cmd.Parameters.AddWithValue("@Clave", Clave);
                        cmd.Parameters.AddWithValue("@RolID", RolID);

                        //se ejecuta el procedimiento
                        cmd.ExecuteNonQuery();
                    }

                }

            }
            catch (Exception ex)
            {

                throw new Exception("Error al guardar el usuario: " + ex.Message);
            }
        }
    }
}