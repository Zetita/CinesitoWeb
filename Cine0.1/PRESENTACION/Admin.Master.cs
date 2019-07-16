using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRESENTACION
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkUsuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Admin_Usuarios.aspx");
        }

        protected void LinkSucursales_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Admin_Sucursales.aspx");
        }

        protected void LinkPeliculas_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Admin_Peliculas.aspx");
        }


        protected void LinkFormatos_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Admin_Formatos.aspx");
        }

        protected void LinkFunciones_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Admin_Funciones.aspx");
        }

        protected void LinkSnacks_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Admin_Snacks.aspx");
        }

        protected void LinkVentas_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Admin_Ventas.aspx");
        }
    }
}