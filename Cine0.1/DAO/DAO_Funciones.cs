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
        public DataTable ObtenerTablaFunciones(string Consulta)
        {
            DataTable tabla = ad.ObtenerTabla("Funciones", Consulta);
            return tabla;
        }

        public void armarParametros(ref SqlCommand Comando, Funciones Funcion)
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@ID_FUNCION", SqlDbType.Char, 20);
            SqlParametros.Value = Funcion.IDFuncion;
            SqlParametros = Comando.Parameters.Add("@ID_PXF", SqlDbType.Char, 20);
            SqlParametros.Value = Funcion.IDPxF;
            SqlParametros = Comando.Parameters.Add("@ID_SALA", SqlDbType.Char, 20);
            SqlParametros.Value = Funcion.IDSala;
            SqlParametros = Comando.Parameters.Add("@FECFUNCION", SqlDbType.DateTime);
            SqlParametros.Value = Funcion.FechaHora;
            
        }

        //public bool ActualizarFuncion(Funciones Funcion)
        //{
        //    SqlCommand Comando = new SqlCommand();
        //    armarParametros(ref Comando, Funcion);
        //    int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarFuncion");
        //    if (filasInsertadas == 1)
        //        return true;
        //    else
        //        return false;
        //}

        public int eliminarFuncion(Funciones Funcion)
        {
            SqlCommand comando = new SqlCommand();
            armarParametros(ref comando, Funcion);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spEliminarFuncion");
        }

        public bool insertarFuncion(Funciones Funcion)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, Funcion);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarFuncion");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}
