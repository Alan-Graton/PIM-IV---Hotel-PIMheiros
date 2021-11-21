<%@ Page Title="Reservas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Sistema_Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Label ID="Label_VagasHotel" runat="server" Font-Size="X-Large" Font-Bold="True"></asp:Label> </br>
        <asp:Label ID="Label_ErroReserva" runat="server" ForeColor="Red" Font-Size="X-Large" Font-Bold="True" Visible="False">Preencha os campos Corretamente</asp:Label> </br>
        <asp:Label ID="Label_SucessoReserva" runat="server" ForeColor="#00CC00" Font-Size="X-Large" Font-Bold="True" Visible="False"></asp:Label>
        <h1>Faça a sua Reserva Hoje!</h1>
        <p class="lead">Entre com os seus Dados Pessoais e os dados necessários para a Reserva</p>

        <%-- REALIZAR A RESERVA DO HÓSPEDE --%>
            <div class="div_ReservaHospede">

                <div class="div_DadosPessoais">
                    <asp:TextBox ID="Text_NomeHospede" runat="server" placeholder="Nome" BorderStyle="None" Font-Names="Franklin Gothic Book" Font-Size="Large" Height="36px" Width="157px" ></asp:TextBox>
                    <asp:TextBox ID="Text_CPF_Hospede" runat="server" MaxLength="11" placeholder="CPF" BorderStyle="None" Font-Names="Franklin Gothic Book" Font-Size="Large" Height="36px" Width="157px" ></asp:TextBox>
                    <asp:TextBox ID="Text_EmailHospede" runat="server" placeholder="E-mail" TextMode="Email" BorderStyle="None" Font-Names="Franklin Gothic Book" Font-Size="Large" Height="36px" Width="157px" ></asp:TextBox> </br>
                    <asp:TextBox ID="Text_CelularHospede" runat="server" MaxLength="11" placeholder="Celular" BorderStyle="None" Font-Names="Franklin Gothic Book" Font-Size="Large" Height="36px" Width="157px" ></asp:TextBox>
                    <asp:TextBox ID="Text_Num_CartaoHospede" runat="server" MaxLength="16" placeholder="Num. Cartão" BorderStyle="None" Font-Names="Franklin Gothic Book" Font-Size="Large" Height="36px" Width="157px" ></asp:TextBox> </br>
                </div>
                <%-- Dados Pessoais --%>

                <%-- Dados da Reserva --%>
                <div class="div_DadosReserva">
                    <%-- CHECK-IN --%>
                    <h3>Check-In</h3>
                    <asp:Calendar ID="Calendar_CheckIn" runat="server" BackColor="White" BorderColor="Black" BorderStyle="None" DayNameFormat="Shortest" Font-Bold="False" Font-Italic="False" Font-Names="Franklin Gothic Book" Font-Size="Large" ForeColor="Black" Height="220px" NextPrevFormat="ShortMonth" ShowGridLines="True" ToolTip="Check-In" Width="400px" >
                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <DayStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="14%" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="White" />
                        <OtherMonthDayStyle ForeColor="#999999" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
                        <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
                        <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <TodayDayStyle BackColor="#CCCC99" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <WeekendDayStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:Calendar>

                    <%-- CHECKOUT --%>
                    <h3>CheckOut</h3>
                    <asp:Calendar ID="Calendar_CheckOut" runat="server" BackColor="White" BorderColor="Black" BorderStyle="None" DayNameFormat="Shortest" Font-Bold="False" Font-Italic="False" Font-Names="Franklin Gothic Book" Font-Size="Large" ForeColor="Black" Height="220px" NextPrevFormat="ShortMonth" ShowGridLines="True" ToolTip="CheckOut" Width="400px" >
                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <DayStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="14%" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="White" />
                        <OtherMonthDayStyle ForeColor="#999999" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
                        <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
                        <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <TodayDayStyle BackColor="#CCCC99" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <WeekendDayStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:Calendar>

                    <%-- QUARTOS --%>
                    <h3>Quartos</h3>
                    <asp:TextBox ID="Text_Num_Quarto" runat="server" placeholder="Num. Quarto" TextMode="Number" BorderStyle="None" Font-Names="Franklin Gothic Book" Font-Size="Large" Height="36px" Width="157px" ></asp:TextBox> </br> </br>
                    <asp:DropDownList ID="List_CategoriaQuartos" runat="server" Width="157px" Font-Names="Franklin Gothic Book" Font-Size="Large" Height="36px">
                         <asp:ListItem Value="Standard">Standard</asp:ListItem>
                         <asp:ListItem Value="Master">Master</asp:ListItem>
                         <asp:ListItem Value="Deluxe">Deluxe</asp:ListItem>
                    </asp:DropDownList> </br>

                    <asp:Label ID="Label_Pagamento" runat="server" Font-Size="X-Large" Font-Bold="True" ForeColor="#333333">Total a Pagar: R$ </asp:Label>
                    <asp:Label ID="Label_PagamentoTotal" runat="server" Font-Size="X-Large" Font-Bold="True" ForeColor="#333333"></asp:Label> </br> </br>
                </div>

                <asp:Button ID="Btn_SalvarReserva" runat="server" class="btn btn-primary btn-lg" Text="Salvar Reserva" OnClick="Btn_SalvarReserva_Click" BackColor="#00CC00" BorderColor="#00CC00" />

                <asp:CheckBox ID="CKBX_StatusReserva" runat="server" Text="Reserva Ativa" Checked="True" Font-Size="X-Large" ForeColor="#0066FF"/> </br>
            </div>
        <hr/>

        <%-- REALIZAR A CONSULTA DE RESERVA --%>
            <div class="div_Consulta">
                <h3>Entre com o seu CPF para Consultar e/ou Alterar a sua Reserva</h3>
                <asp:Label ID="Label_AvisoConsulta" runat="server" Font-Bold="True" Font-Size="X-Large" Visible="False"></asp:Label> </br>
                <asp:TextBox ID="Text_ConsultarReserva" placeholder="CPF" runat="server"  MaxLength="11" Height="36px" Width="157px" BorderStyle="None" Font-Names="Franklin Gothic Book" Font-Size="Large" ></asp:TextBox> </br> </br>
                <asp:Button ID="Btn_ConsultarReserva" runat="server" class="btn btn-primary btn-lg" Text="Consultar" OnClick="Btn_ConsultarReserva_Click" />
                <span>
                    <asp:Button ID="Btn_SalvarAlteracoes" runat="server" class="btn btn-primary btn-lg" Text="Salvar Alterações" BackColor="#FF3300" BorderColor="#FF3300" OnClick="Btn_SalvarAlteracoes_Click" Visible="False" />
                </span>
            </div>
    </div>
</asp:Content>