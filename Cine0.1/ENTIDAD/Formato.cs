using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Formato
    {
        private String s_idFormato;
        private String s_Nombre;
        private String s_Idioma;
        private bool b_Subtitulos;
        private Double d_Precio;

        public Formato()
        {

        }

        public String IdFormato
        {
            set { s_idFormato = value; }
            get { return s_idFormato; }
        }
        public String Nombre
        {
            set { s_Nombre = value; }
            get { return s_Nombre; }
        }
        public String Idioma
        {
            set { s_Idioma = value; }
            get { return s_Idioma; }
        }
        public bool Subtitulos
        {
            set { b_Subtitulos = value; }
            get { return b_Subtitulos; }
        }
        public Double Precio
        {
            set { d_Precio = value; }
            get { return d_Precio; }
        }
    }
}
