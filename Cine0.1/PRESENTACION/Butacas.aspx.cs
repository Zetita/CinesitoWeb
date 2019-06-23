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
                        Colorear(x.ToString(), 0);
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

        ///Perdon Sheila, era necesario :(

        protected void Colorear(string x, int Origen)
        {
            switch (x)
            {
                case "1":
                    if (Origen == 0)
                    {
                        btn1.BackColor = Color.Red;
                        btn1.Enabled = false;
                    }
                    else
                    {
                        if (btn1.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn1.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn1.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "2":
                    if (Origen == 0)
                    {
                        btn2.BackColor = Color.Red;
                        btn2.Enabled = false;
                    }
                    else
                    {
                        if (btn2.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn2.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn2.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "3":
                    if (Origen == 0)
                    {
                        btn3.BackColor = Color.Red;
                        btn3.Enabled = false;
                    }
                    else
                    {
                        if (btn3.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn3.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn3.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "4":
                    if (Origen == 0)
                    {
                        btn4.BackColor = Color.Red;
                        btn4.Enabled = false;
                    }
                    else
                    {
                        if (btn4.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn4.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn4.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "5":
                    if (Origen == 0)
                    {
                        btn5.BackColor = Color.Red;
                        btn5.Enabled = false;
                    }
                    else
                    {
                        if (btn5.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn5.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn5.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "6":
                    if (Origen == 0)
                    {
                        btn6.BackColor = Color.Red;
                        btn6.Enabled = false;
                    }
                    else
                    {
                        if (btn6.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn6.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn6.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "7":
                    if (Origen == 0)
                    {
                        btn7.BackColor = Color.Red;
                        btn7.Enabled = false;
                    }
                    else
                    {
                        if (btn7.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn7.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn7.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "8":
                    if (Origen == 0)
                    {
                        btn8.BackColor = Color.Red;
                        btn8.Enabled = false;
                    }
                    else
                    {
                        if (btn8.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn8.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn8.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "9":
                    if (Origen == 0)
                    {
                        btn9.BackColor = Color.Red;
                        btn9.Enabled = false;
                    }
                    else
                    {
                        if (btn9.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn9.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn9.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "10":
                    if (Origen == 0)
                    {
                        btn10.BackColor = Color.Red;
                        btn10.Enabled = false;
                    }
                    else
                    {
                        if (btn10.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn10.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn10.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "11":
                    if (Origen == 0)
                    {
                        btn11.BackColor = Color.Red;
                        btn11.Enabled = false;
                    }
                    else
                    {
                        if (btn11.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn11.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn11.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "12":
                    if (Origen == 0)
                    {
                        btn12.BackColor = Color.Red;
                        btn12.Enabled = false;
                    }
                    else
                    {
                        if (btn12.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn12.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn12.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "13":
                    if (Origen == 0)
                    {
                        btn13.BackColor = Color.Red;
                        btn13.Enabled = false;
                    }
                    else
                    {
                        if (btn13.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn13.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn13.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "14":
                    if (Origen == 0)
                    {
                        btn14.BackColor = Color.Red;
                        btn14.Enabled = false;
                    }
                    else
                    {
                        if (btn14.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn14.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn14.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "15":
                    if (Origen == 0)
                    {
                        btn15.BackColor = Color.Red;
                        btn15.Enabled = false;
                    }
                    else
                    {
                        if (btn15.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn15.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn15.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "16":
                    if (Origen == 0)
                    {
                        btn16.BackColor = Color.Red;
                        btn16.Enabled = false;
                    }
                    else
                    {
                        if (btn16.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn16.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn16.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "17":
                    if (Origen == 0)
                    {
                        btn17.BackColor = Color.Red;
                        btn17.Enabled = false;
                    }
                    else
                    {
                        if (btn17.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn17.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn17.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "18":
                    if (Origen == 0)
                    {
                        btn18.BackColor = Color.Red;
                        btn18.Enabled = false;
                    }
                    else
                    {
                        if (btn18.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn18.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn18.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "19":
                    if (Origen == 0)
                    {
                        btn19.BackColor = Color.Red;
                        btn19.Enabled = false;
                    }
                    else
                    {
                        if (btn19.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn19.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn19.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "20":
                    if (Origen == 0)
                    {
                        btn20.BackColor = Color.Red;
                        btn20.Enabled = false;
                    }
                    else
                    {
                        if (btn20.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn20.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn20.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "21":
                    if (Origen == 0)
                    {
                        btn21.BackColor = Color.Red;
                        btn21.Enabled = false;
                    }
                    else
                    {
                        if (btn21.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn21.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn21.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "22":
                    if (Origen == 0)
                    {
                        btn22.BackColor = Color.Red;
                        btn22.Enabled = false;
                    }
                    else
                    {
                        if (btn22.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn22.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn22.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "23":
                    if (Origen == 0)
                    {
                        btn23.BackColor = Color.Red;
                        btn23.Enabled = false;
                    }
                    else
                    {
                        if (btn23.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn23.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn23.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "24":
                    if (Origen == 0)
                    {
                        btn24.BackColor = Color.Red;
                        btn24.Enabled = false;
                    }
                    else
                    {
                        if (btn24.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn24.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn24.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "25":
                    if (Origen == 0)
                    {
                        btn25.BackColor = Color.Red;
                        btn25.Enabled = false;
                    }
                    else
                    {
                        if (btn25.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn25.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn25.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "26":
                    if (Origen == 0)
                    {
                        btn26.BackColor = Color.Red;
                        btn26.Enabled = false;
                    }
                    else
                    {
                        if (btn26.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn26.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn26.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "27":
                    if (Origen == 0)
                    {
                        btn27.BackColor = Color.Red;
                        btn27.Enabled = false;
                    }
                    else
                    {
                        if (btn27.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn27.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn27.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "28":
                    if (Origen == 0)
                    {
                        btn28.BackColor = Color.Red;
                        btn28.Enabled = false;
                    }
                    else
                    {
                        if (btn28.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn28.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn28.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "29":
                    if (Origen == 0)
                    {
                        btn29.BackColor = Color.Red;
                        btn29.Enabled = false;
                    }
                    else
                    {
                        if (btn29.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn29.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn29.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "30":
                    if (Origen == 0)
                    {
                        btn30.BackColor = Color.Red;
                        btn30.Enabled = false;
                    }
                    else
                    {
                        if (btn30.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn30.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn30.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "31":
                    if (Origen == 0)
                    {
                        btn31.BackColor = Color.Red;
                        btn31.Enabled = false;
                    }
                    else
                    {
                        if (btn31.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn31.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn31.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "32":
                    if (Origen == 0)
                    {
                        btn32.BackColor = Color.Red;
                        btn32.Enabled = false;
                    }
                    else
                    {
                        if (btn32.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn32.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn32.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "33":
                    if (Origen == 0)
                    {
                        btn33.BackColor = Color.Red;
                        btn33.Enabled = false;
                    }
                    else
                    {
                        if (btn33.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn33.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn33.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "34":
                    if (Origen == 0)
                    {
                        btn34.BackColor = Color.Red;
                        btn34.Enabled = false;
                    }
                    else
                    {
                        if (btn34.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn34.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn34.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "35":
                    if (Origen == 0)
                    {
                        btn35.BackColor = Color.Red;
                        btn35.Enabled = false;
                    }
                    else
                    {
                        if (btn35.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn35.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn35.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "36":
                    if (Origen == 0)
                    {
                        btn36.BackColor = Color.Red;
                        btn36.Enabled = false;
                    }
                    else
                    {
                        if (btn36.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn36.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn36.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "37":
                    if (Origen == 0)
                    {
                        btn37.BackColor = Color.Red;
                        btn37.Enabled = false;
                    }
                    else
                    {
                        if (btn37.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn37.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn37.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "38":
                    if (Origen == 0)
                    {
                        btn38.BackColor = Color.Red;
                        btn38.Enabled = false;
                    }
                    else
                    {
                        if (btn38.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn38.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn38.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "39":
                    if (Origen == 0)
                    {
                        btn39.BackColor = Color.Red;
                        btn39.Enabled = false;
                    }
                    else
                    {
                        if (btn39.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn39.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn39.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "40":
                    if (Origen == 0)
                    {
                        btn40.BackColor = Color.Red;
                        btn40.Enabled = false;
                    }
                    else
                    {
                        if (btn40.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn40.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn40.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "41":
                    if (Origen == 0)
                    {
                        btn41.BackColor = Color.Red;
                        btn41.Enabled = false;
                    }
                    else
                    {
                        if (btn41.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn41.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn41.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "42":
                    if (Origen == 0)
                    {
                        btn42.BackColor = Color.Red;
                        btn42.Enabled = false;
                    }
                    else
                    {
                        if (btn42.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn42.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn42.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "43":
                    if (Origen == 0)
                    {
                        btn43.BackColor = Color.Red;
                        btn43.Enabled = false;
                    }
                    else
                    {
                        if (btn43.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn43.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn43.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
                case "44":
                    if (Origen == 0)
                    {
                        btn44.BackColor = Color.Red;
                        btn44.Enabled = false;
                    }
                    else
                    {
                        if (btn44.BackColor == Color.Green)
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) < 10)
                            {
                                btn44.BackColor = Color.Empty;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) + 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(Application["CantEntradasT"].ToString()) > 0)
                            {
                                btn44.BackColor = Color.Green;
                                Application["CantEntradasT"] = Convert.ToInt32(Application["CantEntradasT"]) - 1;
                            }
                        }
                    }
                    break;
            }
        }
        protected void btn1_Click(object sender, EventArgs e)
        {
            Colorear("1", 1);
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            Colorear("2", 1);
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            Colorear("3", 1);
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            Colorear("4", 1);
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            Colorear("5", 1);
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            Colorear("6", 1);
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            Colorear("7", 1);
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            Colorear("8", 1);
        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            Colorear("9", 1);
        }

        protected void btn10_Click(object sender, EventArgs e)
        {
            Colorear("10", 1);
        }

        protected void btn11_Click(object sender, EventArgs e)
        {
            Colorear("11", 1);
        }

        protected void btn12_Click(object sender, EventArgs e)
        {
            Colorear("12", 1);
        }

        protected void btn13_Click(object sender, EventArgs e)
        {
            Colorear("13", 1);
        }

        protected void btn14_Click(object sender, EventArgs e)
        {
            Colorear("14", 1);
        }

        protected void btn15_Click(object sender, EventArgs e)
        {
            Colorear("15", 1);
        }

        protected void btn16_Click(object sender, EventArgs e)
        {
            Colorear("16", 1);
        }

        protected void btn17_Click(object sender, EventArgs e)
        {
            Colorear("17", 1);
        }

        protected void btn18_Click(object sender, EventArgs e)
        {
            Colorear("18", 1);
        }

        protected void btn19_Click(object sender, EventArgs e)
        {
            Colorear("19", 1);
        }

        protected void btn20_Click(object sender, EventArgs e)
        {
            Colorear("20", 1);
        }

        protected void btn21_Click(object sender, EventArgs e)
        {
            Colorear("21", 1);
        }

        protected void btn22_Click(object sender, EventArgs e)
        {
            Colorear("22", 1);
        }

        protected void btn23_Click(object sender, EventArgs e)
        {
            Colorear("23", 1);
        }

        protected void btn24_Click(object sender, EventArgs e)
        {
            Colorear("24", 1);
        }

        protected void btn25_Click(object sender, EventArgs e)
        {
            Colorear("25", 1);
        }

        protected void btn26_Click(object sender, EventArgs e)
        {
            Colorear("26", 1);
        }

        protected void btn27_Click(object sender, EventArgs e)
        {
            Colorear("27", 1);
        }

        protected void btn28_Click(object sender, EventArgs e)
        {
            Colorear("28", 1);
        }

        protected void btn29_Click(object sender, EventArgs e)
        {
            Colorear("29", 1);
        }

        protected void btn30_Click(object sender, EventArgs e)
        {
            Colorear("30", 1);
        }

        protected void btn31_Click(object sender, EventArgs e)
        {
            Colorear("31", 1);
        }

        protected void btn32_Click(object sender, EventArgs e)
        {
            Colorear("32", 1);
        }

        protected void btn33_Click(object sender, EventArgs e)
        {
            Colorear("33", 1);
        }

        protected void btn34_Click(object sender, EventArgs e)
        {
            Colorear("34", 1);
        }

        protected void btn35_Click(object sender, EventArgs e)
        {
            Colorear("35", 1);
        }

        protected void btn36_Click(object sender, EventArgs e)
        {
            Colorear("36", 1);
        }

        protected void btn37_Click(object sender, EventArgs e)
        {
            Colorear("37", 1);
        }

        protected void btn38_Click(object sender, EventArgs e)
        {
            Colorear("38", 1);
        }

        protected void btn39_Click(object sender, EventArgs e)
        {
            Colorear("39", 1);
        }

        protected void btn40_Click(object sender, EventArgs e)
        {
            Colorear("40", 1);
        }

        protected void btn41_Click(object sender, EventArgs e)
        {
            Colorear("41", 1);
        }

        protected void btn42_Click(object sender, EventArgs e)
        {
            Colorear("42", 1);
        }

        protected void btn43_Click(object sender, EventArgs e)
        {
            Colorear("43", 1);
        }

        protected void btn44_Click(object sender, EventArgs e)
        {
            Colorear("44", 1);
        }
    }
}