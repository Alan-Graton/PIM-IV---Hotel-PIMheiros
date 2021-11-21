
namespace Sistema_Desktop_para_Hotel.Forms
{
    partial class Frm_Funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Funcionarios));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TabControl_Recepcao = new MaterialSkin.Controls.MaterialTabControl();
            this.TabPag_Hospedes = new System.Windows.Forms.TabPage();
            this.Btn_LimparCampos = new MaterialSkin.Controls.MaterialButton();
            this.Btn_ListarTodas_Fichas = new MaterialSkin.Controls.MaterialButton();
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
            this.Txt_Pesquisar_CPFHospede = new MaterialSkin.Controls.MaterialTextBox();
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
            this.TabPag_Configuracoes = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.Btn_ViewNovaSenha = new MaterialSkin.Controls.MaterialButton();
            this.Btn_ViewSenhaAtual = new MaterialSkin.Controls.MaterialButton();
            this.Lbl_credenciaisErro = new MaterialSkin.Controls.MaterialLabel();
            this.Btn_CancelarSalvar_NovasCredenciais = new MaterialSkin.Controls.MaterialButton();
            this.Btn_SalvarNovas_Credenciais = new MaterialSkin.Controls.MaterialButton();
            this.Txt_NovaSenha_Recepcao = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_NovoUsuario_Recepcao = new MaterialSkin.Controls.MaterialTextBox();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.Btn_Cancelar_Validacao = new MaterialSkin.Controls.MaterialButton();
            this.Btn_ValidarCrendencias_Atuais = new MaterialSkin.Controls.MaterialButton();
            this.Txt_SenhaAtual_Recepcao = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_UsuarioAtual_Recepcao = new MaterialSkin.Controls.MaterialTextBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TabControl_Recepcao.SuspendLayout();
            this.TabPag_Hospedes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ListagemHospedes)).BeginInit();
            this.materialCard5.SuspendLayout();
            this.TabPag_Configuracoes.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Configurações.png");
            this.imageList1.Images.SetKeyName(1, "Reservas.png");
            // 
            // TabControl_Recepcao
            // 
            this.TabControl_Recepcao.Controls.Add(this.TabPag_Hospedes);
            this.TabControl_Recepcao.Controls.Add(this.TabPag_Configuracoes);
            this.TabControl_Recepcao.Depth = 0;
            this.TabControl_Recepcao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl_Recepcao.ImageList = this.imageList1;
            this.TabControl_Recepcao.Location = new System.Drawing.Point(3, 64);
            this.TabControl_Recepcao.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl_Recepcao.Multiline = true;
            this.TabControl_Recepcao.Name = "TabControl_Recepcao";
            this.TabControl_Recepcao.SelectedIndex = 0;
            this.TabControl_Recepcao.Size = new System.Drawing.Size(1015, 522);
            this.TabControl_Recepcao.TabIndex = 0;
            // 
            // TabPag_Hospedes
            // 
            this.TabPag_Hospedes.Controls.Add(this.Btn_LimparCampos);
            this.TabPag_Hospedes.Controls.Add(this.Btn_ListarTodas_Fichas);
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
            this.TabPag_Hospedes.TabIndex = 0;
            this.TabPag_Hospedes.Text = "Hóspedes";
            this.TabPag_Hospedes.UseVisualStyleBackColor = true;
            // 
            // Btn_LimparCampos
            // 
            this.Btn_LimparCampos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_LimparCampos.AutoSize = false;
            this.Btn_LimparCampos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_LimparCampos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_LimparCampos.Depth = 0;
            this.Btn_LimparCampos.HighEmphasis = true;
            this.Btn_LimparCampos.Icon = null;
            this.Btn_LimparCampos.Location = new System.Drawing.Point(436, 439);
            this.Btn_LimparCampos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_LimparCampos.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_LimparCampos.Name = "Btn_LimparCampos";
            this.Btn_LimparCampos.Size = new System.Drawing.Size(116, 36);
            this.Btn_LimparCampos.TabIndex = 35;
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
            this.Btn_ListarTodas_Fichas.Location = new System.Drawing.Point(730, 439);
            this.Btn_ListarTodas_Fichas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_ListarTodas_Fichas.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_ListarTodas_Fichas.Name = "Btn_ListarTodas_Fichas";
            this.Btn_ListarTodas_Fichas.Size = new System.Drawing.Size(112, 36);
            this.Btn_ListarTodas_Fichas.TabIndex = 34;
            this.Btn_ListarTodas_Fichas.Text = "Listar Tudo";
            this.Btn_ListarTodas_Fichas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_ListarTodas_Fichas.UseAccentColor = true;
            this.Btn_ListarTodas_Fichas.UseVisualStyleBackColor = true;
            this.Btn_ListarTodas_Fichas.Click += new System.EventHandler(this.Btn_ListarTodas_Fichas_Click);
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
            this.Btn_Listar_FichasReservas_Inativas.Location = new System.Drawing.Point(866, 439);
            this.Btn_Listar_FichasReservas_Inativas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Listar_FichasReservas_Inativas.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Listar_FichasReservas_Inativas.Name = "Btn_Listar_FichasReservas_Inativas";
            this.Btn_Listar_FichasReservas_Inativas.Size = new System.Drawing.Size(130, 36);
            this.Btn_Listar_FichasReservas_Inativas.TabIndex = 32;
            this.Btn_Listar_FichasReservas_Inativas.Text = "Listar Fichas Inativas";
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
            this.Btn_Listar_FichasReservas_Ativas.Location = new System.Drawing.Point(576, 439);
            this.Btn_Listar_FichasReservas_Ativas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Listar_FichasReservas_Ativas.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Listar_FichasReservas_Ativas.Name = "Btn_Listar_FichasReservas_Ativas";
            this.Btn_Listar_FichasReservas_Ativas.Size = new System.Drawing.Size(130, 36);
            this.Btn_Listar_FichasReservas_Ativas.TabIndex = 31;
            this.Btn_Listar_FichasReservas_Ativas.Text = "Listar Fichas Ativas";
            this.Btn_Listar_FichasReservas_Ativas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Listar_FichasReservas_Ativas.UseAccentColor = true;
            this.Btn_Listar_FichasReservas_Ativas.UseVisualStyleBackColor = true;
            this.Btn_Listar_FichasReservas_Ativas.Click += new System.EventHandler(this.Btn_Listar_FichasReservas_Ativas_Click);
            // 
            // Grid_ListagemHospedes
            // 
            this.Grid_ListagemHospedes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Grid_ListagemHospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ListagemHospedes.Location = new System.Drawing.Point(598, 17);
            this.Grid_ListagemHospedes.Name = "Grid_ListagemHospedes";
            this.Grid_ListagemHospedes.Size = new System.Drawing.Size(403, 402);
            this.Grid_ListagemHospedes.TabIndex = 30;
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
            this.Btn_Consultar_FichaHospede.Location = new System.Drawing.Point(156, 439);
            this.Btn_Consultar_FichaHospede.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Consultar_FichaHospede.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Consultar_FichaHospede.Name = "Btn_Consultar_FichaHospede";
            this.Btn_Consultar_FichaHospede.Size = new System.Drawing.Size(116, 36);
            this.Btn_Consultar_FichaHospede.TabIndex = 28;
            this.Btn_Consultar_FichaHospede.Text = "Consultar";
            this.toolTip1.SetToolTip(this.Btn_Consultar_FichaHospede, "Insira o CPF do Hóspede desejado no campo \"Pesquisar por CPF\"");
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
            this.Btn_Editar_FichaHospede.Location = new System.Drawing.Point(296, 439);
            this.Btn_Editar_FichaHospede.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Editar_FichaHospede.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Editar_FichaHospede.Name = "Btn_Editar_FichaHospede";
            this.Btn_Editar_FichaHospede.Size = new System.Drawing.Size(116, 36);
            this.Btn_Editar_FichaHospede.TabIndex = 27;
            this.Btn_Editar_FichaHospede.Text = "Editar";
            this.toolTip1.SetToolTip(this.Btn_Editar_FichaHospede, "Necessário entrar com o CPF do Hóspede no campo \"Pesquisar por CPF\" para alterar " +
        "os dados desejados");
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
            this.Btn_Salvar_CadastroReserva.Location = new System.Drawing.Point(16, 439);
            this.Btn_Salvar_CadastroReserva.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Salvar_CadastroReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Salvar_CadastroReserva.Name = "Btn_Salvar_CadastroReserva";
            this.Btn_Salvar_CadastroReserva.Size = new System.Drawing.Size(116, 36);
            this.Btn_Salvar_CadastroReserva.TabIndex = 26;
            this.Btn_Salvar_CadastroReserva.Text = "Salvar";
            this.Btn_Salvar_CadastroReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Salvar_CadastroReserva.UseAccentColor = false;
            this.Btn_Salvar_CadastroReserva.UseVisualStyleBackColor = true;
            // 
            // materialCard5
            // 
            this.materialCard5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.Lbl_Pagamento_Total);
            this.materialCard5.Controls.Add(this.materialLabel24);
            this.materialCard5.Controls.Add(this.CKBX_ReservaAtivada);
            this.materialCard5.Controls.Add(this.CKBX_HospedesAtivo);
            this.materialCard5.Controls.Add(this.Txt_Pesquisar_CPFHospede);
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
            this.materialCard5.Location = new System.Drawing.Point(17, 17);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(573, 402);
            this.materialCard5.TabIndex = 25;
            // 
            // Lbl_Pagamento_Total
            // 
            this.Lbl_Pagamento_Total.AutoSize = true;
            this.Lbl_Pagamento_Total.Depth = 0;
            this.Lbl_Pagamento_Total.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Pagamento_Total.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.Lbl_Pagamento_Total.HighEmphasis = true;
            this.Lbl_Pagamento_Total.Location = new System.Drawing.Point(442, 140);
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
            this.materialLabel24.Location = new System.Drawing.Point(412, 140);
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
            this.CKBX_ReservaAtivada.Location = new System.Drawing.Point(235, 351);
            this.CKBX_ReservaAtivada.Margin = new System.Windows.Forms.Padding(0);
            this.CKBX_ReservaAtivada.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CKBX_ReservaAtivada.MouseState = MaterialSkin.MouseState.HOVER;
            this.CKBX_ReservaAtivada.Name = "CKBX_ReservaAtivada";
            this.CKBX_ReservaAtivada.Ripple = true;
            this.CKBX_ReservaAtivada.Size = new System.Drawing.Size(149, 37);
            this.CKBX_ReservaAtivada.TabIndex = 25;
            this.CKBX_ReservaAtivada.Text = "Reserva Ativada";
            this.toolTip1.SetToolTip(this.CKBX_ReservaAtivada, "Equivalente a \"Cancelar/Ativar a Reserva\"");
            this.CKBX_ReservaAtivada.UseVisualStyleBackColor = true;
            // 
            // CKBX_HospedesAtivo
            // 
            this.CKBX_HospedesAtivo.AutoSize = true;
            this.CKBX_HospedesAtivo.Depth = 0;
            this.CKBX_HospedesAtivo.Location = new System.Drawing.Point(11, 351);
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
            // Txt_Pesquisar_CPFHospede
            // 
            this.Txt_Pesquisar_CPFHospede.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Pesquisar_CPFHospede.Depth = 0;
            this.Txt_Pesquisar_CPFHospede.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_Pesquisar_CPFHospede.Hint = "Pesquisar por CPF";
            this.Txt_Pesquisar_CPFHospede.LeadingIcon = null;
            this.Txt_Pesquisar_CPFHospede.Location = new System.Drawing.Point(11, 102);
            this.Txt_Pesquisar_CPFHospede.MaxLength = 11;
            this.Txt_Pesquisar_CPFHospede.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_Pesquisar_CPFHospede.Multiline = false;
            this.Txt_Pesquisar_CPFHospede.Name = "Txt_Pesquisar_CPFHospede";
            this.Txt_Pesquisar_CPFHospede.Size = new System.Drawing.Size(203, 36);
            this.Txt_Pesquisar_CPFHospede.TabIndex = 23;
            this.Txt_Pesquisar_CPFHospede.Text = "";
            this.toolTip1.SetToolTip(this.Txt_Pesquisar_CPFHospede, "Inserir CPF do Hóspede para realizar consulta de seus dados");
            this.Txt_Pesquisar_CPFHospede.TrailingIcon = global::Sistema_Desktop_para_Hotel.Properties.Resources.Lupa;
            this.Txt_Pesquisar_CPFHospede.UseTallSize = false;
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
            this.Txt_CartaoHospede.Location = new System.Drawing.Point(238, 134);
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
            this.Txt_NumQuarto_Hospede.Location = new System.Drawing.Point(237, 176);
            this.Txt_NumQuarto_Hospede.MaxLength = 50;
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
            this.materialLabel8.Location = new System.Drawing.Point(239, 268);
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
            this.materialLabel9.Location = new System.Drawing.Point(239, 303);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(88, 24);
            this.materialLabel9.TabIndex = 16;
            this.materialLabel9.Text = "CheckOut";
            this.materialLabel9.UseAccent = true;
            // 
            // Date_CheckIn_Hospede
            // 
            this.Date_CheckIn_Hospede.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_CheckIn_Hospede.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_CheckIn_Hospede.Location = new System.Drawing.Point(403, 268);
            this.Date_CheckIn_Hospede.Name = "Date_CheckIn_Hospede";
            this.Date_CheckIn_Hospede.Size = new System.Drawing.Size(130, 29);
            this.Date_CheckIn_Hospede.TabIndex = 15;
            // 
            // Date_CheckOut_Hospede
            // 
            this.Date_CheckOut_Hospede.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_CheckOut_Hospede.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_CheckOut_Hospede.Location = new System.Drawing.Point(403, 303);
            this.Date_CheckOut_Hospede.Name = "Date_CheckOut_Hospede";
            this.Date_CheckOut_Hospede.Size = new System.Drawing.Size(130, 29);
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
            this.Combobx_CategoriaQuarto_Hospede.Location = new System.Drawing.Point(405, 177);
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
            this.materialDivider6.Size = new System.Drawing.Size(10, 298);
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
            this.Txt_CPF_Hospede.Location = new System.Drawing.Point(11, 216);
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
            this.Txt_EmailHospede.Location = new System.Drawing.Point(11, 296);
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
            this.Txt_CelularHospede.Location = new System.Drawing.Point(11, 256);
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
            this.Txt_NomeHospede.Location = new System.Drawing.Point(11, 176);
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
            // TabPag_Configuracoes
            // 
            this.TabPag_Configuracoes.Controls.Add(this.materialCard1);
            this.TabPag_Configuracoes.ImageKey = "Configurações.png";
            this.TabPag_Configuracoes.Location = new System.Drawing.Point(4, 39);
            this.TabPag_Configuracoes.Name = "TabPag_Configuracoes";
            this.TabPag_Configuracoes.Size = new System.Drawing.Size(1007, 479);
            this.TabPag_Configuracoes.TabIndex = 3;
            this.TabPag_Configuracoes.Text = "Configurações";
            this.TabPag_Configuracoes.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.Btn_ViewNovaSenha);
            this.materialCard1.Controls.Add(this.Btn_ViewSenhaAtual);
            this.materialCard1.Controls.Add(this.Lbl_credenciaisErro);
            this.materialCard1.Controls.Add(this.Btn_CancelarSalvar_NovasCredenciais);
            this.materialCard1.Controls.Add(this.Btn_SalvarNovas_Credenciais);
            this.materialCard1.Controls.Add(this.Txt_NovaSenha_Recepcao);
            this.materialCard1.Controls.Add(this.Txt_NovoUsuario_Recepcao);
            this.materialCard1.Controls.Add(this.materialDivider2);
            this.materialCard1.Controls.Add(this.Btn_Cancelar_Validacao);
            this.materialCard1.Controls.Add(this.Btn_ValidarCrendencias_Atuais);
            this.materialCard1.Controls.Add(this.Txt_SenhaAtual_Recepcao);
            this.materialCard1.Controls.Add(this.Txt_UsuarioAtual_Recepcao);
            this.materialCard1.Controls.Add(this.materialDivider1);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(159, 34);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(656, 374);
            this.materialCard1.TabIndex = 0;
            // 
            // Btn_ViewNovaSenha
            // 
            this.Btn_ViewNovaSenha.AutoSize = false;
            this.Btn_ViewNovaSenha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_ViewNovaSenha.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_ViewNovaSenha.Depth = 0;
            this.Btn_ViewNovaSenha.Enabled = false;
            this.Btn_ViewNovaSenha.HighEmphasis = true;
            this.Btn_ViewNovaSenha.Icon = global::Sistema_Desktop_para_Hotel.Properties.Resources.Ver_Senha;
            this.Btn_ViewNovaSenha.Location = new System.Drawing.Point(285, 266);
            this.Btn_ViewNovaSenha.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_ViewNovaSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_ViewNovaSenha.Name = "Btn_ViewNovaSenha";
            this.Btn_ViewNovaSenha.Size = new System.Drawing.Size(40, 36);
            this.Btn_ViewNovaSenha.TabIndex = 13;
            this.Btn_ViewNovaSenha.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Btn_ViewNovaSenha.UseAccentColor = true;
            this.Btn_ViewNovaSenha.UseVisualStyleBackColor = true;
            this.Btn_ViewNovaSenha.Click += new System.EventHandler(this.Btn_ViewNovaSenha_Click);
            // 
            // Btn_ViewSenhaAtual
            // 
            this.Btn_ViewSenhaAtual.AutoSize = false;
            this.Btn_ViewSenhaAtual.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_ViewSenhaAtual.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_ViewSenhaAtual.Depth = 0;
            this.Btn_ViewSenhaAtual.HighEmphasis = true;
            this.Btn_ViewSenhaAtual.Icon = global::Sistema_Desktop_para_Hotel.Properties.Resources.Ver_Senha;
            this.Btn_ViewSenhaAtual.Location = new System.Drawing.Point(281, 87);
            this.Btn_ViewSenhaAtual.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_ViewSenhaAtual.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_ViewSenhaAtual.Name = "Btn_ViewSenhaAtual";
            this.Btn_ViewSenhaAtual.Size = new System.Drawing.Size(40, 36);
            this.Btn_ViewSenhaAtual.TabIndex = 12;
            this.Btn_ViewSenhaAtual.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Btn_ViewSenhaAtual.UseAccentColor = false;
            this.Btn_ViewSenhaAtual.UseVisualStyleBackColor = true;
            this.Btn_ViewSenhaAtual.Click += new System.EventHandler(this.Btn_ViewSenhaAtual_Click);
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
            this.Lbl_credenciaisErro.Size = new System.Drawing.Size(1, 0);
            this.Lbl_credenciaisErro.TabIndex = 11;
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
            // Txt_NovaSenha_Recepcao
            // 
            this.Txt_NovaSenha_Recepcao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_NovaSenha_Recepcao.Depth = 0;
            this.Txt_NovaSenha_Recepcao.Enabled = false;
            this.Txt_NovaSenha_Recepcao.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_NovaSenha_Recepcao.Hint = "Nova Senha";
            this.Txt_NovaSenha_Recepcao.LeadingIcon = null;
            this.Txt_NovaSenha_Recepcao.Location = new System.Drawing.Point(17, 307);
            this.Txt_NovaSenha_Recepcao.MaxLength = 50;
            this.Txt_NovaSenha_Recepcao.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_NovaSenha_Recepcao.Multiline = false;
            this.Txt_NovaSenha_Recepcao.Name = "Txt_NovaSenha_Recepcao";
            this.Txt_NovaSenha_Recepcao.Size = new System.Drawing.Size(248, 50);
            this.Txt_NovaSenha_Recepcao.TabIndex = 8;
            this.Txt_NovaSenha_Recepcao.Text = "";
            this.Txt_NovaSenha_Recepcao.TrailingIcon = null;
            // 
            // Txt_NovoUsuario_Recepcao
            // 
            this.Txt_NovoUsuario_Recepcao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_NovoUsuario_Recepcao.Depth = 0;
            this.Txt_NovoUsuario_Recepcao.Enabled = false;
            this.Txt_NovoUsuario_Recepcao.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_NovoUsuario_Recepcao.Hint = "Novo Usuário";
            this.Txt_NovoUsuario_Recepcao.LeadingIcon = null;
            this.Txt_NovoUsuario_Recepcao.Location = new System.Drawing.Point(17, 241);
            this.Txt_NovoUsuario_Recepcao.MaxLength = 50;
            this.Txt_NovoUsuario_Recepcao.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_NovoUsuario_Recepcao.Multiline = false;
            this.Txt_NovoUsuario_Recepcao.Name = "Txt_NovoUsuario_Recepcao";
            this.Txt_NovoUsuario_Recepcao.Size = new System.Drawing.Size(248, 50);
            this.Txt_NovoUsuario_Recepcao.TabIndex = 7;
            this.Txt_NovoUsuario_Recepcao.Text = "";
            this.Txt_NovoUsuario_Recepcao.TrailingIcon = null;
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
            // Txt_SenhaAtual_Recepcao
            // 
            this.Txt_SenhaAtual_Recepcao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_SenhaAtual_Recepcao.Depth = 0;
            this.Txt_SenhaAtual_Recepcao.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_SenhaAtual_Recepcao.Hint = "Senha Atual";
            this.Txt_SenhaAtual_Recepcao.LeadingIcon = null;
            this.Txt_SenhaAtual_Recepcao.Location = new System.Drawing.Point(18, 136);
            this.Txt_SenhaAtual_Recepcao.MaxLength = 50;
            this.Txt_SenhaAtual_Recepcao.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_SenhaAtual_Recepcao.Multiline = false;
            this.Txt_SenhaAtual_Recepcao.Name = "Txt_SenhaAtual_Recepcao";
            this.Txt_SenhaAtual_Recepcao.Size = new System.Drawing.Size(248, 50);
            this.Txt_SenhaAtual_Recepcao.TabIndex = 3;
            this.Txt_SenhaAtual_Recepcao.Text = "";
            this.Txt_SenhaAtual_Recepcao.TrailingIcon = null;
            // 
            // Txt_UsuarioAtual_Recepcao
            // 
            this.Txt_UsuarioAtual_Recepcao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_UsuarioAtual_Recepcao.Depth = 0;
            this.Txt_UsuarioAtual_Recepcao.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_UsuarioAtual_Recepcao.Hint = "Usuário Atual";
            this.Txt_UsuarioAtual_Recepcao.LeadingIcon = null;
            this.Txt_UsuarioAtual_Recepcao.Location = new System.Drawing.Point(18, 73);
            this.Txt_UsuarioAtual_Recepcao.MaxLength = 50;
            this.Txt_UsuarioAtual_Recepcao.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_UsuarioAtual_Recepcao.Multiline = false;
            this.Txt_UsuarioAtual_Recepcao.Name = "Txt_UsuarioAtual_Recepcao";
            this.Txt_UsuarioAtual_Recepcao.Size = new System.Drawing.Size(248, 50);
            this.Txt_UsuarioAtual_Recepcao.TabIndex = 2;
            this.Txt_UsuarioAtual_Recepcao.Text = "";
            this.Txt_UsuarioAtual_Recepcao.TrailingIcon = null;
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
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Dica";
            // 
            // Frm_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 589);
            this.Controls.Add(this.TabControl_Recepcao);
            this.DrawerTabControl = this.TabControl_Recepcao;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recepção";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Funcionarios_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Funcionarios_Load);
            this.TabControl_Recepcao.ResumeLayout(false);
            this.TabPag_Hospedes.ResumeLayout(false);
            this.TabPag_Hospedes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ListagemHospedes)).EndInit();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.TabPag_Configuracoes.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl TabControl_Recepcao;
        private System.Windows.Forms.TabPage TabPag_Hospedes;
        private System.Windows.Forms.TabPage TabPag_Configuracoes;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton Btn_CancelarSalvar_NovasCredenciais;
        private MaterialSkin.Controls.MaterialButton Btn_SalvarNovas_Credenciais;
        private MaterialSkin.Controls.MaterialTextBox Txt_NovaSenha_Recepcao;
        private MaterialSkin.Controls.MaterialTextBox Txt_NovoUsuario_Recepcao;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialButton Btn_Cancelar_Validacao;
        private MaterialSkin.Controls.MaterialButton Btn_ValidarCrendencias_Atuais;
        private MaterialSkin.Controls.MaterialTextBox Txt_SenhaAtual_Recepcao;
        private MaterialSkin.Controls.MaterialTextBox Txt_UsuarioAtual_Recepcao;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel Lbl_credenciaisErro;
        private MaterialSkin.Controls.MaterialButton Btn_Listar_FichasReservas_Inativas;
        private MaterialSkin.Controls.MaterialButton Btn_Listar_FichasReservas_Ativas;
        private System.Windows.Forms.DataGridView Grid_ListagemHospedes;
        private MaterialSkin.Controls.MaterialButton Btn_Consultar_FichaHospede;
        private MaterialSkin.Controls.MaterialButton Btn_Editar_FichaHospede;
        private MaterialSkin.Controls.MaterialButton Btn_Salvar_CadastroReserva;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialLabel Lbl_Pagamento_Total;
        private MaterialSkin.Controls.MaterialLabel materialLabel24;
        private MaterialSkin.Controls.MaterialCheckbox CKBX_ReservaAtivada;
        private MaterialSkin.Controls.MaterialCheckbox CKBX_HospedesAtivo;
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
        private MaterialSkin.Controls.MaterialButton Btn_ListarTodas_Fichas;
        private MaterialSkin.Controls.MaterialTextBox Txt_Pesquisar_CPFHospede;
        private MaterialSkin.Controls.MaterialButton Btn_ViewNovaSenha;
        private MaterialSkin.Controls.MaterialButton Btn_ViewSenhaAtual;
        private MaterialSkin.Controls.MaterialButton Btn_LimparCampos;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}