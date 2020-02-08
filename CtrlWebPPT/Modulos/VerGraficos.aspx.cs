using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace CtrlWebPPT.Modulos
{
    public partial class VerGraficos : System.Web.UI.Page
    {
        string[] produ = new string[4];
        int[] util = new int[4];
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=Ctrl_Test;Persist Security Info=True;User ID=sa;Password=hola1234");

        protected void Page_Load(object sender, EventArgs e)
        {
            cn.Open();

            SqlCommand cmd = new SqlCommand("SELECT Productos, Cantidad from ProductosCantidad;", cn);

            SqlDataReader leer = cmd.ExecuteReader();

            int cont = 0;

            while(leer.Read())
            {
                produ[cont] = leer.GetString(0);
                util[cont] = leer.GetInt32(1);
                cont++;
            }

            leer.Close();
            cn.Close();
            Chart1.Series["Series1"].Points.DataBindXY(produ, util);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44305/Modulos/VerReportes.aspx");
        }
    }
}