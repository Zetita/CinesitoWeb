using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public DataTable ObtenerTituloFormato(String id)
        {
            DAO_PxF da = new DAO_PxF();
            return da.ObtenerTituloFormato(id);
        }
        public bool editarPxF(PeliculasxFormato pxf)
        {
            DAO_PxF da = new DAO_PxF();
            return da.ActualizarPxF(pxf);
        }
        public int eliminarPxF(PeliculasxFormato pxf)
        {
            DAO_PxF da = new DAO_PxF();
            return da.eliminarPxF(pxf);
        }
        public bool insertarPxF(PeliculasxFormato pxf)
        {
            DAO_PxF da = new DAO_PxF();
            return da.insertarPxF(pxf);
        }
    }
}
