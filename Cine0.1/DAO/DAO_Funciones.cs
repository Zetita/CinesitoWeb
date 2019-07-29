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
    public class DAO_Funciones
    {
        AccesoDatos ad = new AccesoDatos();

        public DataTable ObtenerTablaFunciones()
        {
            DataTable tabla = ad.ObtenerTabla("Funciones", "Select * From Funciones");
            return tabla;
        }
        //public DataTable ObtenerTablaFuncionesDisp()
        //{
        //    DataTable tabla = ad.ObtenerTabla("Funciones", "Select * From Funciones");
        //    return tabla;
        //}
        public DataTable ObtenerTablaFunciones(string Consulta)
        {
            DataTable tabla = ad.ObtenerTabla("Funciones", Consulta);
            return tabla;
        }

        public void armarParametros(ref SqlCommand Comando, Funcion funcion)
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@ID_FUNCION", SqlDbType.Char, 6);
            SqlParametros.Value = funcion.IDFuncion;
            SqlParametros = Comando.Parameters.Add("@ID_PELICULA", SqlDbType.Char, 6);
            SqlParametros.Value = funcion.IDPelicula;
            SqlParametros = Comando.Parameters.Add("@ID_FORMATO", SqlDbType.Char, 6);
            SqlParametros.Value = funcion.IDFormato;
            SqlParametros = Comando.Parameters.Add("@ID_SALA", SqlDbType.Char, 6);
            SqlParametros.Value = funcion.IDSala;
            SqlParametros = Comando.Parameters.Add("@ID_SUCURSAL", SqlDbType.Char, 6);
            SqlParametros.Value = funcion.IDSucursal;
            SqlParametros = Comando.Parameters.Add("@FECHA_HORA", SqlDbType.DateTime);
            SqlParametros.Value = funcion.FechaHora;
            SqlParametros = Comando.Parameters.Add("@ESTADO", SqlDbType.Bit);
            SqlParametros.Value = funcion.Estado;
            
        }

        public void armarParametrosEditar(ref SqlCommand Comando, Funcion funcion)
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@ID_FUNCION", SqlDbType.Char, 6);
            SqlParametros.Value = funcion.IDFuncion;
            SqlParametros = Comando.Parameters.Add("@ID_PELICULA", SqlDbType.Char, 6);
            SqlParametros.Value = funcion.IDPelicula;
            SqlParametros = Comando.Parameters.Add("@ID_FORMATO", SqlDbType.Char, 6);
            SqlParametros.Value = funcion.IDFormato;
            SqlParametros = Comando.Parameters.Add("@ID_SALA", SqlDbType.Char, 6);
            SqlParametros.Value = funcion.IDSala;
            SqlParametros = Comando.Parameters.Add("@ID_SUCURSAL", SqlDbType.Char, 6);
            SqlParametros.Value = funcion.IDSucursal;
            SqlParametros = Comando.Parameters.Add("@FECHA_HORA", SqlDbType.DateTime);
            SqlParametros.Value = funcion.FechaHora;
            

        }

        public bool ActualizarFuncion(Funcion funcion)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametrosEditar(ref Comando, funcion);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarFuncion");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }

        public int eliminarFuncion(Funcion funcion)
        {
            SqlCommand comando = new SqlCommand();
            armarParametros(ref comando, funcion);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spEliminarFuncion");
        }

        public bool insertarFuncion(Funcion funcion)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, funcion);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarFuncion");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}
