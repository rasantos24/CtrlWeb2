<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerGraficos.aspx.cs" Inherits="CtrlWebPPT.Modulos.VerGraficos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gráficos de los Reportes</title>
    <link rel="shortcut icon" href="logoCtrl.ico" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Chart ID="Chart1" runat="server" Height="500px" Width="575px">
            <Series>
                <asp:Series ChartType="StackedColumn" Name="Series1">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
        </div>
        
        <div class="btn-group" role="group" aria-label="Basic example">
            <asp:Button ID="Button2" runat="server" Text="Imprimir" OnClientClick="javascript:window.print();" CssClass="btn btn-dark" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Regresar" CssClass="btn btn-warning" />
        </div>
    </form>
    
    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</body>
</html>
