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
    public class DAO_SxV
    {
        AccesoDatos ad = new AccesoDatos();
        public DataTable ObtenerTablaSxV()
        {
            DataTable tabla = ad.ObtenerTabla("SnacksXVentas", "Select * from SnacksXVentas");
            return tabla;
        }
        public DataTable ObtenerTablaSxV(String Consulta)
        {
            DataTable tabla = ad.ObtenerTabla("SnacksxVentas", Consulta);
            return tabla;
        }
        public void armarParametros(ref SqlCommand Comando, SnackxVenta sxv)
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@ID_VENTA", SqlDbType.Char, 6);
            SqlParametros.Value = sxv.IdVenta;
            SqlParametros = Comando.Parameters.Add("@ID_SNACK", SqlDbType.Char, 6);
            SqlParametros.Value = sxv.IdSnack;
            SqlParametros = Comando.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 30);
            SqlParametros.Value = sxv.Nombre;
            SqlParametros = Comando.Parameters.Add("@PRECIO", SqlDbType.SmallMoney);
            SqlParametros.Value = sxv.Precio;
            SqlParametros = Comando.Parameters.Add("@CANTIDAD", SqlDbType.Int);
            SqlParametros.Value = sxv.Cantidad;

        }

        public bool ActualizarSxV(SnackxVenta sxv)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, sxv);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarSxV");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }

        public int eliminarSxV(SnackxVenta sxv)
        {
            SqlCommand comando = new SqlCommand();
            armarParametros(ref comando, sxv);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spEliminarSxV");
        }

        public bool insertarSxV(SnackxVenta sxv)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, sxv);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarSxV");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}