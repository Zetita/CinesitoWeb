using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Sala
    {
        private String s_IdSala;
        private String s_IdSucursal;
        private String s_NomSala;
        private int i_Butacas;

        public Sala()
        {
            
        }
        public String IdSala
        {
            set { s_IdSala = value; }
            get { return s_IdSala; }
        }
        public String IdSucursal
        {
            set { s_IdSucursal = value; }
            get { return s_IdSucursal; }
        }
        public String NomSala
        {
            set { s_NomSala = value; }
            get { return s_NomSala; }
        }
        public int Butacas
        {
            set { i_Butacas = value; }
            get { return i_Butacas; }
        }
    }
}
