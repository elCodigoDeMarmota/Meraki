using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerSitio
{
    public partial class LOGIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProbar_Click(object sender, ImageClickEventArgs e)
        {
            USUARIO Us= new USUARIO();//Instanciar la clase
            string mensaje = null;
            DataTable dt = new DataTable();
            try
            {
                //mensaje = Us.ProbarConexion(); // estoy llamando a un metodo de la clase
                //lblMensaje.Text= mensaje;
                dt =Us.Autentificación(txtUser.Text, txtClave.Text);
                if (dt.Rows.Count > 0)
                {
                    //variables de sesión, siempre lo va a guardar como string
                    Session["Rol"] = dt.Rows[0]["USU_ROL_ID"].ToString();
                    Session["NombreUsuario"] = dt.Rows[0]["USU_NOMBRE"].ToString();
                    lblMensaje.Text = "Bienvenido " + Session["NombreUsuario"].ToString();
                    if (Session["Rol"].ToString() == "1")  /*Es Admin*/
                    {
                        Response.Redirect("Home.aspx");
                    }
                    if (Session["Rol"].ToString() == "2") /*Es Supervisor*/
                    {
                        Response.Redirect("HomeSupervisor.aspx");
                    }
                }
                else
                {
                    lblMensaje.Text = "Usuario no existe";
                }
            }
            catch (Exception ex)
            {

            throw ex;
            }
        }
    }
}