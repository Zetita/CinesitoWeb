using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using ENTIDAD;

namespace NEGOCIO
{
    public class n_Funcion
    {
        public DataTable ObtenerTabla()
        {
            DAO_Funciones da = new DAO_Funciones();
            return da.ObtenerTablaFunciones();
        }

        public DataTable ObtenerTabla(String Consulta)
        {
            DAO_Funciones da = new DAO_Funciones();
            return da.ObtenerTablaFunciones(Consulta);
        }

        public bool editarFuncion(Funcion Funcion)
        {
            DAO_Funciones da = new DAO_Funciones();
            return da.ActualizarFuncion(Funcion);
        }
        public int eliminarFuncion(Funcion Funcion)
        {
            DAO_Funciones da = new DAO_Funciones();
            return da.eliminarFuncion(Funcion);
        }
        public bool insertarFuncion(Funcion Funcion)
        {
            DAO_Funciones da = new DAO_Funciones();
            return da.insertarFuncion(Funcion);
        }
    }
}
