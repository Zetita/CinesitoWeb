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
    public class n_Snack
    {
        public DataTable ObtenerTabla()
        {
            DAO_Snacks da = new DAO_Snacks();
            return da.ObtenerTablaSnacks();
        }

        //public bool editarSnack(Snack snack)
        //{
        //    DAO_Snacks da = new DAO_Snacks();
        //    return da.ActualizarSnack(snack);
        //}
        public int eliminarSnack(Snack snack)
        {
            DAO_Snacks da = new DAO_Snacks();
            return da.eliminarSnack(snack);
        }
        public bool insertarSnack(Snack snack)
        {
            DAO_Snacks da = new DAO_Snacks();
            return da.insertarSnack(snack)
        }
    }
}
