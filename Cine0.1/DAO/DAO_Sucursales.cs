﻿using System;
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

        public void armarParametros(ref SqlCommand Comando, Sucursal sucursal)
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@ID_SUCURSAL", SqlDbType.Char, 20);
            SqlParametros.Value = sucursal.idSucursal;
            SqlParametros = Comando.Parameters.Add("@NOMBRE", SqlDbType.Char, 20);
            SqlParametros.Value = sucursal.Nombre;
            SqlParametros = Comando.Parameters.Add("@DIRECCION", SqlDbType.Char, 60);
            SqlParametros.Value = sucursal.Direccion;
            SqlParametros = Comando.Parameters.Add("@LOCALIDAD", SqlDbType.Char, 40);
            SqlParametros.Value = sucursal.Localidad;
            SqlParametros = Comando.Parameters.Add("@PROVINCIA", SqlDbType.Char, 40);
            SqlParametros.Value = sucursal.Provincia;
            

        }

        public bool ActualizarSucursal(Sucursal sucursal)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, sucursal);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarSucursal");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }

        public int eliminarSucursal(Sucursal sucursal)
        {
            SqlCommand comando = new SqlCommand();
            armarParametros(ref comando, sucursal);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spEliminarSucursal");
        }

        public bool insertarSucursal(Sucursal sucursal)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, sucursal);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarSucursal");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}
