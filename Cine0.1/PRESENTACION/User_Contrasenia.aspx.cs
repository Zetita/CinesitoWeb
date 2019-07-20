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
    public partial class User_Contrasenia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtVieja.Attributes.Add("placeholder", "Contraseña actual");
            txtNueva.Attributes.Add("placeholder", "Contraseña nueva");
            txtConfirmar.Attributes.Add("placeholder", "Repita la nueva contraseña");


            if (Session["NivelUser"].ToString() == "1")
                lbConfig.Visible = true;
            else
                lbConfig.Visible = false;

            
            lblUsuario.Text = Session["UserLogeado"].ToString();
        }

        protected void lbCerrar_Click(object sender, EventArgs e)
        {
            Session["UserLogeado"] = null;
            Response.Cookies["Mensaje"].Value = "3";
            Response.Cookies["Mensaje"].Expires = DateTime.Now.AddHours(1);
            Response.Redirect("Inicio.aspx");
        }

        protected void lbConfig_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Admin_Peliculas.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            n_Usuario n_usuario = new n_Usuario();
            lblOldPassIncorrecta.Visible = false;
            lblNewPassRepetida.Visible = false;
            lblNewPassDiferente.Visible = false;

            if (n_usuario.estaRegistrado(Session["UserLogeado"].ToString(), txtVieja.Text) == false)
            {
                lblOldPassIncorrecta.Visible = true;
                lblOldPassIncorrecta.Text = "Contraseña incorrecta.";
            }
            else
            {

                if(txtNueva.Text==txtVieja.Text)
                {
                    lblNewPassRepetida.Visible = true;
                    lblNewPassRepetida.Text = "Contraseña debe ser diferente a la actual.";
                }
                
               
                if(txtNueva.Text==txtConfirmar.Text)
                {
                    //guardarlo
                    lblGuardado.Visible = true;
                    lblGuardado.Text = "Se ha cambiado la contraseña exitosamente.";
                }
                else
                {
                    lblNewPassDiferente.Visible = true;
                    lblNewPassDiferente.Text = "Los campos confirmación de nueva contraseña y nueva contraseña no coinciden.";

                }
              

            }

               
        }

    }
}