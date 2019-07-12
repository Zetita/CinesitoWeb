using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTIDAD;

namespace DAO
{
    public class DAO_Usuarios
    {
        AccesoDatos ad = new AccesoDatos();
        public DataTable ObtenerTablaTodos()
        {
            DataTable tabla = ad.ObtenerTabla("Usuarios", "Select * from Usuarios where Activo='True'");
            return tabla;
        }
        public DataTable ObtenerTablaUsuario(String usuario)
        {
            DataTable tabla = ad.ObtenerTabla("Usuario", "Select * from Usuarios where Usuario='" + usuario + "'");
            return tabla;
        }
        public DataTable ObtenerTablaIDUsuario(int ID)
        {
            DataTable tabla = ad.ObtenerTabla("Usuario", "Select * from Usuarios where ID_Usuario='" + ID + "'");
            return tabla;
        }
        public DataTable ObtenerTablaAdmins()
        {
            return ad.ObtenerTabla("Administradores", "Select * from Usuarios Where Administrador=1");
        }
        public DataTable ObtenerTablaUsuarios()
        {
            return ad.ObtenerTabla("Usuarios", "Select * from Usuarios where Administrador=0");
        }
        
        public bool estaRegistrado(String usuario, String pass)
        {
            SqlConnection cn = ad.ObtenerConexion();
            SqlCommand cmd;
            SqlDataReader dr;
            String sql =
            "SELECT * From Usuarios Where Usuario='" + usuario + "' AND Contrasenia='" + pass + "' and Activo='True'";
            if (cn != null)
            {
                cmd = new SqlCommand(sql, cn);
                try
                {
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                        return true;
                    else
                        return false;
                }
                catch (SqlException ex)
                {
                    return false;
                }
                finally
                {
                    cn.Close();
                }
            }
            else
                return false;
        }

        public bool esAdministrador(String usuario)
        {
            SqlConnection cn = ad.ObtenerConexion();
            SqlCommand cmd;
            SqlDataReader dr;
            String sql =
            "Select * From Usuarios Where Usuario='" + usuario + "' AND Administrador='True' and Activo='True'";
            if (cn != null)
            {
                cmd = new SqlCommand(sql, cn);
                try
                {
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                        return true;
                    else
                        return false;
                }
                catch (SqlException ex)
                {
                    return false;
                }
                finally
                {
                    cn.Close();
                }
            }
            else
                return false;
        }
        public void armarParametros(ref SqlCommand Comando, Usuario usuario)
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@USUARIO", SqlDbType.Char, 40);
            SqlParametros.Value = usuario.User;
            SqlParametros = Comando.Parameters.Add("@CONTRASENIA", SqlDbType.Char,16);
            SqlParametros.Value = usuario.Contrasenia;
            SqlParametros = Comando.Parameters.Add("@EMAIL", SqlDbType.Char, 40);
            SqlParametros.Value = usuario.Email;
            SqlParametros = Comando.Parameters.Add("@APELLIDOS", SqlDbType.Char, 40);
            SqlParametros.Value = usuario.Apellido;
            SqlParametros = Comando.Parameters.Add("@NOMBRES", SqlDbType.Char, 40);
            SqlParametros.Value = usuario.Nombre;
            SqlParametros = Comando.Parameters.Add("@DNI", SqlDbType.Char, 8);
            SqlParametros.Value = usuario.Dni;
            SqlParametros = Comando.Parameters.Add("@TELEFONO", SqlDbType.Char, 15);
            SqlParametros.Value = usuario.Telefono;
            SqlParametros = Comando.Parameters.Add("@FECHANAC", SqlDbType.Date);
            SqlParametros.Value = usuario.FechaNac;
            SqlParametros = Comando.Parameters.Add("@ADMINISTRADOR", SqlDbType.Bit);
            SqlParametros.Value = usuario.Administrador;
            SqlParametros = Comando.Parameters.Add("@ACTIVO", SqlDbType.Bit);
            SqlParametros.Value = usuario.Activo;
  
        }

        public bool ActualizarUsuario(Usuario usuario)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, usuario);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarUsuario");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }

        public int eliminarUsuario(Usuario usuario)
        {
            SqlCommand comando = new SqlCommand();
            armarParametros(ref comando, usuario);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spEliminarUsuario");
        }

        public bool insertarUsuario(Usuario usuario)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, usuario);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarUsuario");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}
