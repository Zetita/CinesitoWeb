using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace PRESENTACION
{
    public partial class Butacas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DAO.GestionDatos Datos = new DAO.GestionDatos();
            //string ID_Funcion = Application["ID_Funcion"].ToString();
            //string Consulta = "Select * from ButacasxFunciones where ID_Funcion=" + ID_Funcion;
            //DataTable dt = Datos.ObtenerTodos("ButacasxFunciones", Consulta);
            //for (int x = 1; x <= 44; x++)
            //{
            //        for (int j = 0; j < dt.Rows.Count; j++)
            //        {
            //            if (x.ToString()== dt.Rows[j]["ID_Butaca"].ToString().Trim())
            //            {
            //            Colorear(x.ToString());
            //            }
            //        }
            //}

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Peliculas.aspx");
        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            Response.Redirect("Compras.aspx");
        }

        ///Perdon Sheila, era necesario :(

        public void Colorear(string x)
        {
            switch (x)
            {
                case "1":
                    btn1.BackColor = Color.Red;
                    break;
                case "2":
                    btn2.BackColor = Color.Red;
                    break;
                case "3":
                    btn3.BackColor = Color.Red;
                    break;
                case "4":
                    btn4.BackColor = Color.Red;
                    break;
                case "5":
                    btn5.BackColor = Color.Red;
                    break;
                case "6":
                    btn6.BackColor = Color.Red;
                    break;
                case "7":
                    btn7.BackColor = Color.Red;
                    break;
                case "8":
                    btn8.BackColor = Color.Red;
                    break;
                case "9":
                    btn9.BackColor = Color.Red;
                    break;
                case "10":
                    btn10.BackColor = Color.Red;
                    break;
                case "11":
                    btn11.BackColor = Color.Red;
                    break;
                case "12":
                    btn12.BackColor = Color.Red;
                    break;
                case "13":
                    btn13.BackColor = Color.Red;
                    break;
                case "14":
                    btn14.BackColor = Color.Red;
                    break;
                case "15":
                    btn15.BackColor = Color.Red;
                    break;
                case "16":
                    btn16.BackColor = Color.Red;
                    break;
                case "17":
                    btn17.BackColor = Color.Red;
                    break;
                case "18":
                    btn18.BackColor = Color.Red;
                    break;
                case "19":
                    btn19.BackColor = Color.Red;
                    break;
                case "20":
                    btn20.BackColor = Color.Red;
                    break;
                case "21":
                    btn21.BackColor = Color.Red;
                    break;
                case "22":
                    btn22.BackColor = Color.Red;
                    break;
                case "23":
                    btn23.BackColor = Color.Red;
                    break;
                case "24":
                    btn24.BackColor = Color.Red;
                    break;
                case "25":
                    btn25.BackColor = Color.Red;
                    break;
                case "26":
                    btn26.BackColor = Color.Red;
                    break;
                case "27":
                    btn27.BackColor = Color.Red;
                    break;
                case "28":
                    btn28.BackColor = Color.Red;
                    break;
                case "29":
                    btn29.BackColor = Color.Red;
                    break;
                case "30":
                    btn30.BackColor = Color.Red;
                    break;
                case "31":
                    btn31.BackColor = Color.Red;
                    break;
                case "32":
                    btn32.BackColor = Color.Red;
                    break;
                case "33":
                    btn33.BackColor = Color.Red;
                    break;
                case "34":
                    btn34.BackColor = Color.Red;
                    break;
                case "35":
                    btn35.BackColor = Color.Red;
                    break;
                case "36":
                    btn36.BackColor = Color.Red;
                    break;
                case "37":
                    btn37.BackColor = Color.Red;
                    break;
                case "38":
                    btn38.BackColor = Color.Red;
                    break;
                case "39":
                    btn39.BackColor = Color.Red;
                    break;
                case "40":
                    btn40.BackColor = Color.Red;
                    break;
                case "41":
                    btn41.BackColor = Color.Red;
                    break;
                case "42":
                    btn42.BackColor = Color.Red;
                    break;
                case "43":
                    btn43.BackColor = Color.Red;
                    break;
                case "44":
                    btn44.BackColor = Color.Red;
                    break;
            }
        }
    }
}