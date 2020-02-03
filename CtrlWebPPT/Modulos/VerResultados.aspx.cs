using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CtrlWebPPT.Modulos
{
    public partial class VerResultados : System.Web.UI.Page
    {
        public SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=Ctrl_Test;Persist Security Info=True;User ID=sa;Password=hola1234");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select Descripcion, Costo, Precio, Impuesto, PrecioConImpuesto from icProductos;", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        void consultaDato()
        {
            SqlDataAdapter da = new SqlDataAdapter("select Descripcion, Costo, Precio, Impuesto, PrecioConImpuesto from icProductos where Descripcion like '" + TextBox1.Text + "%'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            //Process.Start("https://localhost:44305/");
            Response.Redirect("https://localhost:44305/");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            consultaDato();
        }
    }
}