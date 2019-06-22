using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Usuario
    {
        private int i_idUsuario;
        private String s_User;
        private String s_Contrasenia;
        private String s_Email;
        private String s_Apellido;
        private String s_Nombre;
        private String s_Dni;
        private String s_Telefono;
        private DateTime dt_FechaNac;
        private bool b_Administrador;
        private bool b_Activo;


        public Usuario()
        {

        }

        public int idUsuario
        {
            set { i_idUsuario = value; }
            get { return i_idUsuario; }
        }

        public String User
        {
            set { s_User = value; }
            get { return s_User; }
        }

        public String Contrasenia
        {
            set { s_Contrasenia = value; }
            get { return s_Contrasenia; }
        }

        public String Email
        {
            set { s_Email = value; }
            get { return s_Email; }
        }

        public String Apellido
        {
            set { s_Apellido = value; }
            get { return s_Apellido; }
        }

        public String Nombre
        {
            set { s_Nombre = value; }
            get { return s_Nombre; }
        }

        public String Dni
        {
            set { s_Dni = value; }
            get { return s_Dni; }
        }

        public String Telefono
        {
            set { s_Telefono = value; }
            get { return s_Telefono; }
        }

        public DateTime FechaNac
        {
            set { dt_FechaNac = value; }
            get { return dt_FechaNac; }
        }

        public bool Administrador
        {
            set { b_Administrador = value; }
            get { return b_Administrador; }
        }
        public bool Activo
        {
            set { b_Activo = value; }
            get { return b_Activo; }
        }
    }
}
