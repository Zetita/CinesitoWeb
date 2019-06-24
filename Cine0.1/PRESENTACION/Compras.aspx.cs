using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class Compras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            n_BxF BxF = new n_BxF();
            n_Funcion Funcion = new n_Funcion();

            //string ID_Funcion = Application["ID_Funcion"].ToString();
            int Cantidad = Convert.ToInt32(Application["Cantidad"].ToString());
            double Precio = Convert.ToDouble(Application["Precio"].ToString()) * Cantidad;
            string ID_Funcion = "1";
            string Consulta = ArmarConsultaHeavy(ID_Funcion);

            DataTable dt = Funcion.ObtenerTabla(Consulta);
            LlenarResumen(dt);

            
            lblEntrada.Text = "Precio Entrada x"+Cantidad;
            lblTotal.Text = "Total";
            lblPrecioFinal.Text = "$" + Precio.ToString();
            lblPrecio.Text = "$" + Convert.ToDouble(Application["PrecioTotal"].ToString());
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Butacas.aspx");
        }

        public string ArmarConsultaHeavy(string ID)
        {
            string Consulta = "Select Peliculas.ImagenURL,Peliculas.Titulo_Pelicula,Formatos.Idioma_Formato,Formatos.Nombre_Formato,Formatos.Precio_Formato,Formatos.Subtitulos_Formato, " +
                "Salas.Sala, Sucursales.Nombre_Sucursal,Sucursales.Direccion_Sucursal,Sucursales.Localidad_Sucursal,Sucursales.Provincia_Sucursal,datename(dw,Funciones.FechaHora_Funcion) as DiaSemana, " +
                "DATEPART(dd,Funciones.FechaHora_Funcion) as Dia,DATENAME(mm,Funciones.FechaHora_Funcion) as Mes,DATEPART(hh,Funciones.FechaHora_Funcion) as Hora,DATEPART(n,Funciones.FechaHora_Funcion) as Minuto " +
                "from Funciones " +
                "Inner Join PeliculasxFormatos on Funciones.ID_PxF = PeliculasxFormatos.ID_PxF " +
                "Inner Join Peliculas on PeliculasxFormatos.ID_Pelicula = Peliculas.ID_Pelicula " +
                "Inner Join Formatos on PeliculasxFormatos.ID_Formato = Formatos.ID_Formato " +
                "Inner Join Salas on Funciones.ID_Sala = Salas.ID_Sala " +
                "Inner Join Sucursales on Funciones.ID_Sucursal = Sucursales.ID_Sucursal " +
                "where Funciones.ID_Funcion = " + ID;
            return Consulta;
        }

        public void LlenarResumen(DataTable dt)
        {
            imgPelicula.ImageUrl = dt.Rows[0]["ImagenURL"].ToString();
            lblNombre.Text = dt.Rows[0]["Titulo_Pelicula"].ToString().ToUpper();
            if (dt.Rows[0]["Subtitulos_Formato"].ToString() == "False")
            {
                lblFormato.Text = dt.Rows[0]["Nombre_Formato"] + " - Audio " + dt.Rows[0]["Idioma_Formato"];
            }
            else
            {
                lblFormato.Text = dt.Rows[0]["Nombre_Formato"] + " - Subtitulos " + dt.Rows[0]["Idioma_Formato"];
            }
            lblSucursal.Text = dt.Rows[0]["Nombre_Sucursal"].ToString().TrimEnd() + " - Sala " + dt.Rows[0]["Sala"].ToString().TrimEnd();
            lblDireccion.Text = dt.Rows[0]["Direccion_Sucursal"].ToString().TrimEnd() + ", " + dt.Rows[0]["Localidad_Sucursal"].ToString().TrimEnd() + ", " + dt.Rows[0]["Provincia_Sucursal"].ToString().TrimEnd();
            lblFecha.Text = dt.Rows[0]["DiaSemana"].ToString() + " " + dt.Rows[0]["Dia"].ToString() + " de " + dt.Rows[0]["Mes"].ToString() + " - " + dt.Rows[0]["Hora"] + ":" + dt.Rows[0]["Minuto"];
            Application["Precio"] = Convert.ToDouble(dt.Rows[0]["Precio_Formato"].ToString());
        }
    }
}