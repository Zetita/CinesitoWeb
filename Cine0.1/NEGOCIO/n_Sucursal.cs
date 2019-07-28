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
    public class n_Sucursal
    {
        public DataTable ObtenerTabla()
        {
            DAO_Sucursales da = new DAO_Sucursales();
            return da.ObtenerTablaSucursales();
        }

        public bool editarSucursal(Sucursal sucursal)
        {
            DAO_Sucursales da = new DAO_Sucursales();

            return da.ActualizarSucursal(sucursal);
        }
        public int eliminarSucursal(Sucursal sucursal)
        {
            DAO_Sucursales da = new DAO_Sucursales();
            return da.eliminarSucursal(sucursal);
        }
        public bool insertarSucursal(Sucursal sucursal)
        {
            DAO_Sucursales da = new DAO_Sucursales();
            return da.insertarSucursal(sucursal);
        }

    }
}
