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
    public class DAO_PxF
    {

        AccesoDatos ad = new AccesoDatos();
        public DataTable ObtenerTablaPxF()
        {
            DataTable tabla = ad.ObtenerTabla("PeliculasxFormatos", "Select * from PeliculasXFormatos");
            return tabla;
        }
        public DataTable ObtenerTablaPxF(String id_pel)
        {
            DataTable tabla = ad.ObtenerTabla("PeliculasxFormatos", "Select * from PeliculasXFormatos Where ID_Pelicula='" + id_pel + "'");
            return tabla;
        }
        public void armarParametros(ref SqlCommand Comando, PeliculasxFormato pxf)
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@ID_PXF", SqlDbType.Char, 20);
            SqlParametros.Value = pxf.IDPxF;
            SqlParametros = Comando.Parameters.Add("@ID_PELICULA", SqlDbType.Char, 20);
            SqlParametros.Value = pxf.IDPelicula;
            SqlParametros = Comando.Parameters.Add("@ID_FORMATO", SqlDbType.Char, 20);
            SqlParametros.Value = pxf.IDFormato;

        }

        public bool ActualizarPxF(PeliculasxFormato pxf)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, pxf);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarPxF");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }

        public int eliminarSucursal(PeliculasxFormato pxf)
        {
            SqlCommand comando = new SqlCommand();
            armarParametros(ref comando, pxf);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spEliminarPxF");
        }

        public bool insertarSucursal(PeliculasxFormato pxf)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, pxf);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarPxF");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}
