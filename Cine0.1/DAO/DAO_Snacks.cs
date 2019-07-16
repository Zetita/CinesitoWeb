using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTIDAD;

namespace DAO
{
    public class DAO_Snacks
    {
        AccesoDatos ad = new AccesoDatos();
        public DataTable ObtenerTablaSnacks()
        {
            DataTable tabla = ad.ObtenerTabla("Snacks", "Select * from Snacks");
            return tabla;
        }
        public DataTable ObtenerTablaSnacks(String tipo)
        {
            DataTable tabla = ad.ObtenerTabla("Snacks", "Select * from Snacks Where Tipo_Snack='" + tipo + "'");
            return tabla;
        }

        public DataTable ObtenerTablaSnacks2(String Consulta)
        {
            DataTable tabla = ad.ObtenerTabla("Snacks", Consulta);
            return tabla;
        }

        public void armarParametros(ref SqlCommand Comando, Snack snack)
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@ID_SNACK", SqlDbType.Char, 6);
            SqlParametros.Value = snack.idSnack;
            SqlParametros = Comando.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 30);
            SqlParametros.Value = snack.Nombre;
            SqlParametros = Comando.Parameters.Add("@TIPO", SqlDbType.VarChar, 20);
            SqlParametros.Value = snack.Tipo;
            SqlParametros = Comando.Parameters.Add("@PRECIO", SqlDbType.SmallMoney);
            SqlParametros.Value = snack.Precio;
            SqlParametros = Comando.Parameters.Add("@IMAGENURL", SqlDbType.Text);
            SqlParametros.Value = snack.ImagenURL;
            SqlParametros = Comando.Parameters.Add("@ESTADO", SqlDbType.Bit);
            SqlParametros.Value = snack.Estado;

        }

        public bool ActualizarSnack(Snack snack)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, snack);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarSnack");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }

        public int eliminarSnack(Snack snack)
        {
            SqlCommand comando = new SqlCommand();
            armarParametros(ref comando, snack);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spEliminarSnack");
        }

        public bool insertarSnack(Snack snack)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametros(ref Comando, snack);
            int filasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarSnack");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}
