using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class ButacasxFunciones
    {
        private string s_IDButaca;
        private string s_IDFuncion;
        private string s_Fila;
        private string s_Butaca;

        public ButacasxFunciones()
        {

        }

        public string IDButaca
        {
            get { return s_IDButaca; }
            set { s_IDButaca=value;}
        }

        public string IDFuncion
        {
            get { return s_IDFuncion; }
            set { s_IDFuncion = value; }
        }

        public string Fila
        {
            get { return s_Fila; }
            set { s_Fila = value; }
        }

        public string Butaca
        {
            get { return s_Butaca; }
            set { s_Butaca = value; }
        }
    }
}
