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
        private string s_IDPelicula;
        private string s_IDFormato;
        private string s_IDSucursal;
        private string s_IDSala;
        private DateTime dt_FechaHora;
        private bool b_Estado;

        public Funcion()
        {

        }

        public string IDFuncion
        {
            get { return s_IDFuncion; }
            set { s_IDFuncion = value; }
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

        public string IDSala
        {
            get { return s_IDSala; }
            set { s_IDSala = value; }
        }
        public string IDSucursal
        {
            get { return s_IDSucursal; }
            set { s_IDSucursal = value; }
        }
        public DateTime FechaHora
        {
            get { return dt_FechaHora; }
            set { dt_FechaHora = value; }
        }
        public bool Estado
        {
            set { b_Estado = value; }
            get { return b_Estado; }
        }
    }
}
