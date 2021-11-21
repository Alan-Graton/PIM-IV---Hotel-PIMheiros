using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class LoginHotel
    {
        private string UsuarioLogin;
        private string SenhaLogin;

        public LoginHotel()
        {

        }
        public LoginHotel(string login, string senha)
        {
            this.UsuarioLogin = login;
            this.SenhaLogin = senha;
        }

        public string UsuarioHotel { get => UsuarioLogin; set => UsuarioLogin = value; }
        public string SenhaHotel { get => SenhaLogin; set => SenhaLogin = value; }
    }
}
