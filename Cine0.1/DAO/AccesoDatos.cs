using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
        public DataTable ObtenerTabla(String Nombre, String Sql)
        {
            DataSet ds = new DataSet();

            SqlConnection Conexion = ObtenerConexion();
            SqlDataAdapter adaptador = ObtenerAdaptador(Sql);
            adaptador.Fill(ds, Nombre);
            return ds.Tables[Nombre];
        }

        

        public int EjecutarProcedimientoAlmacenado(SqlCommand Comando, String NombreSP)
        {
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;
            int FilasCambiadas = cmd.ExecuteNonQuery(); ///System.Data.SqlClient.SqlException: 
            ///'No se permite la conversión implícita del tipo de datos char a varbinary(max). Utilice la función CONVERT para ejecutar esta consulta.'

            Conexion.Close();
            return FilasCambiadas;
        }
    }
}
