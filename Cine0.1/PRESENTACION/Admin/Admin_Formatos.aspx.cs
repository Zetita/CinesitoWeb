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
    public partial class Admin_Formatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                cargarGrilla();
            }

        }
        public void cargarGrilla()
        {
            n_Formato n_formato = new n_Formato();
            grdFormatos.DataSource = n_formato.ObtenerTabla();
            grdFormatos.DataBind();
            
        }
        void ClearInputs(ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                ClearInputs(ctrl.Controls);
            }
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (rfv1.IsValid && rfv2.IsValid && rfv3.IsValid && rfv4.IsValid && cv1.IsValid)
            {
                Formato formato = new Formato();

                if (grdFormatos.Rows.Count < 10)
                    formato.IdFormato = "FOR00" + (grdFormatos.Rows.Count + 1);
                if (grdFormatos.Rows.Count > 10 && grdFormatos.Rows.Count < 100)
                    formato.IdFormato = "FOR0" + (grdFormatos.Rows.Count + 1);
                if (grdFormatos.Rows.Count > 100)
                    formato.IdFormato = "FOR" + (grdFormatos.Rows.Count + 1);
                formato.Nombre = txtNombre.Text;
                formato.Idioma = txtIdioma.Text;

                if (rblSubs.SelectedValue == "1")
                    formato.Subtitulos = true;
                else
                    formato.Subtitulos = false;
                
                formato.Precio = float.Parse(txtPrecio.Text);

                n_Formato n_formato = new n_Formato();

                if (n_formato.insertarFormato(formato))
                {
                    lblAgregado.Text = "Cargado exitosamente.";
                    lblAgregado.ForeColor = System.Drawing.Color.Green;
                    cargarGrilla();
                    ClearInputs(Page.Controls);

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

        protected void grdFormatos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdFormatos.PageIndex = e.NewPageIndex;
            cargarGrilla();
        }

        protected void grdFormatos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdFormatos.EditIndex = e.NewEditIndex;
            cargarGrilla();
        }

        protected void grdFormatos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdFormatos.EditIndex = -1;
            cargarGrilla();
        }

        protected void grdFormatos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String s_IdFormato = ((Label)grdFormatos.Rows[e.RowIndex].FindControl("lbl_eit_IDFormato")).Text;
            String s_Nombre = ((TextBox)grdFormatos.Rows[e.RowIndex].FindControl("txt_eit_Nombre")).Text;
            String s_Idioma = ((TextBox)grdFormatos.Rows[e.RowIndex].FindControl("txt_eit_Idioma")).Text;
            bool b_Subtitulos;
            if (((CheckBox)grdFormatos.Rows[e.RowIndex].FindControl("cb_eit_Subtitulos")).Checked == true)
                b_Subtitulos = true;
            else
                b_Subtitulos = false;



            Double d_Precio = Double.Parse(((TextBox)grdFormatos.Rows[e.RowIndex].FindControl("txt_eit_Precio")).Text);

            Formato formato = new Formato();
            formato.IdFormato = s_IdFormato;
            formato.Nombre = s_Nombre;
            formato.Idioma = s_Idioma;
            formato.Subtitulos = b_Subtitulos;
            formato.Precio = d_Precio;

            n_Formato n_formato = new n_Formato();
            n_formato.editarFormato(formato);

            grdFormatos.EditIndex = -1;
            cargarGrilla();
        }
    }
}