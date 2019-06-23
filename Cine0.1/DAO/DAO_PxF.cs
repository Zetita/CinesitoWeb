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
    public class DAO_PxF
    {

        AccesoDatos ad = new AccesoDatos();
        public DataTable ObtenerTablaPxF()
        {
            DataTable tabla = ad.ObtenerTabla("PeliculasxFormatos", "Select * from PeliculasxFormatos");
            return tabla;
        }

        public void armarParametros(ref SqlCommand Comando, PeliculasxFormato PxF)
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@ID_PXF", SqlDbType.Char, 20);
            SqlParametros.Value = PxF.IDPxF;
            SqlParametros = Comando.Parameters.Add("@ID_PELICULA", SqlDbType.Char, 20);
            SqlParametros.Value = PxF.IDPelicula;
            SqlParametros = Comando.Parameters.Add("@ID_FORMATO", SqlDbType.Char, 20);
            SqlParametros.Value = PxF.IDFormato;

        }

        //public bool ActualizarPxF(PeliculasxFormatos PxF)
        //{
        //    SqlCommand Comando = new SqlCommand();
        //    armarParametros(ref Comando, PxF);
        //    int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarPxF");
        //    if (filasInsertadas == 1)
        //        return true;
        //    else
        //        return false;
        //}

        public int eliminarSucursal(PeliculasxFormato PxF)
        {
            SqlCommand comando = new SqlCommand();
            armarParametros(ref comando, PxF);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spEliminarPxF");
        }

        public bool insertarSucursal(PeliculasxFormato PxF)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, PxF);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarPxF");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}
