using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class PeliculasxFormato
    {
        private string s_IDPelicula;
        private string s_IDFormato;

        public PeliculasxFormato()
        {

        }

        public string IDPelicula
        {
            get { return s_IDPelicula; }
            set { s_IDPelicula = value; }
        }

        public string IDFormato
        {
            get { return s_IDFormato; }
            set { s_IDFormato = value; }
        }
    }
}
