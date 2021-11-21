using Classes;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Reserva_Web
{
    public partial class WebHotel : System.Web.UI.Page
    {
        string statusHospede = "";
        string statusReserva = "";
        string categoriaQuarto = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Salvar Reserva
        protected void Btn_SalvarReserva_Click(object sender, EventArgs e)
        {
            // Selecionando Categoria de Quartos
            switch (RadioList_CategoriaQuarto.SelectedIndex.ToString())
            {
                case "Standard":
                    categoriaQuarto = "Standard";
                    break;
                case "Master":
                    categoriaQuarto = "Master";
                    break;
                case "Deluxe":
                    categoriaQuarto = "Deluxe";
                    break;
            }

            // Selecionando Status da Reserva
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

            /* VALIDAÇÃO DE CAMPOS NUMÉRICOS */
            if ( // Verificando tamanho do Text
                (Text_CPF_Hospede.Text.Length == Text_CPF_Hospede.MaxLength && Text_CelularHospede.Text.Length == Text_CelularHospede.MaxLength &&
                Text_NumCartao.Text.Length == Text_NumCartao.MaxLength && Text_NumQuarto.Text.Length <= Text_NumQuarto.MaxLength) &&
                // Verificando se dados inseridos são números
                (Text_CPF_Hospede.Text.All(char.IsDigit) && Text_CelularHospede.Text.All(char.IsDigit) && Text_NumCartao.Text.All(char.IsDigit) &&
                Text_NumQuarto.Text.All(char.IsDigit)))
            {
                Hospedes hospedes = new Hospedes();
                // Dados Pessoais
                hospedes.Nome = Text_NomeHospede.Text;
                hospedes.CPF = Text_CPF_Hospede.Text;
                hospedes.Celular = Text_CelularHospede.Text;
                hospedes.Email = Text_EmailHospede.Text;

                // Dados da Reserva
                hospedes.Categoria_Quarto = categoriaQuarto;
                hospedes.Numero_Quarto = Text_NumQuarto.Text;
                hospedes.CheckIn = DateTime.Parse(Text_CheckIn.Text);
                hospedes.CheckOut = DateTime.Parse(Text_CheckOut.Text);
                hospedes.Status = statusHospede;
                hospedes.Status_Reserva = statusReserva;
                HospedesDAL hospedesDAL = new HospedesDAL();

                hospedesDAL.AddCadastroReservaHospede(hospedes);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Preencha os Campos Corretamente')", true);
            }
        }

        // Cancelar/Limpar Campos
        protected void Btn_Cancelar_LimparCampos_Click(object sender, EventArgs e)
        {
            var CamposText = new[]
            {
                Text_CelularHospede, Text_CPF_Hospede, Text_EmailHospede, Text_NomeHospede,
                Text_CheckIn, Text_CheckOut, Text_NumCartao, Text_NumQuarto
            };
            foreach(var campo in CamposText)
            {
                campo.Text = "";
            }
            if (CKBX_StatusReserva.Checked) CKBX_StatusReserva.Checked = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Realizando Consulta de Reserva')", true);
        }
    }
}