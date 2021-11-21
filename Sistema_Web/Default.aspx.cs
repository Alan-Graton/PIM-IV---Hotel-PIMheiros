using Classes;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Web
{
    public partial class _Default : Page
    {
        // Verificar Capacidade do Hotel
        string CapacidadeHotel = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            // Verificando Quantidade de Vagas Disponíveis no Hotel
            FuncionariosDAL funcionariosDAL = new FuncionariosDAL();
            Label_VagasHotel.Text = funcionariosDAL.CapacidadeTotalHotel(out string capacidadeHotel);
            CapacidadeHotel = capacidadeHotel;
            _= (CapacidadeHotel == "Vagas") ? Label_VagasHotel.ForeColor = System.Drawing.Color.Green : Label_VagasHotel.ForeColor = System.Drawing.Color.Red;
        }

        /* REALIZAR RESERVA */
        protected void Btn_SalvarReserva_Click(object sender, EventArgs e)
        {
            // Status relacionandos ao Hóspede
            string statusHospede = "";
            string statusReserva = "";

            // Preço das Categorias de Quartos
            int precoCategoria = 0;
            int Diaria = int.Parse(Calendar_CheckOut.SelectedDate.Date.Subtract(Calendar_CheckIn.SelectedDate.Date).TotalDays.ToString());

            // Calculando Diária
            switch (List_CategoriaQuartos.Text)
            {
                case "Standard":
                    precoCategoria = 150;
                    if (Diaria == 0)
                    {
                        precoCategoria -= 15;
                    }
                    else
                    {
                        precoCategoria *= Diaria;
                    }
                    Label_PagamentoTotal.Text = precoCategoria.ToString();
                    break;
                case "Master":
                    precoCategoria = 250;
                    if (Diaria == 0)
                    {
                        precoCategoria -= 25;
                    }
                    else
                    {
                        precoCategoria *= Diaria;
                    }
                    Label_PagamentoTotal.Text = precoCategoria.ToString();
                    break;
                case "Deluxe":
                    precoCategoria = 350;
                    if (Diaria == 0)
                    {
                        precoCategoria -= 35;
                    }
                    else
                    {
                        precoCategoria *= Diaria;
                    }
                    Label_PagamentoTotal.Text = precoCategoria.ToString();
                    break;
            }

            // Verificando o Status da Reserva
            if (CKBX_StatusReserva.Checked)
            {
                statusReserva = "Ativada";
                statusHospede = "Ativo";
            }
            else
            {
                statusReserva = "Desativada";
                statusHospede = "Inativo";
            }

            // Instânciando Objetos
            Hospedes hospedes = new Hospedes
            (
                Text_NomeHospede.Text, Text_CPF_Hospede.Text, Text_EmailHospede.Text, Text_CelularHospede.Text,
                statusHospede, statusReserva, Text_Num_CartaoHospede.Text, DateTime.Parse(Calendar_CheckIn.SelectedDate.ToString()), DateTime.Parse(Calendar_CheckOut.SelectedDate.ToString()),
                Text_Num_Quarto.Text, List_CategoriaQuartos.Text, precoCategoria
            );
            HospedesDAL hospedesDAL = new HospedesDAL();

            var CamposText = new[]
            {
                Text_NomeHospede, Text_CPF_Hospede, Text_CelularHospede, Text_EmailHospede,
                Text_Num_CartaoHospede, Text_Num_Quarto
            };

            // Validação de Campos
            foreach(var campo in CamposText)
            {
                // Campos Inválidos
                if (campo.Text.Equals("") || (Text_CelularHospede.Text.Length < 11 || !Text_CelularHospede.Text.All(char.IsDigit)) ||
                    (Text_CPF_Hospede.Text.Length < 11 || !Text_CPF_Hospede.Text.All(char.IsDigit)) || 
                    (Text_Num_CartaoHospede.Text.Length < 16 || !Text_Num_CartaoHospede.Text.All(char.IsDigit)))
                {
                    Label_ErroReserva.Visible = true;
                    break;
                }

                // Campos Válidos
                else if(campo.Text != "" && (Text_CelularHospede.Text.Length == 11 && Text_CelularHospede.Text.All(char.IsDigit)) &&
                    (Text_CPF_Hospede.Text.Length == 11 && Text_CPF_Hospede.Text.All(char.IsDigit)) &&
                    (Text_Num_CartaoHospede.Text.Length == 16 && Text_Num_CartaoHospede.Text.All(char.IsDigit)))
                {
                    /* VERIFICANDO SE HÁ VAGAS NO HOTEL */

                    // Há Vagas
                    if(CapacidadeHotel == "Vagas")
                    {
                        Label_ErroReserva.Visible = false;
                        Label_SucessoReserva.Visible = true;

                        //// Atualizando o Banner de Vagas
                        //Label_VagasHotel.ForeColor = System.Drawing.Color.Green;
                        //Label_VagasHotel.Text = "Ainda há Vagas em nosso Hotel '3'";

                        // Executar Método
                        Label_SucessoReserva.Text = hospedesDAL.AddCadastroReservaHospede(hospedes);

                        // 'Resetando' Campos
                        foreach(var campos in CamposText)
                        {
                            campos.Text = "";
                        }
                        CKBX_StatusReserva.Checked = true;
                        break;
                    }

                    // Não Há Vagas
                    else if(CapacidadeHotel == "Lotado")
                    {
                        Label_VagasHotel.ForeColor = System.Drawing.Color.Red;
                        Label_VagasHotel.Text = "Sinto muito, não temos mais Vagas ;-;";
                        break;
                    }
                }
            }
        }

        /* CONSULTAR RESERVA */
        protected void Btn_ConsultarReserva_Click(object sender, EventArgs e)
        {
            Hospedes hospedes = new Hospedes();
            HospedesDAL hospedesDAL = new HospedesDAL();

            Label_PagamentoTotal.Text = "";

            // Validando Campo de Busca
            if(Text_ConsultarReserva.Text.Length == Text_ConsultarReserva.MaxLength && Text_ConsultarReserva.Text.All(char.IsDigit))
            {
                hospedes = hospedesDAL.ConsultarHospedesReservas(Text_ConsultarReserva.Text, out string retorno);
                Label_AvisoConsulta.Text = retorno;
                Label_AvisoConsulta.ForeColor = System.Drawing.Color.Red;

                // Hóspede Localizado
                if(hospedes != null)
                {
                    Label_AvisoConsulta.Text = "Reserva Localizada com Sucesso! '3'";
                    // Dados Pessoais
                    Text_NomeHospede.Text = hospedes.Nome.ToString();
                    Text_CPF_Hospede.Text = hospedes.CPF.ToString();
                    Text_EmailHospede.Text = hospedes.Email.ToString();
                    Text_CelularHospede.Text = hospedes.Celular.ToString();
                    Text_Num_CartaoHospede.Text = hospedes.Numero_Cartao.ToString();
                    // Reserva
                    Calendar_CheckIn.SelectedDate = DateTime.Parse(hospedes.CheckIn.ToString());
                    Calendar_CheckOut.SelectedDate = DateTime.Parse(hospedes.CheckOut.ToString());
                    // Quartos e Pagamento
                    Text_Num_Quarto.Text = hospedes.Numero_Quarto.ToString();
                    List_CategoriaQuartos.Text = hospedes.Categoria_Quarto.ToString();
                    Label_PagamentoTotal.Text = hospedes.Preco_Categoria.ToString();
                    _ = (hospedes.Status_Reserva == "Ativada" || hospedes.Status == "Ativo") ? CKBX_StatusReserva.Checked = true : CKBX_StatusReserva.Checked = false;

                    Label_AvisoConsulta.Visible = true;
                    Label_AvisoConsulta.Text = "Hóspede Localizado com Sucesso";
                    Label_AvisoConsulta.ForeColor = System.Drawing.Color.Green;

                    Btn_SalvarAlteracoes.Visible = true;
                }
            }
            else
            {
                Label_AvisoConsulta.Visible = true;
                Label_AvisoConsulta.Text = "Informe um CPF Válido";
                Label_AvisoConsulta.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void Btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            // Status do Hóspede e de sua Reserva
            string statusHospede = "";
            string statusReserva = "";

            // Preço das Categorias de Quartos
            int precoCategoria = 0;
            int Diaria = int.Parse(Calendar_CheckOut.SelectedDate.Date.Subtract(Calendar_CheckIn.SelectedDate.Date).TotalDays.ToString());

            // Calculando Diária
            switch (List_CategoriaQuartos.Text)
            {
                case "Standard":
                    precoCategoria = 150;
                    if (Diaria == 0)
                    {
                        precoCategoria -= 15;
                    }
                    else
                    {
                        precoCategoria *= Diaria;
                    }
                    Label_PagamentoTotal.Text = precoCategoria.ToString();
                    break;
                case "Master":
                    precoCategoria = 250;
                    if (Diaria == 0)
                    {
                        precoCategoria -= 25;
                    }
                    else
                    {
                        precoCategoria *= Diaria;
                    }
                    Label_PagamentoTotal.Text = precoCategoria.ToString();
                    break;
                case "Deluxe":
                    precoCategoria = 350;
                    if (Diaria == 0)
                    {
                        precoCategoria -= 35;
                    }
                    else
                    {
                        precoCategoria *= Diaria;
                    }
                    Label_PagamentoTotal.Text = precoCategoria.ToString();
                    break;
            }

            // Verificando Status da Reserva
            if (CKBX_StatusReserva.Checked)
            {
                statusHospede = "Ativo";
                statusReserva = "Ativada";
            }
            else
            {
                statusHospede = "Inativo";
                statusReserva = "Desativada";
            }

            Hospedes hospedes = new Hospedes
            (
                Text_NomeHospede.Text, Text_CPF_Hospede.Text, Text_EmailHospede.Text, Text_CelularHospede.Text,
                statusHospede, statusReserva, Text_Num_CartaoHospede.Text, DateTime.Parse(Calendar_CheckIn.SelectedDate.ToString()), DateTime.Parse(Calendar_CheckOut.SelectedDate.ToString()),
                Text_Num_Quarto.Text, List_CategoriaQuartos.Text, int.Parse(Label_PagamentoTotal.Text.ToString())
            );
            HospedesDAL hospedesDAL = new HospedesDAL();

            var CamposText = new[]
            {
                Text_NomeHospede, Text_CPF_Hospede, Text_CelularHospede, Text_EmailHospede,
                Text_Num_CartaoHospede, Text_Num_Quarto
            };

            // Validação de Campos
            foreach(var campo in CamposText)
            {
                // Campos Inválidos
                if (campo.Text.Equals("") || Text_CelularHospede.Text.Length < Text_CelularHospede.MaxLength || !Text_CelularHospede.Text.All(char.IsDigit) ||
                    Text_CPF_Hospede.Text.Length < Text_CPF_Hospede.MaxLength || !Text_CPF_Hospede.Text.All(char.IsDigit) ||
                    Text_Num_CartaoHospede.Text.Length < Text_Num_CartaoHospede.MaxLength || !Text_Num_CartaoHospede.Text.All(char.IsDigit))
                {
                    Label_ErroReserva.Visible = true;
                    break;
                }

                // Campos Válidos
                else if(campo.Text != "" && Text_CelularHospede.Text.Length == Text_CelularHospede.MaxLength && Text_CelularHospede.Text.All(char.IsDigit) &&
                    Text_CPF_Hospede.Text.Length == Text_CPF_Hospede.MaxLength && Text_CPF_Hospede.Text.All(char.IsDigit) &&
                    Text_Num_CartaoHospede.Text.Length == Text_Num_CartaoHospede.MaxLength && Text_Num_CartaoHospede.Text.All(char.IsDigit))
                {
                    Label_ErroReserva.Visible = false;

                    // Caso Hóspede queira Ativar sua Reserva quando não haja vagas no Hotel
                    if(CapacidadeHotel == "Lotado" && !CKBX_StatusReserva.Checked)
                    {
                        Label_AvisoConsulta.Visible = true;
                        Label_AvisoConsulta.Text = "Sinto muito, mas não temos quartos vagos ;-;";
                        break;
                    }

                    // Há vagas no Hotel
                    else if(CapacidadeHotel == "Vagas")
                    {
                        Label_AvisoConsulta.Visible = true;
                        Label_AvisoConsulta.Text = "";

                        // Para retornar a Mensagem de Sucesso
                        Label_AvisoConsulta.Text = hospedesDAL.AlterarFichaHospede(hospedes, Text_ConsultarReserva.Text);

                        /* 'RESETANDO' CAMPOS */
                        CKBX_StatusReserva.Checked = true;
                        Text_ConsultarReserva.Text = "";

                        // Limpando Campos de Texto
                        foreach(var campos in CamposText)
                        {
                            campos.Text = "";
                        }
                        Label_ErroReserva.Visible = false;
                        Label_PagamentoTotal.Text = "";

                        Btn_SalvarAlteracoes.Visible = false;
                    }
                }
            }
        }
    }
}