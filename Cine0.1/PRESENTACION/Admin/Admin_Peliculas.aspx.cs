using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTIDAD;
using NEGOCIO;
using System.Data;

namespace PRESENTACION
{
    public partial class Admin_Peliculas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.WebForms;
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "/Scripts/jquery-1.8.0.js"
            });

            if (!IsPostBack)
            {
                cargarGrilla();
                cargarDDL();
                cargarDDLPeliculas();
                cargarCheckBoxs();
            }
        }
        public void cargarGrilla()
        {
            n_Pelicula n_pelicula = new n_Pelicula();
            grdPeliculas.DataSource = n_pelicula.ObtenerTablaTodos();
            grdPeliculas.DataBind();
        }

        public void cargarDDL()
        {
            ddlClasificacion.Items.Add("ATP");
            ddlClasificacion.Items.Add("SAM13");
            ddlClasificacion.Items.Add("SAM16");
            ddlClasificacion.Items.Add("SAM18");
            ddlClasificacion.Items.Insert(0, "-Seleccione Clasificacion-");          
        }
        public void cargarDDLPeliculas()
        {
            n_Pelicula n_pelicula = new n_Pelicula();

            ddlPeliculas.DataTextField = "Titulo_Pelicula";
            ddlPeliculas.DataValueField = "ID_Pelicula";
            ddlPeliculas.DataSource = n_pelicula.ObtenerTabla();
            ddlPeliculas.DataBind();
            ddlPeliculas.Items.Insert(0, "--Seleccione una pelicula--");
        }
        public void cargarCheckBoxs()
        {
            n_Formato n_formato = new n_Formato();
            DataTable dt = n_formato.ObtenerTabla();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboxlistFormatos.Items.Add(new ListItem(dt.Rows[i]["Nombre_Formato"].ToString(), dt.Rows[i]["ID_Formato"].ToString()));
            }
            
        }
        void ClearInputs(ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                ClearInputs(ctrl.Controls);
                if (ctrl is CheckBoxList)
                    ((CheckBoxList)ctrl).ClearSelection();
            }
        }


        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ddlClasificacion.SelectedIndex == 0)
                rfv2.IsValid = false;
            if (rfv1.IsValid && rfv2.IsValid && rfv3.IsValid && rfv4.IsValid && rfv5.IsValid && rfv6.IsValid && rfv7.IsValid && rfv8.IsValid && Calendar1.SelectedDate!=null)
            {
                String pathCarpeta = @"img\portadas\";
                String savePath = Server.MapPath("~") + pathCarpeta;
                String fileName = fileImagen.FileName;
                String pathCompleta = savePath + fileName;
                DateTime datetime = new DateTime(Calendar1.SelectedDate.Year, Calendar1.SelectedDate.Month,
                   Calendar1.SelectedDate.Day);

                Pelicula pelicula = new Pelicula();
                n_Pelicula n_pelicula = new n_Pelicula();
      
                if (n_pelicula.ObtenerCantRegistros() < 10)
                    pelicula.idPelicula = "PEL00" + (n_pelicula.ObtenerCantRegistros() + 1);
                if (n_pelicula.ObtenerCantRegistros() > 10 && n_pelicula.ObtenerCantRegistros() < 100)
                    pelicula.idPelicula = "PELC0" + (n_pelicula.ObtenerCantRegistros() + 1);
                if (n_pelicula.ObtenerCantRegistros() > 100)
                    pelicula.idPelicula = "PEL" + (n_pelicula.ObtenerCantRegistros() + 1);

                pelicula.Titulo = txtTitulo.Text;
                pelicula.Generos = txtGeneros.Text;
                pelicula.Clasificacion = ddlClasificacion.SelectedValue.ToString();
                pelicula.FecEstreno = datetime;
                pelicula.Director = txtDirector.Text;
                pelicula.Sinopsis = txtSinopsis.Text;

                if (rbtnEstado.SelectedValue == "1")
                    pelicula.Estado = true;
                else
                    pelicula.Estado = false;

                String rutaBase = "~/img/portadas/" + fileName;
                pelicula.ImagenURL = rutaBase;


                String[] dur = txtDuracion.Text.Split(':');
                TimeSpan durtime = new TimeSpan(Int32.Parse(dur[0]), Int32.Parse(dur[1]), 0);
                pelicula.Duracion = durtime;
                pelicula.TrailerURL = txtTrailerURL.Text;
                pelicula.Estado = true;


                if (n_pelicula.insertarPelicula(pelicula))
                {
                    lblAgregado.Text = "Cargado exitosamente.";
                    lblAgregado.ForeColor = System.Drawing.Color.Green;
                    cargarGrilla();
                    cargarDDLPeliculas();
                    ClearInputs(Page.Controls);

                }
                else
                {
                    lblAgregado.Text = "Error al agregar.";
                    lblAgregado.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblAg.Text = "Complete los campos necesarios!";
            }
        }

     

        protected void grdPeliculas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String codigo = ((Label)grdPeliculas.Rows[e.RowIndex].FindControl("lbl_it_IDPelicula")).Text;

            Pelicula pelicula = new Pelicula();
            pelicula.idPelicula = codigo;
            pelicula.Estado = false;

            n_Pelicula n_pelicula = new n_Pelicula();
            n_pelicula.eliminarPelicula(pelicula);
            
            cargarGrilla();
        }

        protected void grdPeliculas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdPeliculas.EditIndex = e.NewEditIndex;
            cargarGrilla();
        }

        protected void grdPeliculas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdPeliculas.EditIndex = -1;
            cargarGrilla();
        }

        protected void grdPeliculas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String s_IdPelicula = ((Label)grdPeliculas.Rows[e.RowIndex].FindControl("lbl_eit_IDPelicula")).Text;
            String s_Titulo = ((TextBox)grdPeliculas.Rows[e.RowIndex].FindControl("txt_eit_Titulo")).Text;
            String s_Genero = ((TextBox)grdPeliculas.Rows[e.RowIndex].FindControl("txt_eit_Genero")).Text;
             String s_Clasificacion= ((TextBox)grdPeliculas.Rows[e.RowIndex].FindControl("txt_eit_Clasificacion")).Text;

            DateTime s_Estreno = ((Calendar)grdPeliculas.Rows[e.RowIndex].FindControl("Calendar2")).SelectedDate;
            String s_Director=((TextBox) grdPeliculas.Rows[e.RowIndex].FindControl("txt_eit_Director")).Text;
            String s_Sinopsis=((TextBox) grdPeliculas.Rows[e.RowIndex].FindControl("txt_eit_Sinopsis")).Text;
            String  s_Imagen = ((FileUpload)grdPeliculas.Rows[e.RowIndex].FindControl("FileUpload1")).FileName;
            String s_duracion=((TextBox) grdPeliculas.Rows[e.RowIndex].FindControl("txt_eit_Duracion")).Text;
            String s_Trailer=((TextBox) grdPeliculas.Rows[e.RowIndex].FindControl("txt_eit_TrailerURL")).Text;
            bool b_Estado;
            if (((CheckBox)grdPeliculas.Rows[e.RowIndex].FindControl("cb_eit_Estado")).Checked == true)
                b_Estado = true;
            else
                b_Estado = false;
            
            String ruta = "~/img/portadas/" + s_Imagen;

            Pelicula pelicula = new Pelicula();
            pelicula.idPelicula = s_IdPelicula;
            pelicula.Titulo = s_Titulo;
            pelicula.Generos = s_Genero;
            pelicula.Clasificacion = s_Clasificacion;
            pelicula.FecEstreno = s_Estreno;
            pelicula.Director = s_Director;
            pelicula.Sinopsis = s_Sinopsis;
            pelicula.ImagenURL = ruta;
            pelicula.Duracion =  TimeSpan.Parse(s_duracion);
            pelicula.TrailerURL = s_Trailer;
            pelicula.Estado = b_Estado;

            n_Pelicula n_pelicula = new n_Pelicula();
            n_pelicula.editarPelicula(pelicula);

            grdPeliculas.EditIndex = -1;
            cargarGrilla();


        }

        protected void btnCargarPelxFor_Click(object sender, EventArgs e)
        {
            n_PxF n_pxf = new n_PxF();
            PeliculasxFormato pel = new PeliculasxFormato();
            int marcados=0;
            for (int i = 0; i < cboxlistFormatos.Items.Count; i++)
            {
                if (cboxlistFormatos.Items[i].Selected)
                {
                    marcados++;
                }
            }

            if(ddlPeliculas.SelectedIndex>0 && marcados!=0)
            {

                for (int i = 0; i < cboxlistFormatos.Items.Count; i++)
                {
                    pel.IDFormato = "";
                    if (cboxlistFormatos.Items[i].Selected)
                    {
                        pel.IDPelicula = ddlPeliculas.SelectedValue;
                        pel.IDFormato = cboxlistFormatos.Items[i].Value;
                        
                        if (n_pxf.insertarPxF(pel))
                        {
                            lblCargado.Text = "Cargado exitosamente.";
                            lblCargado.ForeColor = System.Drawing.Color.Green;

                        }
                        else
                        {
                            lblCargado.Text = "Error al agregar.";
                            lblCargado.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    
                }
                ClearInputs(Page.Controls);
                cargarGrilla();
            }
            else
            {
                lblCargado.Text = "Complete los campos necesarios!";
            }
        }

        protected void grdPeliculas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdPeliculas.PageIndex = e.NewPageIndex;
            cargarGrilla();
        }
    }
}