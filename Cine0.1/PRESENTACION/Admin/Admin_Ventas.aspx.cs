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
    public partial class Admin_Ventas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserLogeado"] != null)
            {
                if (Session["NivelUser"].ToString() == "1")
                {
                    n_Pelicula Pelicula = new n_Pelicula();
                    DataTable dt = Pelicula.ObtenerTabla();

                    if (!IsPostBack)
                    {
                        Butacas(0);
                        LlenarDDLPeliculas(dt);
                        Session["ButacasDisp"] = 10;
                    }
                }
                else
                {
                    Response.Cookies["Error"].Value = "2";
                    Response.Cookies["Error"].Expires = DateTime.Now.AddHours(1);
                    Response.Redirect("Inicio.aspx");
                }
}
            else
            {
                Response.Cookies["Error"].Value = "1";
                Response.Cookies["Error"].Expires = DateTime.Now.AddHours(1);
                Response.Redirect("Inicio.aspx");
            }
        }

        protected void ddlPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            n_Sucursal Sucursal = new n_Sucursal();
            DataTable dt = Sucursal.ObtenerTabla();
            if (ddlPelicula.SelectedItem.ToString() != "-")
            {
                ddlSucursal.Enabled = true;
                ddlSucursal.Items.Clear();
                ddlSucursal.Items.Add("-");
                LlenarDDLSucursales(dt);

                Limpiar(0);

            }
            else
            {
                ddlSucursal.Enabled = false;
                ddlSucursal.Items.Clear();
                ddlSucursal.Items.Add("-");

                Limpiar(0);

            }
           
        }

        protected void ddlSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            n_Formato Formato = new n_Formato();
            DataTable dt = Formato.ObtenerTabla();
            if (ddlSucursal.SelectedItem.ToString() != "-" && ddlPelicula.SelectedItem.ToString() != "-")
            {
                ddlFormato.Enabled = true;
                ddlFormato.Items.Clear();
                ddlFormato.Items.Add("-");
                LlenarDDLFormato(dt);

                Limpiar(1);

                Butacas(0);
            }
            else
            {
                ddlFormato.Enabled = false;
                ddlFormato.Items.Clear();
                ddlFormato.Items.Add("-");

                Limpiar(1);

                Butacas(0);
            }
        }

        protected void ddlFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
            n_Funcion Funcion = new n_Funcion();
            DataTable dt = new DataTable();
            string Consulta = string.Empty;
            string IDPel = string.Empty;
            string IDFor = string.Empty;
            if (ddlFormato.SelectedItem.ToString() != "-" && ddlSucursal.SelectedItem.ToString() != "-" && ddlPelicula.SelectedItem.ToString() != "-")
            {
                try
                {
                    IDPel = ddlPelicula.SelectedValue.ToString();
                    IDFor = ddlFormato.SelectedValue.ToString();
                    Consulta = ArmarConsulta(IDPel,IDFor, ddlSucursal.SelectedValue.ToString(), 0);

                    dt = Funcion.ObtenerTabla(Consulta);

                    ddlDia.Items.Clear();
                    ddlDia.Items.Add("-");

                    Limpiar(2);

                    if (dt.Rows.Count > 0)
                    {
                        ddlDia.Enabled = true;
                        LlenarDDLDia(dt);
                    }
                    else
                    {
                        Boton(2);
                        Limpiar(1);
                    }
                }
                catch
                {
                    Boton(2);
                    Limpiar(1);
                }
            }
            else
            {

                Limpiar(1);
                Butacas(0);
            }
        }

        protected void ddlDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            n_Funcion Funcion = new n_Funcion();
            DataTable dt = new DataTable();
            string Consulta = string.Empty;
            string IDPel = ddlPelicula.SelectedValue.ToString();
            string IDFor = ddlFormato.SelectedValue.ToString();
            if (ddlDia.SelectedItem.ToString() != "-" && ddlFormato.SelectedItem.ToString() != "-" && ddlSucursal.SelectedItem.ToString() != "-" && ddlPelicula.SelectedItem.ToString() != "-")
            {
                Consulta = ArmarConsulta(IDPel,IDFor, ddlSucursal.SelectedValue.ToString(),1);

                dt = Funcion.ObtenerTabla(Consulta);

                ddlHorario.Items.Clear();
                ddlHorario.Items.Add("-");

                if (dt.Rows.Count > 0)
                {
                    ddlHorario.Enabled = true;
                    LlenarDDLHorario(dt);
                }
                else
                {
                    Limpiar(2);

                }
            }
            else
            {
                Limpiar(2);
            }
        }

        protected void ddlHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            n_Funcion Funcion = new n_Funcion();
            DataTable dt = new DataTable();
            string IDFuncion = string.Empty;
            string Consulta = string.Empty;
            string IDPel = ddlPelicula.SelectedValue.ToString();
            string IDFor = ddlFormato.SelectedValue.ToString();
            if (ddlHorario.SelectedItem.ToString() !="-" && ddlDia.SelectedItem.ToString() != "-" && ddlFormato.SelectedItem.ToString() != "-" && ddlSucursal.SelectedItem.ToString() != "-" && ddlPelicula.SelectedItem.ToString() != "-")
            {
                Consulta = ArmarConsulta(IDPel,IDFor, ddlSucursal.SelectedValue.ToString(), 2);
                dt = Funcion.ObtenerTabla(Consulta);
                IDFuncion = dt.Rows[0]["ID_Funcion"].ToString();
                Session["IDFuncion"] = IDFuncion;
                Butacas(1);
            }
            else
            {
                Butacas(0);
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarBxF();
            AgregarVenta();
            AgregarDetalleVenta();
            Reiniciar();
        }

        public void LlenarDDLPeliculas(DataTable dt)
        {
            ddlPelicula.Items.Clear();
            ddlPelicula.Items.Add("-");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlPelicula.Items.Add(dt.Rows[i]["Titulo_Pelicula"].ToString());
                ddlPelicula.Items[i+1].Value = dt.Rows[i]["ID_Pelicula"].ToString();
            }
        }

        public void LlenarDDLSucursales(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlSucursal.Items.Add(dt.Rows[i]["Nombre_Sucursal"].ToString());
                ddlSucursal.Items[i+1].Value = dt.Rows[i]["ID_Sucursal"].ToString();
            }
        }

        public void LlenarDDLFormato(DataTable dt)
        {
            string Formato;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Formato = ArmarFormato(dt.Rows[i]["Nombre_Formato"].ToString(), dt.Rows[i]["Subtitulos_Formato"].ToString(), dt.Rows[i]["Idioma_Formato"].ToString());
                ddlFormato.Items.Add(Formato);
                ddlFormato.Items[i+1].Value = dt.Rows[i]["ID_Formato"].ToString();
            }
        }

        public string ArmarFormato(string Nombre, string Subtitulos, string Idioma)
        {
            string Formato = string.Empty;
            if (Subtitulos == "True")
            {
                Formato = Nombre + " Subtitulada al " + Idioma;
            }
            else
            {
                Formato = Nombre + " Doblada al " + Idioma;
            }
            return Formato;
        }

        public void LlenarDDLDia(DataTable dt)
        {
            string[] Fecha;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                Fecha = dt.Rows[i]["FechaHora_Funcion"].ToString().Split(' ');

                if (dt.Rows[i]["FechaHora_Funcion"].ToString().Contains(Fecha[0]))
                {
                    if (DateTime.Now < Convert.ToDateTime(dt.Rows[i]["FechaHora_Funcion"].ToString()))
                    {
                        if (!FechaRepetida(Fecha[0]))
                            ddlDia.Items.Add(Fecha[0]);
                    }
                }
            }
            if (ddlDia.Items.Count > 1)
            {
                ddlDia.Enabled = true;
                Boton(0);
            }
            else
            {
                ddlDia.Enabled = false;
                ddlHorario.Enabled = false;
                Boton(2);
            }
        }

        public string ArmarConsulta(string IDPel,string IDFor,string IDSuc,int Origen)
        {
            if (Origen == 0)
            {
                string Consulta = "Select * from Funciones where ID_Pelicula='" + IDPel + "' and ID_Formato='"+ IDFor +"' and ID_Sucursal='" + IDSuc + "'";
                return Consulta;
            }
            else if(Origen==1)
            {
                string Consulta = "Select * from Funciones where ID_Pelicula='" + IDPel + "' and ID_Formato='" + IDFor + "' and ID_Sucursal='" + IDSuc + "' and " + ArmarConsultaFecha();
                return Consulta;
            }
            else
            {
                string Consulta = "Select * from Funciones where ID_Pelicula='" + IDPel + "' and ID_Formato='" + IDFor + "' and ID_Sucursal='" + IDSuc+"' and DATEDIFF(n, FechaHora_Funcion,'" + ddlDia.SelectedItem.ToString() + " " + ddlHorario.SelectedItem.ToString() +"') = 0";
                return Consulta;
            }
        }

        public string ArmarConsultaFecha()
        {
            string[] Fecha=ddlDia.SelectedItem.ToString().Split('/');
            string Resto= "(DATEPART(yy, FechaHora_Funcion) = "+Fecha[2]+" and DATEPART(mm, FechaHora_Funcion) = "+Fecha[0]+" and DATEPART(dd, FechaHora_Funcion) = "+Fecha[1]+")";
            return Resto;
        }

        public bool FechaRepetida(string Fecha)
        {
            for (int i = 0; i < ddlDia.Items.Count; i++)
            {
                if (ddlDia.Items[i].ToString() == Fecha)
                {
                    return true;
                }
            }
            return false;
        }

        public void LlenarDDLHorario(DataTable dt)
        {
            string[] Fecha;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Fecha = dt.Rows[i]["FechaHora_Funcion"].ToString().Split(' ');

                if (Fecha[2] != null)
                {
                    Fecha[1] = Fecha[1] + " " + Fecha[2];
                }

                ddlHorario.Items.Add(Fecha[1]);
            }
        }

        public void Butacas(int Origen)
        {
            string ID_Funcion;
            string Consulta;
            n_BxF BxF = new n_BxF();
            DataTable dt = new DataTable();
        
            if (Origen == 1)
            {
                ID_Funcion = Session["IDFuncion"].ToString();
                Consulta = "Select * from ButacaxFunciones where ID_Funcion='" + ID_Funcion+"'";
                dt = BxF.ObtenerTabla(Consulta);
            }

            for (int i = 1; i <= 44; i++)
            {
                if (Origen == 0)
                {
                    Colorear(Page,"btn" + i, 0);
                }
                else
                {
                    Colorear(Page, "btn" + i, 2);
                    for (int x = 0; x < dt.Rows.Count; x++)
                    {
                        if (i.ToString() == dt.Rows[x]["ID_Butaca"].ToString().Trim())
                            Colorear(Page, "btn" + i, 1);
                    }
                }
            }
        }

        public void Limpiar(int Origen)
        {
            if (Origen == 2 || Origen == 1 || Origen == 0)
            {
                ddlHorario.Enabled = false;
                ddlHorario.Items.Clear();
                ddlHorario.Items.Add("-");

                if (Origen == 1 || Origen == 0)
                {
                    ddlDia.Enabled = false;
                    ddlDia.Items.Clear();
                    ddlDia.Items.Add("-");

                    if (Origen == 0)
                    {
                        ddlFormato.Enabled = false;
                        ddlFormato.Items.Clear();
                        ddlFormato.Items.Add("-");
                    }
                }
                Butacas(0);
            }
        }

            public void Colorear(Page Pagina, string IDBoton, int Origen)
            {
                Button Boton;
                foreach (Control ctrl in Pagina.Form.Controls)
                {
                    foreach (Control Control in ctrl.Controls)
                        if (Control is Button)
                        {
                            Boton = (Button)Control;
                            if (Boton.ID == IDBoton)
                            {
                                if (Origen == 0)
                                {
                                    Boton.BackColor = Color.Empty;
                                    Boton.Enabled = false;
                                }
                                else if (Origen == 1)
                                {
                                    Boton.BackColor = Color.Red;
                                    Boton.Enabled = false;
                                }
                                else
                                {
                                    Boton.BackColor = Color.Empty;
                                    Boton.Enabled = true;
                                }
                            }
                        }
                }
            }
        
        public void Colorear2(object sender, EventArgs e)
        {
            int Seleccionados;
            Button IDBoton;
            IDBoton = (Button)sender;
            if (IDBoton.BackColor == Color.Empty)
            {
                if (Convert.ToInt32(Session["ButacasDisp"].ToString()) > 0){
                    IDBoton.BackColor = Color.Green;
                    Session["ButacasDisp"] = Convert.ToInt32(Session["ButacasDisp"].ToString()) - 1;
                    Boton(1);
                }
            }
            else
            {
                if (Convert.ToInt32(Session["ButacasDisp"].ToString()) < 10)
                {
                    Session["ButacasDisp"] = Convert.ToInt32(Session["ButacasDisp"].ToString()) + 1;
                    IDBoton.BackColor = Color.Empty;
                    
                }
            }
            ContarSeleccionados(Page,0);
            Seleccionados = Convert.ToInt32(Session["ButacasContadas"].ToString());
            if (Seleccionados == 0)
            {
                Boton(0);
            }
        }

       public void Boton(int Origen)
        {
            switch (Origen)
            {
                case 0:
                    btnAgregar.Text = "Complete los datos.";
                    btnAgregar.Enabled = false;
                    break;
                case 1:
                    btnAgregar.Text = "Agregar venta.";
                    btnAgregar.Enabled = true;
                    break;
                case 2:
                    btnAgregar.Text = "No existe función para ese día.";
                    btnAgregar.Enabled = false;
                    break;
            }
        }

        public void ContarSeleccionados(Page Pagina,int Origen)
        {
            Button Boton;
            int Contador = 0;
            string Butaca = string.Empty;
            string FyC = string.Empty;
            for (int i = 1; i <= 44; i++)
            {
                foreach (Control ctrl in Pagina.Form.Controls)
                {
                    foreach (Control Control in ctrl.Controls)
                        if (Control is Button)
                        {
                            Boton = (Button)Control;
                            if (Boton.ID == "btn"+i)
                            {
                                if (Boton.BackColor == Color.Green)
                                {
                                    Contador++;
                                    if (Origen == 1)
                                    {
                                        Butaca += i + "-";
                                        FyC += Boton.CommandName.ToString() + ",";
                                    }
                                }
                            }
                        }
                }
            }
            if (Origen == 1)
            {
                Butaca = Butaca.Remove(Butaca.Length - 1);
                FyC = FyC.Remove(FyC.Length - 1);
            }
            Session["ButacasContadas"]= Contador;
            Session["ButacasSeleccionadas"] = Butaca;
            Session["FilaYButaca"] = FyC;
        }

        public void AgregarBxF()
        {
            ContarSeleccionados(Page, 1);
            string[] Butacas = Session["ButacasSeleccionadas"].ToString().Split('-');
            string[] FilaYButaca = Session["FilaYButaca"].ToString().Split(',');
            string IDFuncion = Session["IDFuncion"].ToString();
            string[] FYB;
            ButacasxFunciones e_BxF = new ButacasxFunciones();
            n_BxF BxF = new n_BxF();
            for (int i = 0; i < Butacas.Length; i++)
            {
                FYB = FilaYButaca[i].Split('-');
                e_BxF.IDButaca = Butacas[i];
                e_BxF.IDFuncion = IDFuncion;
                e_BxF.Butaca = FYB[1];
                e_BxF.Fila = FYB[0];
                BxF.insertarBxF(e_BxF);
            }
        }

        public void AgregarVenta()
        {

            string[] Butacas = Session["ButacasSeleccionadas"].ToString().Split('-');
            double PrecioTotal = SacarPrecio(Butacas.Length);

            n_Venta n_Ven = new n_Venta();
            Venta Ven = new Venta();
            Ven.IdVenta = SacarIDVenta();
            Ven.Usuario = Session["UserLogeado"].ToString();
            Ven.IdUsuario = SacarIDUser(Ven.Usuario);
            Ven.FechaHora = DateTime.Now;
            Ven.CantidadEntradas = Butacas.Length;
            Ven.PrecioFinal = PrecioTotal;

            n_Ven.insertarVenta(Ven);

            Session["IDVenta"] = Ven.IdVenta;
        }

        public int SacarIDUser(string Nombre)
        {
            n_Usuario User = new n_Usuario();
            DataTable dt = User.ObtenerUsuario(Nombre);
            return Convert.ToInt32(dt.Rows[0]["ID_Usuario"].ToString());
        }

        public double SacarPrecio(int Cant)
        {
            double Precio;
            n_Formato Formato = new n_Formato();
            DataTable dt = Formato.ObtenerTabla(ddlFormato.SelectedValue.ToString());
            Precio = Convert.ToDouble(dt.Rows[0]["Precio_Formato"].ToString());
            return Precio * Cant;
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

        public void AgregarDetalleVenta()
        {
            string IDVenta = Session["IDVenta"].ToString();
            string IDFuncion = Session["IDFuncion"].ToString();
            string[] Butacas = Session["ButacasSeleccionadas"].ToString().Split('-');
            int Cant = Butacas.Length;
            double PrecioU = SacarPrecio(Cant) / Cant;
            n_DetalleVenta n_Det = new n_DetalleVenta();
            DetalleVenta Det = new DetalleVenta();

            for (int i = 0; i < Cant; i++)
            {
                Det.IdVenta = IDVenta;
                Det.IdFuncion = IDFuncion;
                Det.IdButaca = Butacas[i];
                Det.FilaButaca = "1";
                Det.Butaca = "1";
                Det.PrecioEntrada = PrecioU;
                n_Det.insertarDetalleVenta(Det);
            }
        }

        public void Reiniciar()
        {
            n_Pelicula n_Pel = new n_Pelicula();
            DataTable dt = n_Pel.ObtenerTabla();
            LlenarDDLPeliculas(dt);
            ddlSucursal.Enabled = false;
            ddlSucursal.Items.Clear();
            ddlSucursal.Items.Add("-");
            Limpiar(0);
            Butacas(0);
            Boton(0);
            Response.Write("<script>window.alert('Venta agregada exitosamente');</script>");
        }

    }
}