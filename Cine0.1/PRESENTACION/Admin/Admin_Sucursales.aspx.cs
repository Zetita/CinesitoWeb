using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTIDAD;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class Admin_Sucursales : System.Web.UI.Page
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
                cargarGrillaSuc();
                cargarGrillaSuc();

            }
        }
        public void cargarGrillaSuc()
        {
            n_Sucursal n_sucursal = new n_Sucursal();
            grdSucursales.DataSource = n_sucursal.ObtenerTabla();
            grdSucursales.DataBind();
        }
        public void cargarGrillaSalas()
        {
            n_Sala n_sala = new n_Sala();
            grdSalas.DataSource = n_sala.ObtenerTablaSalas();
            grdSalas.DataBind();
        }

        protected void btnAgregarSuc_Click(object sender, EventArgs e)
        {
            if(rfv1.IsValid && rfv2.IsValid && rfv3.IsValid && rfv4.IsValid && rfv5.IsValid)
            {
                Sucursal sucursal = new Sucursal();

                if (grdSucursales.Rows.Count < 10)
                    sucursal.idSucursal = "SUCOO" + (grdSucursales.Rows.Count + 1);
                if (grdSucursales.Rows.Count > 10 && grdSucursales.Rows.Count < 100)
                    sucursal.idSucursal = "SUCO" + (grdSucursales.Rows.Count + 1);
                if (grdSucursales.Rows.Count > 10)
                    sucursal.idSucursal = "SUC" + (grdSucursales.Rows.Count + 1);

                sucursal.Nombre = txtNombre.Text;
                sucursal.Direccion = txtDireccion.Text;
                sucursal.Localidad = txtLocalidad.Text;
                sucursal.Provincia = txtProvincia.Text;
                sucursal.DireccionURL = txtDireccionURL.Text;

                n_Sucursal n_sucursal = new n_Sucursal();

                if(n_sucursal.insertarSucursal(sucursal))
                {
                    lblAgregado.Text = "Cargado exitosamente.";
                    lblAgregado.ForeColor = System.Drawing.Color.Green;
                    cargarGrillaSuc();
                }
                else
                {
                    lblAgregado.Text = "Error al cargar.";
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