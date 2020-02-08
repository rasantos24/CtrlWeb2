<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerResultados.aspx.cs" Inherits="CtrlWebPPT.Modulos.VerResultados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consulta de precios</title>
    <link rel="shortcut icon" href="logoCtrl.ico" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
</head>
<body>
    <form id="form1" runat="server" style="background-color:white">
        <div class="btn-group" role="group" aria-label="Basic example">
            <asp:TextBox ID="TextBox1" Text="" runat="server" CssClass="form-control" placeholder="Ingrese el producto"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click1" CssClass="btn btn-info"/>
            <asp:Button ID="Button2" runat="server" Text="Regresar" OnClick="Button2_Click" CssClass="btn btn-warning" />
        </div>
        <div class="table-responsive-xl">
            <asp:GridView style="margin-left:auto; margin-right:auto" ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Width="1511px">
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="Black" HorizontalAlign="Right" BackColor="White" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
        </div>
    </form>

    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</body>
</html>
