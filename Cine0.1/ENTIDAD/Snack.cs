using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Snack
    {
        private String s_idSnack;
        private String s_Nombre;
        private String s_Tipo;
        private Double d_Precio;
        private String s_ImagenURL;
        private bool b_Estado;

        public Snack()
        {

        }

        public String idSnack
        {
            set { s_idSnack = value; }
            get { return s_idSnack; }
        }

        public String Nombre
        {
            set { s_Nombre = value; }
            get { return s_Nombre; }
        }

        public String Tipo
        {
            set { s_Tipo = value; }
            get { return s_Tipo; }
        }

        public Double Precio
        {
            set { d_Precio = value; }
            get { return d_Precio; }
        }

        public String ImagenURL
        {
            set { s_ImagenURL = value; }
            get { return s_ImagenURL; }
        }

        public bool Estado
        {
            set { b_Estado = value; }
            get { return b_Estado; }
        }

    }
}
