﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using ENTIDAD;
using NEGOCIO;
namespace PRESENTACION
{
    public partial class Sucursales : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
          


               
           if (!IsPostBack) { 
                cargarDDL();
            }


        }

       protected void cargarDDL()
        {
           
            n_Sucursal n_sucursal = new n_Sucursal();
            DataTable dt = n_sucursal.ObtenerTabla();
            
            DdlSucursal.DataTextField = "Nombre_Sucursal";
            DdlSucursal.DataValueField = "ID_Sucursal";
            DdlSucursal.DataSource = n_sucursal.ObtenerTabla();
            DdlSucursal.DataBind();
            DdlSucursal.Items.Insert(0, "----Seleccione Sucursal----");

        }

        protected void DdlSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

            n_Sucursal n_sucursal = new n_Sucursal();
            DataTable dt = n_sucursal.ObtenerTabla();

            if (DdlSucursal.SelectedIndex == 0)
            {
                lblDireccion.Text = "";
                lblLocalidad.Text = "";
                lblProvincia.Text = "";
                lblMapita.Text = "";

            }

            if (DdlSucursal.SelectedIndex != 0) { 
            lblDireccion.Text = dt.Rows[DdlSucursal.SelectedIndex-1]["Direccion_Sucursal"].ToString();
            lblLocalidad.Text = dt.Rows[DdlSucursal.SelectedIndex-1]["Localidad_Sucursal"].ToString();
            lblProvincia.Text = dt.Rows[DdlSucursal.SelectedIndex-1]["Provincia_Sucursal"].ToString();
            lblMapita.Text= "<iframe src ="+dt.Rows[DdlSucursal.SelectedIndex-1]["DireccionURL"]+"width = '500' height = '500' frameborder = '0' style = 'border:0' allowfullscreen ></iframe>";
            }



        }
    }
}