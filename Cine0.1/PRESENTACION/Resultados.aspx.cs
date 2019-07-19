using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;
using System.Data;

namespace PRESENTACION
{
    public partial class Resultados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Filtro = Session["Filtro"].ToString();
            string Consulta = "Select [ImagenURL], LTRIM(RTRIM([Titulo_Pelicula])),[ID_Pelicula] From Peliculas where Titulo_Pelicula LIKE'%" + Filtro + "' or Titulo_Pelicula LIKE'%" + Filtro + "%' or Titulo_Pelicula LIKE'" + Filtro + "%'";
            n_Pelicula n_Pel = new n_Pelicula();
            DataTable dt = n_Pel.ObtenerTabla(Consulta);
            lblResultado.Text=("Resultados de '"+Filtro+"'").ToUpper();

            sqldsFuente.SelectCommand = Consulta;
        }

        protected void imgbtn_Pelicula_Command1(object sender, CommandEventArgs e)
        {
            Application["ID_Pelicula"] = e.CommandName.Trim();
            Response.Redirect("Peliculas.aspx");
        }
    }
}