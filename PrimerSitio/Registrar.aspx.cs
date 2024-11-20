using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerSitio
{
    public partial class Registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CargaDropRol();
            }
        }

        public void CargaDropRol()
        {
            USUARIO USU = new USUARIO();
            try
            {
                ddlRol.DataSource = USU.ListaRol();
                ddlRol.DataTextField = "NOMBRE";
                ddlRol.DataValueField = "ID";
                ddlRol.DataBind();
                ddlRol.Items.Insert(0, new ListItem("Seleccionar", "-1"));
            }
            catch (Exception ex )
            {

                lblMensaje.Text = "Error al cargar los roles: " + ex.Message;
            }
        }

        

       
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlRol.SelectedValue == "-1")
                {
                    lblMensaje.Text = "Por favor selecciona un rol válido.";
                    return;
                }

                string Nombre = txtNombre.Text; 
                string Email = txtEmail.Text; 
                string User = txtUsuario.Text;
                string Clave = txtContraseña.Text; 
                int RolID = Convert.ToInt32(ddlRol.SelectedValue); 

                USUARIO USU = new USUARIO();
                USU.GuardaUsuario(Nombre,Email,User, Clave, RolID);

                lblMensaje.Text = "Usuario registrado exitosamente.";

                // Limpiar formulario
                txtNombre.Text = "";
                txtUsuario.Text = "";
                txtEmail.Text = "";
                txtContraseña.Text = "";
                txtEmail.Text = "";
                ddlRol.SelectedIndex = -1; 

            }
            catch (Exception)
            {

                lblMensaje.Text = "Error al registrar usuario" + ddlRol.SelectedItem.Text; ;
            }

        }
    }
}