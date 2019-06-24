using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ENTIDAD;


namespace DAO
{
    public class DAO_Salas
    {
        AccesoDatos ad = new AccesoDatos();
        public DataTable ObtenerTablaSalas()
        {
            DataTable tabla = ad.ObtenerTabla("Salas", "Select * from Salas");
            return tabla;
        }
        public DataTable ObtenerTablaSalas(String id_suc)
        {
            DataTable tabla = ad.ObtenerTabla("Salas", "Select * from Salas Where ID_Sucursal like '" + id_suc + "%'");
            return tabla;
        }
       
        public void armarParametros(ref SqlCommand Comando, Sala sala)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@ID_SALA", SqlDbType.Char, 10);
            SqlParametros.Value = sala.IdSala;
            SqlParametros = Comando.Parameters.Add("@ID_SUCURSAL", SqlDbType.Char, 10);
            SqlParametros.Value = sala.IdSucursal;
            SqlParametros = Comando.Parameters.Add("@SALA", SqlDbType.Char, 20);
            SqlParametros.Value = sala.NomSala;
            SqlParametros = Comando.Parameters.Add("@BUTACAS", SqlDbType.Bit);
            SqlParametros.Value = sala.Butacas;

        }
        public bool ActualizarSala(Sala sala)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, sala);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarSala");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }

        public int eliminarSala(Sala sala)
        {
            SqlCommand comando = new SqlCommand();
            armarParametros(ref comando, sala);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spEliminarSala");
        }

        public bool insertarSala(Sala sala)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, sala);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarSala");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}
