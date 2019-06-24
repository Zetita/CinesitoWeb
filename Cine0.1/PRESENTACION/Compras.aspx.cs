using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using NEGOCIO;
using ENTIDAD;
using System.Drawing;

namespace PRESENTACION
{
    public partial class Compras : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
            n_BxF BxF = new n_BxF();
            n_Funcion Funcion = new n_Funcion();

            string ID_Funcion = Application["ID_Funcion"].ToString();
            int Cantidad = Convert.ToInt32(Application["Cantidad"].ToString());
            double Precio = Convert.ToDouble(Application["Precio"].ToString()) * Cantidad;
            //string ID_Funcion = "1";
            string Consulta = ArmarConsultaHeavy(ID_Funcion);

            DataTable dt = Funcion.ObtenerTabla(Consulta);
            LlenarResumen(dt);

            lblEntrada.Text = "Precio Entrada x"+Cantidad;
            lblTotal.Text = "Total";
            lblPrecioFinal.Text ="$"+ Precio.ToString();
            lblPrecio.Text = "$"+Application["PrecioTotal"].ToString();

            if (IsPostBack)
            {
                if(TieneErrores(Page)&&cbTerm.Checked)
                {
                    Boton("1");
                }
                else
                {
                    Boton("2");
                }
            } 
        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Contains("@"))
            {
                txtEmail.BorderColor = Color.Red;
                Boton("2");
            }
            else
            {
                txtEmail.BorderColor = Color.Empty;
                ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "DoPostBack", "__doPostBack(sender, e)", true);
            }

        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            string[] Butacas = Application["ButacasReservadas"].ToString().Split(',');
            string IDFuncion = Application["ID_Funcion"].ToString();
            int Cantidad = 0;
            n_BxF ButxFun = new n_BxF();
            ButacasxFunciones BxF = new ButacasxFunciones();
            for (int i = 0; i < Butacas.Length-1; i++)
            {
                BxF.IDButaca = Butacas[i];
                BxF.IDFuncion = IDFuncion;
                BxF.Fila = "1";
                BxF.Butaca = "1";
                if (ButxFun.insertarBxF(BxF))
                {
                    Cantidad++;
                }
            }
            if (Cantidad == Butacas.Length)
            {
                Response.Write("<script>window.alert('Butacas reservadas con exito.');</script>");
            }
            else
            {
                Response.Write("<script>window.alert('Error al reservar butacas.');</script>");
            }
            Response.Redirect("Inicio.aspx");
        }

        protected void Validar(object sender, EventArgs e)
        {
            TextBox txt;
            txt = (TextBox)sender;
            if (txt.Text == string.Empty)
            {
                txt.BorderColor = Color.Red;
                Boton("2");
            }
            else
            {
                txt.BorderColor = Color.Empty;
                ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "DoPostBack", "__doPostBack(sender, e)", true);
            }
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

        public void Boton(string Estado)
        {
            switch (Estado)
            {
                case "0":
                    btnConfirmar.Text = " COMPLETE LOS DATOS NECESARIOS";
                    btnConfirmar.Enabled = false;
                    break;
                case "1":
                    btnConfirmar.Text = " CONFIRMAR COMPRA ";
                    btnConfirmar.Enabled = true;
                    break;
                case "2":
                    btnConfirmar.Text = "DATOS ERRONEOS INGRESADOS";
                    btnConfirmar.Enabled = false;
                    break;
            }
        }

        public bool TieneErrores(Page Pagina)
        {
            TextBox txt;
            foreach (Control ctrl in Pagina.Form.Controls)
            {
                foreach (Control Control in ctrl.Controls)
                    if (Control is TextBox)
                    {
                        txt = (TextBox)Control;
                        if (txt.BorderColor==Color.Red)
                        {
                            return false;
                        }
                    }
            }
            return true;
        }
    }
}