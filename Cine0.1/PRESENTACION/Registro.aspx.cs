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
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.WebForms;
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "/Scripts/jquery-1.8.0.js"
            });
        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if(rfv1.IsValid && rfv2.IsValid && rfv3.IsValid && rfv4.IsValid && rfv5.IsValid && rfv6.IsValid && rfv7.IsValid && rfv8.IsValid)
            {
                Usuario usuario = new Usuario();
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.Dni = txtDni.Text;
                usuario.FechaNac = txtNacimiento.;
                usuario.Email = txtEmail.Text;
                usuario.User = txtUsuario.Text;
                usuario.Contrasenia = txtContrasenia.Text;
                usuario.Telefono = txtTelefono.Text;

                n_Usuario n_usuario = new n_Usuario();

                if(n_usuario.estaRegistrado(usuario))
            }
        }
    }
}