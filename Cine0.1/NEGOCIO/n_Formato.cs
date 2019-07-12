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
    public class n_Formato
    {
        public DataTable ObtenerTabla()
        {
            DAO_Formatos da = new DAO_Formatos();
            return da.ObtenerTablaFormatos();
        }

        public DataTable ObtenerTabla(string ID)
        {
            DAO_Formatos da = new DAO_Formatos();
            return da.ObtenerTablaFormatos(ID);
        }

        public bool editarFormato(Formato formato)
        {
            DAO_Formatos da = new DAO_Formatos();
            return da.ActualizarFormato(formato);
        }
        public int eliminarFormato(Formato formato)
        {
            DAO_Formatos da = new DAO_Formatos();
            return da.eliminarFormato(formato);
        }
        public bool insertarFormato(Formato formato)
        {
            DAO_Formatos da = new DAO_Formatos();
            return da.insertarFormato(formato);
        }
    }
}
