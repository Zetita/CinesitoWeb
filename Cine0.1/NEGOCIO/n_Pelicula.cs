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
    public class n_Pelicula
    {
        public DataTable ObtenerTabla()
        {
            DAO_Peliculas da = new DAO_Peliculas();
            return da.ObtenerTablaPeliculas();
        }

        public DataTable ObtenerTabla(String Consulta)
        {
            DAO_Peliculas da = new DAO_Peliculas();
            return da.ObtenerTablaPeliculas(Consulta);
        }
        //public bool editarPelicula(Pelicula pelicula)
        //{
        //    DAO_Peliculas da = new DAO_Peliculas();
        //    return da.ActualizarPeliculas(pelicula);
        //}
        public int eliminarPelicula(Pelicula pelicula)
        {
            DAO_Peliculas da = new DAO_Peliculas();
            return da.eliminarPeliculas(pelicula);
        }
        public bool insertarPelicula(Pelicula pelicula)
        {
            DAO_Peliculas da = new DAO_Peliculas();
            return da.insertarPelicula(pelicula);
        }
        
    }
}
