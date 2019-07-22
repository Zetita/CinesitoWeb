using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
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
            if (!IsPostBack)
            {
                txtNacimiento.Attributes.Add("placeholder", "dd/mm/aaaa");
            }

            
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
        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            n_Usuario n_usuario = new n_Usuario();
         

            if(rfv1.IsValid && rfv2.IsValid && rfv3.IsValid && rfv4.IsValid && rfv5.IsValid && rfv6.IsValid && rfv7.IsValid && rfv8.IsValid)
            {
                if(n_usuario.estaRegistrado(txtUsuario.Text))
                {
                    lblError.Text = "Usuario no disponible" + "<br>";
                    if (n_usuario.estaRegistradoEmail(txtEmail.Text))
                    {
                        lblError.Text += "Email ya se encuentra registrado";
                        return;
                    }
                    return;
                }
                if(n_usuario.estaRegistradoEmail(txtEmail.Text))
                {
                    lblError.Text += "Email ya se encuentra registrado";
                    return;
                }


                DateTime CreatdDate = DateTime.ParseExact(txtNacimiento.Text, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                
                usuario.User = txtUsuario.Text;
                usuario.Contrasenia = txtContrasenia.Text; 
                usuario.Email = txtEmail.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.Nombre = txtNombre.Text;
                usuario.Dni = txtDni.Text;
                usuario.Telefono = txtTelefono.Text;
                usuario.FechaNac = CreatdDate;
                usuario.Activo = true;
                usuario.Administrador = false;

                if (!(n_usuario.estaRegistrado(txtUsuario.Text)))
                {
                    if (n_usuario.agregarUsuario(usuario))
                    {
                        AgregarImagen();
                        lblAdd.Text = "USUARIO REGISTRADO.";
                        lblAdd.ForeColor = System.Drawing.Color.Blue;
                        ClearInputs(Page.Controls);
                    }
                    else
                    {
                        lblAdd.Text = "ERROR AL REGISTRAR, INTENTELO NUEVAMENTE.";
                        lblAdd.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    lblAdd.Text = "NOMBRE DE USUARIO EXISTENTE.";
                    lblAdd.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblAdd.Text = "COMPLETE LOS CAMPOS MARCADOS.";
                lblAdd.ForeColor = System.Drawing.Color.Red;
            }
        }
        
        public void AgregarImagen()
        {
            string archivoOrigen = Server.MapPath(string.Format("~/Recursos/user.png"));
            string rutaDestino = Server.MapPath(string.Format("~/img/user/" + txtUsuario.Text + ".png"));
            File.Copy(archivoOrigen, rutaDestino);
        }

        protected void btnInicioSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("/LogIn.aspx");
        }
    }
}