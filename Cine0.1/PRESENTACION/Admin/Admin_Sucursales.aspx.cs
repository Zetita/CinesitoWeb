using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTIDAD;
using NEGOCIO;
using System.Data;

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
                cargarGrillaSalas();
                cargarDDLSucs();
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
        public void cargarDDLSucs()
        {
            n_Sucursal n_sucursal = new n_Sucursal();
            ddlSucursales.DataTextField = "Nombre_Sucursal";
            ddlSucursales.DataValueField = "ID_Sucursal";
            ddlSucursales.DataSource = n_sucursal.ObtenerTabla();
            ddlSucursales.DataBind();
            ddlSucursales.Items.Insert(0, "--Seleccione una sucursal--");
        }
        protected void btnAgregarSuc_Click(object sender, EventArgs e)
        {
            if(rfv1.IsValid && rfv2.IsValid && rfv3.IsValid && rfv4.IsValid && rfv5.IsValid)
            {
                Sucursal sucursal = new Sucursal();

                if (grdSucursales.Rows.Count < 10)
                    sucursal.idSucursal = "SUC00" + (grdSucursales.Rows.Count + 1);
                if (grdSucursales.Rows.Count > 10 && grdSucursales.Rows.Count < 100)
                    sucursal.idSucursal = "SUC0" + (grdSucursales.Rows.Count + 1);
                if (grdSucursales.Rows.Count > 100)
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

        protected void btnAgregarSala_Click(object sender, EventArgs e)
        {
            if(rfv6.IsValid && rfv7.IsValid && rfv8.IsValid && cv1.IsValid)
            {
                Sala sala = new Sala();
                n_Sala n_sala = new n_Sala();
                
                if (grdSalas.Rows.Count < 10)
                    sala.IdSala = "SAL00" + (grdSalas.Rows.Count + 1);
                if (grdSalas.Rows.Count > 10 && grdSalas.Rows.Count < 100)
                    sala.IdSala = "SAL0" + (grdSalas.Rows.Count + 1);
                if (grdSalas.Rows.Count > 100)
                    sala.IdSala = "SAL" + (grdSalas.Rows.Count + 1);

                sala.IdSucursal = ddlSucursales.SelectedValue.ToString();
                sala.NomSala = txtSala.Text;
                sala.Butacas = Int32.Parse(txtButacas.Text);

                if (n_sala.insertarSala(sala))
                {
                    lblAgregado2.Text = "Cargado exitosamente.";
                    lblAgregado2.ForeColor = System.Drawing.Color.Green;
                    cargarGrillaSalas();
                }
                else
                {
                    lblAgregado2.Text = "Error al cargar.";
                    lblAgregado.ForeColor = System.Drawing.Color.Red;
                }

            }
            else
            {
                lblAg2.Text = "Complete los campos necesarios!";
            }
        }

        protected void grdSucursales_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //String codigo = ((Label)grdSucursales.Rows[e.RowIndex].FindControl("lbl_it_IDSucursal")).Text;

            //Sucursal suc = new Sucursal();
            //suc.idSucursal = codigo;
            //suc.Estado = false;

            //n_Sucursal n_sucursal = new n_Sucursal();
            //n_sucursal.eliminarSucursal(suc);

            //cargarGrillaSuc();
        }
    }
}