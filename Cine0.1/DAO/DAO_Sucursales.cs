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
    public class DAO_Sucursales
    {
        AccesoDatos ad = new AccesoDatos();
        public DataTable ObtenerTablaSucursales()
        {
            DataTable tabla = ad.ObtenerTabla("Sucursales", "Select * from Sucursales");
            return tabla;
        }

        public void armarParametros(ref SqlCommand Comando, Sucursal Sucursal)
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@ID_SUCURSAL", SqlDbType.Char, 20);
            SqlParametros.Value = Sucursal.idSucursal;
            SqlParametros = Comando.Parameters.Add("@NOMBRE", SqlDbType.Char, 20);
            SqlParametros.Value = Sucursal.Nombre;
            SqlParametros = Comando.Parameters.Add("@DIRECCION", SqlDbType.Char, 60);
            SqlParametros.Value = Sucursal.Direccion;
            SqlParametros = Comando.Parameters.Add("@LOCALIDAD", SqlDbType.Char, 40);
            SqlParametros.Value = Sucursal.Localidad;
            SqlParametros = Comando.Parameters.Add("@PROVINCIA", SqlDbType.Char, 40);
            SqlParametros.Value = Sucursal.Provincia;
            

        }

        //public bool ActualizarSucursal(Sucursal Sucursal)
        //{
        //    SqlCommand Comando = new SqlCommand();
        //    armarParametros(ref Comando, Funcion);
        //    int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarSucursal");
        //    if (filasInsertadas == 1)
        //        return true;
        //    else
        //        return false;
        //}

        public int eliminarSucursal(Sucursal Sucursal)
        {
            SqlCommand comando = new SqlCommand();
            armarParametros(ref comando, Sucursal);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spEliminarSucursal");
        }

        public bool insertarSucursal(Sucursal Sucursal)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, Sucursal);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarSucursal");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}
