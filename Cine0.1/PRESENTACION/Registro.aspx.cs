﻿using System;
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
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.WebForms;
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "/Scripts/jquery-1.8.0.js"
            });
            txtUsuario2.Focus();
        }
        void ClearInputs(ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                ClearInputs(ctrl.Controls);
            }
        }
        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if(rfv1.IsValid && rfv2.IsValid && rfv3.IsValid && rfv4.IsValid && rfv5.IsValid && rfv6.IsValid && rfv7.IsValid && rfv8.IsValid)
            {
                Usuario usuario = new Usuario();
                DateTime CreatdDate = DateTime.ParseExact(txtNacimiento.Text, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                
                usuario.User = txtUsuario.Text;
                usuario.Contrasenia = txtContrasenia.Text; 
                usuario.Email = txtEmail.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.Nombre = txtNombre.Text;
                usuario.Dni = txtDni.Text;
                usuario.Telefono = txtTelefono.Text;
                usuario.FechaNac = CreatdDate;
                usuario.Activo = true;
                usuario.Administrador = false;

                n_Usuario n_usuario = new n_Usuario();

                if (!(n_usuario.estaRegistrado(txtUsuario.Text)))
                {
                    if (n_usuario.agregarUsuario(usuario))
                    {
                        lblAdd.Text = "USUARIO REGISTRADO.";
                        lblAdd.ForeColor = System.Drawing.Color.Blue;
                        ClearInputs(Page.Controls);
                    }
                    else
                    {
                        lblAdd.Text = "ERROR AL REGISTRAR, INTENTELO NUEVAMENTE.";
                        lblAdd.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    lblAdd.Text = "NOMBRE DE USUARIO EXISTENTE.";
                    lblAdd.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblAdv.Text = "COMPLETE LOS CAMPOS MARCADOS.";
                lblAdv.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        { 
            if (rfv9.IsValid && rfv10.IsValid)
            {
                n_Usuario n_usuario = new n_Usuario();
                DataTable dt = new DataTable();
                if (n_usuario.estaRegistrado(txtUsuario2.Text, txtContrasenia2.Text)==true)
                {
                    Session["UserLogeado"] = txtUsuario2.Text;

                    if (n_usuario.esAdministrador(Session["UserLogeado"].ToString()))
                    {
                        Session["NivelUser"] = "1";
                        Response.Redirect("/Admin/Admin_Peliculas.aspx");
                    }
                    else
                    {
                        Session["NivelUser"] = "0";
                        Response.Cookies["Mensaje"].Value = "4";
                        Response.Cookies["Mensaje"].Expires = DateTime.Now.AddHours(1);
                        Response.Redirect("~/Inicio.aspx");
                    }
                }
                else
                {
                    lblAdv2.Text = "USUARIO Y/O CONTRASEÑA INCORRECTOS.";
                    lblAdv.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}