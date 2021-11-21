
namespace Sistema_Desktop_para_Hotel.Forms
{
    partial class Frm_Gerencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Gerencia));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TabControl_Gerencia = new MaterialSkin.Controls.MaterialTabControl();
            this.TabPag_Funcionarios = new System.Windows.Forms.TabPage();
            this.Btn_LimparCampos = new MaterialSkin.Controls.MaterialButton();
            this.Btn_ListarTodas_Fichas = new MaterialSkin.Controls.MaterialButton();
            this.Btn_ListarFichas_Desativadas = new MaterialSkin.Controls.MaterialButton();
            this.Btn_ListarFichas_Ativadas = new MaterialSkin.Controls.MaterialButton();
            this.Grid_ListagemFunc = new System.Windows.Forms.DataGridView();
            this.Btn_Editar_FichaFunc = new MaterialSkin.Controls.MaterialButton();
            this.Btn_Consultar_FichaFunc = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.Lbl_ErroConsulta_Hosp = new MaterialSkin.Controls.MaterialLabel();
            this.Lbl_ErroConsulta = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard13 = new MaterialSkin.Controls.MaterialCard();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.CKBX_StatusFunc = new MaterialSkin.Controls.MaterialCheckbox();
            this.Txt_CPF_PesquisarFuncs = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_EmailFunc = new MaterialSkin.Controls.MaterialTextBox();
            this.materialDivider10 = new MaterialSkin.Controls.MaterialDivider();
            this.Txt_CPF_Func = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel23 = new MaterialSkin.Controls.MaterialLabel();
            this.Txt_NomeFunc = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.Txt_CargoFunc = new MaterialSkin.Controls.MaterialTextBox();
            this.CKBX_FichaStatusFunc = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialDivider9 = new MaterialSkin.Controls.MaterialDivider();
            this.Txt_CTPS_Func = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.Lbl_ErroCadastro_Funcs = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.Btn_SalvarCadastro_Func = new MaterialSkin.Controls.MaterialButton();
            this.TabPag_Hospedes = new System.Windows.Forms.TabPage();
            this.Btn_LimparCampos_Hosp = new MaterialSkin.Controls.MaterialButton();
            this.Btn_ListarTodas_Reservas = new MaterialSkin.Controls.MaterialButton();
            this.Btn_Listar_FichasReservas_Inativas = new MaterialSkin.Controls.MaterialButton();
            this.Btn_Listar_FichasReservas_Ativas = new MaterialSkin.Controls.MaterialButton();
            this.Grid_ListagemHospedes = new System.Windows.Forms.DataGridView();
            this.Btn_Consultar_FichaHospede = new MaterialSkin.Controls.MaterialButton();
            this.Btn_Editar_FichaHospede = new MaterialSkin.Controls.MaterialButton();
            this.Btn_Salvar_CadastroReserva = new MaterialSkin.Controls.MaterialButton();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.Lbl_Pagamento_Total = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
            this.CKBX_ReservaAtivada = new MaterialSkin.Controls.MaterialCheckbox();
            this.CKBX_HospedesAtivo = new MaterialSkin.Controls.MaterialCheckbox();
            this.Txt_PesquisarCPF_Hosp = new MaterialSkin.Controls.MaterialTextBox();
            this.Lbl_ErroCadastro = new MaterialSkin.Controls.MaterialLabel();
            this.Txt_CartaoHospede = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_NumQuarto_Hospede = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.Date_CheckIn_Hospede = new System.Windows.Forms.DateTimePicker();
            this.Date_CheckOut_Hospede = new System.Windows.Forms.DateTimePicker();
            this.Combobx_CategoriaQuarto_Hospede = new MaterialSkin.Controls.MaterialComboBox();
            this.materialDivider7 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider6 = new MaterialSkin.Controls.MaterialDivider();
            this.Txt_CPF_Hospede = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_EmailHospede = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_CelularHospede = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_NomeHospede = new MaterialSkin.Controls.MaterialTextBox();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.TabPag_Relatorios = new System.Windows.Forms.TabPage();
            this.materialCard8 = new MaterialSkin.Controls.MaterialCard();
            this.Btn_AtualizarRelatórios = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider11 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider14 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider13 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard12 = new MaterialSkin.Controls.MaterialCard();
            this.Lbl_Relatorio_GanhoTotal = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard11 = new MaterialSkin.Controls.MaterialCard();
            this.Lbl_Relatorio_FuncsInativos = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard10 = new MaterialSkin.Controls.MaterialCard();
            this.Lbl_Relatorio_ReservasAtivas = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard9 = new MaterialSkin.Controls.MaterialCard();
            this.Lbl_Relatorio_FuncsAtivos = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider12 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.TabPag_Configuracao = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.Btn_ViewNovaSenha = new MaterialSkin.Controls.MaterialButton();
            this.Btn_View_SenhaAtual = new MaterialSkin.Controls.MaterialButton();
            this.Lbl_SenhaCurta = new MaterialSkin.Controls.MaterialLabel();
            this.Lbl_CamposVazios = new MaterialSkin.Controls.MaterialLabel();
            this.Lbl_credenciaisErro = new MaterialSkin.Controls.MaterialLabel();
            this.Btn_CancelarSalvar_NovasCredenciais = new MaterialSkin.Controls.MaterialButton();
            this.Btn_SalvarNovas_Credenciais = new MaterialSkin.Controls.MaterialButton();
            this.Txt_NovaSenha_Gerencia = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_NovoUsuario_Gerencia = new MaterialSkin.Controls.MaterialTextBox();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.Btn_Cancelar_Validacao = new MaterialSkin.Controls.MaterialButton();
            this.Btn_ValidarCrendencias_Atuais = new MaterialSkin.Controls.MaterialButton();
            this.Txt_SenhaAtual_Gerencia = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_UsuarioAtual_Gerencia = new MaterialSkin.Controls.MaterialTextBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TabPag_Sobre = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialDivider8 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TabControl_Gerencia.SuspendLayout();
            this.TabPag_Funcionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ListagemFunc)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.materialCard13.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.TabPag_Hospedes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ListagemHospedes)).BeginInit();
            this.materialCard5.SuspendLayout();
            this.TabPag_Relatorios.SuspendLayout();
            this.materialCard8.SuspendLayout();
            this.materialCard12.SuspendLayout();
            this.materialCard11.SuspendLayout();
            this.materialCard10.SuspendLayout();
            this.materialCard9.SuspendLayout();
            this.TabPag_Configuracao.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.TabPag_Sobre.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Configurações.png");
            this.imageList1.Images.SetKeyName(1, "Funcionários.png");
            this.imageList1.Images.SetKeyName(2, "Menu Principal.png");
            this.imageList1.Images.SetKeyName(3, "Relatórios.png");
            this.imageList1.Images.SetKeyName(4, "Reservas.png");
            this.imageList1.Images.SetKeyName(5, "Visualizar Fichas.png");
            this.imageList1.Images.SetKeyName(6, "info.png");
            // 
            // TabControl_Gerencia
            // 
            this.TabControl_Gerencia.Controls.Add(this.TabPag_Funcionarios);
            this.TabControl_Gerencia.Controls.Add(this.TabPag_Hospedes);
            this.TabControl_Gerencia.Controls.Add(this.TabPag_Relatorios);
            this.TabControl_Gerencia.Controls.Add(this.TabPag_Configuracao);
            this.TabControl_Gerencia.Controls.Add(this.TabPag_Sobre);
            this.TabControl_Gerencia.Depth = 0;
            this.TabControl_Gerencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl_Gerencia.HotTrack = true;
            this.TabControl_Gerencia.ImageList = this.imageList1;
            this.TabControl_Gerencia.Location = new System.Drawing.Point(3, 64);
            this.TabControl_Gerencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl_Gerencia.Multiline = true;
            this.TabControl_Gerencia.Name = "TabControl_Gerencia";
            this.TabControl_Gerencia.SelectedIndex = 0;
            this.TabControl_Gerencia.Size = new System.Drawing.Size(1015, 522);
            this.TabControl_Gerencia.TabIndex = 0;
            // 
            // TabPag_Funcionarios
            // 
            this.TabPag_Funcionarios.Controls.Add(this.Btn_LimparCampos);
            this.TabPag_Funcionarios.Controls.Add(this.Btn_ListarTodas_Fichas);
            this.TabPag_Funcionarios.Controls.Add(this.Btn_ListarFichas_Desativadas);
            this.TabPag_Funcionarios.Controls.Add(this.Btn_ListarFichas_Ativadas);
            this.TabPag_Funcionarios.Controls.Add(this.Grid_ListagemFunc);
            this.TabPag_Funcionarios.Controls.Add(this.Btn_Editar_FichaFunc);
            this.TabPag_Funcionarios.Controls.Add(this.Btn_Consultar_FichaFunc);
            this.TabPag_Funcionarios.Controls.Add(this.materialCard2);
            this.TabPag_Funcionarios.Controls.Add(this.Btn_SalvarCadastro_Func);
            this.TabPag_Funcionarios.ImageKey = "Funcionários.png";
            this.TabPag_Funcionarios.Location = new System.Drawing.Point(4, 39);
            this.TabPag_Funcionarios.Name = "TabPag_Funcionarios";
            this.TabPag_Funcionarios.Padding = new System.Windows.Forms.Padding(3);
            this.TabPag_Funcionarios.Size = new System.Drawing.Size(1007, 479);
            this.TabPag_Funcionarios.TabIndex = 0;
            this.TabPag_Funcionarios.Text = "Funcionários";
            this.TabPag_Funcionarios.UseVisualStyleBackColor = true;
            // 
            // Btn_LimparCampos
            // 
            this.Btn_LimparCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_LimparCampos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_LimparCampos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_LimparCampos.Depth = 0;
            this.Btn_LimparCampos.HighEmphasis = true;
            this.Btn_LimparCampos.Icon = null;
            this.Btn_LimparCampos.Location = new System.Drawing.Point(369, 434);
            this.Btn_LimparCampos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_LimparCampos.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_LimparCampos.Name = "Btn_LimparCampos";
            this.Btn_LimparCampos.Size = new System.Drawing.Size(139, 36);
            this.Btn_LimparCampos.TabIndex = 23;
            this.Btn_LimparCampos.Text = "Limpar Campos";
            this.Btn_LimparCampos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_LimparCampos.UseAccentColor = false;
            this.Btn_LimparCampos.UseVisualStyleBackColor = true;
            this.Btn_LimparCampos.Click += new System.EventHandler(this.Btn_LimparCampos_Click);
            // 
            // Btn_ListarTodas_Fichas
            // 
            this.Btn_ListarTodas_Fichas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_ListarTodas_Fichas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_ListarTodas_Fichas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.Btn_ListarTodas_Fichas.Depth = 0;
            this.Btn_ListarTodas_Fichas.HighEmphasis = true;
            this.Btn_ListarTodas_Fichas.Icon = null;
            this.Btn_ListarTodas_Fichas.Location = new System.Drawing.Point(713, 434);
            this.Btn_ListarTodas_Fichas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_ListarTodas_Fichas.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_ListarTodas_Fichas.Name = "Btn_ListarTodas_Fichas";
            this.Btn_ListarTodas_Fichas.Size = new System.Drawing.Size(112, 36);
            this.Btn_ListarTodas_Fichas.TabIndex = 22;
            this.Btn_ListarTodas_Fichas.Text = "Listar Tudo";
            this.Btn_ListarTodas_Fichas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_ListarTodas_Fichas.UseAccentColor = true;
            this.Btn_ListarTodas_Fichas.UseVisualStyleBackColor = true;
            this.Btn_ListarTodas_Fichas.Click += new System.EventHandler(this.Btn_ListarTodas_Fichas_Click);
            // 
            // Btn_ListarFichas_Desativadas
            // 
            this.Btn_ListarFichas_Desativadas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_ListarFichas_Desativadas.AutoSize = false;
            this.Btn_ListarFichas_Desativadas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_ListarFichas_Desativadas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_ListarFichas_Desativadas.Depth = 0;
            this.Btn_ListarFichas_Desativadas.HighEmphasis = true;
            this.Btn_ListarFichas_Desativadas.Icon = null;
            this.Btn_ListarFichas_Desativadas.Location = new System.Drawing.Point(858, 434);
            this.Btn_ListarFichas_Desativadas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_ListarFichas_Desativadas.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_ListarFichas_Desativadas.Name = "Btn_ListarFichas_Desativadas";
            this.Btn_ListarFichas_Desativadas.Size = new System.Drawing.Size(139, 36);
            this.Btn_ListarFichas_Desativadas.TabIndex = 10;
            this.Btn_ListarFichas_Desativadas.Text = "Listar Fichas Desativadas";
            this.Btn_ListarFichas_Desativadas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_ListarFichas_Desativadas.UseAccentColor = false;
            this.Btn_ListarFichas_Desativadas.UseVisualStyleBackColor = true;
            this.Btn_ListarFichas_Desativadas.Click += new System.EventHandler(this.Btn_ListarFichas_Desativadas_Click);
            // 
            // Btn_ListarFichas_Ativadas
            // 
            this.Btn_ListarFichas_Ativadas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_ListarFichas_Ativadas.AutoSize = false;
            this.Btn_ListarFichas_Ativadas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_ListarFichas_Ativadas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_ListarFichas_Ativadas.Depth = 0;
            this.Btn_ListarFichas_Ativadas.HighEmphasis = true;
            this.Btn_ListarFichas_Ativadas.Icon = null;
            this.Btn_ListarFichas_Ativadas.Location = new System.Drawing.Point(541, 434);
            this.Btn_ListarFichas_Ativadas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_ListarFichas_Ativadas.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_ListarFichas_Ativadas.Name = "Btn_ListarFichas_Ativadas";
            this.Btn_ListarFichas_Ativadas.Size = new System.Drawing.Size(139, 36);
            this.Btn_ListarFichas_Ativadas.TabIndex = 9;
            this.Btn_ListarFichas_Ativadas.Text = "Listar Fichas Ativadas";
            this.Btn_ListarFichas_Ativadas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_ListarFichas_Ativadas.UseAccentColor = true;
            this.Btn_ListarFichas_Ativadas.UseVisualStyleBackColor = true;
            this.Btn_ListarFichas_Ativadas.Click += new System.EventHandler(this.Btn_ListarFichas_Ativadas_Click);
            // 
            // Grid_ListagemFunc
            // 
            this.Grid_ListagemFunc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Grid_ListagemFunc.BackgroundColor = System.Drawing.Color.White;
            this.Grid_ListagemFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_ListagemFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ListagemFunc.Location = new System.Drawing.Point(615, 17);
            this.Grid_ListagemFunc.Name = "Grid_ListagemFunc";
            this.Grid_ListagemFunc.Size = new System.Drawing.Size(386, 408);
            this.Grid_ListagemFunc.TabIndex = 8;
            // 
            // Btn_Editar_FichaFunc
            // 
            this.Btn_Editar_FichaFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Editar_FichaFunc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Editar_FichaFunc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Editar_FichaFunc.Depth = 0;
            this.Btn_Editar_FichaFunc.Enabled = false;
            this.Btn_Editar_FichaFunc.HighEmphasis = true;
            this.Btn_Editar_FichaFunc.Icon = null;
            this.Btn_Editar_FichaFunc.Location = new System.Drawing.Point(265, 434);
            this.Btn_Editar_FichaFunc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Editar_FichaFunc.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Editar_FichaFunc.Name = "Btn_Editar_FichaFunc";
            this.Btn_Editar_FichaFunc.Size = new System.Drawing.Size(71, 36);
            this.Btn_Editar_FichaFunc.TabIndex = 6;
            this.Btn_Editar_FichaFunc.Text = "Editar";
            this.Btn_Editar_FichaFunc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Editar_FichaFunc.UseAccentColor = true;
            this.Btn_Editar_FichaFunc.UseVisualStyleBackColor = true;
            this.Btn_Editar_FichaFunc.Click += new System.EventHandler(this.Btn_Editar_FichaFunc_Click);
            // 
            // Btn_Consultar_FichaFunc
            // 
            this.Btn_Consultar_FichaFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Consultar_FichaFunc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Consultar_FichaFunc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Consultar_FichaFunc.Depth = 0;
            this.Btn_Consultar_FichaFunc.HighEmphasis = true;
            this.Btn_Consultar_FichaFunc.Icon = null;
            this.Btn_Consultar_FichaFunc.Location = new System.Drawing.Point(126, 434);
            this.Btn_Consultar_FichaFunc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Consultar_FichaFunc.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Consultar_FichaFunc.Name = "Btn_Consultar_FichaFunc";
            this.Btn_Consultar_FichaFunc.Size = new System.Drawing.Size(106, 36);
            this.Btn_Consultar_FichaFunc.TabIndex = 5;
            this.Btn_Consultar_FichaFunc.Text = "Consultar";
            this.toolTip1.SetToolTip(this.Btn_Consultar_FichaFunc, "Entre com o ID do Hóspede no campo \"ID\" e pressione \"CONSULTAR\".\r\n\r\nEm seguida al" +
        "tere os dados desejado e pressione \"EDITAR\" para salvar as alterações.");
            this.Btn_Consultar_FichaFunc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Consultar_FichaFunc.UseAccentColor = true;
            this.Btn_Consultar_FichaFunc.UseVisualStyleBackColor = true;
            this.Btn_Consultar_FichaFunc.Click += new System.EventHandler(this.Btn_Consultar_FichaFunc_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.Lbl_ErroConsulta_Hosp);
            this.materialCard2.Controls.Add(this.Lbl_ErroConsulta);
            this.materialCard2.Controls.Add(this.materialCard13);
            this.materialCard2.Controls.Add(this.materialCard6);
            this.materialCard2.Controls.Add(this.Lbl_ErroCadastro_Funcs);
            this.materialCard2.Controls.Add(this.materialDivider3);
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(17, 17);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(593, 408);
            this.materialCard2.TabIndex = 0;
            // 
            // Lbl_ErroConsulta_Hosp
            // 
            this.Lbl_ErroConsulta_Hosp.AutoSize = true;
            this.Lbl_ErroConsulta_Hosp.Depth = 0;
            this.Lbl_ErroConsulta_Hosp.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_ErroConsulta_Hosp.HighEmphasis = true;
            this.Lbl_ErroConsulta_Hosp.Location = new System.Drawing.Point(319, 12);
            this.Lbl_ErroConsulta_Hosp.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_ErroConsulta_Hosp.Name = "Lbl_ErroConsulta_Hosp";
            this.Lbl_ErroConsulta_Hosp.Size = new System.Drawing.Size(1, 0);
            this.Lbl_ErroConsulta_Hosp.TabIndex = 24;
            this.Lbl_ErroConsulta_Hosp.UseAccent = true;
            this.Lbl_ErroConsulta_Hosp.Visible = false;
            // 
            // Lbl_ErroConsulta
            // 
            this.Lbl_ErroConsulta.AutoSize = true;
            this.Lbl_ErroConsulta.Depth = 0;
            this.Lbl_ErroConsulta.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_ErroConsulta.HighEmphasis = true;
            this.Lbl_ErroConsulta.Location = new System.Drawing.Point(359, 12);
            this.Lbl_ErroConsulta.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_ErroConsulta.Name = "Lbl_ErroConsulta";
            this.Lbl_ErroConsulta.Size = new System.Drawing.Size(1, 0);
            this.Lbl_ErroConsulta.TabIndex = 23;
            this.Lbl_ErroConsulta.UseAccent = true;
            this.Lbl_ErroConsulta.Visible = false;
            // 
            // materialCard13
            // 
            this.materialCard13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard13.Controls.Add(this.materialDivider4);
            this.materialCard13.Controls.Add(this.CKBX_StatusFunc);
            this.materialCard13.Controls.Add(this.Txt_CPF_PesquisarFuncs);
            this.materialCard13.Controls.Add(this.Txt_EmailFunc);
            this.materialCard13.Controls.Add(this.materialDivider10);
            this.materialCard13.Controls.Add(this.Txt_CPF_Func);
            this.materialCard13.Controls.Add(this.materialLabel23);
            this.materialCard13.Controls.Add(this.Txt_NomeFunc);
            this.materialCard13.Depth = 0;
            this.materialCard13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard13.Location = new System.Drawing.Point(9, 57);
            this.materialCard13.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard13.Name = "materialCard13";
            this.materialCard13.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard13.Size = new System.Drawing.Size(262, 310);
            this.materialCard13.TabIndex = 22;
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(59, 107);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(144, 10);
            this.materialDivider4.TabIndex = 23;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // CKBX_StatusFunc
            // 
            this.CKBX_StatusFunc.AutoSize = true;
            this.CKBX_StatusFunc.Depth = 0;
            this.CKBX_StatusFunc.Location = new System.Drawing.Point(14, 259);
            this.CKBX_StatusFunc.Margin = new System.Windows.Forms.Padding(0);
            this.CKBX_StatusFunc.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CKBX_StatusFunc.MouseState = MaterialSkin.MouseState.HOVER;
            this.CKBX_StatusFunc.Name = "CKBX_StatusFunc";
            this.CKBX_StatusFunc.Ripple = true;
            this.CKBX_StatusFunc.Size = new System.Drawing.Size(71, 37);
            this.CKBX_StatusFunc.TabIndex = 22;
            this.CKBX_StatusFunc.Text = "Ativo";
            this.toolTip1.SetToolTip(this.CKBX_StatusFunc, "Em caso o Funcionário esteja de licensa, de férias, etc");
            this.CKBX_StatusFunc.UseVisualStyleBackColor = true;
            // 
            // Txt_CPF_PesquisarFuncs
            // 
            this.Txt_CPF_PesquisarFuncs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_CPF_PesquisarFuncs.Depth = 0;
            this.Txt_CPF_PesquisarFuncs.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_CPF_PesquisarFuncs.Hint = "Pesquisar CPF";
            this.Txt_CPF_PesquisarFuncs.LeadingIcon = null;
            this.Txt_CPF_PesquisarFuncs.Location = new System.Drawing.Point(17, 58);
            this.Txt_CPF_PesquisarFuncs.MaxLength = 11;
            this.Txt_CPF_PesquisarFuncs.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_CPF_PesquisarFuncs.Multiline = false;
            this.Txt_CPF_PesquisarFuncs.Name = "Txt_CPF_PesquisarFuncs";
            this.Txt_CPF_PesquisarFuncs.Size = new System.Drawing.Size(231, 36);
            this.Txt_CPF_PesquisarFuncs.TabIndex = 21;
            this.Txt_CPF_PesquisarFuncs.Text = "";
            this.toolTip1.SetToolTip(this.Txt_CPF_PesquisarFuncs, "Entre com o CPF do Funcionário desejado");
            this.Txt_CPF_PesquisarFuncs.TrailingIcon = global::Sistema_Desktop_para_Hotel.Properties.Resources.Lupa;
            this.Txt_CPF_PesquisarFuncs.UseTallSize = false;
            // 
            // Txt_EmailFunc
            // 
            this.Txt_EmailFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_EmailFunc.Depth = 0;
            this.Txt_EmailFunc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_EmailFunc.Hint = "E-mail";
            this.Txt_EmailFunc.LeadingIcon = null;
            this.Txt_EmailFunc.Location = new System.Drawing.Point(17, 209);
            this.Txt_EmailFunc.MaxLength = 50;
            this.Txt_EmailFunc.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_EmailFunc.Multiline = false;
            this.Txt_EmailFunc.Name = "Txt_EmailFunc";
            this.Txt_EmailFunc.Size = new System.Drawing.Size(231, 36);
            this.Txt_EmailFunc.TabIndex = 10;
            this.Txt_EmailFunc.Text = "";
            this.Txt_EmailFunc.TrailingIcon = null;
            this.Txt_EmailFunc.UseTallSize = false;
            // 
            // materialDivider10
            // 
            this.materialDivider10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider10.Depth = 0;
            this.materialDivider10.Location = new System.Drawing.Point(59, 33);
            this.materialDivider10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider10.Name = "materialDivider10";
            this.materialDivider10.Size = new System.Drawing.Size(144, 10);
            this.materialDivider10.TabIndex = 20;
            this.materialDivider10.Text = "materialDivider10";
            // 
            // Txt_CPF_Func
            // 
            this.Txt_CPF_Func.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_CPF_Func.Depth = 0;
            this.Txt_CPF_Func.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_CPF_Func.Hint = "CPF";
            this.Txt_CPF_Func.LeadingIcon = null;
            this.Txt_CPF_Func.Location = new System.Drawing.Point(17, 170);
            this.Txt_CPF_Func.MaxLength = 11;
            this.Txt_CPF_Func.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_CPF_Func.Multiline = false;
            this.Txt_CPF_Func.Name = "Txt_CPF_Func";
            this.Txt_CPF_Func.Size = new System.Drawing.Size(231, 36);
            this.Txt_CPF_Func.TabIndex = 8;
            this.Txt_CPF_Func.Text = "";
            this.Txt_CPF_Func.TrailingIcon = null;
            this.Txt_CPF_Func.UseTallSize = false;
            // 
            // materialLabel23
            // 
            this.materialLabel23.AutoSize = true;
            this.materialLabel23.Depth = 0;
            this.materialLabel23.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel23.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel23.Location = new System.Drawing.Point(60, 6);
            this.materialLabel23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel23.Name = "materialLabel23";
            this.materialLabel23.Size = new System.Drawing.Size(143, 24);
            this.materialLabel23.TabIndex = 19;
            this.materialLabel23.Text = "Dados Pessoais";
            this.materialLabel23.UseAccent = true;
            // 
            // Txt_NomeFunc
            // 
            this.Txt_NomeFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_NomeFunc.Depth = 0;
            this.Txt_NomeFunc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_NomeFunc.Hint = "Nome";
            this.Txt_NomeFunc.LeadingIcon = null;
            this.Txt_NomeFunc.Location = new System.Drawing.Point(17, 131);
            this.Txt_NomeFunc.MaxLength = 50;
            this.Txt_NomeFunc.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_NomeFunc.Multiline = false;
            this.Txt_NomeFunc.Name = "Txt_NomeFunc";
            this.Txt_NomeFunc.Size = new System.Drawing.Size(231, 36);
            this.Txt_NomeFunc.TabIndex = 7;
            this.Txt_NomeFunc.Text = "";
            this.Txt_NomeFunc.TrailingIcon = null;
            this.Txt_NomeFunc.UseTallSize = false;
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.Txt_CargoFunc);
            this.materialCard6.Controls.Add(this.CKBX_FichaStatusFunc);
            this.materialCard6.Controls.Add(this.materialDivider9);
            this.materialCard6.Controls.Add(this.Txt_CTPS_Func);
            this.materialCard6.Controls.Add(this.materialLabel5);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(322, 57);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(259, 310);
            this.materialCard6.TabIndex = 21;
            // 
            // Txt_CargoFunc
            // 
            this.Txt_CargoFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_CargoFunc.Depth = 0;
            this.Txt_CargoFunc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_CargoFunc.Hint = "Cargo";
            this.Txt_CargoFunc.LeadingIcon = null;
            this.Txt_CargoFunc.Location = new System.Drawing.Point(12, 131);
            this.Txt_CargoFunc.MaxLength = 50;
            this.Txt_CargoFunc.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_CargoFunc.Multiline = false;
            this.Txt_CargoFunc.Name = "Txt_CargoFunc";
            this.Txt_CargoFunc.Size = new System.Drawing.Size(231, 36);
            this.Txt_CargoFunc.TabIndex = 24;
            this.Txt_CargoFunc.Text = "";
            this.Txt_CargoFunc.TrailingIcon = null;
            this.Txt_CargoFunc.UseTallSize = false;
            // 
            // CKBX_FichaStatusFunc
            // 
            this.CKBX_FichaStatusFunc.AutoSize = true;
            this.CKBX_FichaStatusFunc.Depth = 0;
            this.CKBX_FichaStatusFunc.Location = new System.Drawing.Point(12, 224);
            this.CKBX_FichaStatusFunc.Margin = new System.Windows.Forms.Padding(0);
            this.CKBX_FichaStatusFunc.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CKBX_FichaStatusFunc.MouseState = MaterialSkin.MouseState.HOVER;
            this.CKBX_FichaStatusFunc.Name = "CKBX_FichaStatusFunc";
            this.CKBX_FichaStatusFunc.Ripple = true;
            this.CKBX_FichaStatusFunc.Size = new System.Drawing.Size(132, 37);
            this.CKBX_FichaStatusFunc.TabIndex = 23;
            this.CKBX_FichaStatusFunc.Text = "Ficha Ativada";
            this.toolTip1.SetToolTip(this.CKBX_FichaStatusFunc, "Equivalente a deletar a ficha, porém, neste caso é possível reativar a ficha do F" +
        "uncionário");
            this.CKBX_FichaStatusFunc.UseVisualStyleBackColor = true;
            // 
            // materialDivider9
            // 
            this.materialDivider9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider9.Depth = 0;
            this.materialDivider9.Location = new System.Drawing.Point(40, 43);
            this.materialDivider9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider9.Name = "materialDivider9";
            this.materialDivider9.Size = new System.Drawing.Size(179, 10);
            this.materialDivider9.TabIndex = 18;
            this.materialDivider9.Text = "materialDivider9";
            // 
            // Txt_CTPS_Func
            // 
            this.Txt_CTPS_Func.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_CTPS_Func.Depth = 0;
            this.Txt_CTPS_Func.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_CTPS_Func.Hint = "CTPS";
            this.Txt_CTPS_Func.LeadingIcon = null;
            this.Txt_CTPS_Func.Location = new System.Drawing.Point(12, 174);
            this.Txt_CTPS_Func.MaxLength = 11;
            this.Txt_CTPS_Func.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_CTPS_Func.Multiline = false;
            this.Txt_CTPS_Func.Name = "Txt_CTPS_Func";
            this.Txt_CTPS_Func.Size = new System.Drawing.Size(231, 36);
            this.Txt_CTPS_Func.TabIndex = 16;
            this.Txt_CTPS_Func.Text = "";
            this.Txt_CTPS_Func.TrailingIcon = null;
            this.Txt_CTPS_Func.UseTallSize = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(41, 16);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(178, 24);
            this.materialLabel5.TabIndex = 17;
            this.materialLabel5.Text = "Dados Profissionais";
            this.materialLabel5.UseAccent = true;
            // 
            // Lbl_ErroCadastro_Funcs
            // 
            this.Lbl_ErroCadastro_Funcs.AutoSize = true;
            this.Lbl_ErroCadastro_Funcs.Depth = 0;
            this.Lbl_ErroCadastro_Funcs.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_ErroCadastro_Funcs.HighEmphasis = true;
            this.Lbl_ErroCadastro_Funcs.Location = new System.Drawing.Point(278, 12);
            this.Lbl_ErroCadastro_Funcs.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_ErroCadastro_Funcs.Name = "Lbl_ErroCadastro_Funcs";
            this.Lbl_ErroCadastro_Funcs.Size = new System.Drawing.Size(246, 19);
            this.Lbl_ErroCadastro_Funcs.TabIndex = 15;
            this.Lbl_ErroCadastro_Funcs.Text = "Preencha os campos corretamente";
            this.Lbl_ErroCadastro_Funcs.UseAccent = true;
            this.Lbl_ErroCadastro_Funcs.Visible = false;
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(10, 29);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(229, 10);
            this.materialDivider3.TabIndex = 1;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.HighEmphasis = true;
            this.materialLabel2.Location = new System.Drawing.Point(11, 2);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(228, 24);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Cadastro de Funcionários";
            this.materialLabel2.UseAccent = true;
            // 
            // Btn_SalvarCadastro_Func
            // 
            this.Btn_SalvarCadastro_Func.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_SalvarCadastro_Func.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_SalvarCadastro_Func.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_SalvarCadastro_Func.Depth = 0;
            this.Btn_SalvarCadastro_Func.HighEmphasis = true;
            this.Btn_SalvarCadastro_Func.Icon = null;
            this.Btn_SalvarCadastro_Func.Location = new System.Drawing.Point(17, 434);
            this.Btn_SalvarCadastro_Func.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_SalvarCadastro_Func.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_SalvarCadastro_Func.Name = "Btn_SalvarCadastro_Func";
            this.Btn_SalvarCadastro_Func.Size = new System.Drawing.Size(76, 36);
            this.Btn_SalvarCadastro_Func.TabIndex = 3;
            this.Btn_SalvarCadastro_Func.Text = "Salvar";
            this.Btn_SalvarCadastro_Func.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_SalvarCadastro_Func.UseAccentColor = false;
            this.Btn_SalvarCadastro_Func.UseVisualStyleBackColor = true;
            this.Btn_SalvarCadastro_Func.Click += new System.EventHandler(this.Btn_SalvarCadastro_Func_Click);
            // 
            // TabPag_Hospedes
            // 
            this.TabPag_Hospedes.Controls.Add(this.Btn_LimparCampos_Hosp);
            this.TabPag_Hospedes.Controls.Add(this.Btn_ListarTodas_Reservas);
            this.TabPag_Hospedes.Controls.Add(this.Btn_Listar_FichasReservas_Inativas);
            this.TabPag_Hospedes.Controls.Add(this.Btn_Listar_FichasReservas_Ativas);
            this.TabPag_Hospedes.Controls.Add(this.Grid_ListagemHospedes);
            this.TabPag_Hospedes.Controls.Add(this.Btn_Consultar_FichaHospede);
            this.TabPag_Hospedes.Controls.Add(this.Btn_Editar_FichaHospede);
            this.TabPag_Hospedes.Controls.Add(this.Btn_Salvar_CadastroReserva);
            this.TabPag_Hospedes.Controls.Add(this.materialCard5);
            this.TabPag_Hospedes.ImageKey = "Reservas.png";
            this.TabPag_Hospedes.Location = new System.Drawing.Point(4, 39);
            this.TabPag_Hospedes.Name = "TabPag_Hospedes";
            this.TabPag_Hospedes.Padding = new System.Windows.Forms.Padding(3);
            this.TabPag_Hospedes.Size = new System.Drawing.Size(1007, 479);
            this.TabPag_Hospedes.TabIndex = 1;
            this.TabPag_Hospedes.Text = "Hóspedes";
            this.TabPag_Hospedes.UseVisualStyleBackColor = true;
            // 
            // Btn_LimparCampos_Hosp
            // 
            this.Btn_LimparCampos_Hosp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_LimparCampos_Hosp.AutoSize = false;
            this.Btn_LimparCampos_Hosp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_LimparCampos_Hosp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_LimparCampos_Hosp.Depth = 0;
            this.Btn_LimparCampos_Hosp.HighEmphasis = true;
            this.Btn_LimparCampos_Hosp.Icon = null;
            this.Btn_LimparCampos_Hosp.Location = new System.Drawing.Point(408, 434);
            this.Btn_LimparCampos_Hosp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_LimparCampos_Hosp.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_LimparCampos_Hosp.Name = "Btn_LimparCampos_Hosp";
            this.Btn_LimparCampos_Hosp.Size = new System.Drawing.Size(116, 36);
            this.Btn_LimparCampos_Hosp.TabIndex = 27;
            this.Btn_LimparCampos_Hosp.Text = "Limpar Campos";
            this.Btn_LimparCampos_Hosp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_LimparCampos_Hosp.UseAccentColor = false;
            this.Btn_LimparCampos_Hosp.UseVisualStyleBackColor = true;
            this.Btn_LimparCampos_Hosp.Click += new System.EventHandler(this.Btn_LimparCampos_Hosp_Click);
            // 
            // Btn_ListarTodas_Reservas
            // 
            this.Btn_ListarTodas_Reservas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_ListarTodas_Reservas.AutoSize = false;
            this.Btn_ListarTodas_Reservas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_ListarTodas_Reservas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_ListarTodas_Reservas.Depth = 0;
            this.Btn_ListarTodas_Reservas.HighEmphasis = true;
            this.Btn_ListarTodas_Reservas.Icon = null;
            this.Btn_ListarTodas_Reservas.Location = new System.Drawing.Point(690, 434);
            this.Btn_ListarTodas_Reservas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_ListarTodas_Reservas.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_ListarTodas_Reservas.Name = "Btn_ListarTodas_Reservas";
            this.Btn_ListarTodas_Reservas.Size = new System.Drawing.Size(130, 36);
            this.Btn_ListarTodas_Reservas.TabIndex = 25;
            this.Btn_ListarTodas_Reservas.Text = "Listar Tudo";
            this.Btn_ListarTodas_Reservas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_ListarTodas_Reservas.UseAccentColor = true;
            this.Btn_ListarTodas_Reservas.UseVisualStyleBackColor = true;
            this.Btn_ListarTodas_Reservas.Click += new System.EventHandler(this.Btn_ListarTodas_Reservas_Click);
            // 
            // Btn_Listar_FichasReservas_Inativas
            // 
            this.Btn_Listar_FichasReservas_Inativas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Listar_FichasReservas_Inativas.AutoSize = false;
            this.Btn_Listar_FichasReservas_Inativas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Listar_FichasReservas_Inativas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Listar_FichasReservas_Inativas.Depth = 0;
            this.Btn_Listar_FichasReservas_Inativas.HighEmphasis = true;
            this.Btn_Listar_FichasReservas_Inativas.Icon = null;
            this.Btn_Listar_FichasReservas_Inativas.Location = new System.Drawing.Point(838, 434);
            this.Btn_Listar_FichasReservas_Inativas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Listar_FichasReservas_Inativas.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Listar_FichasReservas_Inativas.Name = "Btn_Listar_FichasReservas_Inativas";
            this.Btn_Listar_FichasReservas_Inativas.Size = new System.Drawing.Size(130, 36);
            this.Btn_Listar_FichasReservas_Inativas.TabIndex = 23;
            this.Btn_Listar_FichasReservas_Inativas.Text = "Listar Reservas Inativas";
            this.Btn_Listar_FichasReservas_Inativas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Listar_FichasReservas_Inativas.UseAccentColor = false;
            this.Btn_Listar_FichasReservas_Inativas.UseVisualStyleBackColor = true;
            this.Btn_Listar_FichasReservas_Inativas.Click += new System.EventHandler(this.Btn_Listar_FichasReservas_Inativas_Click);
            // 
            // Btn_Listar_FichasReservas_Ativas
            // 
            this.Btn_Listar_FichasReservas_Ativas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Listar_FichasReservas_Ativas.AutoSize = false;
            this.Btn_Listar_FichasReservas_Ativas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Listar_FichasReservas_Ativas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Listar_FichasReservas_Ativas.Depth = 0;
            this.Btn_Listar_FichasReservas_Ativas.HighEmphasis = true;
            this.Btn_Listar_FichasReservas_Ativas.Icon = null;
            this.Btn_Listar_FichasReservas_Ativas.Location = new System.Drawing.Point(542, 434);
            this.Btn_Listar_FichasReservas_Ativas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Listar_FichasReservas_Ativas.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Listar_FichasReservas_Ativas.Name = "Btn_Listar_FichasReservas_Ativas";
            this.Btn_Listar_FichasReservas_Ativas.Size = new System.Drawing.Size(130, 36);
            this.Btn_Listar_FichasReservas_Ativas.TabIndex = 22;
            this.Btn_Listar_FichasReservas_Ativas.Text = "Listar Reservas Ativas";
            this.Btn_Listar_FichasReservas_Ativas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Listar_FichasReservas_Ativas.UseAccentColor = false;
            this.Btn_Listar_FichasReservas_Ativas.UseVisualStyleBackColor = true;
            this.Btn_Listar_FichasReservas_Ativas.Click += new System.EventHandler(this.Btn_Listar_FichasReservas_Ativas_Click);
            // 
            // Grid_ListagemHospedes
            // 
            this.Grid_ListagemHospedes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Grid_ListagemHospedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Grid_ListagemHospedes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Grid_ListagemHospedes.BackgroundColor = System.Drawing.Color.White;
            this.Grid_ListagemHospedes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_ListagemHospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ListagemHospedes.Location = new System.Drawing.Point(587, 14);
            this.Grid_ListagemHospedes.Name = "Grid_ListagemHospedes";
            this.Grid_ListagemHospedes.Size = new System.Drawing.Size(414, 404);
            this.Grid_ListagemHospedes.TabIndex = 10;
            // 
            // Btn_Consultar_FichaHospede
            // 
            this.Btn_Consultar_FichaHospede.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Consultar_FichaHospede.AutoSize = false;
            this.Btn_Consultar_FichaHospede.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Consultar_FichaHospede.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Consultar_FichaHospede.Depth = 0;
            this.Btn_Consultar_FichaHospede.HighEmphasis = true;
            this.Btn_Consultar_FichaHospede.Icon = null;
            this.Btn_Consultar_FichaHospede.Location = new System.Drawing.Point(140, 434);
            this.Btn_Consultar_FichaHospede.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Consultar_FichaHospede.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Consultar_FichaHospede.Name = "Btn_Consultar_FichaHospede";
            this.Btn_Consultar_FichaHospede.Size = new System.Drawing.Size(116, 36);
            this.Btn_Consultar_FichaHospede.TabIndex = 8;
            this.Btn_Consultar_FichaHospede.Text = "Consultar";
            this.toolTip1.SetToolTip(this.Btn_Consultar_FichaHospede, "Entre com o ID do Hóspede no campo \"ID\" e pressione \"CONSULTAR\".\r\n\r\nEm seguida Ed" +
        "ite os dados desejados pressione \"EDITAR\" para salvar as alterações.\r\n");
            this.Btn_Consultar_FichaHospede.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Consultar_FichaHospede.UseAccentColor = true;
            this.Btn_Consultar_FichaHospede.UseVisualStyleBackColor = true;
            this.Btn_Consultar_FichaHospede.Click += new System.EventHandler(this.Btn_Consultar_FichaHospede_Click);
            // 
            // Btn_Editar_FichaHospede
            // 
            this.Btn_Editar_FichaHospede.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Editar_FichaHospede.AutoSize = false;
            this.Btn_Editar_FichaHospede.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Editar_FichaHospede.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Editar_FichaHospede.Depth = 0;
            this.Btn_Editar_FichaHospede.Enabled = false;
            this.Btn_Editar_FichaHospede.HighEmphasis = true;
            this.Btn_Editar_FichaHospede.Icon = null;
            this.Btn_Editar_FichaHospede.Location = new System.Drawing.Point(274, 434);
            this.Btn_Editar_FichaHospede.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Editar_FichaHospede.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Editar_FichaHospede.Name = "Btn_Editar_FichaHospede";
            this.Btn_Editar_FichaHospede.Size = new System.Drawing.Size(116, 36);
            this.Btn_Editar_FichaHospede.TabIndex = 7;
            this.Btn_Editar_FichaHospede.Text = "Editar";
            this.Btn_Editar_FichaHospede.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Editar_FichaHospede.UseAccentColor = true;
            this.Btn_Editar_FichaHospede.UseVisualStyleBackColor = true;
            this.Btn_Editar_FichaHospede.Click += new System.EventHandler(this.Btn_Editar_FichaHospede_Click);
            // 
            // Btn_Salvar_CadastroReserva
            // 
            this.Btn_Salvar_CadastroReserva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Salvar_CadastroReserva.AutoSize = false;
            this.Btn_Salvar_CadastroReserva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Salvar_CadastroReserva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Salvar_CadastroReserva.Depth = 0;
            this.Btn_Salvar_CadastroReserva.HighEmphasis = true;
            this.Btn_Salvar_CadastroReserva.Icon = null;
            this.Btn_Salvar_CadastroReserva.Location = new System.Drawing.Point(6, 434);
            this.Btn_Salvar_CadastroReserva.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Salvar_CadastroReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Salvar_CadastroReserva.Name = "Btn_Salvar_CadastroReserva";
            this.Btn_Salvar_CadastroReserva.Size = new System.Drawing.Size(116, 36);
            this.Btn_Salvar_CadastroReserva.TabIndex = 6;
            this.Btn_Salvar_CadastroReserva.Text = "Salvar Cadastro";
            this.Btn_Salvar_CadastroReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Salvar_CadastroReserva.UseAccentColor = false;
            this.Btn_Salvar_CadastroReserva.UseVisualStyleBackColor = true;
            this.Btn_Salvar_CadastroReserva.Click += new System.EventHandler(this.Btn_Salvar_CadastroReserva_Click);
            // 
            // materialCard5
            // 
            this.materialCard5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.Lbl_Pagamento_Total);
            this.materialCard5.Controls.Add(this.materialLabel24);
            this.materialCard5.Controls.Add(this.CKBX_ReservaAtivada);
            this.materialCard5.Controls.Add(this.CKBX_HospedesAtivo);
            this.materialCard5.Controls.Add(this.Txt_PesquisarCPF_Hosp);
            this.materialCard5.Controls.Add(this.Lbl_ErroCadastro);
            this.materialCard5.Controls.Add(this.Txt_CartaoHospede);
            this.materialCard5.Controls.Add(this.Txt_NumQuarto_Hospede);
            this.materialCard5.Controls.Add(this.materialLabel8);
            this.materialCard5.Controls.Add(this.materialLabel9);
            this.materialCard5.Controls.Add(this.Date_CheckIn_Hospede);
            this.materialCard5.Controls.Add(this.Date_CheckOut_Hospede);
            this.materialCard5.Controls.Add(this.Combobx_CategoriaQuarto_Hospede);
            this.materialCard5.Controls.Add(this.materialDivider7);
            this.materialCard5.Controls.Add(this.materialLabel10);
            this.materialCard5.Controls.Add(this.materialDivider6);
            this.materialCard5.Controls.Add(this.Txt_CPF_Hospede);
            this.materialCard5.Controls.Add(this.Txt_EmailHospede);
            this.materialCard5.Controls.Add(this.Txt_CelularHospede);
            this.materialCard5.Controls.Add(this.Txt_NomeHospede);
            this.materialCard5.Controls.Add(this.materialDivider5);
            this.materialCard5.Controls.Add(this.materialLabel7);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(10, 14);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(573, 404);
            this.materialCard5.TabIndex = 1;
            // 
            // Lbl_Pagamento_Total
            // 
            this.Lbl_Pagamento_Total.AutoSize = true;
            this.Lbl_Pagamento_Total.Depth = 0;
            this.Lbl_Pagamento_Total.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Pagamento_Total.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.Lbl_Pagamento_Total.HighEmphasis = true;
            this.Lbl_Pagamento_Total.Location = new System.Drawing.Point(440, 150);
            this.Lbl_Pagamento_Total.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Pagamento_Total.Name = "Lbl_Pagamento_Total";
            this.Lbl_Pagamento_Total.Size = new System.Drawing.Size(1, 0);
            this.Lbl_Pagamento_Total.TabIndex = 27;
            this.Lbl_Pagamento_Total.UseAccent = true;
            // 
            // materialLabel24
            // 
            this.materialLabel24.AutoSize = true;
            this.materialLabel24.Depth = 0;
            this.materialLabel24.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel24.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel24.HighEmphasis = true;
            this.materialLabel24.Location = new System.Drawing.Point(410, 150);
            this.materialLabel24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel24.Name = "materialLabel24";
            this.materialLabel24.Size = new System.Drawing.Size(24, 24);
            this.materialLabel24.TabIndex = 26;
            this.materialLabel24.Text = "R$";
            this.materialLabel24.UseAccent = true;
            // 
            // CKBX_ReservaAtivada
            // 
            this.CKBX_ReservaAtivada.AutoSize = true;
            this.CKBX_ReservaAtivada.Depth = 0;
            this.CKBX_ReservaAtivada.Location = new System.Drawing.Point(235, 357);
            this.CKBX_ReservaAtivada.Margin = new System.Windows.Forms.Padding(0);
            this.CKBX_ReservaAtivada.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CKBX_ReservaAtivada.MouseState = MaterialSkin.MouseState.HOVER;
            this.CKBX_ReservaAtivada.Name = "CKBX_ReservaAtivada";
            this.CKBX_ReservaAtivada.Ripple = true;
            this.CKBX_ReservaAtivada.Size = new System.Drawing.Size(149, 37);
            this.CKBX_ReservaAtivada.TabIndex = 25;
            this.CKBX_ReservaAtivada.Text = "Reserva Ativada";
            this.toolTip1.SetToolTip(this.CKBX_ReservaAtivada, "Em caso do Hóspede quiser cancelar a reserva, basta não marcar/desmarcar esta opç" +
        "ão");
            this.CKBX_ReservaAtivada.UseVisualStyleBackColor = true;
            // 
            // CKBX_HospedesAtivo
            // 
            this.CKBX_HospedesAtivo.AutoSize = true;
            this.CKBX_HospedesAtivo.Depth = 0;
            this.CKBX_HospedesAtivo.Location = new System.Drawing.Point(11, 360);
            this.CKBX_HospedesAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.CKBX_HospedesAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CKBX_HospedesAtivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.CKBX_HospedesAtivo.Name = "CKBX_HospedesAtivo";
            this.CKBX_HospedesAtivo.Ripple = true;
            this.CKBX_HospedesAtivo.Size = new System.Drawing.Size(137, 37);
            this.CKBX_HospedesAtivo.TabIndex = 24;
            this.CKBX_HospedesAtivo.Text = "Hóspede Ativo";
            this.CKBX_HospedesAtivo.UseVisualStyleBackColor = true;
            // 
            // Txt_PesquisarCPF_Hosp
            // 
            this.Txt_PesquisarCPF_Hosp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_PesquisarCPF_Hosp.Depth = 0;
            this.Txt_PesquisarCPF_Hosp.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_PesquisarCPF_Hosp.Hint = "Pesquisar CPF";
            this.Txt_PesquisarCPF_Hosp.LeadingIcon = null;
            this.Txt_PesquisarCPF_Hosp.Location = new System.Drawing.Point(11, 102);
            this.Txt_PesquisarCPF_Hosp.MaxLength = 11;
            this.Txt_PesquisarCPF_Hosp.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_PesquisarCPF_Hosp.Multiline = false;
            this.Txt_PesquisarCPF_Hosp.Name = "Txt_PesquisarCPF_Hosp";
            this.Txt_PesquisarCPF_Hosp.Size = new System.Drawing.Size(203, 36);
            this.Txt_PesquisarCPF_Hosp.TabIndex = 23;
            this.Txt_PesquisarCPF_Hosp.Text = "";
            this.toolTip1.SetToolTip(this.Txt_PesquisarCPF_Hosp, "Inserir CPF do Hóspede para realizar consulta de seus dados");
            this.Txt_PesquisarCPF_Hosp.TrailingIcon = global::Sistema_Desktop_para_Hotel.Properties.Resources.Lupa;
            this.Txt_PesquisarCPF_Hosp.UseTallSize = false;
            // 
            // Lbl_ErroCadastro
            // 
            this.Lbl_ErroCadastro.AutoSize = true;
            this.Lbl_ErroCadastro.Depth = 0;
            this.Lbl_ErroCadastro.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_ErroCadastro.HighEmphasis = true;
            this.Lbl_ErroCadastro.Location = new System.Drawing.Point(236, 14);
            this.Lbl_ErroCadastro.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_ErroCadastro.Name = "Lbl_ErroCadastro";
            this.Lbl_ErroCadastro.Size = new System.Drawing.Size(246, 19);
            this.Lbl_ErroCadastro.TabIndex = 22;
            this.Lbl_ErroCadastro.Text = "Preencha os campos corretamente";
            this.Lbl_ErroCadastro.UseAccent = true;
            this.Lbl_ErroCadastro.Visible = false;
            // 
            // Txt_CartaoHospede
            // 
            this.Txt_CartaoHospede.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_CartaoHospede.Depth = 0;
            this.Txt_CartaoHospede.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_CartaoHospede.Hint = "Cartão";
            this.Txt_CartaoHospede.LeadingIcon = null;
            this.Txt_CartaoHospede.Location = new System.Drawing.Point(236, 144);
            this.Txt_CartaoHospede.MaxLength = 16;
            this.Txt_CartaoHospede.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_CartaoHospede.Multiline = false;
            this.Txt_CartaoHospede.Name = "Txt_CartaoHospede";
            this.Txt_CartaoHospede.Size = new System.Drawing.Size(161, 36);
            this.Txt_CartaoHospede.TabIndex = 19;
            this.Txt_CartaoHospede.Text = "";
            this.Txt_CartaoHospede.TrailingIcon = null;
            this.Txt_CartaoHospede.UseTallSize = false;
            // 
            // Txt_NumQuarto_Hospede
            // 
            this.Txt_NumQuarto_Hospede.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_NumQuarto_Hospede.Depth = 0;
            this.Txt_NumQuarto_Hospede.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_NumQuarto_Hospede.Hint = "Número do Quarto";
            this.Txt_NumQuarto_Hospede.LeadingIcon = null;
            this.Txt_NumQuarto_Hospede.Location = new System.Drawing.Point(235, 186);
            this.Txt_NumQuarto_Hospede.MaxLength = 2;
            this.Txt_NumQuarto_Hospede.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_NumQuarto_Hospede.Multiline = false;
            this.Txt_NumQuarto_Hospede.Name = "Txt_NumQuarto_Hospede";
            this.Txt_NumQuarto_Hospede.Size = new System.Drawing.Size(161, 36);
            this.Txt_NumQuarto_Hospede.TabIndex = 18;
            this.Txt_NumQuarto_Hospede.Text = "";
            this.Txt_NumQuarto_Hospede.TrailingIcon = null;
            this.Txt_NumQuarto_Hospede.UseTallSize = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.HighEmphasis = true;
            this.materialLabel8.Location = new System.Drawing.Point(239, 284);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(80, 24);
            this.materialLabel8.TabIndex = 17;
            this.materialLabel8.Text = "Check-In";
            this.materialLabel8.UseAccent = true;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel9.HighEmphasis = true;
            this.materialLabel9.Location = new System.Drawing.Point(239, 319);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(88, 24);
            this.materialLabel9.TabIndex = 16;
            this.materialLabel9.Text = "CheckOut";
            this.materialLabel9.UseAccent = true;
            // 
            // Date_CheckIn_Hospede
            // 
            this.Date_CheckIn_Hospede.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Date_CheckIn_Hospede.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_CheckIn_Hospede.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_CheckIn_Hospede.Location = new System.Drawing.Point(403, 284);
            this.Date_CheckIn_Hospede.Name = "Date_CheckIn_Hospede";
            this.Date_CheckIn_Hospede.Size = new System.Drawing.Size(128, 29);
            this.Date_CheckIn_Hospede.TabIndex = 15;
            this.Date_CheckIn_Hospede.Value = new System.DateTime(2021, 11, 2, 0, 0, 0, 0);
            // 
            // Date_CheckOut_Hospede
            // 
            this.Date_CheckOut_Hospede.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_CheckOut_Hospede.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_CheckOut_Hospede.Location = new System.Drawing.Point(403, 319);
            this.Date_CheckOut_Hospede.Name = "Date_CheckOut_Hospede";
            this.Date_CheckOut_Hospede.Size = new System.Drawing.Size(128, 29);
            this.Date_CheckOut_Hospede.TabIndex = 14;
            // 
            // Combobx_CategoriaQuarto_Hospede
            // 
            this.Combobx_CategoriaQuarto_Hospede.AutoResize = false;
            this.Combobx_CategoriaQuarto_Hospede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Combobx_CategoriaQuarto_Hospede.Depth = 0;
            this.Combobx_CategoriaQuarto_Hospede.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Combobx_CategoriaQuarto_Hospede.DropDownHeight = 118;
            this.Combobx_CategoriaQuarto_Hospede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobx_CategoriaQuarto_Hospede.DropDownWidth = 121;
            this.Combobx_CategoriaQuarto_Hospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Combobx_CategoriaQuarto_Hospede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Combobx_CategoriaQuarto_Hospede.FormattingEnabled = true;
            this.Combobx_CategoriaQuarto_Hospede.Hint = "Categoria de Quartos";
            this.Combobx_CategoriaQuarto_Hospede.IntegralHeight = false;
            this.Combobx_CategoriaQuarto_Hospede.ItemHeight = 29;
            this.Combobx_CategoriaQuarto_Hospede.Items.AddRange(new object[] {
            "Standard",
            "Master",
            "Deluxe"});
            this.Combobx_CategoriaQuarto_Hospede.Location = new System.Drawing.Point(403, 187);
            this.Combobx_CategoriaQuarto_Hospede.MaxDropDownItems = 4;
            this.Combobx_CategoriaQuarto_Hospede.MouseState = MaterialSkin.MouseState.OUT;
            this.Combobx_CategoriaQuarto_Hospede.Name = "Combobx_CategoriaQuarto_Hospede";
            this.Combobx_CategoriaQuarto_Hospede.Size = new System.Drawing.Size(159, 35);
            this.Combobx_CategoriaQuarto_Hospede.StartIndex = 0;
            this.Combobx_CategoriaQuarto_Hospede.TabIndex = 12;
            this.Combobx_CategoriaQuarto_Hospede.UseTallSize = false;
            // 
            // materialDivider7
            // 
            this.materialDivider7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider7.Depth = 0;
            this.materialDivider7.Location = new System.Drawing.Point(238, 86);
            this.materialDivider7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider7.Name = "materialDivider7";
            this.materialDivider7.Size = new System.Drawing.Size(158, 10);
            this.materialDivider7.TabIndex = 11;
            this.materialDivider7.Text = "materialDivider7";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel10.Location = new System.Drawing.Point(237, 58);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(160, 24);
            this.materialLabel10.TabIndex = 10;
            this.materialLabel10.Text = "Realizar Reservas";
            this.materialLabel10.UseAccent = true;
            // 
            // materialDivider6
            // 
            this.materialDivider6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider6.Depth = 0;
            this.materialDivider6.Location = new System.Drawing.Point(220, 53);
            this.materialDivider6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider6.Name = "materialDivider6";
            this.materialDivider6.Size = new System.Drawing.Size(10, 334);
            this.materialDivider6.TabIndex = 9;
            this.materialDivider6.Text = "materialDivider6";
            // 
            // Txt_CPF_Hospede
            // 
            this.Txt_CPF_Hospede.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_CPF_Hospede.Depth = 0;
            this.Txt_CPF_Hospede.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_CPF_Hospede.Hint = "CPF";
            this.Txt_CPF_Hospede.LeadingIcon = null;
            this.Txt_CPF_Hospede.Location = new System.Drawing.Point(11, 226);
            this.Txt_CPF_Hospede.MaxLength = 11;
            this.Txt_CPF_Hospede.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_CPF_Hospede.Multiline = false;
            this.Txt_CPF_Hospede.Name = "Txt_CPF_Hospede";
            this.Txt_CPF_Hospede.Size = new System.Drawing.Size(203, 36);
            this.Txt_CPF_Hospede.TabIndex = 8;
            this.Txt_CPF_Hospede.Text = "";
            this.Txt_CPF_Hospede.TrailingIcon = null;
            this.Txt_CPF_Hospede.UseTallSize = false;
            // 
            // Txt_EmailHospede
            // 
            this.Txt_EmailHospede.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_EmailHospede.Depth = 0;
            this.Txt_EmailHospede.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_EmailHospede.Hint = "E-mail";
            this.Txt_EmailHospede.LeadingIcon = null;
            this.Txt_EmailHospede.Location = new System.Drawing.Point(11, 306);
            this.Txt_EmailHospede.MaxLength = 50;
            this.Txt_EmailHospede.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_EmailHospede.Multiline = false;
            this.Txt_EmailHospede.Name = "Txt_EmailHospede";
            this.Txt_EmailHospede.Size = new System.Drawing.Size(203, 36);
            this.Txt_EmailHospede.TabIndex = 7;
            this.Txt_EmailHospede.Text = "";
            this.Txt_EmailHospede.TrailingIcon = null;
            this.Txt_EmailHospede.UseTallSize = false;
            // 
            // Txt_CelularHospede
            // 
            this.Txt_CelularHospede.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_CelularHospede.Depth = 0;
            this.Txt_CelularHospede.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_CelularHospede.Hint = "Celular";
            this.Txt_CelularHospede.LeadingIcon = null;
            this.Txt_CelularHospede.Location = new System.Drawing.Point(11, 266);
            this.Txt_CelularHospede.MaxLength = 11;
            this.Txt_CelularHospede.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_CelularHospede.Multiline = false;
            this.Txt_CelularHospede.Name = "Txt_CelularHospede";
            this.Txt_CelularHospede.Size = new System.Drawing.Size(203, 36);
            this.Txt_CelularHospede.TabIndex = 5;
            this.Txt_CelularHospede.Text = "";
            this.Txt_CelularHospede.TrailingIcon = null;
            this.Txt_CelularHospede.UseTallSize = false;
            // 
            // Txt_NomeHospede
            // 
            this.Txt_NomeHospede.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_NomeHospede.Depth = 0;
            this.Txt_NomeHospede.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_NomeHospede.Hint = "Nome";
            this.Txt_NomeHospede.LeadingIcon = null;
            this.Txt_NomeHospede.Location = new System.Drawing.Point(11, 186);
            this.Txt_NomeHospede.MaxLength = 50;
            this.Txt_NomeHospede.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_NomeHospede.Multiline = false;
            this.Txt_NomeHospede.Name = "Txt_NomeHospede";
            this.Txt_NomeHospede.Size = new System.Drawing.Size(203, 36);
            this.Txt_NomeHospede.TabIndex = 2;
            this.Txt_NomeHospede.Text = "";
            this.Txt_NomeHospede.TrailingIcon = null;
            this.Txt_NomeHospede.UseTallSize = false;
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(15, 83);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(199, 10);
            this.materialDivider5.TabIndex = 1;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.HighEmphasis = true;
            this.materialLabel7.Location = new System.Drawing.Point(11, 55);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(203, 24);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Cadastro de Hóspedes";
            this.materialLabel7.UseAccent = true;
            // 
            // TabPag_Relatorios
            // 
            this.TabPag_Relatorios.Controls.Add(this.materialCard8);
            this.TabPag_Relatorios.ImageKey = "Relatórios.png";
            this.TabPag_Relatorios.Location = new System.Drawing.Point(4, 39);
            this.TabPag_Relatorios.Name = "TabPag_Relatorios";
            this.TabPag_Relatorios.Size = new System.Drawing.Size(1007, 479);
            this.TabPag_Relatorios.TabIndex = 4;
            this.TabPag_Relatorios.Text = "Relatórios";
            this.TabPag_Relatorios.UseVisualStyleBackColor = true;
            // 
            // materialCard8
            // 
            this.materialCard8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialCard8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard8.Controls.Add(this.Btn_AtualizarRelatórios);
            this.materialCard8.Controls.Add(this.materialDivider11);
            this.materialCard8.Controls.Add(this.materialLabel3);
            this.materialCard8.Controls.Add(this.materialDivider14);
            this.materialCard8.Controls.Add(this.materialDivider13);
            this.materialCard8.Controls.Add(this.materialLabel22);
            this.materialCard8.Controls.Add(this.materialCard12);
            this.materialCard8.Controls.Add(this.materialCard11);
            this.materialCard8.Controls.Add(this.materialCard10);
            this.materialCard8.Controls.Add(this.materialCard9);
            this.materialCard8.Controls.Add(this.materialDivider12);
            this.materialCard8.Controls.Add(this.materialLabel13);
            this.materialCard8.Depth = 0;
            this.materialCard8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard8.Location = new System.Drawing.Point(135, 62);
            this.materialCard8.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard8.Name = "materialCard8";
            this.materialCard8.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard8.Size = new System.Drawing.Size(737, 319);
            this.materialCard8.TabIndex = 0;
            // 
            // Btn_AtualizarRelatórios
            // 
            this.Btn_AtualizarRelatórios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_AtualizarRelatórios.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.Btn_AtualizarRelatórios.Depth = 0;
            this.Btn_AtualizarRelatórios.HighEmphasis = true;
            this.Btn_AtualizarRelatórios.Icon = null;
            this.Btn_AtualizarRelatórios.Location = new System.Drawing.Point(448, 242);
            this.Btn_AtualizarRelatórios.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_AtualizarRelatórios.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_AtualizarRelatórios.Name = "Btn_AtualizarRelatórios";
            this.Btn_AtualizarRelatórios.Size = new System.Drawing.Size(190, 36);
            this.Btn_AtualizarRelatórios.TabIndex = 10;
            this.Btn_AtualizarRelatórios.Text = "Atualizar Relatórios";
            this.Btn_AtualizarRelatórios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_AtualizarRelatórios.UseAccentColor = true;
            this.Btn_AtualizarRelatórios.UseVisualStyleBackColor = true;
            this.Btn_AtualizarRelatórios.Click += new System.EventHandler(this.Btn_AtualizarRelatórios_Click);
            // 
            // materialDivider11
            // 
            this.materialDivider11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider11.Depth = 0;
            this.materialDivider11.Location = new System.Drawing.Point(72, 209);
            this.materialDivider11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider11.Name = "materialDivider11";
            this.materialDivider11.Size = new System.Drawing.Size(176, 10);
            this.materialDivider11.TabIndex = 9;
            this.materialDivider11.Text = "materialDivider11";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.HighEmphasis = true;
            this.materialLabel3.Location = new System.Drawing.Point(115, 182);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(90, 24);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Hóspedes";
            this.materialLabel3.UseAccent = true;
            // 
            // materialDivider14
            // 
            this.materialDivider14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider14.Depth = 0;
            this.materialDivider14.Location = new System.Drawing.Point(363, 18);
            this.materialDivider14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider14.Name = "materialDivider14";
            this.materialDivider14.Size = new System.Drawing.Size(10, 284);
            this.materialDivider14.TabIndex = 7;
            this.materialDivider14.Text = "materialDivider14";
            // 
            // materialDivider13
            // 
            this.materialDivider13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider13.Depth = 0;
            this.materialDivider13.Location = new System.Drawing.Point(477, 46);
            this.materialDivider13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider13.Name = "materialDivider13";
            this.materialDivider13.Size = new System.Drawing.Size(133, 10);
            this.materialDivider13.TabIndex = 6;
            this.materialDivider13.Text = "materialDivider13";
            // 
            // materialLabel22
            // 
            this.materialLabel22.AutoSize = true;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel22.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel22.HighEmphasis = true;
            this.materialLabel22.Location = new System.Drawing.Point(488, 18);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(110, 24);
            this.materialLabel22.TabIndex = 5;
            this.materialLabel22.Text = "Ganho Total";
            this.materialLabel22.UseAccent = true;
            // 
            // materialCard12
            // 
            this.materialCard12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard12.Controls.Add(this.Lbl_Relatorio_GanhoTotal);
            this.materialCard12.Controls.Add(this.materialLabel21);
            this.materialCard12.Depth = 0;
            this.materialCard12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard12.Location = new System.Drawing.Point(432, 78);
            this.materialCard12.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard12.Name = "materialCard12";
            this.materialCard12.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard12.Size = new System.Drawing.Size(222, 44);
            this.materialCard12.TabIndex = 4;
            // 
            // Lbl_Relatorio_GanhoTotal
            // 
            this.Lbl_Relatorio_GanhoTotal.AutoSize = true;
            this.Lbl_Relatorio_GanhoTotal.Depth = 0;
            this.Lbl_Relatorio_GanhoTotal.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Relatorio_GanhoTotal.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.Lbl_Relatorio_GanhoTotal.Location = new System.Drawing.Point(41, 10);
            this.Lbl_Relatorio_GanhoTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Relatorio_GanhoTotal.Name = "Lbl_Relatorio_GanhoTotal";
            this.Lbl_Relatorio_GanhoTotal.Size = new System.Drawing.Size(1, 0);
            this.Lbl_Relatorio_GanhoTotal.TabIndex = 2;
            this.Lbl_Relatorio_GanhoTotal.UseAccent = true;
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel21.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel21.Location = new System.Drawing.Point(8, 10);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(24, 24);
            this.materialLabel21.TabIndex = 1;
            this.materialLabel21.Text = "R$";
            this.materialLabel21.UseAccent = true;
            // 
            // materialCard11
            // 
            this.materialCard11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard11.Controls.Add(this.Lbl_Relatorio_FuncsInativos);
            this.materialCard11.Controls.Add(this.materialLabel19);
            this.materialCard11.Depth = 0;
            this.materialCard11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard11.Location = new System.Drawing.Point(49, 124);
            this.materialCard11.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard11.Name = "materialCard11";
            this.materialCard11.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard11.Size = new System.Drawing.Size(222, 44);
            this.materialCard11.TabIndex = 3;
            // 
            // Lbl_Relatorio_FuncsInativos
            // 
            this.Lbl_Relatorio_FuncsInativos.AutoSize = true;
            this.Lbl_Relatorio_FuncsInativos.Depth = 0;
            this.Lbl_Relatorio_FuncsInativos.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Relatorio_FuncsInativos.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.Lbl_Relatorio_FuncsInativos.Location = new System.Drawing.Point(96, 10);
            this.Lbl_Relatorio_FuncsInativos.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Relatorio_FuncsInativos.Name = "Lbl_Relatorio_FuncsInativos";
            this.Lbl_Relatorio_FuncsInativos.Size = new System.Drawing.Size(1, 0);
            this.Lbl_Relatorio_FuncsInativos.TabIndex = 2;
            this.Lbl_Relatorio_FuncsInativos.UseAccent = true;
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel19.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel19.Location = new System.Drawing.Point(8, 10);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(82, 24);
            this.materialLabel19.TabIndex = 1;
            this.materialLabel19.Text = "Inativos: ";
            this.materialLabel19.UseAccent = true;
            // 
            // materialCard10
            // 
            this.materialCard10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard10.Controls.Add(this.Lbl_Relatorio_ReservasAtivas);
            this.materialCard10.Controls.Add(this.materialLabel17);
            this.materialCard10.Depth = 0;
            this.materialCard10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard10.Location = new System.Drawing.Point(49, 236);
            this.materialCard10.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard10.Name = "materialCard10";
            this.materialCard10.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard10.Size = new System.Drawing.Size(222, 44);
            this.materialCard10.TabIndex = 3;
            // 
            // Lbl_Relatorio_ReservasAtivas
            // 
            this.Lbl_Relatorio_ReservasAtivas.AutoSize = true;
            this.Lbl_Relatorio_ReservasAtivas.Depth = 0;
            this.Lbl_Relatorio_ReservasAtivas.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Relatorio_ReservasAtivas.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.Lbl_Relatorio_ReservasAtivas.Location = new System.Drawing.Point(81, 10);
            this.Lbl_Relatorio_ReservasAtivas.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Relatorio_ReservasAtivas.Name = "Lbl_Relatorio_ReservasAtivas";
            this.Lbl_Relatorio_ReservasAtivas.Size = new System.Drawing.Size(1, 0);
            this.Lbl_Relatorio_ReservasAtivas.TabIndex = 2;
            this.Lbl_Relatorio_ReservasAtivas.UseAccent = true;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel17.Location = new System.Drawing.Point(8, 10);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(67, 24);
            this.materialLabel17.TabIndex = 1;
            this.materialLabel17.Text = "Ativos: ";
            this.materialLabel17.UseAccent = true;
            // 
            // materialCard9
            // 
            this.materialCard9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard9.Controls.Add(this.Lbl_Relatorio_FuncsAtivos);
            this.materialCard9.Controls.Add(this.materialLabel);
            this.materialCard9.Depth = 0;
            this.materialCard9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard9.Location = new System.Drawing.Point(49, 64);
            this.materialCard9.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard9.Name = "materialCard9";
            this.materialCard9.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard9.Size = new System.Drawing.Size(222, 44);
            this.materialCard9.TabIndex = 2;
            // 
            // Lbl_Relatorio_FuncsAtivos
            // 
            this.Lbl_Relatorio_FuncsAtivos.AutoSize = true;
            this.Lbl_Relatorio_FuncsAtivos.Depth = 0;
            this.Lbl_Relatorio_FuncsAtivos.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Relatorio_FuncsAtivos.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.Lbl_Relatorio_FuncsAtivos.Location = new System.Drawing.Point(81, 10);
            this.Lbl_Relatorio_FuncsAtivos.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Relatorio_FuncsAtivos.Name = "Lbl_Relatorio_FuncsAtivos";
            this.Lbl_Relatorio_FuncsAtivos.Size = new System.Drawing.Size(1, 0);
            this.Lbl_Relatorio_FuncsAtivos.TabIndex = 2;
            this.Lbl_Relatorio_FuncsAtivos.UseAccent = true;
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Depth = 0;
            this.materialLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel.Location = new System.Drawing.Point(8, 10);
            this.materialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(67, 24);
            this.materialLabel.TabIndex = 1;
            this.materialLabel.Text = "Ativos: ";
            this.materialLabel.UseAccent = true;
            // 
            // materialDivider12
            // 
            this.materialDivider12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider12.Depth = 0;
            this.materialDivider12.Location = new System.Drawing.Point(72, 46);
            this.materialDivider12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider12.Name = "materialDivider12";
            this.materialDivider12.Size = new System.Drawing.Size(176, 10);
            this.materialDivider12.TabIndex = 1;
            this.materialDivider12.Text = "materialDivider12";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel13.HighEmphasis = true;
            this.materialLabel13.Location = new System.Drawing.Point(103, 19);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(115, 24);
            this.materialLabel13.TabIndex = 0;
            this.materialLabel13.Text = "Funcionários";
            this.materialLabel13.UseAccent = true;
            // 
            // TabPag_Configuracao
            // 
            this.TabPag_Configuracao.Controls.Add(this.materialCard1);
            this.TabPag_Configuracao.ImageKey = "Configurações.png";
            this.TabPag_Configuracao.Location = new System.Drawing.Point(4, 39);
            this.TabPag_Configuracao.Name = "TabPag_Configuracao";
            this.TabPag_Configuracao.Size = new System.Drawing.Size(1007, 479);
            this.TabPag_Configuracao.TabIndex = 5;
            this.TabPag_Configuracao.Text = "Configurações";
            this.TabPag_Configuracao.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.Btn_ViewNovaSenha);
            this.materialCard1.Controls.Add(this.Btn_View_SenhaAtual);
            this.materialCard1.Controls.Add(this.Lbl_SenhaCurta);
            this.materialCard1.Controls.Add(this.Lbl_CamposVazios);
            this.materialCard1.Controls.Add(this.Lbl_credenciaisErro);
            this.materialCard1.Controls.Add(this.Btn_CancelarSalvar_NovasCredenciais);
            this.materialCard1.Controls.Add(this.Btn_SalvarNovas_Credenciais);
            this.materialCard1.Controls.Add(this.Txt_NovaSenha_Gerencia);
            this.materialCard1.Controls.Add(this.Txt_NovoUsuario_Gerencia);
            this.materialCard1.Controls.Add(this.materialDivider2);
            this.materialCard1.Controls.Add(this.Btn_Cancelar_Validacao);
            this.materialCard1.Controls.Add(this.Btn_ValidarCrendencias_Atuais);
            this.materialCard1.Controls.Add(this.Txt_SenhaAtual_Gerencia);
            this.materialCard1.Controls.Add(this.Txt_UsuarioAtual_Gerencia);
            this.materialCard1.Controls.Add(this.materialDivider1);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(119, 34);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(656, 374);
            this.materialCard1.TabIndex = 1;
            // 
            // Btn_ViewNovaSenha
            // 
            this.Btn_ViewNovaSenha.AutoSize = false;
            this.Btn_ViewNovaSenha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_ViewNovaSenha.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_ViewNovaSenha.Depth = 0;
            this.Btn_ViewNovaSenha.Enabled = false;
            this.Btn_ViewNovaSenha.HighEmphasis = true;
            this.Btn_ViewNovaSenha.Icon = ((System.Drawing.Image)(resources.GetObject("Btn_ViewNovaSenha.Icon")));
            this.Btn_ViewNovaSenha.Location = new System.Drawing.Point(285, 268);
            this.Btn_ViewNovaSenha.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_ViewNovaSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_ViewNovaSenha.Name = "Btn_ViewNovaSenha";
            this.Btn_ViewNovaSenha.Size = new System.Drawing.Size(39, 36);
            this.Btn_ViewNovaSenha.TabIndex = 15;
            this.Btn_ViewNovaSenha.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Btn_ViewNovaSenha.UseAccentColor = true;
            this.Btn_ViewNovaSenha.UseVisualStyleBackColor = true;
            this.Btn_ViewNovaSenha.Click += new System.EventHandler(this.Btn_ViewNovaSenha_Click);
            // 
            // Btn_View_SenhaAtual
            // 
            this.Btn_View_SenhaAtual.AutoSize = false;
            this.Btn_View_SenhaAtual.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_View_SenhaAtual.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_View_SenhaAtual.Depth = 0;
            this.Btn_View_SenhaAtual.HighEmphasis = true;
            this.Btn_View_SenhaAtual.Icon = ((System.Drawing.Image)(resources.GetObject("Btn_View_SenhaAtual.Icon")));
            this.Btn_View_SenhaAtual.Location = new System.Drawing.Point(281, 95);
            this.Btn_View_SenhaAtual.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_View_SenhaAtual.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_View_SenhaAtual.Name = "Btn_View_SenhaAtual";
            this.Btn_View_SenhaAtual.Size = new System.Drawing.Size(39, 36);
            this.Btn_View_SenhaAtual.TabIndex = 14;
            this.Btn_View_SenhaAtual.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Btn_View_SenhaAtual.UseAccentColor = true;
            this.Btn_View_SenhaAtual.UseVisualStyleBackColor = true;
            this.Btn_View_SenhaAtual.Click += new System.EventHandler(this.Btn_View_SenhaAtual_Click);
            // 
            // Lbl_SenhaCurta
            // 
            this.Lbl_SenhaCurta.AutoSize = true;
            this.Lbl_SenhaCurta.Depth = 0;
            this.Lbl_SenhaCurta.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_SenhaCurta.HighEmphasis = true;
            this.Lbl_SenhaCurta.Location = new System.Drawing.Point(479, 243);
            this.Lbl_SenhaCurta.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_SenhaCurta.Name = "Lbl_SenhaCurta";
            this.Lbl_SenhaCurta.Size = new System.Drawing.Size(160, 19);
            this.Lbl_SenhaCurta.TabIndex = 13;
            this.Lbl_SenhaCurta.Text = "Senha muito pequena!";
            this.Lbl_SenhaCurta.UseAccent = true;
            this.Lbl_SenhaCurta.Visible = false;
            // 
            // Lbl_CamposVazios
            // 
            this.Lbl_CamposVazios.AutoSize = true;
            this.Lbl_CamposVazios.Depth = 0;
            this.Lbl_CamposVazios.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_CamposVazios.HighEmphasis = true;
            this.Lbl_CamposVazios.Location = new System.Drawing.Point(339, 243);
            this.Lbl_CamposVazios.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_CamposVazios.Name = "Lbl_CamposVazios";
            this.Lbl_CamposVazios.Size = new System.Drawing.Size(112, 19);
            this.Lbl_CamposVazios.TabIndex = 12;
            this.Lbl_CamposVazios.Text = "Campos Vazios";
            this.Lbl_CamposVazios.UseAccent = true;
            this.Lbl_CamposVazios.Visible = false;
            // 
            // Lbl_credenciaisErro
            // 
            this.Lbl_credenciaisErro.AutoSize = true;
            this.Lbl_credenciaisErro.Depth = 0;
            this.Lbl_credenciaisErro.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_credenciaisErro.HighEmphasis = true;
            this.Lbl_credenciaisErro.Location = new System.Drawing.Point(339, 18);
            this.Lbl_credenciaisErro.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_credenciaisErro.Name = "Lbl_credenciaisErro";
            this.Lbl_credenciaisErro.Size = new System.Drawing.Size(157, 19);
            this.Lbl_credenciaisErro.TabIndex = 11;
            this.Lbl_credenciaisErro.Text = "Credenciais incorretas";
            this.Lbl_credenciaisErro.UseAccent = true;
            this.Lbl_credenciaisErro.Visible = false;
            // 
            // Btn_CancelarSalvar_NovasCredenciais
            // 
            this.Btn_CancelarSalvar_NovasCredenciais.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_CancelarSalvar_NovasCredenciais.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_CancelarSalvar_NovasCredenciais.Depth = 0;
            this.Btn_CancelarSalvar_NovasCredenciais.Enabled = false;
            this.Btn_CancelarSalvar_NovasCredenciais.HighEmphasis = true;
            this.Btn_CancelarSalvar_NovasCredenciais.Icon = null;
            this.Btn_CancelarSalvar_NovasCredenciais.Location = new System.Drawing.Point(542, 314);
            this.Btn_CancelarSalvar_NovasCredenciais.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_CancelarSalvar_NovasCredenciais.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_CancelarSalvar_NovasCredenciais.Name = "Btn_CancelarSalvar_NovasCredenciais";
            this.Btn_CancelarSalvar_NovasCredenciais.Size = new System.Drawing.Size(96, 36);
            this.Btn_CancelarSalvar_NovasCredenciais.TabIndex = 10;
            this.Btn_CancelarSalvar_NovasCredenciais.Text = "Cancelar";
            this.Btn_CancelarSalvar_NovasCredenciais.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_CancelarSalvar_NovasCredenciais.UseAccentColor = true;
            this.Btn_CancelarSalvar_NovasCredenciais.UseVisualStyleBackColor = true;
            this.Btn_CancelarSalvar_NovasCredenciais.Click += new System.EventHandler(this.Btn_CancelarSalvar_NovasCredenciais_Click);
            // 
            // Btn_SalvarNovas_Credenciais
            // 
            this.Btn_SalvarNovas_Credenciais.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_SalvarNovas_Credenciais.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_SalvarNovas_Credenciais.Depth = 0;
            this.Btn_SalvarNovas_Credenciais.Enabled = false;
            this.Btn_SalvarNovas_Credenciais.HighEmphasis = true;
            this.Btn_SalvarNovas_Credenciais.Icon = null;
            this.Btn_SalvarNovas_Credenciais.Location = new System.Drawing.Point(285, 314);
            this.Btn_SalvarNovas_Credenciais.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_SalvarNovas_Credenciais.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_SalvarNovas_Credenciais.Name = "Btn_SalvarNovas_Credenciais";
            this.Btn_SalvarNovas_Credenciais.Size = new System.Drawing.Size(225, 36);
            this.Btn_SalvarNovas_Credenciais.TabIndex = 9;
            this.Btn_SalvarNovas_Credenciais.Text = "Salvar Novas Credenciais";
            this.Btn_SalvarNovas_Credenciais.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_SalvarNovas_Credenciais.UseAccentColor = false;
            this.Btn_SalvarNovas_Credenciais.UseVisualStyleBackColor = true;
            this.Btn_SalvarNovas_Credenciais.Click += new System.EventHandler(this.Btn_SalvarNovas_Credenciais_Click);
            // 
            // Txt_NovaSenha_Gerencia
            // 
            this.Txt_NovaSenha_Gerencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_NovaSenha_Gerencia.Depth = 0;
            this.Txt_NovaSenha_Gerencia.Enabled = false;
            this.Txt_NovaSenha_Gerencia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_NovaSenha_Gerencia.Hint = "Nova Senha";
            this.Txt_NovaSenha_Gerencia.LeadingIcon = null;
            this.Txt_NovaSenha_Gerencia.Location = new System.Drawing.Point(17, 307);
            this.Txt_NovaSenha_Gerencia.MaxLength = 50;
            this.Txt_NovaSenha_Gerencia.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_NovaSenha_Gerencia.Multiline = false;
            this.Txt_NovaSenha_Gerencia.Name = "Txt_NovaSenha_Gerencia";
            this.Txt_NovaSenha_Gerencia.Size = new System.Drawing.Size(248, 50);
            this.Txt_NovaSenha_Gerencia.TabIndex = 8;
            this.Txt_NovaSenha_Gerencia.Text = "";
            this.Txt_NovaSenha_Gerencia.TrailingIcon = null;
            // 
            // Txt_NovoUsuario_Gerencia
            // 
            this.Txt_NovoUsuario_Gerencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_NovoUsuario_Gerencia.Depth = 0;
            this.Txt_NovoUsuario_Gerencia.Enabled = false;
            this.Txt_NovoUsuario_Gerencia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_NovoUsuario_Gerencia.Hint = "Novo Usuário";
            this.Txt_NovoUsuario_Gerencia.LeadingIcon = null;
            this.Txt_NovoUsuario_Gerencia.Location = new System.Drawing.Point(17, 241);
            this.Txt_NovoUsuario_Gerencia.MaxLength = 50;
            this.Txt_NovoUsuario_Gerencia.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_NovoUsuario_Gerencia.Multiline = false;
            this.Txt_NovoUsuario_Gerencia.Name = "Txt_NovoUsuario_Gerencia";
            this.Txt_NovoUsuario_Gerencia.Size = new System.Drawing.Size(248, 50);
            this.Txt_NovoUsuario_Gerencia.TabIndex = 7;
            this.Txt_NovoUsuario_Gerencia.Text = "";
            this.Txt_NovoUsuario_Gerencia.TrailingIcon = null;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(21, 212);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(616, 10);
            this.materialDivider2.TabIndex = 6;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // Btn_Cancelar_Validacao
            // 
            this.Btn_Cancelar_Validacao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Cancelar_Validacao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Cancelar_Validacao.Depth = 0;
            this.Btn_Cancelar_Validacao.HighEmphasis = true;
            this.Btn_Cancelar_Validacao.Icon = null;
            this.Btn_Cancelar_Validacao.Location = new System.Drawing.Point(542, 143);
            this.Btn_Cancelar_Validacao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Cancelar_Validacao.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Cancelar_Validacao.Name = "Btn_Cancelar_Validacao";
            this.Btn_Cancelar_Validacao.Size = new System.Drawing.Size(96, 36);
            this.Btn_Cancelar_Validacao.TabIndex = 5;
            this.Btn_Cancelar_Validacao.Text = "Cancelar";
            this.Btn_Cancelar_Validacao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Cancelar_Validacao.UseAccentColor = true;
            this.Btn_Cancelar_Validacao.UseVisualStyleBackColor = true;
            this.Btn_Cancelar_Validacao.Click += new System.EventHandler(this.Btn_Cancelar_Validacao_Click);
            // 
            // Btn_ValidarCrendencias_Atuais
            // 
            this.Btn_ValidarCrendencias_Atuais.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_ValidarCrendencias_Atuais.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_ValidarCrendencias_Atuais.Depth = 0;
            this.Btn_ValidarCrendencias_Atuais.HighEmphasis = true;
            this.Btn_ValidarCrendencias_Atuais.Icon = null;
            this.Btn_ValidarCrendencias_Atuais.Location = new System.Drawing.Point(281, 143);
            this.Btn_ValidarCrendencias_Atuais.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_ValidarCrendencias_Atuais.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_ValidarCrendencias_Atuais.Name = "Btn_ValidarCrendencias_Atuais";
            this.Btn_ValidarCrendencias_Atuais.Size = new System.Drawing.Size(232, 36);
            this.Btn_ValidarCrendencias_Atuais.TabIndex = 4;
            this.Btn_ValidarCrendencias_Atuais.Text = "Validar credenciais atuais";
            this.Btn_ValidarCrendencias_Atuais.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_ValidarCrendencias_Atuais.UseAccentColor = false;
            this.Btn_ValidarCrendencias_Atuais.UseVisualStyleBackColor = true;
            this.Btn_ValidarCrendencias_Atuais.Click += new System.EventHandler(this.Btn_ValidarCrendencias_Atuais_Click);
            // 
            // Txt_SenhaAtual_Gerencia
            // 
            this.Txt_SenhaAtual_Gerencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_SenhaAtual_Gerencia.Depth = 0;
            this.Txt_SenhaAtual_Gerencia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_SenhaAtual_Gerencia.Hint = "Senha Atual";
            this.Txt_SenhaAtual_Gerencia.LeadingIcon = null;
            this.Txt_SenhaAtual_Gerencia.Location = new System.Drawing.Point(18, 136);
            this.Txt_SenhaAtual_Gerencia.MaxLength = 50;
            this.Txt_SenhaAtual_Gerencia.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_SenhaAtual_Gerencia.Multiline = false;
            this.Txt_SenhaAtual_Gerencia.Name = "Txt_SenhaAtual_Gerencia";
            this.Txt_SenhaAtual_Gerencia.Size = new System.Drawing.Size(248, 50);
            this.Txt_SenhaAtual_Gerencia.TabIndex = 3;
            this.Txt_SenhaAtual_Gerencia.Text = "";
            this.Txt_SenhaAtual_Gerencia.TrailingIcon = null;
            // 
            // Txt_UsuarioAtual_Gerencia
            // 
            this.Txt_UsuarioAtual_Gerencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_UsuarioAtual_Gerencia.Depth = 0;
            this.Txt_UsuarioAtual_Gerencia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_UsuarioAtual_Gerencia.Hint = "Usuário Atual";
            this.Txt_UsuarioAtual_Gerencia.LeadingIcon = null;
            this.Txt_UsuarioAtual_Gerencia.Location = new System.Drawing.Point(18, 73);
            this.Txt_UsuarioAtual_Gerencia.MaxLength = 50;
            this.Txt_UsuarioAtual_Gerencia.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_UsuarioAtual_Gerencia.Multiline = false;
            this.Txt_UsuarioAtual_Gerencia.Name = "Txt_UsuarioAtual_Gerencia";
            this.Txt_UsuarioAtual_Gerencia.Size = new System.Drawing.Size(248, 50);
            this.Txt_UsuarioAtual_Gerencia.TabIndex = 2;
            this.Txt_UsuarioAtual_Gerencia.Text = "";
            this.Txt_UsuarioAtual_Gerencia.TrailingIcon = null;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(18, 42);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(248, 10);
            this.materialDivider1.TabIndex = 1;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Location = new System.Drawing.Point(17, 15);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(250, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Alterar credenciais de Login";
            this.materialLabel1.UseAccent = true;
            // 
            // TabPag_Sobre
            // 
            this.TabPag_Sobre.Controls.Add(this.materialCard3);
            this.TabPag_Sobre.ImageKey = "info.png";
            this.TabPag_Sobre.Location = new System.Drawing.Point(4, 39);
            this.TabPag_Sobre.Name = "TabPag_Sobre";
            this.TabPag_Sobre.Size = new System.Drawing.Size(1007, 479);
            this.TabPag_Sobre.TabIndex = 6;
            this.TabPag_Sobre.Text = "Sobre";
            this.TabPag_Sobre.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialMultiLineTextBox1);
            this.materialCard3.Controls.Add(this.materialDivider8);
            this.materialCard3.Controls.Add(this.materialLabel6);
            this.materialCard3.Controls.Add(this.materialLabel4);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(94, 69);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(819, 340);
            this.materialCard3.TabIndex = 0;
            // 
            // materialMultiLineTextBox1
            // 
            this.materialMultiLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox1.Depth = 0;
            this.materialMultiLineTextBox1.Enabled = false;
            this.materialMultiLineTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox1.Location = new System.Drawing.Point(22, 74);
            this.materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            this.materialMultiLineTextBox1.Size = new System.Drawing.Size(701, 76);
            this.materialMultiLineTextBox1.TabIndex = 3;
            this.materialMultiLineTextBox1.Text = resources.GetString("materialMultiLineTextBox1.Text");
            // 
            // materialDivider8
            // 
            this.materialDivider8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider8.Depth = 0;
            this.materialDivider8.Location = new System.Drawing.Point(22, 45);
            this.materialDivider8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider8.Name = "materialDivider8";
            this.materialDivider8.Size = new System.Drawing.Size(143, 10);
            this.materialDivider8.TabIndex = 2;
            this.materialDivider8.Text = "materialDivider8";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel6.Location = new System.Drawing.Point(646, 312);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(156, 14);
            this.materialLabel6.TabIndex = 1;
            this.materialLabel6.Text = "Todos os direitos reservados";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.HighEmphasis = true;
            this.materialLabel4.Location = new System.Drawing.Point(20, 18);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(147, 24);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Sobre o Sistema";
            this.materialLabel4.UseAccent = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            this.toolTip1.AutoPopDelay = 50000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Dica";
            // 
            // Frm_Gerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1021, 589);
            this.Controls.Add(this.TabControl_Gerencia);
            this.DrawerTabControl = this.TabControl_Gerencia;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Gerencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerência";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Gerencia_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Gerencia_Load);
            this.TabControl_Gerencia.ResumeLayout(false);
            this.TabPag_Funcionarios.ResumeLayout(false);
            this.TabPag_Funcionarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ListagemFunc)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard13.ResumeLayout(false);
            this.materialCard13.PerformLayout();
            this.materialCard6.ResumeLayout(false);
            this.materialCard6.PerformLayout();
            this.TabPag_Hospedes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ListagemHospedes)).EndInit();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.TabPag_Relatorios.ResumeLayout(false);
            this.materialCard8.ResumeLayout(false);
            this.materialCard8.PerformLayout();
            this.materialCard12.ResumeLayout(false);
            this.materialCard12.PerformLayout();
            this.materialCard11.ResumeLayout(false);
            this.materialCard11.PerformLayout();
            this.materialCard10.ResumeLayout(false);
            this.materialCard10.PerformLayout();
            this.materialCard9.ResumeLayout(false);
            this.materialCard9.PerformLayout();
            this.TabPag_Configuracao.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.TabPag_Sobre.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl TabControl_Gerencia;
        private System.Windows.Forms.TabPage TabPag_Funcionarios;
        private System.Windows.Forms.TabPage TabPag_Hospedes;
        private System.Windows.Forms.TabPage TabPag_Relatorios;
        private System.Windows.Forms.TabPage TabPag_Configuracao;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel Lbl_credenciaisErro;
        private MaterialSkin.Controls.MaterialButton Btn_CancelarSalvar_NovasCredenciais;
        private MaterialSkin.Controls.MaterialButton Btn_SalvarNovas_Credenciais;
        private MaterialSkin.Controls.MaterialTextBox Txt_NovaSenha_Gerencia;
        private MaterialSkin.Controls.MaterialTextBox Txt_NovoUsuario_Gerencia;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialButton Btn_Cancelar_Validacao;
        private MaterialSkin.Controls.MaterialButton Btn_ValidarCrendencias_Atuais;
        private MaterialSkin.Controls.MaterialTextBox Txt_SenhaAtual_Gerencia;
        private MaterialSkin.Controls.MaterialTextBox Txt_UsuarioAtual_Gerencia;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton Btn_SalvarCadastro_Func;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialLabel Lbl_ErroCadastro;
        private MaterialSkin.Controls.MaterialTextBox Txt_CartaoHospede;
        private MaterialSkin.Controls.MaterialTextBox Txt_NumQuarto_Hospede;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.DateTimePicker Date_CheckIn_Hospede;
        private System.Windows.Forms.DateTimePicker Date_CheckOut_Hospede;
        private MaterialSkin.Controls.MaterialComboBox Combobx_CategoriaQuarto_Hospede;
        private MaterialSkin.Controls.MaterialDivider materialDivider7;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialDivider materialDivider6;
        private MaterialSkin.Controls.MaterialTextBox Txt_CPF_Hospede;
        private MaterialSkin.Controls.MaterialTextBox Txt_EmailHospede;
        private MaterialSkin.Controls.MaterialTextBox Txt_CelularHospede;
        private MaterialSkin.Controls.MaterialTextBox Txt_NomeHospede;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialButton Btn_Salvar_CadastroReserva;
        private MaterialSkin.Controls.MaterialLabel Lbl_ErroCadastro_Funcs;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private MaterialSkin.Controls.MaterialDivider materialDivider12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialDivider materialDivider14;
        private MaterialSkin.Controls.MaterialDivider materialDivider13;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private MaterialSkin.Controls.MaterialCard materialCard12;
        private MaterialSkin.Controls.MaterialLabel Lbl_Relatorio_GanhoTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private MaterialSkin.Controls.MaterialCard materialCard11;
        private MaterialSkin.Controls.MaterialLabel Lbl_Relatorio_FuncsInativos;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialCard materialCard10;
        private MaterialSkin.Controls.MaterialLabel Lbl_Relatorio_ReservasAtivas;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialCard materialCard9;
        private MaterialSkin.Controls.MaterialLabel Lbl_Relatorio_FuncsAtivos;
        private MaterialSkin.Controls.MaterialLabel materialLabel;
        private MaterialSkin.Controls.MaterialDivider materialDivider9;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox Txt_CTPS_Func;
        private MaterialSkin.Controls.MaterialDivider materialDivider10;
        private MaterialSkin.Controls.MaterialLabel materialLabel23;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialCard materialCard13;
        private MaterialSkin.Controls.MaterialTextBox Txt_EmailFunc;
        private MaterialSkin.Controls.MaterialTextBox Txt_CPF_Func;
        private MaterialSkin.Controls.MaterialTextBox Txt_NomeFunc;
        private MaterialSkin.Controls.MaterialCheckbox CKBX_StatusFunc;
        private MaterialSkin.Controls.MaterialTextBox Txt_CPF_PesquisarFuncs;
        private MaterialSkin.Controls.MaterialCheckbox CKBX_FichaStatusFunc;
        private MaterialSkin.Controls.MaterialButton Btn_ListarFichas_Desativadas;
        private MaterialSkin.Controls.MaterialButton Btn_ListarFichas_Ativadas;
        private System.Windows.Forms.DataGridView Grid_ListagemFunc;
        private MaterialSkin.Controls.MaterialButton Btn_Editar_FichaFunc;
        private MaterialSkin.Controls.MaterialButton Btn_Consultar_FichaFunc;
        private MaterialSkin.Controls.MaterialButton Btn_Listar_FichasReservas_Inativas;
        private MaterialSkin.Controls.MaterialButton Btn_Listar_FichasReservas_Ativas;
        private System.Windows.Forms.DataGridView Grid_ListagemHospedes;
        private MaterialSkin.Controls.MaterialButton Btn_Consultar_FichaHospede;
        private MaterialSkin.Controls.MaterialButton Btn_Editar_FichaHospede;
        private MaterialSkin.Controls.MaterialLabel Lbl_Pagamento_Total;
        private MaterialSkin.Controls.MaterialLabel materialLabel24;
        private MaterialSkin.Controls.MaterialCheckbox CKBX_ReservaAtivada;
        private MaterialSkin.Controls.MaterialCheckbox CKBX_HospedesAtivo;
        private MaterialSkin.Controls.MaterialTextBox Txt_PesquisarCPF_Hosp;
        private System.Windows.Forms.ToolTip toolTip1;
        private MaterialSkin.Controls.MaterialButton Btn_ListarTodas_Fichas;
        private MaterialSkin.Controls.MaterialButton Btn_ListarTodas_Reservas;
        private MaterialSkin.Controls.MaterialTextBox Txt_CargoFunc;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialButton Btn_LimparCampos;
        private MaterialSkin.Controls.MaterialButton Btn_LimparCampos_Hosp;
        private MaterialSkin.Controls.MaterialLabel Lbl_SenhaCurta;
        private MaterialSkin.Controls.MaterialLabel Lbl_CamposVazios;
        private MaterialSkin.Controls.MaterialLabel Lbl_ErroConsulta;
        private MaterialSkin.Controls.MaterialDivider materialDivider11;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel Lbl_ErroConsulta_Hosp;
        private MaterialSkin.Controls.MaterialButton Btn_ViewNovaSenha;
        private MaterialSkin.Controls.MaterialButton Btn_View_SenhaAtual;
        private MaterialSkin.Controls.MaterialButton Btn_AtualizarRelatórios;
        private System.Windows.Forms.TabPage TabPag_Sobre;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private MaterialSkin.Controls.MaterialDivider materialDivider8;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}