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
    public partial class RepEntxPel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrilla();
                Contar();
            }
        }

        public void CargarGrilla()
        {
            string Consulta = ArmarConsulta();
            n_Venta n_Ven = new n_Venta();
            grdEntxPel.DataSource = n_Ven.ObtenerTabla(Consulta);
            grdEntxPel.DataBind();
            
        }

        public string ArmarConsulta()
        {
            return "Select Peliculas.Titulo_Pelicula,Sum(Ventas.CantEntradas_Venta) as Cantidad From Ventas " +
                   " Inner Join DetalleVentas on DetalleVentas.ID_Venta = Ventas.ID_Venta " +
                   " Inner Join Funciones on Funciones.ID_Funcion = DetalleVentas.ID_Funcion " +
                   " Inner Join Peliculas on Peliculas.ID_Pelicula = Funciones.ID_Pelicula " +
                   " Group By Peliculas.Titulo_Pelicula Order by Cantidad desc ";
        }

        protected void grdEntxPel_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdEntxPel.PageIndex = e.NewPageIndex;
            CargarGrilla();
        }

        public void Contar()
        {
            string Consulta = ArmarConsulta();
            n_Venta n_Ven = new n_Venta();
            DataTable dt = n_Ven.ObtenerTabla(Consulta);
            if (dt.Rows.Count > 0)
            {
                lblSinVentas.Visible = false;
                lblTotal.Text = "La pelicula con mayor cantidad de entradas vendidas es " + dt.Rows[0]["Titulo_Pelicula"] +
                    " con un total de " + dt.Rows[0]["Cantidad"] + " entradas.";
            }
            else
            {
                lblTotal.Visible = false;
                grdEntxPel.Visible = false;
                lblSinVentas.Visible = true;
                lblSinVentas.Text = "Aun no ha habido ninguna venta.";
            }

        }
    }
}