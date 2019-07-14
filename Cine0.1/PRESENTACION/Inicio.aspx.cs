using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRESENTACION
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["Error"] != null&& Request.Cookies["Error"].Value.ToString() == "1")
            {
                
                    Response.Write("<script>window.alert('Para comprar, primero debe haber iniciado sesión.');</script>");
                    Request.Cookies["Error"].Expires = DateTime.Now.AddDays(-1);
                    this.Response.Cookies.Add(Request.Cookies["Error"]);
                
            }
            else if(Request.Cookies["Compra"] != null && Request.Cookies["Compra"].Value.ToString() == "1")
            {
                Response.Write("<script>window.alert('Compra realizada con exito.');</script>");
                Request.Cookies["Compra"].Expires = DateTime.Now.AddDays(-1);
                this.Response.Cookies.Add(Request.Cookies["Compra"]);
            }

        }

        protected void imgbtn_Pelicula_Command1(object sender, CommandEventArgs e)
        {
            Application["ID_Pelicula"] = e.CommandName.Trim();
            Response.Redirect("Peliculas.aspx");
        }
    }
}