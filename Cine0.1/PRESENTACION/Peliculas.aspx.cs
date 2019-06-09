using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace PRESENTACION
{
    public partial class Peliculas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Consulta = "Select * from Peliculas";
            string Ruta = "Data Source=localhost\\sqlexpress;Initial Catalog=CineFrenz; Integrated Security=true";
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Ruta);
            SqlDataAdapter adp = new SqlDataAdapter(Consulta, cn);
            cn.Open();
            adp.Fill(ds, "Peliculas");
            cn.Close();
            dt = ds.Tables["Peliculas"];
            lblNombre.Text = dt.Rows[0]["Titulo_Pelicula"].ToString();
            lblSinopsis.Text = dt.Rows[0]["Sinopsis_Pelicula"].ToString();
            lblGenero.Text = "Genero: " + dt.Rows[0]["Genero_Pelicula"].ToString() + ".";
            lblDuracion.Text = "Duración: " + dt.Rows[0]["Duración"].ToString() + " horas.";
            lblDirector.Text = "Director: " + dt.Rows[0]["Director_Pelicula"].ToString() + ".";
        }
    }
}