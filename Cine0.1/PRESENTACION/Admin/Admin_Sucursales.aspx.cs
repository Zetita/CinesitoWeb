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
                    cargarGrillaSalas();
                    cargarDDLSucs();
                    ClearInputs(Page.Controls);
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
                    ClearInputs(Page.Controls);
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

    

        protected void grdSalas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdSalas.EditIndex = e.NewEditIndex;
            cargarGrillaSalas();
        }
        protected void grdSalas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String s_Sala = ((Label)grdSalas.Rows[e.RowIndex].FindControl("lbl_eit_IdSala")).Text;
            String s_Sucursal = ((Label)grdSalas.Rows[e.RowIndex].FindControl("lbl_eit_IDSucursal")).Text;
            String s_NombreSala = ((TextBox)grdSalas.Rows[e.RowIndex].FindControl("txt_eit_Sala")).Text;
            String s_Butacas = ((TextBox)grdSalas.Rows[e.RowIndex].FindControl("txt_eit_Butacas")).Text;
            
            

            Sala sala = new Sala();
            sala.IdSala = s_Sala;
            sala.IdSucursal = s_Sucursal;
            sala.NomSala = s_NombreSala;
            sala.Butacas = Int32.Parse(s_Butacas);
            
             n_Sala n_sala = new n_Sala();
            n_sala.editarSala(sala);

            grdSalas.EditIndex = -1;
            cargarGrillaSalas();
        }

        protected void grdSucursales_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdSucursales.EditIndex = e.NewEditIndex;
            cargarGrillaSuc();
        }
        protected void grdSucursales_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String s_Id = ((Label)grdSucursales.Rows[e.RowIndex].FindControl("lbl_eit_IDSucursal")).Text;
            String s_Nombre = ((TextBox)grdSucursales.Rows[e.RowIndex].FindControl("txt_eit_Nombre")).Text;
            String s_Direccion = ((TextBox)grdSucursales.Rows[e.RowIndex].FindControl("txt_eit_Direccion")).Text;
            String s_Localidad = ((TextBox)grdSucursales.Rows[e.RowIndex].FindControl("txt_eit_Localidad")).Text;
            String s_Provincia = ((TextBox)grdSucursales.Rows[e.RowIndex].FindControl("txt_eit_Provincia")).Text;
            String s_DireccionURL = ((TextBox)grdSucursales.Rows[e.RowIndex].FindControl("txt_eit_DireccionURL")).Text;


            Sucursal sucursal = new Sucursal();
            sucursal.idSucursal = s_Id;
            sucursal.Nombre = s_Nombre;
            sucursal.Direccion = s_Direccion;
            sucursal.Localidad = s_Localidad;
            sucursal.Provincia = s_Provincia;
            sucursal.DireccionURL = s_DireccionURL;

            n_Sucursal n_sucursal = new n_Sucursal();
            n_sucursal.editarSucursal(sucursal);

            grdSucursales.EditIndex = -1;
            cargarGrillaSuc();
        }

    }
}