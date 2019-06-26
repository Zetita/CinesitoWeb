using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTIDAD;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class Admin_Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.WebForms;
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "/Scripts/jquery-1.8.0.js"
            });

            if (!IsPostBack)
            {
                cargarGrilla();

            }
        }
        public void cargarGrilla()
        {
            n_Usuario n_usuario = new n_Usuario();
            grdUsuarios.DataSource = n_usuario.ObtenerTablaTodos();
            grdUsuarios.DataBind();
        }

        protected void btnCargarTodos_Click(object sender, EventArgs e)
        {
            n_Usuario n_usuario = new n_Usuario();
            grdUsuarios.DataSource = n_usuario.ObtenerTablaTodos();
            grdUsuarios.DataBind();
        }

        protected void btnUsuarios_Click(object sender, EventArgs e)
        {
            n_Usuario n_usuario = new n_Usuario();
            grdUsuarios.DataSource = n_usuario.ObtenerTablaUsuarios();
            grdUsuarios.DataBind();
        }

        protected void btnAdmins_Click(object sender, EventArgs e)
        {
            n_Usuario n_usuario = new n_Usuario();
            grdUsuarios.DataSource = n_usuario.ObtenerTablaAdmins();
            grdUsuarios.DataBind();
        }
        protected void grdSnacks_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdUsuarios.PageIndex = e.NewPageIndex;
            cargarGrilla();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if(rfv1.IsValid && rfv2.IsValid && rfv3.IsValid && rfv4.IsValid && rfv5.IsValid 
                && rfv6.IsValid && rfv7.IsValid && rfv8.IsValid && rfv9.IsValid)
            {
                Usuario usuario = new Usuario();
                usuario.User = txtUsuario.Text;
                usuario.Contrasenia = txtContrasenia.Text;
                usuario.Email = txtEmail.Text;
                usuario.Apellido = txtApellidos.Text;
                usuario.Nombre = txtNombres.Text;
                usuario.Dni = txtDni.Text;
                usuario.Telefono = txtTelefono.Text;
                if (rbtnAdmin.SelectedValue.ToString() == "1")
                    usuario.Administrador = true;
                else
                    usuario.Administrador = false;
                usuario.Activo = true;

                n_Usuario n_usuario = new n_Usuario();
                if (n_usuario.agregarUsuario(usuario))
                {
                    lblAgregado.Text = "Exito al agregar";
                    lblAgregado.ForeColor = System.Drawing.Color.Green;
                    cargarGrilla();

                }
                else
                {
                    lblAgregado.Text = "Error al agregar.";
                    lblAgregado.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblAg.Text = "Complete los campos necesarios!";
            }
        }
    }
}