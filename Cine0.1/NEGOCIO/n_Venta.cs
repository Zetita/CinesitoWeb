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
    public class n_Venta
    {
        public DataTable ObtenerTablaVenta()
        {
            DAO_Ventas da = new DAO_Ventas();
            return da.ObtenerTablaVentas();
        }
        public DataTable ObtenerTablaVenta(String usuario)
        {
            DAO_Ventas da = new DAO_Ventas();
            return da.ObtenerTablaVentas(usuario);
        }

        public bool editarVenta(Venta venta)
        {
            DAO_Ventas da = new DAO_Ventas();
            return da.ActualizarVenta(venta);
        }
        public int eliminarVenta(Venta venta)
        {
            DAO_Ventas da = new DAO_Ventas();
            return da.eliminarVenta(venta);
        }
        public bool insertarVenta(Venta venta)
        {
            DAO_Ventas da = new DAO_Ventas();
            return da.insertarVenta(venta);

        }
    }
}
