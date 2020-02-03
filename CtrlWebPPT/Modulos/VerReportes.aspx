<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerReportes.aspx.cs" Inherits="CtrlWebPPT.Modulos.VerReportes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Generación de reportes</title>
</head>
<body>
    <form id="form1" runat="server" style="background-color:orange">
        <div>
            Generar reportes para: 
            <asp:Button ID="Button1" runat="server" Text="Productos" OnClick="Button1_Click" />
            |
            <asp:Button ID="Button2" runat="server" Text="Facturas" OnClick="Button2_Click" />
            |
            <asp:Button ID="Button3" runat="server" Text="Ordenes" OnClick="Button3_Click" />
            |
            <asp:Button ID="Button4" runat="server" Text="Almacenes" OnClick="Button4_Click" />
            |
&nbsp;<asp:Button ID="Button5" runat="server" Text="Regresar" OnClick="Button5_Click1" />
        </div>
        <div>
            <asp:GridView style="margin-left:auto; margin-right:auto" ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
