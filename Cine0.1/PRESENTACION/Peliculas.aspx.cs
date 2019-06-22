using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace PRESENTACION
{
    public partial class Peliculas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string IDPelicula;
            DAO.GestionDatos Datos = new DAO.GestionDatos();
            //IDPelicula = Application["ID"].ToString();
            IDPelicula = "1";

            string Consulta = "Select * from Peliculas where ID_Pelicula = " + IDPelicula;
            DataTable dt = Datos.ObtenerTodos("Peliculas", Consulta);
            LlenarPelicula(dt);

            //Consulta = "Select * From Sucursales";
            //dt = Datos.ObtenerTodos("Sucursales", Consulta);
            //LlenarDDLSucursal(dt);
        }

        protected void ddlCine_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ddlFormato.Enabled = true;
            //DAO.GestionDatos Datos = new DAO.GestionDatos();
            //string Consulta = "Select * from Formatos";
            //DataTable dt = Datos.ObtenerTodos("Formatos", Consulta);
            //LlenarDDLFormatos(dt);
            //Application["ID_Sucursal"] = ddlCine.SelectedItem.Value.ToString();
        }

        protected void ddlFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    ddlDía.Enabled = true;
            //    DAO.GestionDatos Datos = new DAO.GestionDatos();
            //    string IDPelicula = Application["ID"].ToString();
            //    string IDPelicula = "1";

            //    string Consulta = "Select * from PeliculasxFormatos";
            //    DataTable dt = Datos.ObtenerTodos("PeliculasxFormatos", Consulta);
            //    string IDPxF = SacarIDPxF(IDPelicula, ddlFormato.SelectedItem.Value.ToString(), dt);

            //    Consulta = "Select * from Funciones where ID_PxF=" + IDPxF;
            //    dt = Datos.ObtenerTodos("Funciones", Consulta);
            //    LlenarDDLDia(dt);
            //    Application["ID_PxF"] = IDPxF;
        }

        protected void ddlDía_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    ddlHorario.Enabled = true;
            //    DAO.GestionDatos Datos = new DAO.GestionDatos();
            //    string Dia = ddlDía.SelectedItem.ToString();
            //    string ID_Sucursal = Application["ID_Sucursal"].ToString();
            //    string IDPxF = Application["IDPxF"].ToString();
            //    string Consulta = "Select * from Funciones where ID_PxF = "+IDPxF+" and ID_Sucursal = "+ID_Sucursal+" and FechaHora_Funcion LIKE '"+Dia+"%'";
            //    DataTable dt = Datos.ObtenerTodos("Funciones", Consulta);
            //    LlenarDDLHora(dt, Dia, IDPxF);
            //    Application["Dia"] = ddlDía.SelectedItem.ToString();      
        }

        protected void ddlHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    Application["Dia"] += ddlHorario.SelectedItem.ToString();
            //    string ID_Funcion=SacarFuncion();
            //    Application["ID_Funcion"] = ID_Funcion;
            //    ddlCantEntradas.Enabled = true;
        }

        protected void ddlCantEntradas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Application["CantEntradas"] = ddlCantEntradas.SelectedItem.ToString();
        }

        public void LlenarPelicula(DataTable dt)
        {
            lblNombre.Text = dt.Rows[0]["Titulo_Pelicula"].ToString();
            lblSinopsis.Text = dt.Rows[0]["Sinopsis_Pelicula"].ToString();
            lblGenero.Text = "Genero: " + dt.Rows[0]["Genero_Pelicula"].ToString() + ".";
            lblDuracion.Text = "Duración: " + dt.Rows[0]["Duracion"].ToString() + " horas.";
            lblDirector.Text = "Director: " + dt.Rows[0]["Director_Pelicula"].ToString().TrimEnd() + ".";
            imgPortada.ImageUrl = dt.Rows[0]["ImagenURL"].ToString();
            lblVideo.Text = "<iframe width='853' height='480' src='" + dt.Rows[0]["TrailerURL"].ToString() + "' frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen style='position: absolute; top: 136px; left: 800px; height: 275px; width: 437px'></iframe>";
        }

        public void LlenarDDLSucursal(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlCine.Items.Add(dt.Rows[i]["Nombre_Sucursal"].ToString());
                ddlCine.Items[i].Value= dt.Rows[i]["ID_Sucursal"].ToString();
            }
        }

        public void LlenarDDLFormatos(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlFormato.Items.Add(dt.Rows[i]["Nombre_Formato"].ToString());
                ddlFormato.Items[i].Value = dt.Rows[i]["ID_Formato"].ToString();
            }
        }

        public void LlenarDDLDia(DataTable dt)
        {
            string[] Fecha;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Fecha = dt.Rows[i]["FechaHora_Funcion"].ToString().Split(' ');
                if (dt.Rows[i]["FechaHora_Funcion"].ToString().Contains(Fecha[0]))
                {
                    ddlDía.Items.Add(Fecha[0]);
                }
            }
        }

        public void LlenarDDLHora(DataTable dt, string Dia, string IDPxF)
        {
            string[] Fecha;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Fecha = dt.Rows[i]["FechaHora_Función"].ToString().Split(' ');
                if (dt.Rows[i]["FechaHora_Función"].ToString().Contains(Dia))
                {
                    ddlHorario.Items.Add(Fecha[1]);
                }
            }
        }

        public string SacarIDPxF(string IDPelicula, string IDFormato, DataTable dt)
        {
            string IDPxF=string.Empty;
            foreach(DataRow i in dt.Rows)
            {
                if (i["ID_Pelicula"].ToString() == IDPelicula && i["ID_Formato"].ToString() == IDFormato)
                {
                    IDPxF = i["ID_PxF"].ToString();
                }
            }
            return IDPxF;
        }

        public string SacarFuncion()
        {
            DAO.GestionDatos Datos = new DAO.GestionDatos();
            string FechaHora = Application["Dia"].ToString();
            string Sucursal = Application["ID_Sucursal"].ToString();
            string PxF = Application["ID_PxF"].ToString();
            string Consulta = "Select * from Funciones where ID_Sucursal = " + Sucursal + " and ID_PxF = " + PxF + "and FechaHora_Funcion =" + FechaHora;
            DataTable dt = Datos.ObtenerTodos("Funciones", Consulta);
            string ID_Funcion = dt.Rows[0]["ID_Funcion"].ToString();
            return ID_Funcion;
        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Butacas.aspx");
        }

        
    }
}