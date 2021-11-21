<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebHotel.aspx.cs" Inherits="Reserva_Web.WebHotel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Hotel PIMheiros</title>
</head>
    <style>
body{
	margin:0;
	box-sizing: border-box;
	background: #8a8780;
}

/*.caixa1 {
    position: absolute;
    width: 30%;
    height: 50%;
    left: 25%;
    top: 20%;
}

.caixa2{
	position: absolute;
	width: 30%;
	height: 50%;
	left: 50%;
	top: 20%;
}

label{
	display: block;
}

label{
	position: relative;
}
 
input{
	width: 50%;
	margin: 2px 5%;
}*/

</style>
<body>
    <%--<form id="Form_Consulta" runat="server">
        <label>Pemba de Site miserável</label>
    </form>--%>
    <header runat="server">
        <label>Essa pemba ta funfando?</label>
        <div runat="server">
            <asp:Button ID="Button1"  runat="server" Text="Button" />
            <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
        </div>
    </header>
    <form id="Form_ReservaHospede" runat="server" lang="pt-br">
        <%--<div runat="server">--%>
            <h1>Faça a sua Reserva Hoje</h1>
            <%--<asp:TextBox ID="Pesquisar_MinhaReserva" runat="server" MaxLength="11" placeholder="CPF"></asp:TextBox>
            <asp:Button ID="Btn_ConsultarReserva" runat="server" Text="Consultar Minha Reserva" OnClick="Button1_Click" />--%>
        <%--</div>--%>
      <%--<hr />--%>
        <div>
            <h3>Dados Pessoais</h3>
            <%-- Dados Pessoais do Hóspede --%>
            <asp:TextBox ID="Text_NomeHospede" runat="server" placeholder="Nome" required="required"></asp:TextBox> </br>
            <asp:TextBox ID="Text_CPF_Hospede" runat="server" MaxLength="11" placeholder="CPF" required="required"></asp:TextBox> </br>
            <asp:TextBox ID="Text_CelularHospede" runat="server" MaxLength="11" placeholder="Celular" required="required"></asp:TextBox> </br>
            <asp:TextBox ID="Text_EmailHospede" runat="server" MaxLength="50" placeholder="E-mail" TextMode="Email" required="required"></asp:TextBox> </br>
            <asp:TextBox ID="Text_NumCartao" runat="server" MaxLength="16" placeholder="Num.Cartão" required="required"></asp:TextBox> </br>
        
            <hr />
            <h3>Dados da Reserva</h3>
            <%-- Dados da Reserva do Hóspede --%>
            <asp:RadioButtonList ID="RadioList_CategoriaQuarto" runat="server">
                <asp:ListItem>Standard</asp:ListItem>
                <asp:ListItem>Master</asp:ListItem>
                <asp:ListItem>Deluxe</asp:ListItem>
            </asp:RadioButtonList>
            </br>
            <asp:TextBox ID="Text_NumQuarto" runat="server" MaxLength="2" palceholder="Num. Quarto" TextMode="Number" required="required"></asp:TextBox>
            <asp:RangeValidator ID="Range_Valida_NumQuarto" runat="server" ControlToValidate="Text_NumQuarto" MinimumValue="1"
               MaximumValue="75" ErrorMessage="Quartos vão de 1-75" Type="Integer"></asp:RangeValidator> </br>
            <asp:TextBox ID="Text_CheckIn" runat="server" TextMode="Date" required="required"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Check-In"></asp:Label> 
            </br>
            <asp:TextBox ID="Text_CheckOut" runat="server" TextMode="Date" required="required"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="CheckOut"></asp:Label> 
            </br>

            <%-- Botões "Submit" & "Reset" --%>
            <asp:Button ID="Btn_SalvarReserva" runat="server" Text="Salvar Reserva" OnClick="Btn_SalvarReserva_Click" />
            <asp:CheckBox ID="CKBX_StatusReserva" runat="server" Text="Cancelar Reserva" />
            <asp:Button ID="Btn_Cancelar_LimparCampos" runat="server" Text="Limpar Campos" OnClick="Btn_Cancelar_LimparCampos_Click" />
        </div>
    </form>
</body>
</html>
