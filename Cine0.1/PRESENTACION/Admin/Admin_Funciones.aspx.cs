using System;
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
            ddlSucursal.Items.Insert(0, "--Seleccione una Sucursal--");

            if (ddlSucursal.SelectedIndex != 0) { 
            n_Sala n_sala = new n_Sala();
            ddlSala.DataTextField = "Sala";
            ddlSala.DataValueField = "ID_Sala";
            ddlSala.DataSource = n_sala.ObtenerTablaSalas(ddlSala.SelectedValue.ToString());
            ddlSala.DataBind();
            }
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
            n_Funcion n_funcion = new n_Funcion();
            Funcion funcion = new Funcion();
            if (rfv1.IsValid && rfv2.IsValid && rfv3.IsValid && rfv5.IsValid && rfv6.IsValid)
            {
                
                if (n_funcion.ObtenerCantRegistros() < 10)
                    funcion.IDFuncion = "FUN00" + (n_funcion.ObtenerCantRegistros() + 1);
                if (n_funcion.ObtenerCantRegistros() >= 10 && n_funcion.ObtenerCantRegistros() < 100)
                    funcion.IDFuncion = "FUN00" + (n_funcion.ObtenerCantRegistros() + 1);
                if (n_funcion.ObtenerCantRegistros() >= 100)
                    funcion.IDFuncion = "FUN" + (n_funcion.ObtenerCantRegistros() + 1);



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

        protected void grdFunciones_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            n_PxF n_pxf = new n_PxF();
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    DropDownList ddl_eit_Formato = (DropDownList)e.Row.FindControl("ddl_eit_Formato");
                    Label lbl_eit_idpxf = (Label)e.Row.FindControl("lbl_eit_idpxf");

                    //bind dropdown-list
                    DataTable dt = n_pxf.ObtenerFormatosxPel(lbl_eit_idpxf.Text);

                    ddl_eit_Formato.DataTextField = "Nombre_Formato";
                    ddl_eit_Formato.DataValueField = "ID_Formato";
                    ddl_eit_Formato.DataSource = dt;
                    ddl_eit_Formato.DataBind();

                    DataRowView dr = e.Row.DataItem as DataRowView;

                    ddl_eit_Formato.SelectedValue = dr["ID_Formato"].ToString();

                    /////////////////
                    DropDownList ddl_eit_Sucursal = (DropDownList)e.Row.FindControl("ddl_eit_Sucursal");
                    n_Sucursal n_sucursal = new n_Sucursal();
                    ddl_eit_Sucursal.DataTextField = "Nombre_Sucursal";
                    ddl_eit_Sucursal.DataValueField = "ID_Sucursal";
                    ddl_eit_Sucursal.DataSource = n_sucursal.ObtenerTabla();
                    ddl_eit_Sucursal.DataBind();
                    DataRowView dr1 = e.Row.DataItem as DataRowView;

                    ddl_eit_Formato.SelectedValue = dr["ID_Sucursal"].ToString();
                    //////////////
                    ///
                    
                  
                     n_Sala n_sala = new n_Sala();
                    DropDownList ddl_eit_Sala = (DropDownList)e.Row.FindControl("ddl_eit_sala");

                    ddl_eit_Sala.DataTextField = "Sala";
                    ddl_eit_Sala.DataValueField = "ID_Sala";
                    ddl_eit_Sala.DataSource = n_sala.ObtenerTablaSalas(ddl_eit_Sucursal.SelectedValue.ToString());
                    ddl_eit_Sala.DataBind();
                    DataRowView dr2 = e.Row.DataItem as DataRowView;

                    ddl_eit_Formato.SelectedValue = dr["ID_Sala"].ToString();

                   
                    

                }
            }
        }



        protected void grdFunciones_RowEditing(object sender, GridViewEditEventArgs e)
        {
            

            grdFunciones.EditIndex = e.NewEditIndex;
            cargarGrilla();
        }

        protected void grdFunciones_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdFunciones.EditIndex = -1;
            cargarGrilla();
        }

        protected void grdFunciones_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String s_IDFuncion = ((Label)grdFunciones.Rows[e.RowIndex].FindControl("lbl_eit_IdFuncion")).Text;
            String s_IDPelicula = ((Label)grdFunciones.Rows[e.RowIndex].FindControl("lbl_eit_Idpxf")).Text;
            String s_Formato = ((DropDownList)grdFunciones.Rows[e.RowIndex].FindControl("ddl_eit_Formato")).Text;
            String s_Sucursal = ((DropDownList)grdFunciones.Rows[e.RowIndex].FindControl("ddl_eit_Sucursal")).Text;
            String s_Sala = ((DropDownList)grdFunciones.Rows[e.RowIndex].FindControl("ddl_eit_Sala")).Text;

            String time = ((TextBox)grdFunciones.Rows[e.RowIndex].FindControl("txt_eit_Horario")).Text;
            int fechaAnio= ((Calendar)grdFunciones.Rows[e.RowIndex].FindControl("cal_eit_fecha")).SelectedDate.Year;
            int fechaMes = ((Calendar)grdFunciones.Rows[e.RowIndex].FindControl("cal_eit_fecha")).SelectedDate.Month;
            int fechaDia = ((Calendar)grdFunciones.Rows[e.RowIndex].FindControl("cal_eit_fecha")).SelectedDate.Day;


            String[] hor = time.Split(':');
            int hora = Int32.Parse(hor[0]);
            int min = Int32.Parse(hor[1]);

            DateTime s_Fhf = new DateTime(fechaAnio,fechaMes,fechaDia, hora, min, 0);
            


            Funcion funcion = new Funcion();
            funcion.IDFuncion = s_IDFuncion;
            funcion.IDPelicula = s_IDPelicula;
            funcion.IDFormato = s_Formato;
            funcion.IDSucursal = s_Sucursal;
            funcion.IDSala = s_Sala;
            funcion.FechaHora = s_Fhf;
    
            n_Funcion n_funcion = new n_Funcion();
            n_funcion.editarFuncion(funcion);

            grdFunciones.EditIndex = -1;
            cargarGrilla();
        }

        protected void grdFunciones_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdFunciones.PageIndex = e.NewPageIndex;
            cargarGrilla();
        }

    }
}