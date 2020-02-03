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
    public partial class VerReportes : System.Web.UI.Page
    {
        public SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=Ctrl_Test;Persist Security Info=True;User ID=sa;Password=hola1234");
        protected void Page_Load(object sender, EventArgs e)
        {
            //productos
            SqlDataAdapter pr = new SqlDataAdapter("select IdProducto, IdAlmacen, Cantidad from icProductosInventario;", cn);
            DataTable dt = new DataTable();
            pr.Fill(dt);
            this.GridView1.DataSource = dt;
            GridView1.DataBind();

            //facturas
            SqlDataAdapter fa = new SqlDataAdapter("select NuId, NoFactura, IdDepto, Descripcion, Cantidad, Precio, Descuento, Impuesto, Total, PrecioConImpuesto from arFacturasDetalle", cn);
            DataTable fadt = new DataTable();
            fa.Fill(fadt);
            this.GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        void generarProductos()
        {
            SqlDataAdapter da = new SqlDataAdapter("select IdProducto, IdAlmacen, Cantidad from icProductosInventario", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        void generarAlmacenes()
        {
            SqlDataAdapter da = new SqlDataAdapter("select IdAlmacen, Descripcion, Telefono, IdCuenta, ControlaLote, Facturar from icAlmacenes", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        void generarFacturas()
        {
            SqlDataAdapter da = new SqlDataAdapter("select NuId, NoFactura, IdDepto, Descripcion, Cantidad, Precio, Descuento, Impuesto, Total, PrecioConImpuesto from arFacturasDetalle", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        void generarOrdenes()
        {
            SqlDataAdapter da = new SqlDataAdapter("select NuId, NoOrden, IdCodigo, Descripcion, Cantidad, Precio, SubTotal, Descuento, Impuesto, Total from posOrdenesDetalle", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            generarProductos();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            generarFacturas();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            generarOrdenes();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            generarAlmacenes();
        }

        protected void Button5_Click1(object sender, EventArgs e)
        {
            //Process.Start("https://localhost:44305/");
            Response.Redirect("https://localhost:44305/");
        }
    }
}