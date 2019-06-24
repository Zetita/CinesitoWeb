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
    public class n_DetalleVenta
    {
        public DataTable ObtenerTablaDetalleVenta()
        {
            DAO_DetalleVentas da = new DAO_DetalleVentas();
            return da.ObtenerTablaDetalleVentas();
        }
        public DataTable ObtenerTablaDetalleVenta(String id_ven)
        {
            DAO_DetalleVentas da = new DAO_DetalleVentas();
            return da.ObtenerTablaDetalleVentas(id_ven);
        }
        public bool editarDetalleVenta(DetalleVenta detalleVenta)
        {
            DAO_DetalleVentas da = new DAO_DetalleVentas();
            return da.ActualizarDetalleVenta(detalleVenta);
        }
        public int eliminarDetalleVenta(DetalleVenta detalleVenta)
        {
            DAO_DetalleVentas da = new DAO_DetalleVentas();
            return da.eliminarDetalleVenta(detalleVenta);
        }
        public bool insertarDetalleVenta(DetalleVenta detalleVenta)
        {
            DAO_DetalleVentas da = new DAO_DetalleVentas();
            return da.insertarDetalleVenta(detalleVenta);
        }
    }
}
