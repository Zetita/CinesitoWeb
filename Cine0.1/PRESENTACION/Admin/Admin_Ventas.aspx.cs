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

            if (!IsPostBack)
            {
                LlenarDDLPeliculas(dt);
            }
        }

        protected void ddlPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            n_Sucursal Sucursal = new n_Sucursal();
            DataTable dt = Sucursal.ObtenerTabla();
            if (ddlPelicula.SelectedItem.ToString() != "-")
            {
                ddlSucursal.Enabled = true;
                ddlSucursal.Items.Clear();
                ddlSucursal.Items.Add("-");
                LlenarDDLSucursales(dt);
            }
            else
            {
                ddlSucursal.Enabled = false;
            }
           
        }

        protected void ddlSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            n_Formato Formato = new n_Formato();
            DataTable dt = Formato.ObtenerTabla();
            if (ddlSucursal.SelectedItem.ToString() != "-" && ddlPelicula.SelectedItem.ToString() != "-")
            {
                ddlFormato.Enabled = true;
                ddlFormato.Items.Clear();
                ddlFormato.Items.Add("-");
                LlenarDDLFormato(dt);
            }
            else
            {
                ddlFormato.Enabled = false;
            }
        }

        protected void ddlFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
            n_Funcion Funcion = new n_Funcion();
            DataTable dt = new DataTable();
            string Consulta = string.Empty;
            string IDPxF = string.Empty;
            if(ddlFormato.SelectedItem.ToString() != "-" && ddlSucursal.SelectedItem.ToString() != "-" && ddlPelicula.SelectedItem.ToString() != "-")
            {
                IDPxF = ArmarIDPxF();
                Session["IDPxF"] = IDPxF;
                Consulta = ArmarConsulta(IDPxF,ddlSucursal.SelectedValue.ToString(),0);

                dt = Funcion.ObtenerTabla(Consulta);

                ddlDia.Items.Clear();
                ddlDia.Items.Add("-");

                if (dt.Rows.Count > 0)
                {
                    ddlDia.Enabled = true;
                    LlenarDDLDia(dt);
                }
                else ddlDia.Enabled = false;
            }
            else
            {
                ddlDia.Enabled = false;
            }
        }

        protected void ddlDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            n_Funcion Funcion = new n_Funcion();
            DataTable dt = new DataTable();
            string Consulta = string.Empty;
            string IDPxF = string.Empty;
            if (ddlDia.SelectedItem.ToString() != "-" && ddlFormato.SelectedItem.ToString() != "-" && ddlSucursal.SelectedItem.ToString() != "-" && ddlPelicula.SelectedItem.ToString() != "-")
            {
                IDPxF = Session["IDPxF"].ToString();
                Consulta = ArmarConsulta(IDPxF, ddlSucursal.SelectedValue.ToString(),1);

                dt = Funcion.ObtenerTabla(Consulta);

                ddlHorario.Items.Clear();
                ddlHorario.Items.Add("-");

                if (dt.Rows.Count > 0)
                {
                    ddlHorario.Enabled = true;
                    LlenarDDLHorario(dt);
                }
                else ddlHorario.Enabled = false;
            }
            else
            {
                ddlHorario.Enabled = false;
            }
        }

        protected void ddlHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            n_Funcion Funcion = new n_Funcion();
            DataTable dt = new DataTable();
            string IDFuncion = string.Empty;
            string Consulta = string.Empty;
            string IDPxF = string.Empty;
            if(ddlHorario.SelectedItem.ToString() !="-" && ddlDia.SelectedItem.ToString() != "-" && ddlFormato.SelectedItem.ToString() != "-" && ddlSucursal.SelectedItem.ToString() != "-" && ddlPelicula.SelectedItem.ToString() != "-")
            {
                IDPxF= Session["IDPxF"].ToString();
                Consulta = ArmarConsulta(IDPxF, ddlSucursal.SelectedValue.ToString(), 2);
                dt = Funcion.ObtenerTabla(Consulta);
                IDFuncion = dt.Rows[0]["ID_Funcion"].ToString();
            }
        }

        public void LlenarDDLPeliculas(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlPelicula.Items.Add(dt.Rows[i]["Titulo_Pelicula"].ToString());
                ddlPelicula.Items[i+1].Value = dt.Rows[i]["ID_Pelicula"].ToString();
            }
        }

        public void LlenarDDLSucursales(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlSucursal.Items.Add(dt.Rows[i]["Nombre_Sucursal"].ToString());
                ddlSucursal.Items[i+1].Value = dt.Rows[i]["ID_Sucursal"].ToString();
            }
        }

        public void LlenarDDLFormato(DataTable dt)
        {
            string Formato;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Formato = ArmarFormato(dt.Rows[i]["Nombre_Formato"].ToString(), dt.Rows[i]["Subtitulos_Formato"].ToString(), dt.Rows[i]["Idioma_Formato"].ToString());
                ddlFormato.Items.Add(Formato);
                ddlFormato.Items[i+1].Value = dt.Rows[i]["ID_Formato"].ToString();
            }
        }

        public string ArmarFormato(string Nombre, string Subtitulos, string Idioma)
        {
            string Formato = string.Empty;
            if (Subtitulos == "True")
            {
                Formato = Nombre + " Subtitulada al " + Idioma;
            }
            else
            {
                Formato = Nombre + " Doblada al " + Idioma;
            }
            return Formato;
        }

        public void LlenarDDLDia(DataTable dt)
        {
            string[] Fecha;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                Fecha = dt.Rows[i]["FechaHora_Funcion"].ToString().Split(' ');

                if (dt.Rows[i]["FechaHora_Funcion"].ToString().Contains(Fecha[0]))
                {
                    if (!FechaRepetida(Fecha[0]))
                        ddlDia.Items.Add(Fecha[0]);
                }
            }
        }

        public string ArmarIDPxF()
        {
            n_PxF PxF = new n_PxF();
            DataTable dt = PxF.ObtenerTabla(ddlPelicula.SelectedValue.ToString(), ddlFormato.SelectedValue.ToString());
            string IDPxF = dt.Rows[0]["ID_PxF"].ToString();
            return IDPxF;
        }

        public string ArmarConsulta(string IDPxF,string IDSuc,int Origen)
        {
            if (Origen == 0)
            {
                string Consulta = "Select * from Funciones where ID_PxF='" + IDPxF + "' and ID_Sucursal='" + IDSuc + "'";
                return Consulta;
            }
            else if(Origen==1)
            {
                string Consulta = "Select * from Funciones where ID_PxF='" + IDPxF + "' and ID_Sucursal='" + IDSuc + "' and " + ArmarConsultaFecha();
                return Consulta;
            }
            else
            {
                string Consulta = "Select * from Funciones where ID_PxF='"+IDPxF+"' and ID_Sucursal='"+IDSuc+"' and DATEDIFF(n, FechaHora_Funcion,'" + ddlDia.SelectedItem.ToString() + " " + ddlHorario.SelectedItem.ToString() +"') = 0";
                return Consulta;
            }
        }

        public string ArmarConsultaFecha()
        {
            string[] Fecha=ddlDia.SelectedItem.ToString().Split('/');
            string Resto= "(DATEPART(yy, FechaHora_Funcion) = "+Fecha[2]+" and DATEPART(mm, FechaHora_Funcion) = "+Fecha[0]+" and DATEPART(dd, FechaHora_Funcion) = "+Fecha[1]+")";
            return Resto;
        }

        public bool FechaRepetida(string Fecha)
        {
            for (int i = 0; i < ddlDia.Items.Count; i++)
            {
                if (ddlDia.Items[i].ToString() == Fecha)
                {
                    return true;
                }
            }
            return false;
        }

        public void LlenarDDLHorario(DataTable dt)
        {
            string[] Fecha;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Fecha = dt.Rows[i]["FechaHora_Funcion"].ToString().Split(' ');

                if (Fecha[2] != null)
                {
                    Fecha[1] = Fecha[1] + " " + Fecha[2];
                }

                ddlHorario.Items.Add(Fecha[1]);
            }
        }

        public void Colorear2(object sender, EventArgs e)
        {

        }

        
    }
}