using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Sucursal
    {
        private String s_idSucursal;
        private String s_Nombre;
        private String s_Direccion;
        private String s_Localidad;
        private String s_Provincia;
        private String s_DireccionURL;

        public Sucursal()
        {

        }

        public String idSucursal
        {
            set { s_idSucursal = value; }
            get { return s_idSucursal; }
        }
        public String Nombre
        {
            set { s_Nombre = value; }
            get { return s_Nombre; }
        }
        public String Direccion
        {
            set { s_Direccion = value; }
            get { return s_Direccion; }
        }
        public String Localidad
        {
            set { s_Localidad = value; }
            get { return s_Localidad; }
        }
        public String Provincia
        {
            set { s_Provincia = value; }
            get { return s_Provincia; }
        }
        public String DireccionURL
        {
            set { s_DireccionURL = value; }
            get { return s_DireccionURL; }
        }
    }
}
