using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRESENTACION
{
    public partial class Resultados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Filtro = Session["Filtro"].ToString();
            lblResultado.Text=("Resultados de '"+Filtro+"'").ToUpper();

        }

        protected void imgbtn_Pelicula_Command1(object sender, CommandEventArgs e)
        {
            Application["ID_Pelicula"] = e.CommandName.Trim();
            Response.Redirect("Peliculas.aspx");
        }
    }
}