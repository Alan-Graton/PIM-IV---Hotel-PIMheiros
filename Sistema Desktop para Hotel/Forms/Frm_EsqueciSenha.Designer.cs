
namespace Sistema_Desktop_para_Hotel.Forms
{
    partial class Frm_EsqueciSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EsqueciSenha));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Lbl_Erro = new MaterialSkin.Controls.MaterialLabel();
            this.Txt_recSenha_Usuario = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_NovaSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_ConfirmarSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.Btn_SalvarNovaSenha = new MaterialSkin.Controls.MaterialButton();
            this.FloatBtn_VoltarLogin = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.Btn_ViewRecuperar_Senha = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(110, 89);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(183, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Recupere sua Senha";
            // 
            // Lbl_Erro
            // 
            this.Lbl_Erro.AutoSize = true;
            this.Lbl_Erro.Depth = 0;
            this.Lbl_Erro.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Erro.HighEmphasis = true;
            this.Lbl_Erro.Location = new System.Drawing.Point(141, 123);
            this.Lbl_Erro.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Erro.Name = "Lbl_Erro";
            this.Lbl_Erro.Size = new System.Drawing.Size(1, 0);
            this.Lbl_Erro.TabIndex = 1;
            this.Lbl_Erro.UseAccent = true;
            this.Lbl_Erro.Visible = false;
            // 
            // Txt_recSenha_Usuario
            // 
            this.Txt_recSenha_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_recSenha_Usuario.Depth = 0;
            this.Txt_recSenha_Usuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_recSenha_Usuario.Hint = "Usuário";
            this.Txt_recSenha_Usuario.LeadingIcon = null;
            this.Txt_recSenha_Usuario.Location = new System.Drawing.Point(76, 181);
            this.Txt_recSenha_Usuario.MaxLength = 50;
            this.Txt_recSenha_Usuario.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_recSenha_Usuario.Multiline = false;
            this.Txt_recSenha_Usuario.Name = "Txt_recSenha_Usuario";
            this.Txt_recSenha_Usuario.Size = new System.Drawing.Size(251, 50);
            this.Txt_recSenha_Usuario.TabIndex = 2;
            this.Txt_recSenha_Usuario.Text = "";
            this.Txt_recSenha_Usuario.TrailingIcon = null;
            // 
            // Txt_NovaSenha
            // 
            this.Txt_NovaSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_NovaSenha.Depth = 0;
            this.Txt_NovaSenha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_NovaSenha.Hint = "Nova Senha";
            this.Txt_NovaSenha.LeadingIcon = null;
            this.Txt_NovaSenha.Location = new System.Drawing.Point(76, 251);
            this.Txt_NovaSenha.MaxLength = 50;
            this.Txt_NovaSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_NovaSenha.Multiline = false;
            this.Txt_NovaSenha.Name = "Txt_NovaSenha";
            this.Txt_NovaSenha.Size = new System.Drawing.Size(251, 50);
            this.Txt_NovaSenha.TabIndex = 3;
            this.Txt_NovaSenha.Text = "";
            this.Txt_NovaSenha.TrailingIcon = null;
            // 
            // Txt_ConfirmarSenha
            // 
            this.Txt_ConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_ConfirmarSenha.Depth = 0;
            this.Txt_ConfirmarSenha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_ConfirmarSenha.Hint = "Confirmar Senha";
            this.Txt_ConfirmarSenha.LeadingIcon = null;
            this.Txt_ConfirmarSenha.Location = new System.Drawing.Point(76, 321);
            this.Txt_ConfirmarSenha.MaxLength = 50;
            this.Txt_ConfirmarSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_ConfirmarSenha.Multiline = false;
            this.Txt_ConfirmarSenha.Name = "Txt_ConfirmarSenha";
            this.Txt_ConfirmarSenha.Size = new System.Drawing.Size(251, 50);
            this.Txt_ConfirmarSenha.TabIndex = 4;
            this.Txt_ConfirmarSenha.Text = "";
            this.Txt_ConfirmarSenha.TrailingIcon = null;
            // 
            // Btn_SalvarNovaSenha
            // 
            this.Btn_SalvarNovaSenha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_SalvarNovaSenha.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_SalvarNovaSenha.Depth = 0;
            this.Btn_SalvarNovaSenha.HighEmphasis = true;
            this.Btn_SalvarNovaSenha.Icon = null;
            this.Btn_SalvarNovaSenha.Location = new System.Drawing.Point(197, 398);
            this.Btn_SalvarNovaSenha.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_SalvarNovaSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_SalvarNovaSenha.Name = "Btn_SalvarNovaSenha";
            this.Btn_SalvarNovaSenha.Size = new System.Drawing.Size(171, 36);
            this.Btn_SalvarNovaSenha.TabIndex = 5;
            this.Btn_SalvarNovaSenha.Text = "Salvar nova Senha";
            this.Btn_SalvarNovaSenha.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_SalvarNovaSenha.UseAccentColor = false;
            this.Btn_SalvarNovaSenha.UseVisualStyleBackColor = true;
            this.Btn_SalvarNovaSenha.Click += new System.EventHandler(this.Btn_SalvarNovaSenha_Click);
            // 
            // FloatBtn_VoltarLogin
            // 
            this.FloatBtn_VoltarLogin.Depth = 0;
            this.FloatBtn_VoltarLogin.Icon = global::Sistema_Desktop_para_Hotel.Properties.Resources.Voltar;
            this.FloatBtn_VoltarLogin.Location = new System.Drawing.Point(44, 396);
            this.FloatBtn_VoltarLogin.Mini = true;
            this.FloatBtn_VoltarLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.FloatBtn_VoltarLogin.Name = "FloatBtn_VoltarLogin";
            this.FloatBtn_VoltarLogin.Size = new System.Drawing.Size(40, 40);
            this.FloatBtn_VoltarLogin.TabIndex = 6;
            this.FloatBtn_VoltarLogin.UseVisualStyleBackColor = true;
            this.FloatBtn_VoltarLogin.Click += new System.EventHandler(this.FloatBtn_VoltarLogin_Click);
            // 
            // Btn_ViewRecuperar_Senha
            // 
            this.Btn_ViewRecuperar_Senha.AutoSize = false;
            this.Btn_ViewRecuperar_Senha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_ViewRecuperar_Senha.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_ViewRecuperar_Senha.Depth = 0;
            this.Btn_ViewRecuperar_Senha.HighEmphasis = true;
            this.Btn_ViewRecuperar_Senha.Icon = global::Sistema_Desktop_para_Hotel.Properties.Resources.Ver_Senha;
            this.Btn_ViewRecuperar_Senha.Location = new System.Drawing.Point(334, 258);
            this.Btn_ViewRecuperar_Senha.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_ViewRecuperar_Senha.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_ViewRecuperar_Senha.Name = "Btn_ViewRecuperar_Senha";
            this.Btn_ViewRecuperar_Senha.Size = new System.Drawing.Size(41, 36);
            this.Btn_ViewRecuperar_Senha.TabIndex = 7;
            this.Btn_ViewRecuperar_Senha.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Btn_ViewRecuperar_Senha.UseAccentColor = true;
            this.Btn_ViewRecuperar_Senha.UseVisualStyleBackColor = true;
            this.Btn_ViewRecuperar_Senha.Click += new System.EventHandler(this.Btn_ViewRecuperar_Senha_Click);
            // 
            // Frm_EsqueciSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 458);
            this.Controls.Add(this.Btn_ViewRecuperar_Senha);
            this.Controls.Add(this.FloatBtn_VoltarLogin);
            this.Controls.Add(this.Btn_SalvarNovaSenha);
            this.Controls.Add(this.Txt_ConfirmarSenha);
            this.Controls.Add(this.Txt_NovaSenha);
            this.Controls.Add(this.Txt_recSenha_Usuario);
            this.Controls.Add(this.Lbl_Erro);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_EsqueciSenha";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esqueci Minha Senha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_EsqueciSenha_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel Lbl_Erro;
        private MaterialSkin.Controls.MaterialTextBox Txt_recSenha_Usuario;
        private MaterialSkin.Controls.MaterialTextBox Txt_NovaSenha;
        private MaterialSkin.Controls.MaterialTextBox Txt_ConfirmarSenha;
        private MaterialSkin.Controls.MaterialButton Btn_SalvarNovaSenha;
        private MaterialSkin.Controls.MaterialFloatingActionButton FloatBtn_VoltarLogin;
        private MaterialSkin.Controls.MaterialButton Btn_ViewRecuperar_Senha;
    }
}