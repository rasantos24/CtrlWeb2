using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace CtrlWebPPT.Modulos
{
    public partial class VerInventarios : System.Web.UI.Page
    {
        public SqlConnection inv = new SqlConnection("Data Source=(local);Initial Catalog=Ctrl_Test;Persist Security Info=True;User ID=sa;Password=hola1234");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dain = new SqlDataAdapter("select * from icInventarioFisico", inv);
            DataTable dtin = new DataTable();
            dain.Fill(dtin);
            this.GridView1.DataSource = dtin;
            GridView1.DataBind();
        }

        void consultaInventario()
        {
            SqlDataAdapter dainv = new SqlDataAdapter("select * from icInventarioFisico where Referencia like '" + TextBox1.Text + "%'", inv);
            DataTable dtinv = new DataTable();
            dainv.Fill(dtinv);
            this.GridView1.DataSource = dtinv;
            GridView1.DataBind();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            consultaInventario();
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            //Process.Start("https://localhost:44305/");
            Response.Redirect("https://localhost:44305/");
        }
    }
}