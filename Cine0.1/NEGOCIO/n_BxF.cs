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
    public class n_BxF
    {
        public DataTable ObtenerTabla()
        {
            DAO_BxF da = new DAO_BxF();
            return da.ObtenerTablaBxF();
        }

        public DataTable ObtenerTabla(String Consulta)
        {
            DAO_BxF da = new DAO_BxF();
            return da.ObtenerTablaBxF(Consulta);
        }
        //public bool editarBxF(ButacasxFunciones BxF)
        //{
        //    DAO_BxF da = new DAO_BxF();
        //    return da.ActualizarBxF(BxF);
        //}
        public int eliminarBxF(ButacasxFunciones BxF)
        {
            DAO_BxF da = new DAO_BxF();
            return da.eliminarBxF(BxF);
        }
        public bool insertarBxF(ButacasxFunciones BxF)
        {
            DAO_BxF da = new DAO_BxF();
            return da.insertarBxF(BxF);
        }
    }
}
