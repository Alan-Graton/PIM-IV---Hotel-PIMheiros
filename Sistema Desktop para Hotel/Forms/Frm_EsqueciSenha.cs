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
    public partial class Frm_EsqueciSenha : MaterialForm
    {
        int cliqueBTN_Senha = 0;
        public Frm_EsqueciSenha()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void Frm_EsqueciSenha_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FloatBtn_VoltarLogin_Click(object sender, EventArgs e)
        {
            Frm_Login Login = new Frm_Login();
            this.Hide(); Login.Show();
        }

        private void Btn_SalvarNovaSenha_Click(object sender, EventArgs e)
        {
            if(Txt_recSenha_Usuario.Text.Equals("") || Txt_NovaSenha.Text.Equals("") || Txt_ConfirmarSenha.Text.Equals(""))
            {
                Lbl_Erro.Visible = true;
                Lbl_Erro.Text = "Usuário incorreto";
            }
            else
            {
                Lbl_Erro.Visible = false;
                if (Txt_ConfirmarSenha.Text != Txt_NovaSenha.Text)
                {
                    Lbl_Erro.Visible = true;
                    Lbl_Erro.Text = "Senha incorreta";
                }
                else
                {
                    LoginHotel login = new LoginHotel(Txt_recSenha_Usuario.Text, Txt_ConfirmarSenha.Text);
                    LoginHotelDAL loginDAL = new LoginHotelDAL();
                    loginDAL.CriarNovaSenha(login);
                    MaterialMessageBox.Show("Senha Atualizada com Sucesso");
                }
            }
        }

        private void Btn_ViewRecuperar_Senha_Click(object sender, EventArgs e)
        {
            cliqueBTN_Senha++;

            // Visualizar Senha
            if(cliqueBTN_Senha % 2 == 0)
            {
                Btn_ViewRecuperar_Senha.Icon = Sistema_Desktop_para_Hotel.Properties.Resources.Ver_Senha;
                Txt_NovaSenha.Password = false;
                Txt_ConfirmarSenha.Password = false;

                Txt_ConfirmarSenha.Focus();
                Txt_NovaSenha.Focus();
            }

            // Ocultar Senha
            else
            {
                Btn_ViewRecuperar_Senha.Icon = Sistema_Desktop_para_Hotel.Properties.Resources.Esconder_Senha;
                Txt_NovaSenha.Password = true;
                Txt_ConfirmarSenha.Password = true;

                Txt_ConfirmarSenha.Focus();
                Txt_NovaSenha.Focus();
            }
        }
    }
}
