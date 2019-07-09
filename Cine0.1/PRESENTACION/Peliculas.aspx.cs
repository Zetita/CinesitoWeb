using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using NEGOCIO;
using System.Drawing;

namespace PRESENTACION
{
    public partial class Peliculas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserLogeado"] != null)
            {
                string IDPelicula;
                n_Pelicula Pelicula = new n_Pelicula();
                n_Sucursal Sucursal = new n_Sucursal();
                DataTable dt = new DataTable();
                IDPelicula = Application["ID_Pelicula"].ToString();


                if (!IsPostBack)
                {

                    string Consulta = "Select * from Peliculas where ID_Pelicula = " + IDPelicula + "And Estado=1";
                    dt = Pelicula.ObtenerTabla(Consulta);
                    if (!IsPostBack) LlenarPelicula(dt);

                    dt = Sucursal.ObtenerTabla();
                    LlenarDDLSucursal(dt);
                }

                else Boton("0");
            }
            else
            {
                Response.Cookies["Error"].Value = "1";
                Response.Cookies["Error"].Expires = DateTime.Now.AddHours(1);
                Response.Redirect("Inicio.aspx");
            }
        }

        protected void ddlCine_SelectedIndexChanged(object sender, EventArgs e)
        {
            n_Formato Datos = new n_Formato();
            DataTable dt = Datos.ObtenerTabla();    
           
            ddlFormato.Enabled = true;
            ddlDía.Enabled = false;
            ddlHorario.Enabled = false;
               
            if (ddlFormato.SelectedItem.ToString() == "-")
            {
                Boton("0");
                ddlDía.Enabled = false;
                ddlHorario.Enabled = false;
            }
            if (ddlCine.SelectedItem.ToString() != "-")
            {
                ddlFormato.Items.Clear();
                ddlFormato.Items.Add("-");

                LlenarDDLFormatos(dt);
                Application["ID_Sucursal"] = ddlCine.SelectedItem.Value.ToString();

                Boton("0");
            }
            else
            {
                ddlFormato.Enabled = false;
            }
        }

        protected void ddlFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            n_PxF PxF = new n_PxF();
            n_Funcion Funcion = new n_Funcion();
            string IDPelicula = Application["ID_Pelicula"].ToString();
            DataTable dt = PxF.ObtenerTabla();
            string IDPxF = SacarIDPxF(IDPelicula, ddlFormato.SelectedValue, dt);
            string IDSucursal = Application["ID_Sucursal"].ToString();

            if (ddlFormato.SelectedItem.ToString() != "-") ddlDía.Enabled = true;
            else
            {
                ddlDía.Enabled = false;
                ddlHorario.Enabled = false;
                Boton("0");
            }
            
            ddlDía.Items.Clear();
            ddlDía.Items.Add("-");

            try
            {
                string Consulta = "Select * from Funciones where ID_PxF = " + IDPxF + " and ID_Sucursal = " + IDSucursal;
                dt = Funcion.ObtenerTabla(Consulta);
                if (dt.Rows.Count > 0)
                {
                    LlenarDDLDia(dt);
                    Application["ID_PxF"] = IDPxF;
                    Boton("0");
                }
                else
                {
                    ddlDía.Enabled = false;
                    ddlHorario.Enabled = false;
                    Boton("2");
                }
            }
            catch
            {
                ddlDía.Enabled = false;
                ddlHorario.Enabled = false;
                Boton("2");
            }


        }

        protected void ddlDía_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            n_Funcion Datos = new n_Funcion();
            string Dia = ddlDía.SelectedItem.ToString();
            string ID_Sucursal = Application["ID_Sucursal"].ToString();
            string IDPxF = Application["ID_PxF"].ToString();

            if (ddlDía.SelectedItem.ToString() != "-"&& ddlFormato.SelectedItem.ToString() != "-") ddlHorario.Enabled = true;
            else ddlHorario.Enabled = false;

            ddlHorario.Items.Clear();
            ddlHorario.Items.Add("-");

            try
            {
                string Consulta = "Select * from Funciones where ID_PxF = " + IDPxF + " and ID_Sucursal = " + ID_Sucursal + " and ";
                Consulta += ArmarConsulta(Dia);
                Application["Dia"] = ddlDía.SelectedItem.ToString();
                DataTable dt = Datos.ObtenerTabla(Consulta);
                LlenarDDLHora(dt, Dia, IDPxF);
                Boton("0");
            }
            catch
            {
                ddlHorario.Enabled = false;
                Boton("2");
            }
        }

        protected void ddlHorario_SelectedIndexChanged(object sender, EventArgs e)
        {

            string ID_Funcion = string.Empty;

            try
            {

                Application["Dia"] += " " + ddlHorario.SelectedItem.ToString();
               
                ID_Funcion = SacarFuncion();
                Application["ID_Funcion"] = ID_Funcion;
                Boton("1");
            }
            catch
            {
                Boton("2");
            }
        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Butacas.aspx");
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
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
                ddlCine.Items[i+1].Value= dt.Rows[i]["ID_Sucursal"].ToString();
            }
        }

        public void LlenarDDLFormatos(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Subtitulos_Formato"].ToString() == "False")
                {
                    ddlFormato.Items.Add(dt.Rows[i]["Nombre_Formato"].ToString() + " - Audio " + dt.Rows[i]["Idioma_Formato"].ToString());
                    ddlFormato.Items[i+1].Value = dt.Rows[i]["ID_Formato"].ToString();
                }
                else
                {
                    ddlFormato.Items.Add(dt.Rows[i]["Nombre_Formato"].ToString() + " - Subtitulos " + dt.Rows[i]["Idioma_Formato"].ToString());
                    ddlFormato.Items[i+1].Value = dt.Rows[i]["ID_Formato"].ToString();
                }
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
                    if(!FechaRepetida(Fecha[0]))
                    ddlDía.Items.Add(Fecha[0]);
                }
            }
        }

        public void LlenarDDLHora(DataTable dt, string Dia, string IDPxF)
        {
            string[] Fecha;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                Fecha = dt.Rows[i]["FechaHora_Funcion"].ToString().Split(' ');
                if (Fecha[2]!=null)
                {
                    Fecha[1] = Fecha[1] + " " + Fecha[2];
                }
                if (dt.Rows[i]["FechaHora_Funcion"].ToString().Contains(Dia))
                {
                    ddlHorario.Items.Add(Fecha[1]);
                    btnSeleccionar.Text = Fecha[1];
                }
            }
        }

        public string SacarIDPxF(string IDPelicula, string IDFormato, DataTable dt)
        {
            string IDPxF=string.Empty;            
            for (int i=0;i<dt.Rows.Count;i++)
            {
                
                if (dt.Rows[i]["ID_Pelicula"].ToString().TrimEnd() == IDPelicula && dt.Rows[i]["ID_Formato"].ToString() == IDFormato)
                {
                    
                    IDPxF = dt.Rows[i]["ID_PxF"].ToString();
                    
                }
            }
            return IDPxF;
        }

        public string SacarFuncion()
        {
            n_Funcion Datos = new n_Funcion();
            string FechaHora = Application["Dia"].ToString();
            string Sucursal = Application["ID_Sucursal"].ToString();
            string PxF = Application["ID_PxF"].ToString();

            string Consulta = "Select * from Funciones where ID_Sucursal = " + Sucursal + " and ID_PxF = " + PxF + " and DATEDIFF(n,FechaHora_Funcion,'" + FechaHora+"') = 0";
            DataTable dt = Datos.ObtenerTabla(Consulta);
            string ID_Funcion = dt.Rows[0]["ID_Funcion"].ToString();
            return ID_Funcion;
        }

        public string ArmarConsulta(string Dia)
        {
            string[] Fecha = Dia.Split('/');
            string Consulta= "(DATEPART(yy, FechaHora_Funcion) = "+Fecha[2]+" and DATEPART(mm, FechaHora_Funcion) = "+Fecha[0]+" and DATEPART(dd, FechaHora_Funcion)= "+Fecha[1]+" )";
            return Consulta;
        }

        public string PrepararDia(string Dia)
        {
            string[] Fecha = Dia.Split('/');
            Dia = Fecha[2] + "-" + Fecha[1] + "-" + Fecha[0];
            return Dia;
        }
       
        public void Boton(string Estado)
        {
            switch (Estado)
            {
                case "0":
                    btnSeleccionar.Text = " COMPLETE LOS DATOS NECESARIOS";
                    btnSeleccionar.Enabled = false;
                    break;
                case "1":
                    btnSeleccionar.Text = " SELECCIONAR BUTACAS ";
                    btnSeleccionar.Enabled = true;
                    break;
                case "2":
                    btnSeleccionar.Text = "NO EXISTE UNA FUNCION CON ESOS DATOS";
                    btnSeleccionar.Enabled = false;
                    break;
            }
        }

        public bool FechaRepetida(string Fecha)
        {
            for (int i = 0; i < ddlDía.Items.Count; i++)
            {
                if (ddlDía.Items[i].ToString() == Fecha)
                {
                    return true;
                }
            }
            return false;
        }

        
    }
}