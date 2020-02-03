<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerInventarios.aspx.cs" Inherits="CtrlWebPPT.Modulos.VerInventarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Generación de Inventarios</title>
</head>
<body>
    <form id="form1" runat="server" style="background-color:orange">
        <div> 
            <asp:TextBox ID="TextBox1" Text="Buscar en el Inventario" runat="server"></asp:TextBox><asp:Button runat="server" Text="Ver" OnClick="Unnamed1_Click" />
        &nbsp;<asp:Button runat="server" Text="Regresar" OnClick="Unnamed2_Click" />
            <asp:GridView style="margin-left:auto; margin-right:auto" ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
