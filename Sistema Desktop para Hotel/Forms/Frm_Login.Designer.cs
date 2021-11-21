
namespace Sistema_Desktop_para_Hotel
{
    partial class Frm_Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.Btn_EsqueciMinhaSenha = new MaterialSkin.Controls.MaterialButton();
            this.Btn_Entrar = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Lbl_LoginErro = new MaterialSkin.Controls.MaterialLabel();
            this.Txt_LoginUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_LoginSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.Btn_Ver_Ocultar_Senha = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Btn_EsqueciMinhaSenha
            // 
            this.Btn_EsqueciMinhaSenha.AutoSize = false;
            this.Btn_EsqueciMinhaSenha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_EsqueciMinhaSenha.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_EsqueciMinhaSenha.Depth = 0;
            this.Btn_EsqueciMinhaSenha.HighEmphasis = true;
            this.Btn_EsqueciMinhaSenha.Icon = null;
            this.Btn_EsqueciMinhaSenha.Location = new System.Drawing.Point(19, 373);
            this.Btn_EsqueciMinhaSenha.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_EsqueciMinhaSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_EsqueciMinhaSenha.Name = "Btn_EsqueciMinhaSenha";
            this.Btn_EsqueciMinhaSenha.Size = new System.Drawing.Size(169, 36);
            this.Btn_EsqueciMinhaSenha.TabIndex = 0;
            this.Btn_EsqueciMinhaSenha.Text = "Esqueci minha senha";
            this.Btn_EsqueciMinhaSenha.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_EsqueciMinhaSenha.UseAccentColor = false;
            this.Btn_EsqueciMinhaSenha.UseVisualStyleBackColor = true;
            this.Btn_EsqueciMinhaSenha.Click += new System.EventHandler(this.Btn_EsqueciMinhaSenha_Click);
            // 
            // Btn_Entrar
            // 
            this.Btn_Entrar.AutoSize = false;
            this.Btn_Entrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Entrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Entrar.Depth = 0;
            this.Btn_Entrar.HighEmphasis = true;
            this.Btn_Entrar.Icon = null;
            this.Btn_Entrar.Location = new System.Drawing.Point(228, 373);
            this.Btn_Entrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Entrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Entrar.Name = "Btn_Entrar";
            this.Btn_Entrar.Size = new System.Drawing.Size(158, 36);
            this.Btn_Entrar.TabIndex = 1;
            this.Btn_Entrar.Text = "Entrar";
            this.Btn_Entrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Entrar.UseAccentColor = true;
            this.Btn_Entrar.UseVisualStyleBackColor = true;
            this.Btn_Entrar.Click += new System.EventHandler(this.Btn_Entrar_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(11, 321);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(376, 10);
            this.materialDivider1.TabIndex = 2;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(7, 74);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(261, 24);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Entre com o suas credenciais";
            // 
            // Lbl_LoginErro
            // 
            this.Lbl_LoginErro.AutoSize = true;
            this.Lbl_LoginErro.Depth = 0;
            this.Lbl_LoginErro.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_LoginErro.HighEmphasis = true;
            this.Lbl_LoginErro.Location = new System.Drawing.Point(68, 126);
            this.Lbl_LoginErro.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_LoginErro.Name = "Lbl_LoginErro";
            this.Lbl_LoginErro.Size = new System.Drawing.Size(248, 19);
            this.Lbl_LoginErro.TabIndex = 4;
            this.Lbl_LoginErro.Text = "Nome de Usuário/Senha incorretos";
            this.Lbl_LoginErro.UseAccent = true;
            this.Lbl_LoginErro.Visible = false;
            // 
            // Txt_LoginUsuario
            // 
            this.Txt_LoginUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_LoginUsuario.Depth = 0;
            this.Txt_LoginUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_LoginUsuario.Hint = "Usuário";
            this.Txt_LoginUsuario.LeadingIcon = null;
            this.Txt_LoginUsuario.Location = new System.Drawing.Point(64, 169);
            this.Txt_LoginUsuario.MaxLength = 50;
            this.Txt_LoginUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_LoginUsuario.Multiline = false;
            this.Txt_LoginUsuario.Name = "Txt_LoginUsuario";
            this.Txt_LoginUsuario.Size = new System.Drawing.Size(257, 50);
            this.Txt_LoginUsuario.TabIndex = 5;
            this.Txt_LoginUsuario.Text = "";
            this.Txt_LoginUsuario.TrailingIcon = null;
            // 
            // Txt_LoginSenha
            // 
            this.Txt_LoginSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_LoginSenha.Depth = 0;
            this.Txt_LoginSenha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_LoginSenha.Hint = "Senha";
            this.Txt_LoginSenha.LeadingIcon = null;
            this.Txt_LoginSenha.Location = new System.Drawing.Point(64, 236);
            this.Txt_LoginSenha.MaxLength = 50;
            this.Txt_LoginSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_LoginSenha.Multiline = false;
            this.Txt_LoginSenha.Name = "Txt_LoginSenha";
            this.Txt_LoginSenha.Password = true;
            this.Txt_LoginSenha.Size = new System.Drawing.Size(257, 50);
            this.Txt_LoginSenha.TabIndex = 6;
            this.Txt_LoginSenha.Text = "";
            this.Txt_LoginSenha.TrailingIcon = null;
            // 
            // Btn_Ver_Ocultar_Senha
            // 
            this.Btn_Ver_Ocultar_Senha.AutoSize = false;
            this.Btn_Ver_Ocultar_Senha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Ver_Ocultar_Senha.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.Btn_Ver_Ocultar_Senha.Depth = 0;
            this.Btn_Ver_Ocultar_Senha.HighEmphasis = true;
            this.Btn_Ver_Ocultar_Senha.Icon = global::Sistema_Desktop_para_Hotel.Properties.Resources.Ver_Senha;
            this.Btn_Ver_Ocultar_Senha.Location = new System.Drawing.Point(328, 242);
            this.Btn_Ver_Ocultar_Senha.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Ver_Ocultar_Senha.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Ver_Ocultar_Senha.Name = "Btn_Ver_Ocultar_Senha";
            this.Btn_Ver_Ocultar_Senha.Size = new System.Drawing.Size(40, 38);
            this.Btn_Ver_Ocultar_Senha.TabIndex = 7;
            this.Btn_Ver_Ocultar_Senha.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Btn_Ver_Ocultar_Senha.UseAccentColor = true;
            this.Btn_Ver_Ocultar_Senha.UseVisualStyleBackColor = true;
            this.Btn_Ver_Ocultar_Senha.Click += new System.EventHandler(this.Btn_Ver_Ocultar_Senha_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 424);
            this.Controls.Add(this.Btn_Ver_Ocultar_Senha);
            this.Controls.Add(this.Txt_LoginSenha);
            this.Controls.Add(this.Txt_LoginUsuario);
            this.Controls.Add(this.Lbl_LoginErro);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.Btn_Entrar);
            this.Controls.Add(this.Btn_EsqueciMinhaSenha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton Btn_EsqueciMinhaSenha;
        private MaterialSkin.Controls.MaterialButton Btn_Entrar;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel Lbl_LoginErro;
        private MaterialSkin.Controls.MaterialTextBox Txt_LoginUsuario;
        private MaterialSkin.Controls.MaterialTextBox Txt_LoginSenha;
        private MaterialSkin.Controls.MaterialButton Btn_Ver_Ocultar_Senha;
    }
}

