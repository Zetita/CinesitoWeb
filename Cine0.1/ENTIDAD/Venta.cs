using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Venta
    {
        private string s_IdVenta;
        private int i_IdUsuario;
        private string s_Usuario;
        private DateTime dt_FechaHora;
        private int i_CantidadEntradas;
        private Double d_PrecioFinal;

        public Venta()
        {

        }
        public string IdVenta
        {
            set { s_IdVenta = value; }
            get { return s_IdVenta; }
        }
        public int IdUsuario
        {
            set { i_IdUsuario = value; }
            get { return i_IdUsuario; }
        }
        public string Usuario
        {
            set { s_Usuario = value; }
            get { return s_Usuario; }
        }
        public DateTime FechaHora
        {
            set { dt_FechaHora = value; }
            get { return dt_FechaHora; }
        }
        public int CantidadEntradas
        {
            set { i_CantidadEntradas = value; }
            get { return i_CantidadEntradas; }
        }
        public Double PrecioFinal
        {
            set { d_PrecioFinal = value; }
            get { return d_PrecioFinal; }
        }
    }
}
