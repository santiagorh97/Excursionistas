<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Presentacion.aspx.cs" Inherits="Interfaz_WEB.Presentacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Excursionistas</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container p-3 my-3 border">
            <div>
                <h2>SISTEMA IA PARA EXCURSIONES</h2>
            </div>
            <br />
            <div>
                <h3>Ingrese el peso máximo y el mínimo de calorías necesarias para escalar</h3>
            </div>
            <br />

            <div>
                <label>Peso máximo: </label>
                <asp:TextBox ID="TbPeso" runat="server"></asp:TextBox>
                <label>&nbsp;&nbsp;&nbsp;&nbsp; Calorías mínima: </label>
                <asp:TextBox ID="TbCalorias"  runat="server"></asp:TextBox>&nbsp;&nbsp;<asp:Button ID="BtnVerificar" runat="server" Text="Verificar" class="btn btn-primary" OnClick="BtnVerificar_Click" />
            </div>
            <br />
            <h4>Los elementos viables serian: </h4>
            <div>
                <asp:TextBox ID="TbRespuesta" runat="server" Height="68px" TextMode="MultiLine" Width="605px"></asp:TextBox>
            </div>

        </div>
    </form>
</body>
</html>
