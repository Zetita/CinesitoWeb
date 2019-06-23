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
    class DAO_Ventas
    {
        AccesoDatos ad = new AccesoDatos();

        public DataTable ObtenerTablaVentas()
        {
            DataTable tabla = ad.ObtenerTabla("Ventas", "Select * from Ventas");
            return tabla;
        }
        public DataTable ObtenerTablaVentas(String usuario)
        {
            DataTable tabla = ad.ObtenerTabla("Ventas", "Select * from Ventas Where Usuario_Venta='" + usuario + "'");
            return tabla;
        }
        public void armarParametros(ref SqlCommand Comando, Venta venta)
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@ID_VENTA", SqlDbType.Char, 10);
            SqlParametros.Value = venta.IdVenta;
            SqlParametros = Comando.Parameters.Add("@IDUSUARIO", SqlDbType.Int);
            SqlParametros.Value = venta.IdUsuario;
            SqlParametros = Comando.Parameters.Add("@USUARIO", SqlDbType.Char, 40);
            SqlParametros.Value = venta.Usuario;
            SqlParametros = Comando.Parameters.Add("@FECHA_HORA", SqlDbType.DateTime);
            SqlParametros.Value = venta.FechaHora;
            SqlParametros = Comando.Parameters.Add("@CANT_ENTRADAS", SqlDbType.Int);
            SqlParametros.Value = venta.CantidadEntradas;
            SqlParametros = Comando.Parameters.Add("@PRECIO_FINAL", SqlDbType.SmallMoney);
            SqlParametros.Value = venta.PrecioFinal;

        }
        public bool ActualizarVenta(Venta venta)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, venta);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarVenta");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }

        public int eliminarFormato(Venta venta)
        {
            SqlCommand comando = new SqlCommand();
            armarParametros(ref comando, venta);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spEliminarVenta");
        }

        public bool insertarFormato(Venta venta)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, venta);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarVenta");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}
