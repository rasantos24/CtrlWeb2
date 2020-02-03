<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerResultados.aspx.cs" Inherits="CtrlWebPPT.Modulos.VerResultados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consulta de precios</title>
</head>
<body>
    <form id="form1" runat="server" style="background-color:orange">
        <div>
            <asp:TextBox ID="TextBox1" Text="Ingrese el producto" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click1" />
        &nbsp;<asp:Button ID="Button2" runat="server" Text="Regresar" OnClick="Button2_Click" />
        </div>
        <div>
            <asp:GridView style="margin-left:auto; margin-right:auto" ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
