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
    public class DAO_Peliculas
    {
        AccesoDatos ad = new AccesoDatos();
        public DataTable ObtenerTablaPeliculas()
        {
            DataTable tabla = ad.ObtenerTabla("Peliculas", "Select * from Peliculas Where Estado=1");
            return tabla;
        }
        public DataTable ObtenerTablaPeliculas(String Consulta)
        {
            DataTable tabla = ad.ObtenerTabla("Peliculas", Consulta );
            return tabla;
        }

        public void armarParametros(ref SqlCommand Comando, Pelicula pelicula)
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@ID_PELICULA", SqlDbType.Char, 6);
            SqlParametros.Value = pelicula.idPelicula;
            SqlParametros = Comando.Parameters.Add("@TITULO", SqlDbType.VarChar, 40);
            SqlParametros.Value = pelicula.Titulo;
            SqlParametros = Comando.Parameters.Add("@GENERO", SqlDbType.Text);
            SqlParametros.Value = pelicula.Generos;
            SqlParametros = Comando.Parameters.Add("@CLASIFICACION", SqlDbType.VarChar, 10);
            SqlParametros.Value = pelicula.Clasificacion;
            SqlParametros = Comando.Parameters.Add("@FECHAESTRENO", SqlDbType.Date);
            SqlParametros.Value = pelicula.FecEstreno;
            SqlParametros = Comando.Parameters.Add("@DIRECTOR", SqlDbType.VarChar, 40);
            SqlParametros.Value = pelicula.Director;
            SqlParametros = Comando.Parameters.Add("@SINOPSIS", SqlDbType.Text);
            SqlParametros.Value = pelicula.Sinopsis;
            SqlParametros = Comando.Parameters.Add("@IMAGENURL", SqlDbType.Text);
            SqlParametros.Value = pelicula.ImagenURL;
            SqlParametros = Comando.Parameters.Add("@DURACION", SqlDbType.Time, 7);
            SqlParametros.Value = pelicula.Duracion;
            SqlParametros = Comando.Parameters.Add("@TRAILERURL", SqlDbType.Text);
            SqlParametros.Value = pelicula.TrailerURL;
            SqlParametros = Comando.Parameters.Add("@ESTADO", SqlDbType.Bit);
            SqlParametros.Value = pelicula.Estado;

        }

        public bool ActualizarPeliculas(Pelicula pelicula)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, pelicula);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarPelicula");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }

        public int eliminarPeliculas(Pelicula pelicula)
        {
            SqlCommand comando = new SqlCommand();
            armarParametros(ref comando, pelicula);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spEliminarPelicula");
        }

        public bool insertarPelicula(Pelicula pelicula)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, pelicula);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarPelicula");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }
        
    }
}
