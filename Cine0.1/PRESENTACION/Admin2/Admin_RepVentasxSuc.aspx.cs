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
    public partial class RepVentasxSuc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) CargarDDL();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
            Calcular();
        }

        public void CargarDDL()
        {
            string Consulta = ArmarConsulta(0);
            n_Venta n_ven = new n_Venta();
            DataTable dt = n_ven.ObtenerTabla(Consulta);
            if (dt.Rows.Count > 0)
            {
                lblSinVentas.Visible = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ddlSuc.Items.Add(dt.Rows[i]["Nombre_Sucursal"].ToString());
                    ddlSuc.Items[i].Value = dt.Rows[i]["ID_Sucursal"].ToString();
                }
            }
            else
            {
                ddlSuc.Visible = false;
                lblRecaudacion.Visible = false;
                btnFiltrar.Visible = false;
                grdVentas.Visible = false;
                lblSinVentas.Visible = true;
                lblSinVentas.Text = "Aun no ha habido ninguna venta.";
            }
        }

        public string ArmarConsulta(int Origen)
        {
            if (Origen == 0)
            {
                return "Select DISTINCT Sucursales.ID_Sucursal,Sucursales.Nombre_Sucursal from Ventas " +
                       "Inner Join DetalleVentas ON DetalleVentas.ID_Venta = Ventas.ID_Venta " +
                       "Inner Join Funciones ON Funciones.ID_Funcion = DetalleVentas.ID_Funcion " +
                       "Inner Join Sucursales ON Sucursales.ID_Sucursal = Funciones.ID_Sucursal ";
            }
            else
            {
                return "Select * from Ventas " +
                       "Inner Join DetalleVentas ON DetalleVentas.ID_Venta = Ventas.ID_Venta " +
                       "Inner Join Funciones ON Funciones.ID_Funcion = DetalleVentas.ID_Funcion " +
                       "Inner Join Sucursales ON Sucursales.ID_Sucursal = Funciones.ID_Sucursal "+
                       "Where Sucursales.ID_Sucursal='" + ddlSuc.SelectedValue + "'"; 
            }
        }

        public void CargarGrilla()
        {
            string Consulta = ArmarConsulta(1);
            n_Venta n_ven = new n_Venta();
            grdVentas.DataSource = n_ven.ObtenerTabla(Consulta);
            grdVentas.DataBind();
        }

        protected void grdVentas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdVentas.PageIndex = e.NewPageIndex;
            CargarGrilla();
        }

        public void Calcular()
        {
            double Total = 0;
            string Consulta = ArmarConsulta(1);
            n_Venta n_Ven = new n_Venta();
            DataTable dt = n_Ven.ObtenerTabla(Consulta);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Total += Convert.ToDouble(dt.Rows[i]["PrecioFinal_Venta"].ToString());
            }

            lblRecaudacion.Text = "El total recaudado por la sucursal de " + ddlSuc.SelectedItem.ToString() + " fue un total de $" + Total;
        }
    }
}