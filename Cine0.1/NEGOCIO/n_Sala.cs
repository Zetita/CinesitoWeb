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
    public class n_Sala
    {
        public DataTable ObtenerTablaSalas()
        {
            DAO_Salas da = new DAO_Salas();
            return da.ObtenerTablaSalas();
        }
        public int ObtenerCantRegistros()
        {
            DAO_Salas da = new DAO_Salas();
            DataTable dt = da.ObtenerTablaSalas();

            return dt.Rows.Count;
        }
        public DataTable ObtenerTablaSalas(String Suc)
        {
            DAO_Salas da = new DAO_Salas();
            return da.ObtenerTablaSalas(Suc);
        }
        public bool editarSala(Sala sala)
        {
            DAO_Salas da = new DAO_Salas();
            return da.ActualizarSala(sala);
        }
        public int eliminarSala(Sala sala)
        {
            DAO_Salas da = new DAO_Salas();
            return da.eliminarSala(sala);
        }
        public bool insertarSala(Sala sala)
        {
            DAO_Salas da = new DAO_Salas();
            return da.insertarSala(sala);
        }
    }
}
