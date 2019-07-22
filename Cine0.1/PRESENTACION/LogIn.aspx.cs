using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTIDAD;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.WebForms;
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "/Scripts/jquery-1.8.0.js"
            });
            txtUsuario.Focus();

        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            if (rfv1.IsValid && rfv2.IsValid)
            {
                n_Usuario n_usuario = new n_Usuario();
                DataTable dt = new DataTable();
                if (n_usuario.estaRegistrado(txtUsuario.Text, txtContrasenia.Text) == true)
                {
                    Session["UserLogeado"] = txtUsuario.Text;

                    if (n_usuario.esAdministrador(Session["UserLogeado"].ToString()))
                    {
                        Session["NivelUser"] = "1";
                        Response.Redirect("/Admin/Admin_Peliculas.aspx");
                    }
                    else
                    {
                        Session["NivelUser"] = "0";
                        Response.Cookies["Mensaje"].Value = "4";
                        Response.Cookies["Mensaje"].Expires = DateTime.Now.AddHours(1);
                        Response.Redirect("~/Inicio.aspx");
                    }
                }
                else
                {
                    lblAdv2.Text = "USUARIO Y/O CONTRASEÑA INCORRECTOS.";
                    lblAdv2.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Registro.aspx");
        }
    }
}