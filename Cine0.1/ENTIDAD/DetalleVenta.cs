using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ENTIDAD
{
    public class DetalleVenta
    {
        private String s_IdVenta;
        private String s_IdFuncion;
        private String s_IdButaca;
        private String s_FilaButaca;
        private String s_Butaca;
        private bool b_BenMenoromayor;
        private Double d_PrecioEntrada;

        public DetalleVenta()
        {

        }
        public String IdVenta
        {
            set { s_IdVenta = value; }
            get { return s_IdVenta; }
        }
        public String IdFuncion
        {
            set { s_IdFuncion = value; }
            get { return s_IdFuncion; }
        }
        public String IdButaca
        {
            set { s_IdButaca = value; }
            get { return s_IdButaca; }
        }
        public String FilaButaca
        {
            set { s_FilaButaca = value; }
            get { return s_FilaButaca; }
        }
        public String Butaca
        {
            set { s_Butaca = value; }
            get { return s_Butaca; }
        }
        public bool BenMenoromayor
        {
            set { b_BenMenoromayor = value; }
            get { return b_BenMenoromayor; }
        }
        public Double PrecioEntrada
        {
            set { d_PrecioEntrada = value; }
            get { return d_PrecioEntrada; }
        }
    }
}
