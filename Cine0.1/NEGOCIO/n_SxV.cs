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
    public class n_SxV
    {
        public DataTable ObtenerTablaSxV()
        {
            DAO_SxV da = new DAO_SxV();
            return da.ObtenerTablaSxV();
        }

        public bool editarSxV(SnackxVenta snackxVenta)
        {
            DAO_SxV da = new DAO_SxV();
            return da.ActualizarSxV(snackxVenta);
        }
        public int eliminarSxV(SnackxVenta snackxVenta)
        {
            DAO_SxV da = new DAO_SxV();
            return da.eliminarSxV(snackxVenta);
        }
        public bool insertarSxV(SnackxVenta snackxVenta)
        {
            DAO_SxV da = new DAO_SxV();
            return da.insertarSxV(snackxVenta);
        }
    }
}  
