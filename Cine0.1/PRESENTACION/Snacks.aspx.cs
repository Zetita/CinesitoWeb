using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class Snacks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void imgbtnSnack_Command(object sender, CommandEventArgs e)
        {
            string Consulta = "Select * from Snacks where ID_Snack='" + e.CommandName.TrimEnd()+"'";
            n_Snack Snack = new n_Snack();

            DataTable dt = Snack.ObtenerTabla(Consulta);

            imgProductoSelec.ImageUrl = dt.Rows[0]["URLImagen_Snack"].ToString();
            lblID.Text = "ID: " + e.CommandName;
            lblProducto.Text = "Producto: " + dt.Rows[0]["Nombre_Snack"].ToString();
            lblPrecio.Text = "Precio: " + dt.Rows[0]["Precio_Snack"].ToString();
        }
    }
}