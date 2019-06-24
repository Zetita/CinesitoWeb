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
    public class n_Sucursal
    {
        public DataTable ObtenerTabla()
        {
            DAO_Sucursales da = new DAO_Sucursales();
            return da.ObtenerTablaSucursales();
        }

        //public bool editarFormato(Formato formato)
        //{
        //     DAO_Sucursales da = new DAO_Sucursales();
        //    return da.ActualizarSucursal(formato);
        //}
        public int eliminarFormato(Sucursal Sucursal)
        {
            DAO_Sucursales da = new DAO_Sucursales();
            return da.eliminarSucursal(Sucursal);
        }
        public bool insertarFormato(Sucursal Sucursal)
        {
            DAO_Sucursales da = new DAO_Sucursales();
            return da.insertarSucursal(Sucursal);
        }
    }
}
