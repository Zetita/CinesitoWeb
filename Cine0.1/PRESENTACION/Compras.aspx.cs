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
            if (Session["UserLogeado"] != null)
            {
                n_BxF BxF = new n_BxF();
                n_Funcion Funcion = new n_Funcion();

                string ID_Funcion = Application["ID_Funcion"].ToString();
                int Cantidad = Convert.ToInt32(Application["Cantidad"].ToString());
                double Precio = Convert.ToDouble(Application["Precio"].ToString()) * Cantidad;
                string Consulta = ArmarConsultaHeavy(ID_Funcion);

                if (!IsPostBack)
                {
                    DataTable dt = Funcion.ObtenerTabla(Consulta);
                    LlenarResumen(dt);
                    LlenarDDL();

                    lblEntrada.Text = "Precio Entrada x" + Cantidad;
                    lblTotal.Text = "Total";
                    lblPrecioFinal.Text = "$" + Precio.ToString();
                    lblPrecio.Text = "$" + Application["PrecioTotal"].ToString();
                }
            }
            else
            {

                Response.Cookies["Error"].Value = "1";
                Response.Cookies["Error"].Expires = DateTime.Now.AddHours(1);
                Response.Redirect("Inicio.aspx");
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (TieneErrores(Page))
            {
                AgregarBxF();
                AgregarVenta();
                AgregarDetalleVenta();
                Response.Cookies["Compra"].Value = "1";
                Response.Cookies["Compra"].Expires = DateTime.Now.AddHours(1);
                Response.Redirect("Inicio.aspx");
            }
            else
            {
                Response.Write("<script>window.alert('Faltan completar datos.');</script>");
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
                "Inner Join Peliculas on Funciones.ID_Pelicula = Peliculas.ID_Pelicula " +
                "Inner Join Formatos on Funciones.ID_Formato = Formatos.ID_Formato " +
                "Inner Join Salas on Funciones.ID_Sala = Salas.ID_Sala " +
                "Inner Join Sucursales on Funciones.ID_Sucursal = Sucursales.ID_Sucursal " +
                "where Funciones.ID_Funcion = '" + ID+"'";
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

        public void LlenarDDL()
        {
            string[] AnioyHora = DateTime.Today.ToString().Split('/');
            string[] Anio = AnioyHora[2].Split(' ');
            int Item= Convert.ToInt32(Anio[0]);
            ddlFechaVenc1.Items.Add("-");
            for (int i = 0; i < 10; i++)
            {
                ddlFechaVenc1.Items.Add((Item + i).ToString());
            }
        }

        public bool TieneErrores(Page Pagina)
        {
            TextBox txt;
            DropDownList ddl;
            CheckBox cb;
            bool Completo = true;
            foreach (Control ctrl in Pagina.Form.Controls)
            {
                foreach (Control Control in ctrl.Controls)
                {
                    if (Control is TextBox)
                    {
                        txt = (TextBox)Control;
                        if (txt.Text == string.Empty)
                        {
                            txt.BorderColor = Color.Red;
                            Completo = false;
                        }
                        else if (txt.ID == "txtEmail")
                        {
                            if (!(txt.Text.Contains('@')))
                            {
                                txt.BorderColor = Color.Red;
                                Completo = false;
                            }
                            else
                            {
                                txt.BorderColor = Color.Empty;
                            }
                        }
                        else
                        {
                            txt.BorderColor = Color.Empty;
                        }
                    }
                    else if (Control is DropDownList)
                    {
                        ddl = (DropDownList)Control;
                        if (ddl.SelectedItem.ToString() == "-")
                        {
                            ddl.BorderColor = Color.Red;
                            Completo = false;
                        }
                        else
                        {
                            ddl.BorderColor = Color.Empty;
                        }
                    }
                    else if(Control is CheckBox)
                    {
                        cb = (CheckBox)Control;
                        if (!cb.Checked)
                        {
                            cb.BorderColor = Color.Red;
                            Completo = false;
                        }
                        else
                        {
                            cb.BorderColor = Color.Empty;
                        }
                    }
                }
            }
            return Completo;
        }

        public void AgregarBxF()
        {
            string[] Butacas = Application["ButacasReservadas"].ToString().TrimEnd(',').Split(',');
            string[] FilayColumna = Application["FyC"].ToString().TrimEnd(',').Split(',');
            string[] FyC;
            string IDFuncion = Application["ID_Funcion"].ToString();
            n_BxF ButxFun = new n_BxF();
            ButacasxFunciones BxF = new ButacasxFunciones();
            for (int i = 0; i < Butacas.Length; i++)
            {
                FyC = FilayColumna[i].ToString().Split('-');
                BxF.IDButaca = Butacas[i];
                BxF.IDFuncion = IDFuncion;
                BxF.Fila = FyC[0];
                BxF.Butaca = FyC[1];
                ButxFun.insertarBxF(BxF);
            }
        }

        public void AgregarVenta()
        {
            n_Venta n_Ven = new n_Venta();
            Venta Ven = new Venta();
            string[] Butacas = Application["ButacasReservadas"].ToString().TrimEnd(',').Split(',');

            Ven.IdVenta = SacarIDVenta();
            Ven.Usuario = Session["UserLogeado"].ToString();
            Ven.IdUsuario = SacarIDUser(Ven.Usuario);
            Ven.FechaHora = DateTime.Now;
            Ven.PrecioFinal = Convert.ToDouble(lblPrecioFinal.Text.TrimStart('$'));
            Ven.CantidadEntradas = Butacas.Length;

            n_Ven.insertarVenta(Ven);

            Session["IDVenta"] = Ven.IdVenta;
            Session["PrecioU"] = Ven.PrecioFinal / Butacas.Length;
        }

        public string SacarIDVenta()
        {
            n_Venta Venta = new n_Venta();
            DataTable dt = Venta.ObtenerTablaVenta();

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows.Count >= 9)
                {
                    if (dt.Rows.Count >= 99) return "VEN" + dt.Rows.Count + 1;
                    else return "VEN0" + (dt.Rows.Count + 1).ToString();
                }
                else return "VEN00" + (dt.Rows.Count + 1).ToString();
            }
            else
            {
                return "VEN001";
            }
        }

        public int SacarIDUser(string Nombre)
        {
            n_Usuario User = new n_Usuario();
            DataTable dt = User.ObtenerUsuario(Nombre);
            return Convert.ToInt32(dt.Rows[0]["ID_Usuario"].ToString());
        }

        public void AgregarDetalleVenta()
        {
            n_DetalleVenta n_Det = new n_DetalleVenta();
            DetalleVenta Det = new DetalleVenta();
            string[] FilayColumna = Application["FyC"].ToString().TrimEnd(',').Split(',');
            string[] FyC;
            string[] Butacas= Application["ButacasReservadas"].ToString().TrimEnd(',').Split(',');

            for (int i = 0; i < Butacas.Length; i++)
            {
                FyC = FilayColumna[i].ToString().Split('-');
                Det.IdFuncion = Application["ID_Funcion"].ToString();
                Det.IdVenta = Session["IDVenta"].ToString();
                Det.PrecioEntrada = Convert.ToDouble(Session["PrecioU"].ToString());
                Det.IdButaca = Butacas[i];
                Det.FilaButaca = FyC[0];
                Det.Butaca = FyC[1];
                n_Det.insertarDetalleVenta(Det);
            }
        }

        protected void ddlFechaVenc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] AnioyHora = DateTime.Today.ToString().Split('/');
            string[] Anio = AnioyHora[2].Split(' ');
            int Item = Convert.ToInt32(AnioyHora[0]);
            if (ddlFechaVenc1.SelectedItem.ToString() != "-")
            {
                ddlFechaVenc2.Enabled = true;
                ddlFechaVenc2.Items.Clear();
                ddlFechaVenc2.Items.Add("-");
                if (ddlFechaVenc1.SelectedItem.ToString() == Anio[0])
                {
                    while (Item < 12)
                    {
                        Item = Item + 1;
                        ddlFechaVenc2.Items.Add(Item.ToString());
                    }
                }
                else
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        ddlFechaVenc2.Items.Add(i.ToString());
                    }
                }
            }
            else
            {
                ddlFechaVenc2.Enabled = false;
                ddlFechaVenc2.Items.Clear();
                ddlFechaVenc2.Items.Add("-");
            }
        }
    }
}