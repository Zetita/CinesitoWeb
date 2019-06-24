using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAO;
using ENTIDAD;

namespace NEGOCIO
{
    public class n_PxF
    {
        public DataTable ObtenerTabla()
        {
            DAO_PxF da = new DAO_PxF();
            return da.ObtenerTablaPxF();
        }

        //public bool editarFormato(PeliculasxFormato PxF)
        //{
        //     DAO_PxF da = new DAO_PxF();
        //    return da.ActualizarPxF(PxF);
        //}
        public int eliminarPxF(PeliculasxFormato PxF)
        {
            DAO_PxF da = new DAO_PxF();
            return da.eliminarPxF(PxF);
        }
        public bool insertarPxF(PeliculasxFormato PxF)
        {
            DAO_PxF da = new DAO_PxF();
            return da.insertarPxF(PxF);
        }
    }
}
