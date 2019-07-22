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
            DataTable tabla = ad.ObtenerTabla("PeliculasxFormatos", "Select * from PeliculasXFormatos");
            return tabla;
        }
        public DataTable ObtenerTablaPxF(String id_pel)
        {
            DataTable tabla = ad.ObtenerTabla("PeliculasxFormatos", "Select * from PeliculasXFormatos Where ID_Pelicula='" + id_pel + "'");
            return tabla;
        }
        public DataTable ObtenerTablaPxF(string id_pel,string id_for)
        {
            DataTable tabla = ad.ObtenerTabla("PeliculasxFormatos", "Select * from PeliculasXFormatos Where ID_Pelicula='" + id_pel + "' and ID_Formato='" + id_for + "'");
            return tabla;
        }
        public DataTable ObtenerTituloFormato(String pel, int aa)
        {
            DataTable tabla =
                ad.ObtenerTabla("TituloFormato", "SELECT Titulo_Pelicula, Nombre_Formato FROM PeliculasXFormatos " +
                "INNER JOIN Peliculas ON PeliculasxFormatos.ID_Pelicula=Peliculas.ID_Pelicula " +
                "INNER JOIN Formatos ON PeliculasxFormatos.ID_Formato=Formatos.ID_Formato WHERE " +
                "PeliculasxFormatos.ID_Pelicula='" + pel + "'");
            return tabla;
        }
        public DataTable ObtenerTablaFormatosxPel(String idpel)
        {
            DataTable tabla =
                ad.ObtenerTabla("FormatosxPel", "SELECT PeliculasXFormatos.ID_Formato, Formatos.Nombre_Formato FROM PeliculasXFormatos " +
                "Inner Join Formatos on PeliculasXFormatos.ID_Formato=Formatos.ID_Formato WHERE PeliculasxFormatos.ID_Pelicula='" + idpel + "'" );
            return tabla;
        }
        public void armarParametros(ref SqlCommand Comando, PeliculasxFormato pxf)
        {
            SqlParameter SqlParametros = new SqlParameter();
            
            SqlParametros = Comando.Parameters.Add("@ID_PELICULA", SqlDbType.Char, 6);
            SqlParametros.Value = pxf.IDPelicula;
            SqlParametros = Comando.Parameters.Add("@ID_FORMATO", SqlDbType.Char, 6);
            SqlParametros.Value = pxf.IDFormato;

        }

        public bool ActualizarPxF(PeliculasxFormato pxf)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, pxf);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarPxF");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }

        public int eliminarPxF(PeliculasxFormato pxf)
        {
            SqlCommand comando = new SqlCommand();
            armarParametros(ref comando, pxf);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spEliminarPxF");
        }

        public bool insertarPxF(PeliculasxFormato pxf)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, pxf);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarPxF");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}
