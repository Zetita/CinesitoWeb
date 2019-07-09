using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;

namespace PRESENTACION.User
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Session["UserLogeado"].ToString();
            
            n_Venta n_venta = new n_Venta();

            if(n_venta.ObtenerTablaVenta(lblUsuario.Text)==null)
                lblSinCompras.Text = "Aun no has comprado entradas, revisa la cartelera para comprar.";
        }

        protected void lbCerrar_Click(object sender, EventArgs e)
        {
            Session["UserLogeado"] = null;
            Response.Redirect("Inicio.aspx");
        }
    }
}