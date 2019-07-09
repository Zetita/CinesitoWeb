using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class Admin_Ventas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            n_Pelicula Pelicula = new n_Pelicula();
            DataTable dt = Pelicula.ObtenerTabla();

            ddlFormato.Enabled = true;
            ddlDia.Enabled = false;
            ddlHorario.Enabled = false;

            //if (ddlFormato.SelectedItem.ToString() == "-")
            //{
            //    Boton("0");
            //    ddlDia.Enabled = false;
            //    ddlHorario.Enabled = false;
            //}
            //if (ddlCine.SelectedItem.ToString() != "-")
            //{
            //    ddlFormato.Items.Clear();
            //    ddlFormato.Items.Add("-");

            //    LlenarDDLFormatos(dt);
            //    Application["ID_Sucursal"] = ddlCine.SelectedItem.Value.ToString();

            //    Boton("0");
            //}
            //else
            //{
            //    ddlFormato.Enabled = false;
            //}
        }

        protected void DdpPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}