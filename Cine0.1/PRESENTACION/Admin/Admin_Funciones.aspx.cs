using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ENTIDAD;
using NEGOCIO;


namespace PRESENTACION
{
    public partial class Admin_Funciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.WebForms;
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "/Scripts/jquery-1.8.0.js"
            });

            if (!IsPostBack)
            {
                cargarGrilla();
                cargarDDL();

            }
        }
        public void cargarGrilla()
        {
            n_Funcion n_funcion = new n_Funcion();
            grdFunciones.DataSource = n_funcion.ObtenerTabla();
            grdFunciones.DataBind();
        }
        public void cargarDDL()
        {
            n_Pelicula n_pelicula = new n_Pelicula();

            ddlPeliculas.DataTextField = "Titulo_Pelicula";
            ddlPeliculas.DataValueField = "ID_Pelicula";
            ddlPeliculas.DataSource = n_pelicula.ObtenerTabla();
            ddlPeliculas.DataBind();
            ddlPeliculas.Items.Insert(0, "--Seleccione una pelicula--");

            n_Sucursal n_sucursal = new n_Sucursal();
            ddlSucursal.DataTextField = "Nombre_Sucursal";
            ddlSucursal.DataValueField = "ID_Sucursal";
            ddlSucursal.DataSource = n_sucursal.ObtenerTabla();
            ddlSucursal.DataBind();
            
            n_Sala n_sala = new n_Sala();
            ddlSala.DataTextField = "Sala";
            ddlSala.DataValueField = "ID_Sala";
            ddlSala.DataSource = n_sala.ObtenerTablaSalas(ddlSucursal.SelectedValue.ToString());
            ddlSala.DataBind();

        }
        
        void ClearInputs(ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                if (ctrl is DropDownList)
                    ((DropDownList)ctrl).SelectedIndex = 0;
                ClearInputs(ctrl.Controls);
            }
        }
        protected void ddlSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            n_Sala n_sala = new n_Sala();
            ddlSala.DataTextField = "Sala";
            ddlSala.DataValueField = "ID_Sala";
            ddlSala.DataSource = n_sala.ObtenerTablaSalas(ddlSucursal.SelectedValue.ToString());
            ddlSala.DataBind();
        }

        protected void ddlPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            n_PxF n_pxf = new n_PxF();
            DataTable dt = n_pxf.ObtenerFormatosxPel(ddlPeliculas.SelectedValue);

            ddlFormatos.DataTextField = "Nombre_Formato";
            ddlFormatos.DataValueField = "ID_Formato";
            ddlFormatos.DataSource = dt;
            ddlFormatos.DataBind();

        }

        protected void btnAgregarFuncion_Click(object sender, EventArgs e)
        {
            if (rfv1.IsValid && rfv2.IsValid && rfv3.IsValid && rfv5.IsValid && rfv6.IsValid)
            {
                Funcion funcion = new Funcion();
                funcion.IDFuncion = "FUN00" + (grdFunciones.Rows.Count + 1);

                //if (grdFunciones.Rows.Count < 10)
                //    funcion.IDFuncion = "FUN00" + (grdFunciones.Rows.Count + 1);
                //if (grdFunciones.Rows.Count > 10 && grdFunciones.Rows.Count < 100)
                //    funcion.IDFuncion = "FUN00" + (grdFunciones.Rows.Count + 1);
                //if (grdFunciones.Rows.Count > 100)
                //    funcion.IDFuncion = "FUN" + (grdFunciones.Rows.Count + 1);

                if (grdFunciones.Rows.Count > 0)
                {
                    if (grdFunciones.Rows.Count >= 9)
                    {
                        if (grdFunciones.Rows.Count >= 99) funcion.IDFuncion = "FUN" + grdFunciones.Rows.Count + 1;
                        else funcion.IDFuncion = "FUN0" + (grdFunciones.Rows.Count + 1).ToString();
                    }
                    else funcion.IDFuncion = "FUN00" + (grdFunciones.Rows.Count + 1).ToString();
                }
                else
                {
                    funcion.IDFuncion = "FUN001";
                }


                funcion.IDPelicula = ddlPeliculas.SelectedValue.ToString();
                funcion.IDFormato = ddlFormatos.SelectedValue.ToString();
                funcion.IDSucursal = ddlSucursal.SelectedValue.ToString();

                funcion.IDSala = ddlSala.SelectedValue.ToString();
                String[] hor = txtHorario.Text.Split(':');
                int hora = Int32.Parse(hor[0]);
                int min = Int32.Parse(hor[1]);

                DateTime datetime = new DateTime(calFecha.SelectedDate.Year, calFecha.SelectedDate.Month,
                    calFecha.SelectedDate.Day, hora, min, 0);
                funcion.FechaHora = datetime;

                n_Funcion n_funcion = new n_Funcion();
                if (n_funcion.insertarFuncion(funcion))
                {
                    lblAgregado.Text = "Cargado exitosamente.";
                    lblAgregado.ForeColor = System.Drawing.Color.Green;
                    cargarGrilla();


                }
                else
                {
                    lblAgregado.Text = "Error al agregar.";
                    lblAgregado.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblAg.Text = "Complete los campos necesarios!";
            }

        }
        
    }
}