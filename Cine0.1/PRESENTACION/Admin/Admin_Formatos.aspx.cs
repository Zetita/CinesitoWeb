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
    }
}