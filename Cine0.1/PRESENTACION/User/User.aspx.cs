using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRESENTACION.User
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///lblUsuario.Text = Session["UserLogeado"].ToString();
            lblUsuario.Text = "usuarioprueba";
        }

        public void cerrarSesion_Click()
        {
            Session["UserLogeado"] = null;
            Response.Redirect("Inicio.aspx");
        }
    }
}