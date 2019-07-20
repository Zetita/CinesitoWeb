using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NEGOCIO;

namespace PRESENTACION.User
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NivelUser"].ToString() == "1")
                lbConfig.Visible = true;
            else
                lbConfig.Visible = false;

            lblUsuario.Text = Session["UserLogeado"].ToString();
            CargarGridView();
            if (!(grdCompras.Rows.Count > 0))
            {
                lblSinCompras.Text = "Aun no has comprado entradas, revisa la cartelera para comprar.";
            }
        }

        protected void lbCerrar_Click(object sender, EventArgs e)
        {
            Session["UserLogeado"] = null;
            Response.Cookies["Mensaje"].Value = "3";
            Response.Cookies["Mensaje"].Expires = DateTime.Now.AddHours(1);
            Response.Redirect("Inicio.aspx");
        }

        public string ArmarConsulta()
        {
            string Consulta;
            Consulta = " Select Peliculas.Titulo_Pelicula as Pelicula, Funciones.FechaHora_Funcion as Funcion, " +
                     " Salas.Sala as Sala, Sucursales.Nombre_Sucursal as Sucursal, " +
                     " DetalleVentas.Fila_Butaca as Fila, DetalleVentas.Butaca as Butaca from Ventas " +
                     " Inner Join DetalleVentas on DetalleVentas.ID_Venta = Ventas.ID_Venta " +
                     " Inner Join Funciones on DetalleVentas.ID_Funcion = Funciones.ID_Funcion " +
                     " Inner Join Peliculas on Peliculas.ID_Pelicula = Funciones.ID_Pelicula " +
                     " Inner Join Salas on Salas.ID_Sala = Funciones.ID_Sala " +
                     " Inner Join Sucursales on Sucursales.ID_Sucursal = Funciones.ID_Sucursal " +
                     " Where Ventas.Usuario_Venta = '" + lblUsuario.Text + "'";
            return Consulta;
        }

        protected void grdCompras_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdCompras.PageIndex = e.NewPageIndex;
            CargarGridView();
        }

        public void CargarGridView()
        {
            n_Venta n_venta = new n_Venta();
            DataTable dt = new DataTable();
            string Consulta = string.Empty;
            Consulta = ArmarConsulta();
            dt = n_venta.ObtenerTabla(Consulta);
            grdCompras.DataSource = dt;
            grdCompras.DataBind();
        }

        protected void lbConfig_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Admin_Peliculas.aspx");
        }
    }
}