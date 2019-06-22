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
        public DataTable ObtenerTablaUsuarios()
        {
            DataTable tabla = ad.ObtenerTabla("Usuario", "Select * from Usuario where estado=1");
            return tabla;
        }

        public DataTable ObtenerTablaAdmins()
        {
            return ad.ObtenerTabla("Administradores", "Select * from Usuarios Where Administrador=1 ");
        }



        public void armarParametros(ref SqlCommand Comando, Usuario usuario)
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@ID_USUARIO", SqlDbType.Char, 20);
            SqlParametros.Value = usuario.idUsuario;
            SqlParametros = Comando.Parameters.Add("@USUARIO", SqlDbType.Char, 40);
            SqlParametros.Value = usuario.User;
            //SqlParametros = Comando.Parameters.Add("@CONTRASENIA", SqlDbType.VarBinary);  DUDITA DECLARACION DE TIPO
            //SqlParametros.Value = usuario.contra;
            SqlParametros = Comando.Parameters.Add("@EMAIL", SqlDbType.Char, 40);
            SqlParametros.Value = usuario.Email;
            SqlParametros = Comando.Parameters.Add("@APELLIDO", SqlDbType.Char, 40);
            SqlParametros.Value = usuario.Apellido;
            SqlParametros = Comando.Parameters.Add("@NOMBRE", SqlDbType.Char, 40);
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

        //public bool ActualizarUsuarios(Usuario usuario)
        //{
        //    SqlCommand Comando = new SqlCommand();
        //    armarParametros(ref Comando, usuario);
        //    int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarUsuario");
        //    if (filasInsertadas == 1)
        //        return true;
        //    else
        //        return false;
        //}

        public int eliminarUsuarios(Usuario usuario)
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
