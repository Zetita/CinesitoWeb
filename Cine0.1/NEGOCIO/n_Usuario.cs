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

        public DataTable getTabla()
        {
            DAO_Usuarios da = new DAO_Usuarios();
            return da.ObtenerTablaUsuarios();
        }
        public DataTable getTabla(String usuario)
        {
            DAO_Usuarios da = new DAO_Usuarios();
            return da.ObtenerTablaUsuarios(usuario);
        }
        public DataTable ObtenerTablaAdmins()
        {
            DAO_Usuarios da = new DAO_Usuarios();
            return da.ObtenerTablaAdmins();
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
    }
}
