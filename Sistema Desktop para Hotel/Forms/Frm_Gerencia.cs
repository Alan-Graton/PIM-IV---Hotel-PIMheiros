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
    public partial class Frm_Gerencia : MaterialForm
    {
        string DescricaoLogin = "";
        int CliqueSenhaAtual;
        int CliqueNovaSenha;
        string CapacidadeHotel = "";
        public Frm_Gerencia()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }
        private void Frm_Gerencia_Load(object sender, EventArgs e)
        {
            FuncionariosDAL funcionariosDAL = new FuncionariosDAL();

            // Verificando Quantidade de Vagas Disponíveis no Hotel
            MaterialMessageBox.Show(funcionariosDAL.CapacidadeTotalHotel(out string capacidadeHotel));
            CapacidadeHotel = capacidadeHotel;

            // Listagem de Funcionários
            DataTable table_Funcionarios = new DataTable();
            List<FuncionariosHotel> listagemFunc = new List<FuncionariosHotel>();
            listagemFunc = funcionariosDAL.ListarTodasFichasFuncionariosHotel();
            Grid_ListagemFunc.DataSource = listagemFunc;

            // Listagem de Reservas Ativas
            DataTable table_Hospedes = new DataTable();
            HospedesDAL hospedesDAL = new HospedesDAL();
            List<Hospedes> list = new List<Hospedes>();
            list = hospedesDAL.ListarReservasAtivas();
            Grid_ListagemHospedes.DataSource = list;

            // Atualização de Relatórios
            Lbl_Relatorio_GanhoTotal.Text = funcionariosDAL.GanhoTotalHotel();

            Lbl_Relatorio_FuncsAtivos.Text = funcionariosDAL.QntFuncionariosAtivos();
            Lbl_Relatorio_FuncsInativos.Text = funcionariosDAL.QntFuncionariosInativos();

            Lbl_Relatorio_ReservasAtivas.Text = funcionariosDAL.QntHospedesAtivos();
        }
        private void Frm_Gerencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        // Limpar Campos de Cadastro de Funcionários
        private void Btn_LimparCampos_Click(object sender, EventArgs e)
        {
            Btn_SalvarCadastro_Func.Enabled = true; Btn_Editar_FichaFunc.Enabled = false;
            Txt_NomeFunc.Clear(); Txt_CPF_Func.Clear(); Txt_CTPS_Func.Clear(); Txt_EmailFunc.Clear(); Txt_CargoFunc.Clear();
            Txt_CPF_PesquisarFuncs.Clear();
            CKBX_StatusFunc.Checked = false; CKBX_FichaStatusFunc.Checked = false;
        }
        // Limpar Campos de Cadastro/Reserva de Hóspedes
        private void Btn_LimparCampos_Hosp_Click(object sender, EventArgs e)
        {
            var CamposTxtHospedes = new[]
            {
                Txt_NomeHospede,
                Txt_CPF_Hospede,
                Txt_EmailHospede,
                Txt_CelularHospede,
                Txt_CartaoHospede,
                Txt_NumQuarto_Hospede,
                Txt_PesquisarCPF_Hosp
            };
            foreach (var campo in CamposTxtHospedes)
            {
                campo.Clear();
            }
            CKBX_HospedesAtivo.Checked = false; CKBX_ReservaAtivada.Checked = false;
            Lbl_Pagamento_Total.Text = "";
            Btn_Editar_FichaHospede.Enabled = false;
            Btn_Salvar_CadastroReserva.Enabled = true;
        }

        /*BOTÕES PARA MANIPULAR OS DADOS DOS FUNCIONÁRIOS*/
        private void Btn_SalvarCadastro_Func_Click(object sender, EventArgs e)
        {
            var CamposTxt_Funcs = new[]
            {
                Txt_NomeFunc, Txt_CPF_Func, Txt_CTPS_Func, Txt_EmailFunc,
                Txt_CargoFunc
            };

            // Validação de campos
            foreach(var campo in CamposTxt_Funcs)
            {
                // Entrandas de campos incorretas
                if (campo.Text.Equals("") || !Txt_CPF_Func.Text.All(char.IsDigit) || !Txt_CTPS_Func.Text.All(char.IsDigit))
                {
                    Lbl_ErroCadastro_Funcs.Visible = true;
                }

                // Entrada de campos correta
                else if(campo.Text != "" && campo.Text != null && Txt_CTPS_Func.Text.All(char.IsDigit) && Txt_CPF_Func.Text.All(char.IsDigit))
                {
                    Lbl_ErroCadastro_Funcs.Visible = false;
                    Lbl_ErroCadastro_Funcs.Text = "";

                    string statusFuncionario = "";
                    string statusFichaFuncionario = "";
                    _ = (CKBX_StatusFunc.Checked) ? statusFuncionario = "Ativo" : statusFuncionario = "Inativo";
                    _ = (CKBX_FichaStatusFunc.Checked) ? statusFichaFuncionario = "Ativada" : statusFichaFuncionario = "Desativada";
                    FuncionariosHotel funcionarios = new FuncionariosHotel
                    (
                        Txt_NomeFunc.Text, Txt_CPF_Func.Text, Txt_CTPS_Func.Text, Txt_EmailFunc.Text,
                        Txt_CargoFunc.Text, statusFuncionario, statusFichaFuncionario
                    );

                    // Executando Método
                    FuncionariosDAL funcionariosDAL = new FuncionariosDAL();
                    MaterialMessageBox.Show(funcionariosDAL.CadastrarFuncionariosHotel(funcionarios));

                    // Limpando Campos
                    foreach(var limpaCampo in CamposTxt_Funcs)
                    {
                        limpaCampo.Clear();
                    }
                    CKBX_StatusFunc.Checked = false; CKBX_FichaStatusFunc.Checked = false;

                    // Listando Fichas
                    DataTable table = new DataTable();
                    List<FuncionariosHotel> list = new List<FuncionariosHotel>();
                    list = funcionariosDAL.ListarTodasFichasFuncionariosHotel();
                    Grid_ListagemFunc.DataSource = list;
                    break;
                }
            }
        }
        private void Btn_Consultar_FichaFunc_Click(object sender, EventArgs e)
        {
            FuncionariosHotel funcionarios = new FuncionariosHotel();
            FuncionariosDAL funcionariosDAL = new FuncionariosDAL();

            // Campo de Pesquisa em Branco
            if (Txt_CPF_PesquisarFuncs.Text.Equals("") || Txt_CPF_PesquisarFuncs.TextLength < 11 || 
                !Txt_CPF_PesquisarFuncs.Text.All(char.IsDigit))
            {
                Lbl_ErroConsulta.Visible = true;
                Lbl_ErroConsulta.Text = "Informe um CPF Válido";
            }

            // Entrada de campo está correta
            else if(Txt_CPF_PesquisarFuncs.TextLength == 11 && Txt_CPF_PesquisarFuncs.Text != "" 
                && Txt_CPF_PesquisarFuncs.Text.All(char.IsDigit))
            {
                Lbl_ErroConsulta.Visible = false;

                // Executando Método
                funcionarios = funcionariosDAL.ConsultarFichaFuncionariosHotel(Txt_CPF_PesquisarFuncs.Text, out string mensagem);
                MaterialMessageBox.Show(mensagem);

                // Caso Funcionários estiver Cadastrado no Sistema
                if (funcionarios != null)
                {
                    // Preenchendo campos com dados da Ficha do Funcionário
                    Txt_NomeFunc.Text = funcionarios.Nome;
                    Txt_CPF_Func.Text = funcionarios.CPF;
                    Txt_CTPS_Func.Text = funcionarios.CTPS;
                    Txt_EmailFunc.Text = funcionarios.Email;
                    Txt_CargoFunc.Text = funcionarios.Cargo;
                    _ = (funcionarios.Status == "Ativo") ? CKBX_StatusFunc.Checked = true : CKBX_StatusFunc.Checked = false;
                    _ = (funcionarios.Status_Ficha == "Ativada") ? CKBX_FichaStatusFunc.Checked = true : CKBX_FichaStatusFunc.Checked = false;

                    Btn_SalvarCadastro_Func.Enabled = false;
                    Btn_Editar_FichaFunc.Enabled = true;
                }
            }
            
        }
        private void Btn_Editar_FichaFunc_Click(object sender, EventArgs e)
        {
            var CamposTxt_Editar = new[]
            {
                Txt_NomeFunc, Txt_CPF_Func, Txt_CTPS_Func,
                Txt_EmailFunc, Txt_CargoFunc
            };

            // Validação de Campos
            foreach(var campo in CamposTxt_Editar)
            {
                // Validando campos
                if (campo.Text.Equals("") || !Txt_CPF_Func.Text.All(char.IsDigit) || !Txt_CTPS_Func.Text.All(char.IsDigit))
                {
                    Lbl_ErroCadastro_Funcs.Visible = true;
                    Lbl_ErroCadastro_Funcs.Text = "Preencha os campos Corretamente";
                }

                // Campos preenchidos corretamente
                else if (campo.Text != "" && campo.Text != null && Txt_CPF_Func.Text.All(char.IsDigit) && Txt_CTPS_Func.Text.All(char.IsDigit))
                {
                    Lbl_ErroCadastro_Funcs.Visible = false;
                    Lbl_ErroCadastro_Funcs.Text = "";
                    Btn_SalvarCadastro_Func.Enabled = true;
                    Btn_Editar_FichaFunc.Enabled = false;

                    string statusFunc = "";
                    string statusFichaFunc = "";

                    _ = (CKBX_StatusFunc.Checked) ? statusFunc = "Ativo" : statusFunc = "Inativo";
                    _ = (CKBX_FichaStatusFunc.Checked) ? statusFichaFunc = "Ativada" : statusFichaFunc = "Desativada";
                    FuncionariosHotel funcionarios = new FuncionariosHotel
                    (
                        Txt_NomeFunc.Text, Txt_CPF_Func.Text, Txt_CTPS_Func.Text, Txt_EmailFunc.Text, Txt_CargoFunc.Text,
                        statusFunc, statusFichaFunc
                    );

                    // Executando Método
                    FuncionariosDAL funcionariosDAL = new FuncionariosDAL();
                    MaterialMessageBox.Show(funcionariosDAL.AlterarFichaAdmissaoFuncionarios(funcionarios, Txt_CPF_PesquisarFuncs.Text));

                    foreach (var limpaCampo in CamposTxt_Editar)
                    {
                        limpaCampo.Clear();
                    }

                    // Limpando Campos
                    CKBX_StatusFunc.Checked = false; CKBX_FichaStatusFunc.Checked = false; Txt_CPF_PesquisarFuncs.Clear();

                    // Listando Fichas
                    DataTable table = new DataTable();
                    List<FuncionariosHotel> list = new List<FuncionariosHotel>();
                    list = funcionariosDAL.ListarTodasFichasFuncionariosHotel();
                    Grid_ListagemFunc.DataSource = list;
                }
            }
        }
        // Listagem de Fichas de Funcionários
        private void Btn_ListarTodas_Fichas_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            FuncionariosDAL funcionariosDAL = new FuncionariosDAL();
            List<FuncionariosHotel> list = new List<FuncionariosHotel>();
            list = funcionariosDAL.ListarTodasFichasFuncionariosHotel();
            Grid_ListagemFunc.DataSource = list;
        }
        private void Btn_ListarFichas_Ativadas_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            FuncionariosDAL funcionariosDAL = new FuncionariosDAL();
            List<FuncionariosHotel> list = new List<FuncionariosHotel>();
            list = funcionariosDAL.ListarFichasAtivadasFuncionariosHotel();
            Grid_ListagemFunc.DataSource = list;
        }
        private void Btn_ListarFichas_Desativadas_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            FuncionariosDAL funcionariosDAL = new FuncionariosDAL();
            List<FuncionariosHotel> list = new List<FuncionariosHotel>();
            list = funcionariosDAL.ListarFichasDesativadasFuncionariosHotel();
            Grid_ListagemFunc.DataSource = list;
        }

        /*BOTÕES PARA MANIPULAR OS DADOS DOS HÓSPEDES*/
        private void Btn_Salvar_CadastroReserva_Click(object sender, EventArgs e)
        {
            string statusHospede = "";
            string statusReservaHospede = "";

            // Preço das Categorias de Quartos
            int precoCategoria = 0;
            int Diaria = int.Parse(Date_CheckOut_Hospede.Value.Date.Subtract(Date_CheckIn_Hospede.Value.Date).TotalDays.ToString());

            // Calculando Diária
            switch (Combobx_CategoriaQuarto_Hospede.Text)
            {
                case "Standard":
                    precoCategoria = 150;
                    if(Diaria == 0)
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
                    if(Diaria == 0)
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

            // Validando campos
            foreach (var campo in CamposTxt_FichaHospede)
            {
                // Entrada de campos incorreta
                if (campo.Text.Equals("") || Txt_CPF_Hospede.TextLength < 11 || Txt_CelularHospede.TextLength < 11 ||
                    !Txt_CPF_Hospede.Text.All(char.IsDigit) || !Txt_CelularHospede.Text.All(char.IsDigit) ||
                   !Txt_CartaoHospede.Text.All(char.IsDigit) || !Txt_NumQuarto_Hospede.Text.All(char.IsDigit))
                {
                    Lbl_ErroCadastro.Visible = true;
                }

                // Verificando Capacidade do Hotel
                if(CapacidadeHotel == "Lotado")
                {
                    MaterialMessageBox.Show("Hotel Atingiu Capacidade Máxima de Quartos Ocupados");
                    break;
                }

                // Entradas de dados estão todas corretas e há vagas no Hotel
                else if (campo.Text != "" && campo.Text != null && Txt_CPF_Hospede.TextLength == 11 && Txt_CelularHospede.TextLength == 11 &&
                    Txt_CPF_Hospede.Text.All(char.IsDigit) || Txt_CelularHospede.Text.All(char.IsDigit) ||
                   Txt_CartaoHospede.Text.All(char.IsDigit) || Txt_NumQuarto_Hospede.Text.All(char.IsDigit) && CapacidadeHotel == "Vagas")
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
                    Lbl_Pagamento_Total.Visible = false;
                    break;
                }
            }
        }
        private void Btn_Consultar_FichaHospede_Click(object sender, EventArgs e)
        {
            Hospedes hospedes = new Hospedes();
            HospedesDAL hospedesDAL = new HospedesDAL();

            // Validação de CPF para pesquisa
            if (Txt_PesquisarCPF_Hosp.Text.Equals("") || Txt_PesquisarCPF_Hosp.TextLength < 11 || !Txt_PesquisarCPF_Hosp.Text.All(char.IsDigit))
            {
                Lbl_ErroCadastro.Visible = true;
                Lbl_ErroCadastro.Text = "CPF Inválido";
            }

            // Entrada de CPF correta
            else if (Txt_PesquisarCPF_Hosp.TextLength == 11 && Txt_PesquisarCPF_Hosp.Text != "" && Txt_PesquisarCPF_Hosp.Text.All(char.IsDigit))
            {
                Lbl_ErroCadastro.Visible = false;
                Lbl_ErroCadastro.Text = "";
                Lbl_ErroCadastro.Visible = false;

                // Executando Método
                hospedes = hospedesDAL.ConsultarHospedesReservas(Txt_PesquisarCPF_Hosp.Text, out string retorno);
                MaterialMessageBox.Show(retorno);

                // Caso Hóspede estiver Cadastrado no Sistema
                if (hospedes != null)
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
            string statusHospede = "";
            string statusReservaHospede = "";
            // Verificando status do Hóspede e de sua Reserva
            _ = (CKBX_HospedesAtivo.Checked) ? statusHospede = "Ativo" : statusHospede = "Inativo";
            _ = (CKBX_ReservaAtivada.Checked) ? statusReservaHospede = "Ativada" : statusReservaHospede = "Desativada";

            // Objetos
            Hospedes hospedes = new Hospedes
            (
                Txt_NomeHospede.Text, Txt_CPF_Hospede.Text, Txt_EmailHospede.Text, Txt_CelularHospede.Text,
                statusHospede, statusReservaHospede, Txt_CartaoHospede.Text,
                DateTime.Parse(Date_CheckIn_Hospede.Text), DateTime.Parse(Date_CheckOut_Hospede.Text),
                Txt_NumQuarto_Hospede.Text, Combobx_CategoriaQuarto_Hospede.Text, int.Parse(Lbl_Pagamento_Total.Text)
            );

            HospedesDAL hospedesDAL = new HospedesDAL();

            // Objeto para campos
            var CamposHospedes = new[]
            {
                Txt_NomeHospede, Txt_CPF_Hospede, Txt_EmailHospede, Txt_CelularHospede,
                Txt_CartaoHospede, Txt_NumQuarto_Hospede
            };
            // Validações e Execução do Método
            foreach(var campo in CamposHospedes)
            {
                // Campos com dados incorretos
                if(campo.Text.Equals("") || Txt_CPF_Hospede.TextLength < 11 || Txt_CelularHospede.TextLength < 11)
                {
                    Lbl_ErroCadastro.Visible = true;
                }

                // Entrada de dados nos campos correta
                else if (campo.Text != "" && Txt_CPF_Hospede.TextLength == 11 && Txt_CelularHospede.TextLength == 11)
                {
                    Lbl_ErroCadastro.Visible = false;
                    // Executando o Método
                    MaterialMessageBox.Show(hospedesDAL.AlterarFichaHospede(hospedes, Txt_PesquisarCPF_Hosp.Text));

                    // Listagem de Reservas Ativas
                    DataTable table = new DataTable();
                    List<Hospedes> list = new List<Hospedes>();
                    list = hospedesDAL.ListarReservasAtivas();
                    Grid_ListagemHospedes.DataSource = list;

                    // Limpando Campos
                    CKBX_HospedesAtivo.Checked = false; CKBX_ReservaAtivada.Checked = false;
                    foreach (var limpaCampos in CamposHospedes)
                    {
                        limpaCampos.Clear();
                    }
                    Txt_PesquisarCPF_Hosp.Clear();
                    Lbl_Pagamento_Total.Text = "";
                    Btn_Editar_FichaHospede.Enabled = false;
                    Btn_Salvar_CadastroReserva.Enabled = true;
                    break;
                }
            }
        }
        // Listagem de Reservas
        private void Btn_Listar_FichasReservas_Ativas_Click(object sender, EventArgs e)
        {
            DataTable table_Hospedes = new DataTable();
            HospedesDAL hospedesDAL = new HospedesDAL();
            List<Hospedes> list = new List<Hospedes>();
            list = hospedesDAL.ListarReservasAtivas();
            Grid_ListagemHospedes.DataSource = list;
        }
        private void Btn_ListarTodas_Reservas_Click(object sender, EventArgs e)
        {
            DataTable table_Hospedes = new DataTable();
            HospedesDAL hospedesDAL = new HospedesDAL();
            List<Hospedes> list = new List<Hospedes>();
            list = hospedesDAL.ListarTodasReservas();
            Grid_ListagemHospedes.DataSource = list;
        }
        private void Btn_Listar_FichasReservas_Inativas_Click(object sender, EventArgs e)
        {
            DataTable table_Hospedes = new DataTable();
            HospedesDAL hospedesDAL = new HospedesDAL();
            List<Hospedes> list = new List<Hospedes>();
            list = hospedesDAL.ListarReservasInativas();
            Grid_ListagemHospedes.DataSource = list;
        }

        /*CAMPOS PARA MANIPULAÇÃO DOS DADOS DO GERENTE*/
        // Página "Configurações"
        private void Btn_ValidarCrendencias_Atuais_Click(object sender, EventArgs e)
        {
            LoginHotel validarCredenciais = new LoginHotel(Txt_UsuarioAtual_Gerencia.Text, Txt_SenhaAtual_Gerencia.Text);
            LoginHotelDAL loginDAL = new LoginHotelDAL();

            // Entrada de Dados para validação
            loginDAL.ValidarLoginHotel(validarCredenciais, out string retornoDescricaoLogin);

            // Validação para alterar somente as credenciais do Gerente
            if(retornoDescricaoLogin != "Gerente")
            {
                Lbl_credenciaisErro.Visible = true;
            }
            // Disponibilizando campos para entrada de novas credenciais
            else
            {
                DescricaoLogin = retornoDescricaoLogin;
                Txt_NovoUsuario_Gerencia.Enabled = true; Txt_NovaSenha_Gerencia.Enabled = true;
                Btn_SalvarNovas_Credenciais.Enabled = true; Btn_CancelarSalvar_NovasCredenciais.Enabled = true;
            }
        }
        private void Btn_Cancelar_Validacao_Click(object sender, EventArgs e)
        {
            Txt_UsuarioAtual_Gerencia.Clear(); Txt_SenhaAtual_Gerencia.Clear();
            Txt_NovoUsuario_Gerencia.Enabled = false; Txt_NovaSenha_Gerencia.Enabled = false;
            Btn_SalvarNovas_Credenciais.Enabled = false; 
            Btn_CancelarSalvar_NovasCredenciais.Enabled = false; Btn_ViewNovaSenha.Enabled = false;
        } 
        private void Btn_View_SenhaAtual_Click(object sender, EventArgs e)
        {
            CliqueSenhaAtual++;
            if(CliqueSenhaAtual % 2 == 0)
            {
                Btn_View_SenhaAtual.Icon = Sistema_Desktop_para_Hotel.Properties.Resources.Ver_Senha;
                Txt_SenhaAtual_Gerencia.Password = true;
                Txt_SenhaAtual_Gerencia.Focus();
            }
            else
            {
                Btn_View_SenhaAtual.Icon = Sistema_Desktop_para_Hotel.Properties.Resources.Esconder_Senha;
                Txt_SenhaAtual_Gerencia.Password = false;
                Txt_SenhaAtual_Gerencia.Focus();
            }
        }

        // Novas Credenciais de Login
        private void Btn_SalvarNovas_Credenciais_Click(object sender, EventArgs e)
        {
            var Campos_NovasCredenciais = new[]
            {
                Txt_UsuarioAtual_Gerencia, Txt_SenhaAtual_Gerencia,
                Txt_NovoUsuario_Gerencia, Txt_NovaSenha_Gerencia
            };
            
            // Validando campos
            if(Txt_NovoUsuario_Gerencia.Text.Equals("") && Txt_NovaSenha_Gerencia.Text.Equals(""))
            {
                Lbl_credenciaisErro.Visible = true;
                Lbl_credenciaisErro.Text = "Campos Vazios";
            }
            else if(Txt_NovaSenha_Gerencia.TextLength < 5)
            {
                Lbl_credenciaisErro.Visible = true;
                Lbl_credenciaisErro.Text = "Senha muito curta!";
            }
            else
            {
                Lbl_credenciaisErro.Visible = false;
                Lbl_credenciaisErro.Text = "";
                LoginHotelDAL loginDAL = new LoginHotelDAL();
                switch (DescricaoLogin)
                {
                    case "Gerente":
                        // Alterando Credenciais de Login
                        Lbl_credenciaisErro.Visible = false;
                        LoginHotel novasCredenciais = new LoginHotel(Txt_NovoUsuario_Gerencia.Text, Txt_NovaSenha_Gerencia.Text);
                        MaterialMessageBox.Show(loginDAL.AlterarCredenciaisLogin(novasCredenciais, DescricaoLogin));

                        // Limpando e Indisponibilizando campos
                        foreach(var campo in Campos_NovasCredenciais)
                        {
                            campo.Clear();
                            campo.Enabled = false;
                        }
                        Btn_SalvarNovas_Credenciais.Enabled = false; Btn_CancelarSalvar_NovasCredenciais.Enabled = false;
                        break;
                    default:
                        Lbl_credenciaisErro.Visible = true;
                        break;
                }
            }
        }
        private void Btn_CancelarSalvar_NovasCredenciais_Click(object sender, EventArgs e)
        {
            Txt_NovoUsuario_Gerencia.Clear(); Txt_NovaSenha_Gerencia.Clear();

            Txt_NovoUsuario_Gerencia.Enabled = false; Txt_NovaSenha_Gerencia.Enabled = false;
            Btn_SalvarNovas_Credenciais.Enabled = false; Btn_CancelarSalvar_NovasCredenciais.Enabled = false;
            Btn_ViewNovaSenha.Enabled = false;
        }
        private void Btn_ViewNovaSenha_Click(object sender, EventArgs e)
        {
            CliqueNovaSenha++;
            if (CliqueNovaSenha % 2 == 0)
            {
                Btn_ViewNovaSenha.Icon = Sistema_Desktop_para_Hotel.Properties.Resources.Ver_Senha;
                Txt_NovaSenha_Gerencia.Password = true;
                Txt_NovaSenha_Gerencia.Focus();
            }
            else
            {
                Btn_ViewNovaSenha.Icon = Sistema_Desktop_para_Hotel.Properties.Resources.Esconder_Senha;
                Txt_NovaSenha_Gerencia.Password = false;
                Txt_NovaSenha_Gerencia.Focus();
            }
        }

        /*RELATÓRIOS*/
        // Página "Relatórios"
        private void Btn_AtualizarRelatórios_Click(object sender, EventArgs e)
        {
            FuncionariosDAL funcionariosDAL = new FuncionariosDAL();
            
            // Soma total de todos os ganhos do Hotel
            Lbl_Relatorio_GanhoTotal.Text = funcionariosDAL.GanhoTotalHotel();

            // Contagem de Funcionários Ativos/Inativos do Hotel
            Lbl_Relatorio_FuncsAtivos.Text = funcionariosDAL.QntFuncionariosAtivos();
            Lbl_Relatorio_FuncsInativos.Text = funcionariosDAL.QntFuncionariosInativos();

            // Contagem de Reservas/Hóspedes Ativas
            Lbl_Relatorio_ReservasAtivas.Text = funcionariosDAL.QntHospedesAtivos();
        }
    }
}
