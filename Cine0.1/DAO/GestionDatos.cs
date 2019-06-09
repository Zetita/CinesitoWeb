﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    class GestionDatos
    {
        private DataTable ObtenerTabla(String Nombre, String Sql)
        {
            DataSet ds = new DataSet();
            AccesoDatos datos = new AccesoDatos();
            SqlDataAdapter adaptador = datos.ObtenerAdaptador(Sql);
            adaptador.Fill(ds, Nombre);
            return ds.Tables[Nombre];
        }
        public DataTable ObtenerTodosLosFormatos()
        {
            return ObtenerTabla("Formatos", "SELECT * FROM Formatos");
        }
    }
}
