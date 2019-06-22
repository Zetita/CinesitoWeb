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
                DataTable tabla = ad.ObtenerTabla("Peliculas", "Select * from Peliculas");
                return tabla;
            }

            public void armarParametros(ref SqlCommand Comando, Peliculas Pelicula)
            {
                SqlParameter SqlParametros = new SqlParameter();

                SqlParametros = Comando.Parameters.Add("@ID_PELICULA", SqlDbType.Char, 20);
                SqlParametros.Value = Pelicula.idPelicula;
                SqlParametros = Comando.Parameters.Add("@TITULO", SqlDbType.Char, 40);
                SqlParametros.Value = Pelicula.Titulo;
                SqlParametros = Comando.Parameters.Add("@GENERO", SqlDbType.Text);
                SqlParametros.Value = Pelicula.Generos;
                SqlParametros = Comando.Parameters.Add("@CLASIFICACION", SqlDbType.Char, 10);
                SqlParametros.Value = Pelicula.Clasificacion;
                SqlParametros = Comando.Parameters.Add("@FECESTRENO", SqlDbType.Date);
                SqlParametros.Value = Pelicula.FecEstreno;
                SqlParametros = Comando.Parameters.Add("@DIRECTOR", SqlDbType.Char, 40);
                SqlParametros.Value = Pelicula.Director;
                SqlParametros = Comando.Parameters.Add("@SINOPSIS", SqlDbType.Text);
                SqlParametros.Value = Pelicula.Sinopsis;
                SqlParametros = Comando.Parameters.Add("@IMAGEN_URL", SqlDbType.Text);
                SqlParametros.Value = Pelicula.ImagenURL;
                SqlParametros = Comando.Parameters.Add("@DURACION", SqlDbType.Bit);
                SqlParametros.Value = Pelicula.Duracion;
                SqlParametros = Comando.Parameters.Add("@TRAILER_URL", SqlDbType.Time, 7);
                SqlParametros.Value = Pelicula.TrailerURL;

            }

            //public bool ActualizarPeliculas(Peliculas Pelicula)
            //{
            //    SqlCommand Comando = new SqlCommand();
            //    armarParametros(ref Comando, Funcion);
            //    int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarPelicula");
            //    if (filasInsertadas == 1)
            //        return true;
            //    else
            //        return false;
            //}

            public int eliminarPeliculas(Peliculas Pelicula)
            {
                SqlCommand comando = new SqlCommand();
                armarParametros(ref comando, Pelicula);
                return ad.EjecutarProcedimientoAlmacenado(comando, "spEliminarPelicula");
            }

            public bool insertarPelicula(Peliculas Pelicula)
            {
                SqlCommand Comando = new SqlCommand();
                armarParametros(ref Comando, Pelicula);
                int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarPelicula");
                if (filasInsertadas == 1)
                    return true;
                else
                    return false;
            }
        
    }
}
