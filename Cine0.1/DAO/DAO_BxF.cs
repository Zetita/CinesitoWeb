﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ENTIDAD;


namespace DAO
{
    public class DAO_BxF
    {
        AccesoDatos ad = new AccesoDatos();
        public DataTable ObtenerTablaBxF()
        {
            DataTable tabla = ad.ObtenerTabla("ButacaXFunciones", "Select * from ButacaXFunciones");
            return tabla;
        }
        public DataTable ObtenerTablaBxF(String Consulta)
        {
            DataTable tabla =
                ad.ObtenerTabla("ButacaXFunciones", Consulta);
            return tabla;
        }

        public void armarParametros(ref SqlCommand Comando, ButacasxFunciones BxF)
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@ID_BUTACA", SqlDbType.Char, 10);
            SqlParametros.Value = BxF.IDButaca;
            SqlParametros = Comando.Parameters.Add("@ID_FUNCION", SqlDbType.Char, 10);
            SqlParametros.Value = BxF.IDFuncion;
            SqlParametros = Comando.Parameters.Add("@FILA", SqlDbType.Char, 20);
            SqlParametros.Value = BxF.Fila;
            SqlParametros = Comando.Parameters.Add("@BUTACA", SqlDbType.Char, 20);
            SqlParametros.Value = BxF.Butaca;

        }

        //public bool ActualizarBxF(ButacasxFunciones BxF)
        //{
        //    SqlCommand Comando = new SqlCommand();
        //    armarParametros(ref Comando, BxF);
        //    int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarBxF");
        //    if (filasInsertadas == 1)
        //        return true;
        //    else
        //        return false;
        //}

        public int eliminarBxF(ButacasxFunciones BxF)
        {
            SqlCommand comando = new SqlCommand();
            armarParametros(ref comando, BxF);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spEliminarBxF");
        }

        public bool insertarBxF(ButacasxFunciones BxF)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, BxF);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarBxF");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}
