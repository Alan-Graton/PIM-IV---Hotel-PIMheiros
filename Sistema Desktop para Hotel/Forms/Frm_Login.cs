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
using Sistema_Desktop_para_Hotel.Forms;

namespace Sistema_Desktop_para_Hotel
{
    public partial class Frm_Login : MaterialForm
    {
        int Clique = 0;
        public Frm_Login()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Brown900, Primary.DeepOrange700,
                Primary.Yellow900, Accent.DeepOrange400,
                TextShade.WHITE
            );
        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            if(Txt_LoginUsuario.Text.Equals("") || Txt_LoginSenha.Text.Equals(""))
            {
                Lbl_LoginErro.Visible = true;
            }
            else
            {
                LoginHotel login = new LoginHotel(Txt_LoginUsuario.Text, Txt_LoginSenha.Text);
                LoginHotelDAL loginDAL = new LoginHotelDAL();
                loginDAL.ValidarLoginHotel(login, out string retornoDescricaoLogin);
                // Redirecionando Usuários para suas respectivas telas
                switch (retornoDescricaoLogin)
                {
                    case "Gerente":
                        Lbl_LoginErro.Visible = false;
                        Frm_Gerencia gerente = new Frm_Gerencia();
                        this.Hide(); gerente.Show();
                        break;
                    case "Funcionário":
                        Lbl_LoginErro.Visible = false;
                        Frm_Funcionarios funcionarios = new Frm_Funcionarios();
                        this.Hide(); funcionarios.Show();
                        break;
                }
            }
        }

        private void Btn_Ver_Ocultar_Senha_Click(object sender, EventArgs e)
        {
            Clique++;
            // Ocultar Senha
            if(Clique % 2 == 0)
            {
                Btn_Ver_Ocultar_Senha.Icon = Sistema_Desktop_para_Hotel.Properties.Resources.Ver_Senha;
                Txt_LoginSenha.Password = true;
                Txt_LoginSenha.Focus();
            }
            // Revelar Senha
            else
            {
                Btn_Ver_Ocultar_Senha.Icon = Sistema_Desktop_para_Hotel.Properties.Resources.Esconder_Senha;
                Txt_LoginSenha.Password = false;
                Txt_LoginSenha.Focus();
            }
        }

        private void Btn_EsqueciMinhaSenha_Click(object sender, EventArgs e)
        {
            Frm_EsqueciSenha EsqueciSenha = new Frm_EsqueciSenha();
            this.Hide(); EsqueciSenha.Show();
        }
    }
}
