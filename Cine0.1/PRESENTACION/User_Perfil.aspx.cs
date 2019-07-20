using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ENTIDAD;
using NEGOCIO;  

namespace PRESENTACION
{
    public partial class User_Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NivelUser"].ToString() == "1")
                lbConfig.Visible = true;
            else
                lbConfig.Visible = false;


            lblUsuario.Text = Session["UserLogeado"].ToString();
            if (Session["NivelUser"].ToString() == "0")
            {
                lbConfig.Visible = false;
            }

            string Usuario;
            n_Usuario n_usuario = new n_Usuario();
            Usuario user = new Usuario();
            DataTable dt = new DataTable();
            Usuario = Session["UserLogeado"].ToString();

            if (!IsPostBack)
            {
                dt = n_usuario.ObtenerUsuario(Usuario);
                
                user=LlenarUsuario(dt);
                txtNombre.Text = user.Nombre;
                txtApellido.Text = user.Apellido;
                txtDNI.Text = user.Dni;
                txtEmail.Text = user.Email;
                txtTelefono.Text = user.Telefono;
                               
            }
        }
        protected void lbCerrar_Click(object sender, EventArgs e)
        {
            Session["UserLogeado"] = null;
            Response.Cookies["Mensaje"].Value = "3";
            Response.Cookies["Mensaje"].Expires = DateTime.Now.AddHours(1);
            Response.Redirect("Inicio.aspx");
        }
        protected void lbConfig_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Admin_Peliculas.aspx");
        }
        public Usuario LlenarUsuario(DataTable dt)
        {
            Usuario user = new Usuario();

            user.idUsuario = Int32.Parse(dt.Rows[0]["ID_Usuario"].ToString());
            user.User = dt.Rows[0]["Usuario"].ToString();
            user.Contrasenia = dt.Rows[0]["Contrasenia"].ToString();
            user.Email = dt.Rows[0]["Email_Usuario"].ToString();
            user.Apellido = dt.Rows[0]["Apellidos_Usuario"].ToString();
            user.Nombre = dt.Rows[0]["Nombres_Usuario"].ToString();
            user.Dni = dt.Rows[0]["DNI_Usuario"].ToString();
            user.Telefono = dt.Rows[0]["Telefono_Usuario"].ToString();

            user.FechaNac = DateTime.Parse(dt.Rows[0]["FechaNac_Usuario"].ToString());

            user.Administrador = bool.Parse(dt.Rows[0]["Administrador"].ToString());
            user.Activo = bool.Parse(dt.Rows[0]["Activo"].ToString());

            return user;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            Usuario userbk = new Usuario();
            n_Usuario n_usuario = new n_Usuario();
            DataTable dt = new DataTable();
            dt = n_usuario.ObtenerUsuario(lblUsuario.Text);

            userbk = LlenarUsuario(dt);

            user.idUsuario = userbk.idUsuario;
            user.User = lblUsuario.Text;
            user.Contrasenia = userbk.Contrasenia;
            user.Email = txtEmail.Text;
            user.Apellido = txtApellido.Text;
            user.Nombre = txtNombre.Text;
            user.Dni = txtDNI.Text;
            user.Telefono = txtTelefono.Text;
            user.Administrador = userbk.Administrador;
            user.Activo = userbk.Activo;

            if(n_usuario.editarUsuario(user))
            {
                lblEd.Text = "USUARIO ACTUALIZADO";
                lblEd.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                lblEd.Text = "ERROR AL EDITAR, INTENTELO NUEVAMENTE";
                lblEd.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}