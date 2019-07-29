using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;
using System.Data;


namespace PRESENTACION
{
    public partial class R_Recaudaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) CargarDDLAños();
        }

        public void CargarDDLAños()
        {
            string Consulta = "select DISTINCT DATEPART(YEAR,FechaHora_Venta) as Anio FROM Ventas " +
             "Order by Anio DESC";
            n_Venta n_Venta = new n_Venta();
            DataTable dt = n_Venta.ObtenerTabla(Consulta);
            if (dt.Rows.Count > 0)
            {
                lblSinVentas.Visible = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ddlAños.Items.Add(dt.Rows[i]["Anio"].ToString());
                }
            }
            else
            {
                ddlAños.Visible = false;
                lblRecaudacion.Visible = false;
                btnFiltrar.Visible = false;
                grdVentas.Visible = false;
                lblSinVentas.Visible = true;
                lblSinVentas.Text = "Aun no ha habido ninguna venta.";
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
            Calcular();
        }

        protected void grdVentas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdVentas.PageIndex = e.NewPageIndex;
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            string Consulta = "select * from Ventas where DATEDIFF(year,FechaHora_Venta,'2019')=0";
            n_Venta n_Ven = new n_Venta();
            grdVentas.DataSource = n_Ven.ObtenerTabla(Consulta);
            grdVentas.DataBind();
        }

        public void Calcular()
        {
            double Total = 0;
            string Consulta = "select * from Ventas where DATEDIFF(year,FechaHora_Venta,'2019')=0";
            n_Venta n_Ven = new n_Venta();
            DataTable dt = n_Ven.ObtenerTabla(Consulta);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Total += Convert.ToDouble(dt.Rows[i]["PrecioFinal_Venta"].ToString());
            }

            lblRecaudacion.Text = "El total recaudado durante el año " + ddlAños.SelectedItem.ToString() + " fue un total de $" + Total;
        }

    }
}