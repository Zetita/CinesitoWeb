using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class SnackxVenta
    {
        private String s_IdVenta;
        private String s_IdSnack;
        private String s_Nombre;
        private Double d_Precio;
        private int i_Cantidad;

        public SnackxVenta()
        {

        }

        public String IdVenta
        {
            set { s_IdVenta = value; }
            get { return s_IdVenta; }
        }
        public String IdSnack
        {
            set { s_IdSnack = value; }
            get { return s_IdSnack; }
        }
        public String Nombre
        {
            set { s_Nombre = value; }
            get { return s_Nombre; }
        }
        public Double Precio
        {
            set { d_Precio = value; }
            get { return d_Precio; }
        }
        public int Cantidad
        {
            set { i_Cantidad = value; }
            get { return i_Cantidad; }
        }
    }
}
