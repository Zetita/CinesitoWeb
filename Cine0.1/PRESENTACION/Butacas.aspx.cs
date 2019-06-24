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
            n_BxF BxF = new n_BxF();
            n_Funcion Funcion = new n_Funcion();
            string ID_Funcion = Application["ID_Funcion"].ToString();
            //string ID_Funcion = "1";
            string Consulta = "Select * from ButacaxFunciones where ID_Funcion=" + ID_Funcion;
            DataTable dt = BxF.ObtenerTabla(Consulta);

            if (!IsPostBack)
            {
                Application["CantEntradasT"] = Application["CantEntradas"] = 10;
            }
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
            dt = Funcion.ObtenerTabla(Consulta);
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

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            Application["ButacasReservadas"] = null;
            int Cantidad;
            Application["Cantidad"]= Cantidad = SacarCantidad();
            double Precio = Convert.ToDouble(Application["Precio"].ToString()) * Cantidad;
            if (Cantidad != 0)
            {
                lblEntrada.Text = "Precio unitario Entrada";
                lblTotal.Text = "Total";
                lblPrecioFinal.Text = "$" + Precio.ToString();
                Application["PrecioTotal"] = lblPrecio.Text = "$" + Convert.ToDouble(Application["Precio"].ToString());
                btnSiguiente.Enabled = true;
            }
            else
            {
                lblTotal.Text = "No se seleccionó ninguna butaca.";
            }
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
            lblFecha.Text = dt.Rows[0]["DiaSemana"].ToString() + " " + dt.Rows[0]["Dia"].ToString() + " de " + dt.Rows[0]["Mes"].ToString()+" - "+dt.Rows[0]["Hora"]+":"+dt.Rows[0]["Minuto"];
            Application["Precio"] = Convert.ToDouble(dt.Rows[0]["Precio_Formato"].ToString());
        }

        public string ArmarConsultaHeavy(string ID)
        {
            string Consulta = "Select Peliculas.ImagenURL,Peliculas.Titulo_Pelicula,Formatos.Idioma_Formato,Formatos.Nombre_Formato,Formatos.Precio_Formato,Formatos.Subtitulos_Formato, " +
                "Salas.Sala, Sucursales.Nombre_Sucursal,Sucursales.Direccion_Sucursal,Sucursales.Localidad_Sucursal,Sucursales.Provincia_Sucursal,datename(dw,Funciones.FechaHora_Funcion) as DiaSemana, " +
                "DATEPART(dd,Funciones.FechaHora_Funcion) as Dia,DATENAME(mm,Funciones.FechaHora_Funcion) as Mes,DATEPART(hh,Funciones.FechaHora_Funcion) as Hora,DATEPART(n,Funciones.FechaHora_Funcion) as Minuto "+
                "from Funciones " +
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
                            Boton.Enabled = false;
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

        public int SacarCantidad()
        {
            
            int Cantidad=0;
            string NombreBoton;
            for (int i = 1; i <= 44; i++)
            {
                NombreBoton = "btn" + i.ToString();
                if(VerificarClickeado(Page, NombreBoton) == 1)
                {
                    if(IsPostBack)
                    Cantidad++;
                }
            }
            if (Cantidad == 10)
            {
                return Cantidad - 1;
            }
            return Cantidad;
        }

        public int VerificarClickeado(Page Pagina, string Nombre)
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
                            if (Boton.BackColor == Color.Green)
                            {
                                Application["ButacasReservadas"] += Nombre + ",";
                                return 1;
                            }
                            return -1;
                        }
                    }
            }
            return 0;
        }

       
    }
}