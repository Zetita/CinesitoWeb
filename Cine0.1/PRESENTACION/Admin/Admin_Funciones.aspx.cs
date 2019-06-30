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
            n_PxF n_pxf = new n_PxF();
            ddlPXF.DataTextField = "ID_PxF";
            ddlPXF.DataValueField = "ID_PxF";
            ddlPXF.DataSource = n_pxf.ObtenerTabla();
            ddlPXF.DataBind();

            //ddlPXF.Items.Insert(0, "---Nada selecionado---");
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

        protected void ddlSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            n_Sala n_sala = new n_Sala();
            ddlSala.DataTextField = "Sala";
            ddlSala.DataValueField = "ID_Sala";
            ddlSala.DataSource = n_sala.ObtenerTablaSalas(ddlSucursal.SelectedValue.ToString());
            ddlSala.DataBind();
        }

        protected void ddlPXF_SelectedIndexChanged(object sender, EventArgs e)
        {
            //n_PxF n_pxf = new n_PxF();
            //DataTable dt = n_pxf.ObtenerTituloFormato(ddlPXF.Text);
            //lblPeliculaFormato.Text = dt.Rows[1][0].ToString() + " - "+ dt.Rows[1][1].ToString();
            
        }

        protected void btnAgregarFuncion_Click(object sender, EventArgs e)
        {
            if (rfv1.IsValid && rfv2.IsValid && rfv3.IsValid && rfv5.IsValid)
            {
                Funcion funcion = new Funcion();
                funcion.IDFuncion = "FN00" + (grdFunciones.Rows.Count + 1);
                funcion.IDPxF = ddlPXF.SelectedValue.ToString();
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