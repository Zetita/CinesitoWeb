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
            int Mensaje;
            if(Request.Cookies["Mensaje"] != null)
            {
                Mensaje = Convert.ToInt32(Request.Cookies["Mensaje"].Value.ToString());
                switch (Mensaje)
                {
                    case 1:
                        Response.Write("<script>window.alert('Para comprar, primero debe haber iniciado sesión.');</script>");
                        break;
                    case 2:
                        Response.Write("<script>window.alert('Compra realizada con exito.');</script>");
                        break;
                    case 3:
                        Response.Write("<script>window.alert('Se cerró la sesión.');</script>");
                        break;
                    case 4:
                        Response.Write("<script>window.alert('Sesión iniciada.');</script>");
                        break;
                }
                Request.Cookies["Mensaje"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(Request.Cookies["Mensaje"]);
            }
        }

        protected void imgbtn_Pelicula_Command1(object sender, CommandEventArgs e)
        {
            Application["ID_Pelicula"] = e.CommandName.Trim();
            Response.Redirect("Peliculas.aspx");
        }
    }
}