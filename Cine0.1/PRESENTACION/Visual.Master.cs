using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRESENTACION
{
    public partial class Visual : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtSearch.Visible = false;
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("/Inicio.aspx");
        }

        protected void imgbtnUser_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["UserLogeado"] == null)
                Response.Redirect("/Registro.aspx");
            else
                Response.Redirect("/User.aspx");
        }

        protected void imgbtnSearch_Click(object sender, ImageClickEventArgs e)
        {
            if (txtSearch.Visible == true)
            {
                if (txtSearch.Value.ToString().Trim() != string.Empty)
                {
                    txtSearch.Visible = false;
                    Redirigir();
                }
                else
                {
                    txtSearch.Value = string.Empty;
                    txtSearch.Visible = false;
                }
            }
            else
            {
                txtSearch.Value = string.Empty;
                txtSearch.Visible = true;
            }
        }

        public void Redirigir()
        {
            Session["Filtro"] = txtSearch.Value.ToString();
            txtSearch.Value = string.Empty;
            Response.Redirect("Resultados.aspx");
        }

    }
}