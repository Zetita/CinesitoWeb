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
    public class DAO_Formatos
    {
        AccesoDatos ad = new AccesoDatos();
        public DataTable ObtenerTablaFormatos()
        {
            DataTable tabla = ad.ObtenerTabla("Formatos", "Select * from Formatos");
            return tabla;
        }

        public void armarParametros(ref SqlCommand Comando, Formato formato)
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@ID_FORMATO", SqlDbType.Char, 20);
            SqlParametros.Value = formato.IdFormato;
            SqlParametros = Comando.Parameters.Add("@NOMBRE", SqlDbType.Char, 20);
            SqlParametros.Value = formato.Nombre;
            SqlParametros = Comando.Parameters.Add("@IDIOMA", SqlDbType.Char, 40);
            SqlParametros.Value = formato.Idioma;
            SqlParametros = Comando.Parameters.Add("@SUBTITULOS", SqlDbType.Bit);
            SqlParametros.Value = formato.Subtitulos;
            SqlParametros = Comando.Parameters.Add("@PRECIO", SqlDbType.Float);
            SqlParametros.Value = formato.Precio;


        }

        //public bool ActualizarFormato(Formato formato)
        //{
        //    SqlCommand Comando = new SqlCommand();
        //    armarParametros(ref Comando, formato);
        //    int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarFormato");
        //    if (filasInsertadas == 1)
        //        return true;
        //    else
        //        return false;
        //}

        public int eliminarFormato(Formato formato)
        {
            SqlCommand comando = new SqlCommand();
            armarParametros(ref comando, formato);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spEliminarFormato");
        }

        public bool insertarFormato(Formato formato)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, formato);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarFormato");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}
