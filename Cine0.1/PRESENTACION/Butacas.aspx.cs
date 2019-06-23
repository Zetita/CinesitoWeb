using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using DAO;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class Butacas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAO_BxF BxF = new DAO_BxF();
            DAO_Funciones Funcion = new DAO_Funciones();
            //string ID_Funcion = Application["ID_Funcion"].ToString();
            string ID_Funcion = "1";
            string Consulta = "Select * from ButacaxFunciones where ID_Funcion=" + ID_Funcion;
            DataTable dt = BxF.ObtenerTablaBxF(Consulta);
            if(!IsPostBack) Application["CantEntradasT"] = Application["CantEntradas"] = 10;
            string NombreBoton;

            for (int x = 1; x <= 44; x++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (x.ToString() == dt.Rows[j]["ID_Butaca"].ToString().Trim())
                    {
                        NombreBoton = "btn" + x.ToString();
                        Colorear(Page, NombreBoton);
                    }
                }
                
            }

            Consulta = ArmarConsultaHeavy(ID_Funcion);
            dt = Funcion.ObtenerTablaFunciones(Consulta);
            LlenarResumen(dt);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Peliculas.aspx");
        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            Response.Redirect("Compras.aspx");
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
        }

        public string ArmarConsultaHeavy(string ID)
        {
            string Consulta = "Select Peliculas.ImagenURL,Peliculas.Titulo_Pelicula,Formatos.Idioma_Formato,Formatos.Nombre_Formato,Formatos.Precio_Formato,Formatos.Subtitulos_Formato, " +
                "Salas.Sala, Sucursales.Nombre_Sucursal,Sucursales.Direccion_Sucursal,Sucursales.Localidad_Sucursal,Sucursales.Provincia_Sucursal from Funciones " +
                "Inner Join PeliculasxFormatos on Funciones.ID_PxF = PeliculasxFormatos.ID_PxF " +
                "Inner Join Peliculas on PeliculasxFormatos.ID_Pelicula = Peliculas.ID_Pelicula " +
                "Inner Join Formatos on PeliculasxFormatos.ID_Formato = Formatos.ID_Formato " +
                "Inner Join Salas on Funciones.ID_Sala = Salas.ID_Sala " +
                "Inner Join Sucursales on Funciones.ID_Sucursal = Sucursales.ID_Sucursal " +
                "where Funciones.ID_Funcion = "+ID;
            return Consulta;
        }

        public static void Colorear(Page Pagina, string Nombre)
        {
            Button Boton;
            foreach (Control ctrl in Pagina.Form.Controls)
            {
                foreach (Control Control in ctrl.Controls)
                    if (Control is Button)
                    {
                        Boton = (Button)Control;
                        if (Boton.ID == Nombre)
                        {
                            Boton.BackColor = Color.Red;
                        }
                    }
            }
        }

        protected void Colorear2(object sender, EventArgs e)
        {
            Button Clickeado = (Button)sender;
            if (Clickeado.BackColor == Color.Green)
            {
                if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                {
                    Clickeado.BackColor = Color.Empty;
                    Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                }
            }
            else
            {
                if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                {
                    Clickeado.BackColor = Color.Green;
                    Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                }
            }
        }

    }
}