using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Funcion
    {
        private string s_IDFuncion;
        private string s_IDPxF;
        private string s_IDSala;
        private string s_FechaHora;

        public Funcion()
        {

        }

        public string IDFuncion
        {
            get { return s_IDFuncion; }
            set { s_IDFuncion = value; }
        }

        public string IDPxF
        {
            get { return s_IDPxF; }
            set { s_IDPxF = value; }
        }

        public string IDSala
        {
            get { return s_IDSala; }
            set { s_IDSala = value; }
        }

        public string FechaHora
        {
            get { return s_FechaHora; }
            set { s_FechaHora = value; }
        }

    }
}
