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
            //ValidationSettings.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.WebForms;
            if (!IsPostBack)
            {
                cargarGrilla();
                ///CargarDDL();
            }
        }
        public void cargarGrilla()
        {
            n_Usuario n_usuario = new n_Usuario();
            n_Snack n_snack = new n_Snack();
            grdSnacks.DataSource = n_snack.ObtenerTabla();
            grdSnacks.DataBind();
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (rfv1.IsValid && rfv2.IsValid && rfv3.IsValid && rfv4.IsValid && rfv5.IsValid)
            {
                String pathCarpeta = @"img\snacks\";
                String savePath = Server.MapPath("~") + pathCarpeta;
                String fileName = FileImagen.FileName;
                String pathCompleta = savePath + fileName;

                Snack snack = new Snack();
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
        
    }
}