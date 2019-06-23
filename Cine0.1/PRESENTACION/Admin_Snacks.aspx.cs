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

        protected void grdSnacks_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdSnacks.PageIndex = e.NewPageIndex;
            cargarGrilla();
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ddlTipoSnack.SelectedIndex == 0)
                rfv2.IsValid = false;
            if (rfv1.IsValid && rfv2.IsValid && rfv3.IsValid && rfv4.IsValid && rfv5.IsValid)
            {
                String pathCarpeta = @"img\snacks\";
                String savePath = Server.MapPath("~") + pathCarpeta;
                String fileName = FileImagen.FileName;
                String pathCompleta = savePath + fileName;

                Snack snack = new Snack();
                snack.idSnack = "SN00" + (grdSnacks.Rows.Count + 1);
                snack.Nombre = txtSnack.Text;
                snack.Tipo = ddlTipoSnack.Text;
                snack.Precio = Double.Parse(txtPrecio.Text);
                snack.Estado = true;
                String rutaBase = "~/img/snacks/" + fileName;
                snack.ImagenURL = rutaBase;

                n_Snack n_snack = new n_Snack();


                if (n_snack.insertarSnack(snack))
                {
                    lblAgregado.Text = "Exito al agregar";
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
            String s_Tipo = ((Label)grdSnacks.Rows[e.RowIndex].FindControl("lbl_eit_Tipo")).Text;
            Double d_Precio = Double.Parse(((TextBox)grdSnacks.Rows[e.RowIndex].FindControl("txt_eit_Precio")).Text);
            String s_urlImagen = ((Label)grdSnacks.Rows[e.RowIndex].FindControl("img_eit_Imagen.ImagenURL")).Text; //arreglar
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
            snack.ImagenURL = s_urlImagen;
            snack.Estado = b_Estado;

            n_Snack n_snack = new n_Snack();
            n_snack.editarSnack(snack);

            grdSnacks.EditIndex = -1;
            cargarGrilla();
        }
    }
}