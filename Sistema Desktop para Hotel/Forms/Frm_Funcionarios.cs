using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using DAL;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Sistema_Desktop_para_Hotel.Forms
{
    public partial class Frm_Funcionarios : MaterialForm
    {
        string DescricaoLogin = "";
        int CliqueSenhaAtual;
        int CliqueNovaSenha;
        string CapacidadeHotel = "";
        public Frm_Funcionarios()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }
        private void Frm_Funcionarios_Load(object sender, EventArgs e)
        {
            FuncionariosDAL funcionariosDAL = new FuncionariosDAL();
            HospedesDAL hospedesDAL = new HospedesDAL();

            // Verificando Quantidade de Vagas Disponíveis no Hotel
            MaterialMessageBox.Show(funcionariosDAL.CapacidadeTotalHotel(out string capacidadeHotel));
            CapacidadeHotel = capacidadeHotel;

            // Listagem de Reservas Ativas
            DataTable table_Hospedes = new DataTable();
            List<Hospedes> list = new List<Hospedes>();
            list = hospedesDAL.ListarReservasAtivas();
            Grid_ListagemHospedes.DataSource = list;
        }
        private void Frm_Funcionarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Limpar Campos
        private void Btn_LimparCampos_Click(object sender, EventArgs e)
        {
            var CamposFichaHospede = new[]
            {
                Txt_NomeHospede, Txt_CPF_Hospede, Txt_Pesquisar_CPFHospede, Txt_EmailHospede, 
                Txt_CartaoHospede, Txt_CelularHospede, Txt_NumQuarto_Hospede
            };
            foreach(var campo in CamposFichaHospede)
            {
                campo.Clear();
            }
            Btn_Editar_FichaHospede.Enabled = false;
            CKBX_HospedesAtivo.Checked = false;
            CKBX_ReservaAtivada.Checked = false;
            Lbl_Pagamento_Total.Text = "";
            Btn_Salvar_CadastroReserva.Enabled = true;
        }

        /*PÁGINA 'Hóspedes'*/
        private void Btn_Salvar_CadastroReserva_Click(object sender, EventArgs e)
        {
            string statusHospede = "";
            string statusReservaHospede = "";
            // Preço das Categorias de Quartos
            int precoCategoria = 0;
            int Diaria = int.Parse(Date_CheckOut_Hospede.Value.Date.Subtract(Date_CheckIn_Hospede.Value.Date).TotalDays.ToString());

            // Calculando Diária e Desconto (caso houver)
            switch (Combobx_CategoriaQuarto_Hospede.Text)
            {
                case "Standard":
                    precoCategoria = 150;
                    // Calculando pequeno desconto para Hóspede que Entrar e Sair no mesmo dia
                    if (Diaria == 0)
                    {
                        precoCategoria -= 15;
                    }
                    else
                    {
                        precoCategoria *= Diaria;
                    }
                    Lbl_Pagamento_Total.Text = precoCategoria.ToString();
                    break;
                case "Master":
                    precoCategoria = 250;
                    // Calculando pequeno desconto para Hóspede que Entrar e Sair no mesmo dia
                    if (Diaria == 0)
                    {
                        precoCategoria -= 25;
                    }
                    else
                    {
                        precoCategoria *= Diaria;
                    }
                    Lbl_Pagamento_Total.Text = precoCategoria.ToString();
                    break;
                case "Deluxe":
                    precoCategoria = 350;
                    // Calculando pequeno desconto para Hóspede que Entrar e Sair no mesmo dia
                    if (Diaria == 0)
                    {
                        precoCategoria -= 35;
                    }
                    else
                    {
                        precoCategoria *= Diaria;
                    }
                    Lbl_Pagamento_Total.Text = precoCategoria.ToString();
                    break;
            }
            _ = (CKBX_HospedesAtivo.Checked) ? statusHospede = "Ativo" : statusHospede = "Inativo";
            _ = (CKBX_ReservaAtivada.Checked) ? statusReservaHospede = "Ativada" : statusReservaHospede = "Desativada";

            Hospedes hospedes = new Hospedes
            (
                Txt_NomeHospede.Text, Txt_CPF_Hospede.Text, Txt_EmailHospede.Text, Txt_CelularHospede.Text,
                statusHospede, statusReservaHospede, Txt_CartaoHospede.Text, DateTime.Parse(Date_CheckIn_Hospede.Text), DateTime.Parse(Date_CheckOut_Hospede.Text),
                Txt_NumQuarto_Hospede.Text, Combobx_CategoriaQuarto_Hospede.Text, precoCategoria
            );
            HospedesDAL hospedesDAL = new HospedesDAL();

            var CamposTxt_FichaHospede = new[]
            {
                Txt_NomeHospede, Txt_CPF_Hospede, Txt_CelularHospede, Txt_EmailHospede,
                Txt_CartaoHospede, Txt_NumQuarto_Hospede
            };

            // Validação de Campos
            foreach (var campo in CamposTxt_FichaHospede)
            {
                // Validando campos
                if (campo.Text.Equals("") || Txt_CPF_Hospede.TextLength < 11 || Txt_CelularHospede.TextLength < 11
                    || !Txt_CPF_Hospede.Text.All(char.IsDigit) || !Txt_CelularHospede.Text.All(char.IsDigit))
                {
                    Lbl_ErroCadastro.Visible = true;
                }
                
                // Verificando Capacidade do Hotel
                if (CapacidadeHotel == "Lotado")
                {
                    MaterialMessageBox.Show("Hotel Atingiu Capacidade Máxima de Quartos Ocupados");
                    break;
                }

                // Campos preenchidos Corretamente e há vagas no Hotel
                else if (campo.Text != "" && campo.Text != null && Txt_CPF_Hospede.TextLength == 11 && Txt_CelularHospede.TextLength == 11
                    && Txt_CPF_Hospede.Text.All(char.IsDigit) && Txt_CelularHospede.Text.All(char.IsDigit) && CapacidadeHotel == "Vagas")
                {
                    Lbl_ErroCadastro.Visible = false;
                    // Chamar Método aqui dentro
                    MaterialMessageBox.Show(hospedesDAL.AddCadastroReservaHospede(hospedes));

                    // Listagem de Reservas Ativas
                    DataTable table = new DataTable();
                    List<Hospedes> list = new List<Hospedes>();
                    list = hospedesDAL.ListarReservasAtivas();
                    Grid_ListagemHospedes.DataSource = list;

                    // Limpando Campos
                    CKBX_HospedesAtivo.Checked = false; CKBX_ReservaAtivada.Checked = false;
                    foreach (var limpaCampos in CamposTxt_FichaHospede)
                    {
                        limpaCampos.Clear();
                    }
                    break;
                }
            }
        }
        private void Btn_Consultar_FichaHospede_Click(object sender, EventArgs e)
        {
            Hospedes hospedes = new Hospedes();
            HospedesDAL hospedesDAL = new HospedesDAL();

            /* VALIDANDO CAMPOS */
            if (Txt_Pesquisar_CPFHospede.Text.Equals(""))
            {
                Lbl_ErroCadastro.Visible = true;
                Lbl_ErroCadastro.Text = "Informe um CPF para a Consulta";
            }
            else if(Txt_Pesquisar_CPFHospede.TextLength < 11)
            {
                Lbl_ErroCadastro.Visible = true;
                Lbl_ErroCadastro.Text = "Informe um CPF Válido";
            }

            // Campos Válidos
            else if(Txt_Pesquisar_CPFHospede.Text != "" && Txt_Pesquisar_CPFHospede.TextLength == 11)
            {
                Lbl_ErroCadastro.Visible = false;
                Lbl_ErroCadastro.Text = "";

                // Executando Método
                hospedes = hospedesDAL.ConsultarHospedesReservas(Txt_Pesquisar_CPFHospede.Text, out string retorno);
                MaterialMessageBox.Show(retorno);

                if(hospedes != null)
                {
                    // Dados Pessoais
                    Txt_NomeHospede.Text = hospedes.Nome;
                    Txt_CPF_Hospede.Text = hospedes.CPF;
                    Txt_EmailHospede.Text = hospedes.Email;
                    Txt_CelularHospede.Text = hospedes.Celular;
                    Txt_CartaoHospede.Text = hospedes.Numero_Cartao;
                    // Reserva
                    Date_CheckIn_Hospede.Value = DateTime.Parse(hospedes.CheckIn.ToString());
                    Date_CheckOut_Hospede.Value = DateTime.Parse(hospedes.CheckOut.ToString());
                    // Quartos e Pagamento
                    Txt_NumQuarto_Hospede.Text = hospedes.Numero_Quarto;
                    Combobx_CategoriaQuarto_Hospede.Text = hospedes.Categoria_Quarto;
                    Lbl_Pagamento_Total.Text = hospedes.Preco_Categoria.ToString();
                    _ = (hospedes.Status == "Ativo") ? CKBX_HospedesAtivo.Checked = true : CKBX_HospedesAtivo.Checked = false;
                    _ = (hospedes.Status_Reserva == "Ativada") ? CKBX_ReservaAtivada.Checked = true : CKBX_ReservaAtivada.Checked = false;

                    Btn_Editar_FichaHospede.Enabled = true;
                    Btn_Salvar_CadastroReserva.Enabled = false;
                }
            }
        }
        private void Btn_Editar_FichaHospede_Click(object sender, EventArgs e)
        {
            // Verificando Status do Hóspede e de sua Reserva
            string statusHospede = "";
            string statusReservaHospede = "";
            _ = (CKBX_HospedesAtivo.Checked) ? statusHospede = "Ativo" : statusHospede = "Inativo";
            _ = (CKBX_ReservaAtivada.Checked) ? statusReservaHospede = "Ativada" : statusReservaHospede = "Desativada";

            // Preço das Categorias de Quartos
            int precoCategoria = 0;
            int Diaria = int.Parse(Date_CheckOut_Hospede.Value.Date.Subtract(Date_CheckIn_Hospede.Value.Date).TotalDays.ToString());

            // Calculando Diária e Desconto (caso houver)
            switch (Combobx_CategoriaQuarto_Hospede.Text)
            {
                case "Standard":
                    precoCategoria = 150;
                    // Calculando pequeno desconto para Hóspede que Entrar e Sair no mesmo dia
                    if (Diaria == 0)
                    {
                        precoCategoria -= 15;
                    }
                    else
                    {
                        precoCategoria *= Diaria;
                    }
                    Lbl_Pagamento_Total.Text = precoCategoria.ToString();
                    break;
                case "Master":
                    precoCategoria = 250;
                    // Calculando pequeno desconto para Hóspede que Entrar e Sair no mesmo dia
                    if (Diaria == 0)
                    {
                        precoCategoria -= 25;
                    }
                    else
                    {
                        precoCategoria *= Diaria;
                    }
                    Lbl_Pagamento_Total.Text = precoCategoria.ToString();
                    break;
                case "Deluxe":
                    precoCategoria = 350;
                    // Calculando pequeno desconto para Hóspede que Entrar e Sair no mesmo dia
                    if (Diaria == 0)
                    {
                        precoCategoria -= 35;
                    }
                    else
                    {
                        precoCategoria *= Diaria;
                    }
                    Lbl_Pagamento_Total.Text = precoCategoria.ToString();
                    break;
            }

            // Objetos
            Hospedes hospedes = new Hospedes
            (
                Txt_NomeHospede.Text, Txt_CPF_Hospede.Text, Txt_EmailHospede.Text, Txt_CelularHospede.Text,
                statusHospede, statusReservaHospede, Txt_CartaoHospede.Text,
                DateTime.Parse(Date_CheckIn_Hospede.Text), DateTime.Parse(Date_CheckOut_Hospede.Text),
                Txt_NumQuarto_Hospede.Text, Combobx_CategoriaQuarto_Hospede.Text, int.Parse(Lbl_Pagamento_Total.Text)
            );

            HospedesDAL hospedesDAL = new HospedesDAL();

            var CamposFichaHospede = new[]
            {
                Txt_NomeHospede, Txt_CPF_Hospede, Txt_Pesquisar_CPFHospede, Txt_EmailHospede,
                Txt_CartaoHospede, Txt_CelularHospede, Txt_NumQuarto_Hospede
            };

            /* VALINDANDO CAMPOS */
            foreach(var campo in CamposFichaHospede)
            {
                // Campos Incorretos
                if(campo.Text.Equals("") || (Txt_CPF_Hospede.TextLength < 11 || Txt_CelularHospede.TextLength < 11) ||
                    !Txt_CPF_Hospede.Text.All(char.IsDigit) || !Txt_CelularHospede.Text.All(char.IsDigit))
                {
                    Lbl_ErroCadastro.Visible = true;
                }

                // Campos Corretos
                else if (campo.Text != "" && (Txt_CPF_Hospede.TextLength == 11 && Txt_CelularHospede.TextLength == 11)
                    && (Txt_CPF_Hospede.Text.All(char.IsDigit) && Txt_CelularHospede.Text.All(char.IsDigit)))
                {
                    Lbl_ErroCadastro.Visible = false;

                    // Executando Método
                    MaterialMessageBox.Show(hospedesDAL.AlterarFichaHospede(hospedes, Txt_Pesquisar_CPFHospede.Text));

                    // Listagem de Reservas Ativas
                    DataTable table = new DataTable();
                    List<Hospedes> list = new List<Hospedes>();
                    list = hospedesDAL.ListarReservasAtivas();
                    Grid_ListagemHospedes.DataSource = list;

                    // Limpando Campos
                    CKBX_HospedesAtivo.Checked = false; CKBX_ReservaAtivada.Checked = false;
                    foreach (var limpaCampos in CamposFichaHospede)
                    {
                        limpaCampos.Clear();
                    }
                    Txt_Pesquisar_CPFHospede.Clear();
                    Lbl_Pagamento_Total.Text = "";
                    Btn_Editar_FichaHospede.Enabled = false;
                    Btn_Salvar_CadastroReserva.Enabled = true; ;
                    break;
                }
            }
        }

        /*PÁGINA 'Configurações'*/
        // Credenciais Atuais
        private void Btn_ValidarCrendencias_Atuais_Click(object sender, EventArgs e)
        {
            LoginHotel validarCredenciais = new LoginHotel(Txt_UsuarioAtual_Recepcao.Text, Txt_SenhaAtual_Recepcao.Text);
            LoginHotelDAL loginDAL = new LoginHotelDAL();

            // Entrada de Dados para validação
            loginDAL.ValidarLoginHotel(validarCredenciais, out string retornoDescricaoLogin);

            // Validação para alterar somente as credenciais do Funcionário
            if(retornoDescricaoLogin != "Funcionário")
            {
                Lbl_credenciaisErro.Visible = true;
            }
            // Disponibilizando campos para entrada de novas credenciais
            else
            {
                DescricaoLogin = retornoDescricaoLogin;
                Txt_NovoUsuario_Recepcao.Enabled = true; Txt_NovaSenha_Recepcao.Enabled = true;
                Btn_SalvarNovas_Credenciais.Enabled = true; Btn_CancelarSalvar_NovasCredenciais.Enabled = true;
                Btn_ViewNovaSenha.Enabled = true;
            }
        }
        private void Btn_Cancelar_Validacao_Click(object sender, EventArgs e)
        {
            Txt_UsuarioAtual_Recepcao.Clear(); Txt_SenhaAtual_Recepcao.Clear();
            Txt_NovoUsuario_Recepcao.Clear(); Txt_NovaSenha_Recepcao.Clear();

            Txt_NovoUsuario_Recepcao.Enabled = false; Txt_NovaSenha_Recepcao.Enabled = false;
            Btn_SalvarNovas_Credenciais.Enabled = false; Btn_CancelarSalvar_NovasCredenciais.Enabled = false;
        }
        private void Btn_ViewSenhaAtual_Click(object sender, EventArgs e)
        {
            CliqueSenhaAtual++;
            // Ocultar Senha
            if (CliqueSenhaAtual % 2 == 0)
            {
                Btn_ViewSenhaAtual.Icon = Sistema_Desktop_para_Hotel.Properties.Resources.Ver_Senha;
                Txt_SenhaAtual_Recepcao.Password = true;
                Txt_SenhaAtual_Recepcao.Focus();
            }
            // Revelar Senha
            else
            {
                Btn_ViewSenhaAtual.Icon = Sistema_Desktop_para_Hotel.Properties.Resources.Esconder_Senha;
                Txt_SenhaAtual_Recepcao.Password = false;
                Txt_SenhaAtual_Recepcao.Focus();
            }
        }

        // Novas Credenciais de Login
        private void Btn_SalvarNovas_Credenciais_Click(object sender, EventArgs e)
        {
            var Campos_NovasCredencais = new[]
            {
                Txt_UsuarioAtual_Recepcao, Txt_SenhaAtual_Recepcao,
                Txt_NovoUsuario_Recepcao, Txt_NovaSenha_Recepcao,
            };

            // Validando campos
            if (Txt_NovoUsuario_Recepcao.Text.Equals("") && Txt_NovaSenha_Recepcao.Text.Equals(""))
            {
                Lbl_credenciaisErro.Visible = true;
                Lbl_credenciaisErro.Text = "Credenciais incorretas";
            }
            else if (Txt_NovaSenha_Recepcao.TextLength < 5)
            {
                Lbl_credenciaisErro.Visible = true;
                Lbl_credenciaisErro.Text = "Senha muito curta";
            }
            LoginHotelDAL loginDAL = new LoginHotelDAL();
            switch (DescricaoLogin)
            {
                case "Funcionário":
                    // Alterando Credenciais de Login
                    Lbl_credenciaisErro.Visible = false;
                    Lbl_credenciaisErro.Text = "";

                    // Executando Método
                    LoginHotel novasCredenciais = new LoginHotel(Txt_NovoUsuario_Recepcao.Text, Txt_NovaSenha_Recepcao.Text);
                    MaterialMessageBox.Show(loginDAL.AlterarCredenciaisLogin(novasCredenciais, DescricaoLogin));

                    // Limpando e Indisponibilizando campos
                    foreach(var campo in Campos_NovasCredencais)
                    {
                        campo.Clear();
                        campo.Enabled = false;
                    }
                    Btn_ViewNovaSenha.Enabled = false;
                    break;
                default:
                    Lbl_credenciaisErro.Visible = true;
                    break;
            }

        }
        private void Btn_CancelarSalvar_NovasCredenciais_Click(object sender, EventArgs e)
        {
            Txt_NovoUsuario_Recepcao.Clear(); Txt_NovaSenha_Recepcao.Clear();

            Txt_NovoUsuario_Recepcao.Enabled = false; Txt_NovaSenha_Recepcao.Enabled = false;
            Btn_SalvarNovas_Credenciais.Enabled = false; Btn_CancelarSalvar_NovasCredenciais.Enabled = false;
        }
        private void Btn_ViewNovaSenha_Click(object sender, EventArgs e)
        {
            CliqueNovaSenha++;
            // Ocultar Senha
            if (CliqueNovaSenha % 2 == 0)
            {
                Btn_ViewNovaSenha.Icon = Sistema_Desktop_para_Hotel.Properties.Resources.Ver_Senha;
                Txt_NovaSenha_Recepcao.Password = true;
                Txt_NovaSenha_Recepcao.Focus();
            }
            // Revelar Senha
            else
            {
                Btn_ViewNovaSenha.Icon = Sistema_Desktop_para_Hotel.Properties.Resources.Esconder_Senha;
                Txt_NovaSenha_Recepcao.Password = false;
                Txt_NovaSenha_Recepcao.Focus();
            }
        }

        /*LISTAGEM DE FICHAS DE RESERVAS*/
        // Listagem de TODAS as Reservas
        private void Btn_ListarTodas_Fichas_Click(object sender, EventArgs e)
        {
            DataTable table_Hospedes = new DataTable();
            HospedesDAL hospedesDAL = new HospedesDAL();
            List<Hospedes> list = new List<Hospedes>();
            list = hospedesDAL.ListarTodasReservas();
            Grid_ListagemHospedes.DataSource = list;
        }
        // Listagem de Reservas Ativas
        private void Btn_Listar_FichasReservas_Ativas_Click(object sender, EventArgs e)
        {
            DataTable table_Hospedes = new DataTable();
            HospedesDAL hospedesDAL = new HospedesDAL();
            List<Hospedes> list = new List<Hospedes>();
            list = hospedesDAL.ListarReservasAtivas();
            Grid_ListagemHospedes.DataSource = list;
        }
        // Listagem de Reservas Inativas
        private void Btn_Listar_FichasReservas_Inativas_Click(object sender, EventArgs e)
        {
            DataTable table_Hospedes = new DataTable();
            HospedesDAL hospedesDAL = new HospedesDAL();
            List<Hospedes> list = new List<Hospedes>();
            list = hospedesDAL.ListarReservasInativas();
            Grid_ListagemHospedes.DataSource = list;
        }
    }
}
