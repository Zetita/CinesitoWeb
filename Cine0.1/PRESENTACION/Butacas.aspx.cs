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
            string ID_Funcion = Application["ID_Funcion"].ToString();
            //string ID_Funcion = "1";
            string Consulta = "Select * from ButacaxFunciones where ID_Funcion=" + ID_Funcion;
            DataTable dt = BxF.ObtenerTablaBxF(Consulta);
            if(!IsPostBack) Application["CantEntradasT"] = Application["CantEntradas"] = 10;


            for (int x = 1; x <= 44; x++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (x.ToString() == dt.Rows[j]["ID_Butaca"].ToString().Trim())
                    {
                        Colorear(x.ToString());
                    }
                }
            }

            Consulta = ArmarConsultaHeavy(ID_Funcion);
            dt = Funcion.ObtenerTablaFunciones(Consulta);
            LlenarResumen(dt);
            
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

        ///Perdon Sheila, era necesario :(

        protected void Colorear(string x)
        {
            switch (x)
            {
                case "1":
                        btn1.BackColor = Color.Red;
                        btn1.Enabled = false;
                    break;
                case "2":
                        btn2.BackColor = Color.Red;
                        btn2.Enabled = false;
                    break;
                case "3":
                        btn3.BackColor = Color.Red;
                        btn3.Enabled = false;
                    break;
                case "4":
                        btn4.BackColor = Color.Red;
                        btn4.Enabled = false;
                    break;
                case "5":
                        btn5.BackColor = Color.Red;
                        btn5.Enabled = false;
                    break;
                case "6":
                        btn6.BackColor = Color.Red;
                        btn6.Enabled = false;
                    break;
                case "7":
                        btn7.BackColor = Color.Red;
                        btn7.Enabled = false;
                    break;
                case "8":
                        btn8.BackColor = Color.Red;
                        btn8.Enabled = false;
                    break;
                case "9":
                        btn9.BackColor = Color.Red;
                        btn9.Enabled = false;
                    break;
                case "10":
                        btn10.BackColor = Color.Red;
                        btn10.Enabled = false;
                    break;
                case "11":
                        btn11.BackColor = Color.Red;
                        btn11.Enabled = false;
                    break;
                case "12":
                        btn12.BackColor = Color.Red;
                        btn12.Enabled = false;
                    break;
                case "13":
                        btn13.BackColor = Color.Red;
                        btn13.Enabled = false;
                    break;
                case "14":
                        btn14.BackColor = Color.Red;
                        btn14.Enabled = false;
                    break;
                case "15":
                        btn15.BackColor = Color.Red;
                        btn15.Enabled = false;
                    break;
                case "16":
                        btn16.BackColor = Color.Red;
                        btn16.Enabled = false;
                    break;
                case "17":
                        btn17.BackColor = Color.Red;
                        btn17.Enabled = false;
                    break;
                case "18":
                        btn18.BackColor = Color.Red;
                        btn18.Enabled = false;
                    break;
                case "19":
                        btn19.BackColor = Color.Red;
                        btn19.Enabled = false;
                    break;
                case "20":
                        btn20.BackColor = Color.Red;
                        btn20.Enabled = false;
                    break;
                case "21":
                        btn21.BackColor = Color.Red;
                        btn21.Enabled = false;
                    break;
                case "22":
                        btn22.BackColor = Color.Red;
                        btn22.Enabled = false;
                    break;
                case "23":
                        btn23.BackColor = Color.Red;
                        btn23.Enabled = false;
                    break;
                case "24":
                        btn24.BackColor = Color.Red;
                        btn24.Enabled = false;
                    break;
                case "25":
                        btn25.BackColor = Color.Red;
                        btn25.Enabled = false;
                    break;
                case "26":
                        btn26.BackColor = Color.Red;
                        btn26.Enabled = false;
                    break;
                case "27":
                        btn27.BackColor = Color.Red;
                        btn27.Enabled = false;
                    break;
                case "28":
                        btn28.BackColor = Color.Red;
                        btn28.Enabled = false;
                    break;
                case "29":
                        btn29.BackColor = Color.Red;
                        btn29.Enabled = false;
                    break;
                case "30":
                        btn30.BackColor = Color.Red;
                        btn30.Enabled = false;
                    break;
                case "31":
                        btn31.BackColor = Color.Red;
                        btn31.Enabled = false;
                    break;
                case "32":
                        btn32.BackColor = Color.Red;
                        btn32.Enabled = false;
                    break;
                case "33":
                        btn33.BackColor = Color.Red;
                        btn33.Enabled = false;
                    break;
                case "34":
                        btn34.BackColor = Color.Red;
                        btn34.Enabled = false;
                    break;
                case "35":
                        btn35.BackColor = Color.Red;
                        btn35.Enabled = false;
                    break;
                case "36":
                        btn36.BackColor = Color.Red;
                        btn36.Enabled = false;
                    break;
                case "37":
                        btn37.BackColor = Color.Red;
                        btn37.Enabled = false;
                    break;
                case "38":
                        btn38.BackColor = Color.Red;
                        btn38.Enabled = false;
                    break;
                case "39":
                        btn39.BackColor = Color.Red;
                        btn39.Enabled = false;
                    break;
                case "40":
                        btn40.BackColor = Color.Red;
                        btn40.Enabled = false;
                    break;
                case "41":
                        btn41.BackColor = Color.Red;
                        btn41.Enabled = false;
                    break;
                case "42":
                        btn42.BackColor = Color.Red;
                        btn42.Enabled = false;
                    break;
                case "43":
                        btn43.BackColor = Color.Red;
                        btn43.Enabled = false;
                    break;
                case "44":
                        btn44.BackColor = Color.Red;
                        btn44.Enabled = false;
                    break;
            }
        }
        
    }
}