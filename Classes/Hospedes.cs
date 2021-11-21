using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Hospedes
    {
        private string Hosp_Nome;
        private string Hosp_CPF;
        private string Hosp_Email;
        private string Hosp_Celular;
        private string Hosp_status;
        private string Hosp_statusReserva;
        private string Hosp_NumeroCartao;
        private DateTime Hosp_CheckIn;
        private DateTime Hosp_CheckOut;
        private string Hosp_NumQuarto;
        private string Hosp_CategoriaQuarto;
        private int Hosp_CategoriaPreco;

        public Hospedes()
        {

        }

        public Hospedes
        (
            string nome, string cpf, string email, string celular, string status, string statusReserva,
            string num_cartao, DateTime checkin, DateTime checkout, 
            string num_quarto, string categoria_quarto, int categoria_preco
        )
        {
            this.Hosp_Nome = nome;
            this.Hosp_CPF = cpf;
            this.Hosp_Email = email;
            this.Hosp_Celular = celular;
            this.Hosp_status = status;
            this.Hosp_statusReserva = statusReserva;
            this.Hosp_NumeroCartao = num_cartao;
            this.Hosp_CheckIn = checkin;
            this.Hosp_CheckOut = checkout;
            this.Hosp_NumQuarto = num_quarto;
            this.Hosp_CategoriaQuarto = categoria_quarto;
            this.Hosp_CategoriaPreco = categoria_preco;
        }

        public string Nome { get => Hosp_Nome; set => Hosp_Nome = value; }
        public string CPF { get => Hosp_CPF; set => Hosp_CPF = value; }
        public string Email { get => Hosp_Email; set => Hosp_Email = value; }
        public string Celular { get => Hosp_Celular; set => Hosp_Celular = value; }
        public string Status { get => Hosp_status; set => Hosp_status = value; }
        public string Status_Reserva { get => Hosp_statusReserva; set => Hosp_statusReserva = value; }
        public string Numero_Cartao { get => Hosp_NumeroCartao; set => Hosp_NumeroCartao = value; }
        public DateTime CheckIn { get => Hosp_CheckIn; set => Hosp_CheckIn = value; }
        public DateTime CheckOut { get => Hosp_CheckOut; set => Hosp_CheckOut = value; }
        public string Numero_Quarto { get => Hosp_NumQuarto; set => Hosp_NumQuarto = value; }
        public string Categoria_Quarto { get => Hosp_CategoriaQuarto; set => Hosp_CategoriaQuarto = value; }
        public int Preco_Categoria { get => Hosp_CategoriaPreco; set => Hosp_CategoriaPreco = value; }
    }
}
