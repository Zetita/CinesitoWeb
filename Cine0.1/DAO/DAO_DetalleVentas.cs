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
    public class DAO_DetalleVentas
    {
        AccesoDatos ad = new AccesoDatos();

        public DataTable ObtenerTablaDetalleVentas()
        {
            DataTable tabla = ad.ObtenerTabla("DetalleVentas", "Select * from DetalleVentas");
            return tabla;
        }
        public DataTable ObtenerTablaDetalleVentas(String id_venta)
        {
            DataTable tabla = ad.ObtenerTabla("Formatos", "Select * from DetalleVentas Where Id_Venta='" + id_venta + "'");
            return tabla;
        }


        public void armarParametros(ref SqlCommand Comando, DetalleVenta detalleventa)
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@ID_VENTA", SqlDbType.Char, 10);
            SqlParametros.Value = detalleventa.IdVenta;
            SqlParametros = Comando.Parameters.Add("@ID_FUNCION", SqlDbType.Char, 10);
            SqlParametros.Value = detalleventa.IdFuncion;
            SqlParametros = Comando.Parameters.Add("@ID_BUTACA", SqlDbType.Char, 10);
            SqlParametros.Value = detalleventa.IdButaca;
            SqlParametros = Comando.Parameters.Add("@FILA_BUTACA", SqlDbType.Char, 20);
            SqlParametros.Value = detalleventa.FilaButaca;
            SqlParametros = Comando.Parameters.Add("@BUTACA", SqlDbType.Char, 20);
            SqlParametros.Value = detalleventa.Butaca;
            SqlParametros = Comando.Parameters.Add("@BEN_MENOROMAYOR", SqlDbType.Bit);
            SqlParametros.Value = detalleventa.BenMenoromayor;
            SqlParametros = Comando.Parameters.Add("@PRECIO", SqlDbType.SmallMoney);
            SqlParametros.Value = detalleventa.PrecioEntrada;
        }

        public bool ActualizarDetalleVenta(DetalleVenta detalleventa)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, detalleventa);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarFormato");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }

        public int eliminarDetalleVenta(DetalleVenta detalleventa)
        {
            SqlCommand comando = new SqlCommand();
            armarParametros(ref comando, detalleventa);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spEliminarFormato");
        }

        public bool insertarDetalleVenta(DetalleVenta detalleventa)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, detalleventa);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarFormato");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}
