using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRESENTACION
{
    public partial class User_Contrasenia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NivelUser"].ToString() == "0")
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
    }
}