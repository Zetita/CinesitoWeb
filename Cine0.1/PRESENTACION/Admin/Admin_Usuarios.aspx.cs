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
        void ClearInputs(ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                ClearInputs(ctrl.Controls);
            }
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
                DateTime dt = DateTime.Parse(txtFecNac.Text);
                usuario.FechaNac = dt;

                if (rbtnAdmin.SelectedValue.ToString() == "1")
                    usuario.Administrador = true;
                else
                    usuario.Administrador = false;
                usuario.Activo = true;

                n_Usuario n_usuario = new n_Usuario();
                if (n_usuario.agregarUsuario(usuario))
                {
                    lblAgregado.Text = "Cargado exitosamente.";
                    lblAgregado.ForeColor = System.Drawing.Color.Green;
                    cargarGrilla();
                    ClearInputs(Page.Controls);

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

        protected void grdUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int codigo = Int32.Parse(((Label)grdUsuarios.Rows[e.RowIndex].FindControl("lbl_IdUsuario")).ToString());

            Usuario usuario = new Usuario();
            usuario.idUsuario = codigo;
            usuario.Activo = false;

            n_Usuario n_usuario = new n_Usuario();
            n_usuario.eliminarUsuario(usuario);
           
            cargarGrilla();
        }
        protected void grdUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdUsuarios.EditIndex = e.NewEditIndex;
            cargarGrilla();
        }

        protected void grdUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String s_Usuario = ((Label)grdUsuarios.Rows[e.RowIndex].FindControl("lbl_eit_Usuario")).Text;
            String s_Contrasenia = ((TextBox)grdUsuarios.Rows[e.RowIndex].FindControl("txt_eit_Contrasenia")).Text;
            String s_Email = ((TextBox)grdUsuarios.Rows[e.RowIndex].FindControl("txt_eit_Email")).Text;
            String s_Apellidos = ((TextBox)grdUsuarios.Rows[e.RowIndex].FindControl("txt_eit_Apellidos")).Text;
            String s_Nombres = ((TextBox)grdUsuarios.Rows[e.RowIndex].FindControl("txt_eit_Nombres")).Text;
            String s_DNI = ((TextBox)grdUsuarios.Rows[e.RowIndex].FindControl("txt_eit_DNI")).Text;
            String s_Telefono = ((TextBox)grdUsuarios.Rows[e.RowIndex].FindControl("txt_eit_Telefono")).Text;
            DateTime dt_FechaNac = DateTime.Parse(((TextBox)grdUsuarios.Rows[e.RowIndex].FindControl("txt_eit_FecNac")).Text);
            bool b_Activo, b_Admin;
            if (((CheckBox)grdUsuarios.Rows[e.RowIndex].FindControl("cb_eit_Activo")).Checked == true)
                b_Activo = true;
            else
                b_Activo = false;

            if (((CheckBox)grdUsuarios.Rows[e.RowIndex].FindControl("cb_eit_Admin")).Checked == true)
                b_Admin = true;
            else
                b_Admin = false;

            Usuario usuario = new Usuario();
            usuario.User = s_Usuario;
            usuario.Contrasenia = s_Contrasenia;
            usuario.Email = s_Email;
            usuario.Apellido = s_Apellidos;
            usuario.Nombre = s_Nombres;
            usuario.Dni = s_DNI;
            usuario.Telefono = s_Telefono;
            usuario.FechaNac = dt_FechaNac;
            usuario.Activo = b_Activo;
            usuario.Administrador = b_Admin;

            n_Usuario n_usuario = new n_Usuario();
            n_usuario.editarUsuario(usuario);

            grdUsuarios.EditIndex = -1;
            cargarGrilla();
        }

        protected void grdUsuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdUsuarios.EditIndex = -1;
            cargarGrilla();
        }

        protected void grdUsuarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdUsuarios.PageIndex = e.NewPageIndex;
            cargarGrilla();
        }
    }
}