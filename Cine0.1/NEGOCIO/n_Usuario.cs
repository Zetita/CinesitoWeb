using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using ENTIDAD;

namespace NEGOCIO
{
    public class n_Usuario
    {

        public DataTable ObtenerTablaTodos()
        {
            DAO_Usuarios da = new DAO_Usuarios();
            return da.ObtenerTablaTodos();
        }
        public DataTable ObtenerTablaAdmins()
        {
            DAO_Usuarios da = new DAO_Usuarios();
            return da.ObtenerTablaAdmins();
        }
        public DataTable ObtenerTablaUsuarios()
        {
            DAO_Usuarios da = new DAO_Usuarios();
            return da.ObtenerTablaUsuarios();
        }
        
        public DataTable ObtenerUsuario(String usuario)
        {
            DAO_Usuarios da = new DAO_Usuarios();
            return da.ObtenerTablaUsuario(usuario);
        }

        public DataTable ObtenerTablaIDUsuarios(int ID)
        {
            DAO_Usuarios da = new DAO_Usuarios();
            return da.ObtenerTablaIDUsuario(ID);
        }

        public bool editarUsuario(Usuario usuario)
        {
            DAO_Usuarios da = new DAO_Usuarios();
            return da.ActualizarUsuario(usuario);
        }

        public int eliminarUsuario(Usuario usuario)
        {
            DAO_Usuarios da = new DAO_Usuarios();
            return da.eliminarUsuario(usuario);
        }

        public bool agregarUsuario(Usuario usuario)
        {
            DAO_Usuarios da = new DAO_Usuarios();
            return da.insertarUsuario(usuario);
        }
        public bool estaRegistrado(String usuario, String pass)
        {
            DAO_Usuarios da = new DAO_Usuarios();
            return da.estaRegistrado(usuario, pass);
        }
        public bool estaRegistrado(String usuario)
        {
            DAO_Usuarios da = new DAO_Usuarios();
            return da.estaRegistrado(usuario);
        }
        public bool esAdministrador(String usuario)
        {
            DAO_Usuarios da = new DAO_Usuarios();
            return da.esAdministrador(usuario);
        }
    }
}
