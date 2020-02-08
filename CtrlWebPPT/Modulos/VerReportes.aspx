<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerReportes.aspx.cs" Inherits="CtrlWebPPT.Modulos.VerReportes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Generación de reportes</title>
    <link rel="shortcut icon" href="logoCtrl.ico" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
</head>
<body>
    <form id="form1" runat="server" style="background-color:white">
        <header>

        </header>

        <div class="btn-group" role="group" aria-label="Basic example">
            <asp:Button ID="Button6" runat="server" Text="Generar Reportes" CssClass="btn btn-primary" />
            <asp:Button ID="Button1" runat="server" Text="Productos" OnClick="Button1_Click" CssClass="btn btn-info" />
            <asp:Button ID="Button2" runat="server" Text="Facturas" OnClick="Button2_Click" CssClass="btn btn-info" />
            <asp:Button ID="Button3" runat="server" Text="Ordenes" OnClick="Button3_Click" CssClass="btn btn-info" />
            <asp:Button ID="Button4" runat="server" Text="Almacenes" OnClick="Button4_Click" CssClass="btn btn-info" />
            <asp:Button ID="Button7" runat="server" Text="Imprimir" OnClientClick="javascript:window.print();" CssClass="btn btn-dark" />
            <asp:Button ID="Button8" runat="server" Text="Estadísticas" OnClick="Button8_Click" CssClass="btn btn-danger" />
            <asp:Button ID="Button5" runat="server" Text="Regresar" OnClick="Button5_Click1" CssClass="btn btn-warning" />
        </div>
        <div>
            <asp:GridView style="margin-left:auto; margin-right:auto" ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" BorderStyle="None" Width="1496px">
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" ForeColor="White" Font-Bold="True" />
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
