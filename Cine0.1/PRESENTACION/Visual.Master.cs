﻿using System;
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
                Response.Redirect("/User/User.aspx");
        }

    }
}