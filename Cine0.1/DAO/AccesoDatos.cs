using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class AccesoDatos
    {
        string rutaBase = "Data Source=localhost\\sqlexpress;Initial Catalog=CineFrenz;Integrated Security=True";

        public AccesoDatos()
        {

        }

        public SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBase);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public SqlDataAdapter ObtenerAdaptador(String consultaSql)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, rutaBase);
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
