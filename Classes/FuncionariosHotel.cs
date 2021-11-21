using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class FuncionariosHotel
    {
        private string Func_Nome;
        private string Func_CPF;
        private string Func_CTPS;
        private string Func_Email;
        private string Func_Cargo;
        private string Func_Status;
        private string Func_StatusFicha;
        
        public FuncionariosHotel()
        {

        }

        public FuncionariosHotel(string nome, string cpf, string ctps, string email, string cargo, 
            string status, string status_ficha)
        {
            this.Func_Nome = nome;
            this.Func_CPF = cpf;
            this.Func_CTPS = ctps;
            this.Func_Email = email;
            this.Func_Cargo = cargo;
            this.Func_Status = status;
            this.Func_StatusFicha = status_ficha;
        }

        public string Nome { get => Func_Nome; set => Func_Nome = value; }
        public string CPF { get => Func_CPF; set => Func_CPF = value; }
        public string CTPS { get => Func_CTPS; set => Func_CTPS = value; }
        public string Email { get => Func_Email; set => Func_Email = value; }
        public string Cargo { get => Func_Cargo; set => Func_Cargo = value; }
        public string Status { get => Func_Status; set => Func_Status = value; }
        public string Status_Ficha { get => Func_StatusFicha; set => Func_StatusFicha = value; }

    }
}
