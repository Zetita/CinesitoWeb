﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ENTIDAD;
using NEGOCIO;
using DAO;

namespace PRESENTACION
{
    public partial class Admin_Snacks : System.Web.UI.Page
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
            n_Snack n_snack = new n_Snack();
            grdSnacks.DataSource = n_snack.ObtenerTabla();
            grdSnacks.DataBind();
        }
        public void cargarDDL()
        {

            ddlTipoSnack.Items.Add("Pochoclos");
            ddlTipoSnack.Items.Add("Bebidas");
            ddlTipoSnack.Items.Add("Snacks");
            ddlTipoSnack.Items.Add("Golosinas");
            ddlTipoSnack.Items.Insert(0, "-Seleccione algun tipo-");
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
        protected void grdSnacks_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdSnacks.PageIndex = e.NewPageIndex;
            cargarGrilla();
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            if (rfv1.IsValid && rfv2.IsValid && rfv3.IsValid && rfv4.IsValid && rfv5.IsValid && cv1.IsValid && ddlTipoSnack.SelectedIndex != 0)
            {
                String pathCarpeta = @"img\snacks\";
                String savePath = Server.MapPath("~") + pathCarpeta;
                String fileName = FileImagen.FileName;
                String pathCompleta = savePath + fileName;

                Snack snack = new Snack();
                if (grdSnacks.Rows.Count < 10)
                    snack.idSnack = "SNC00" + (grdSnacks.Rows.Count + 1);
                if (grdSnacks.Rows.Count >= 10 && grdSnacks.Rows.Count < 100)
                    snack.idSnack = "SNCC0" + (grdSnacks.Rows.Count + 1);
                if (grdSnacks.Rows.Count >= 100)
                    snack.idSnack = "SNC" + (grdSnacks.Rows.Count + 1);

                snack.Nombre = txtSnack.Text;
                snack.Tipo = ddlTipoSnack.Text;
                snack.Precio = Double.Parse(txtPrecio.Text);

                if (rbtnEstado.SelectedValue == "1")
                    snack.Estado = true;
                else
                    snack.Estado = false;
                String rutaBase = "~/img/snacks/" + fileName;
                snack.ImagenURL = rutaBase;

                n_Snack n_snack = new n_Snack();

                if (n_snack.insertarSnack(snack))
                {
                    lblAgregado.Text = "Cargado exitosamente.";
                    lblAgregado.ForeColor = System.Drawing.Color.Green;
                    cargarGrilla();
                    ClearInputs(Page.Controls);
                    AgregarImagen();
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

        protected void grdSnacks_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String codigo = ((Label)grdSnacks.Rows[e.RowIndex].FindControl("lbl_IdSnack")).Text;

            Snack snack = new Snack();
            snack.idSnack = codigo;
            snack.Estado = false;

            n_Snack n_snack = new n_Snack();
            n_snack.eliminarSnack(snack);

            cargarGrilla();
        }



        protected void grdSnacks_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdSnacks.EditIndex = e.NewEditIndex;
            cargarGrilla();
        }

        protected void grdSnacks_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdSnacks.EditIndex = -1;
            cargarGrilla();
        }

        protected void grdSnacks_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String s_IdSnack = ((Label)grdSnacks.Rows[e.RowIndex].FindControl("lbl_eit_IdSnack")).Text;
            String s_Nombre = ((TextBox)grdSnacks.Rows[e.RowIndex].FindControl("txt_eit_Nombre")).Text;
            String s_Tipo = ((DropDownList)grdSnacks.Rows[e.RowIndex].FindControl("ddl_eit_TipoSnack")).Text;
            Double d_Precio = Double.Parse(((TextBox)grdSnacks.Rows[e.RowIndex].FindControl("txt_eit_Precio")).Text);
            String s_UrlImagen = ((FileUpload)grdSnacks.Rows[e.RowIndex].FindControl("FileUpload1")).FileName;

            String ruta = string.Empty;

            if (s_UrlImagen == string.Empty)
            {
                ruta = VerificarImagen(s_IdSnack);
            }
            else
            {
                ruta = "~/img/snacks/" + s_UrlImagen;
            }
            bool b_Estado;

            if (((CheckBox)grdSnacks.Rows[e.RowIndex].FindControl("cb_eit_Estado")).Checked == true)
                b_Estado = true;
            else
                b_Estado = false;

            Snack snack = new Snack();
            snack.idSnack = s_IdSnack;
            snack.Nombre = s_Nombre;
            snack.Tipo = s_Tipo;
            snack.Precio = d_Precio;
            snack.ImagenURL = ruta;
            snack.Estado = b_Estado;

            n_Snack n_snack = new n_Snack();
            n_snack.editarSnack(snack);

            grdSnacks.EditIndex = -1;
            cargarGrilla();
        }

        public void AgregarImagen()
        {
            string extension = string.Empty;
            string oPath = string.Empty;
            if (FileImagen.HasFile)
            {
                extension = FileImagen.FileName.ToString();
                if (extension.Contains(".jpg") || extension.Contains(".png") || extension.Contains(".gif"))
                {
                    oPath = Server.MapPath(string.Format("~/img/snacks/" + FileImagen.FileName));
                    FileImagen.SaveAs(oPath);

                }
                else
                {
                    Response.Write("<script>window.alert('Error de Formato.');</script>");
                }
            }
        }

        public string VerificarImagen(string id)
        {
            n_Snack n_Sna = new n_Snack();
            DataTable dt = n_Sna.ObtenerTabla();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["ID_Snack"].ToString() == id)
                {
                    return dt.Rows[i]["URLImagen_Snack"].ToString();
                }
            }
            return string.Empty;
        }

        protected void grdSnacks_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            n_Snack n_snack = new n_Snack();
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    DropDownList ddl_eit_Tipo = (DropDownList)e.Row.FindControl("ddl_eit_TipoSnack");


                    //bind dropdown-list

                    ddl_eit_Tipo.Items.Add("Pochoclos");
                    ddl_eit_Tipo.Items.Add("Bebidas");
                    ddl_eit_Tipo.Items.Add("Snacks");
                    ddl_eit_Tipo.Items.Add("Golosinas");


                    ddl_eit_Tipo.Items.Insert(0, "-Seleccione algun tipo-");


                    DataRowView dr = e.Row.DataItem as DataRowView;

                    ddl_eit_Tipo.SelectedValue = dr["Tipo_Snack"].ToString();
                }
            }
        }
    }
}