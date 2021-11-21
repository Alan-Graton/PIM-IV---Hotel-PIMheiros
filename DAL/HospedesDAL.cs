using Classes;
using Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HospedesDAL
    {
        public string AddCadastroReservaHospede(Hospedes hospedes)
        {
            string mensagem = "";
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();

                // Procedure para Cadastro de Hóspede
                SqlCommand sqlProcedureCadastro = new SqlCommand("CadastroReservaHospede", connection);
                sqlProcedureCadastro.CommandType = System.Data.CommandType.StoredProcedure;

                // Cadastro
                sqlProcedureCadastro.Parameters.Add("Nome", SqlDbType.VarChar).Value = hospedes.Nome;
                sqlProcedureCadastro.Parameters.Add("CPF", SqlDbType.VarChar).Value = hospedes.CPF;
                sqlProcedureCadastro.Parameters.Add("Email", SqlDbType.VarChar).Value = hospedes.Email;
                sqlProcedureCadastro.Parameters.Add("Celular", SqlDbType.VarChar).Value = hospedes.Celular;
                sqlProcedureCadastro.Parameters.Add("StatusHospede", SqlDbType.VarChar).Value = hospedes.Status;
                sqlProcedureCadastro.Parameters.Add("StatusReservaHospede", SqlDbType.VarChar).Value = hospedes.Status_Reserva;
                sqlProcedureCadastro.Parameters.Add("NumCartao", SqlDbType.VarChar).Value = hospedes.Numero_Cartao;
                // Reserva
                sqlProcedureCadastro.Parameters.Add("CheckIn", SqlDbType.DateTime).Value = hospedes.CheckIn;
                sqlProcedureCadastro.Parameters.Add("CheckOut", SqlDbType.DateTime).Value = hospedes.CheckOut;
                // Quarto
                sqlProcedureCadastro.Parameters.Add("NumeroQuarto", SqlDbType.VarChar).Value = hospedes.Numero_Quarto;
                sqlProcedureCadastro.Parameters.Add("CategoriaQuarto", SqlDbType.VarChar).Value = hospedes.Categoria_Quarto;
                sqlProcedureCadastro.Parameters.Add("CategoriaPreco", SqlDbType.Int).Value = hospedes.Preco_Categoria;

                sqlProcedureCadastro.ExecuteNonQuery();

                return mensagem;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        // Liatagem de Fichas de Reservas
        public List<Hospedes> ListarTodasReservas()
        {
            List<Hospedes> reservasListadas = new List<Hospedes>();
            SqlConnection connection = new StrConexao().GetConnection();
            try
            {
                string Query = "SELECT * FROM HospedesReservas";
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader result = command.ExecuteReader();
                while (result.Read())
                {
                    reservasListadas.Add(new Hospedes()
                    {
                        Nome = result["Nome"].ToString(),
                        CPF = result["CPF"].ToString(),
                        Email = result["Email"].ToString(),
                        Celular = result["Celular"].ToString(),
                        Status = result["StatusHospede"].ToString(),
                        Status_Reserva = result["StatusReservaHospede"].ToString(),
                        Numero_Cartao = result["NumCartao"].ToString(),
                        CheckIn = DateTime.Parse(result["CheckIn"].ToString()),
                        CheckOut = DateTime.Parse(result["CheckOut"].ToString()),
                        Numero_Quarto = result["NumeroQuarto"].ToString(),
                        Categoria_Quarto = result["CategoriaQuarto"].ToString(),
                        Preco_Categoria = int.Parse(result["CategoriaPreco"].ToString())
                    });
                }
                return reservasListadas;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public List<Hospedes> ListarReservasAtivas()
        {
            List<Hospedes> reservasListadas = new List<Hospedes>();
            SqlConnection connection = new StrConexao().GetConnection();
            try
            {
                string Query = "SELECT * FROM HospedesReservas WHERE StatusReservaHospede = 'Ativada'";
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader result = command.ExecuteReader();
                while (result.Read())
                {
                    reservasListadas.Add(new Hospedes()
                    {
                        Nome = result["Nome"].ToString(),
                        CPF = result["CPF"].ToString(),
                        Email = result["Email"].ToString(),
                        Celular = result["Celular"].ToString(),
                        Status = result["StatusHospede"].ToString(),
                        Status_Reserva = result["StatusReservaHospede"].ToString(),
                        Numero_Cartao = result["NumCartao"].ToString(),
                        CheckIn = DateTime.Parse(result["CheckIn"].ToString()),
                        CheckOut = DateTime.Parse(result["CheckOut"].ToString()),
                        Numero_Quarto = result["NumeroQuarto"].ToString(),
                        Categoria_Quarto = result["CategoriaQuarto"].ToString(),
                        Preco_Categoria =  int.Parse(result["CategoriaPreco"].ToString()) // result["CategoriaPreco"].ToString(),
                    });
                }
                return reservasListadas;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public List<Hospedes> ListarReservasInativas()
        {
            List<Hospedes> reservasListadas = new List<Hospedes>();
            SqlConnection connection = new StrConexao().GetConnection();
            try
            {
                string Query = "SELECT * FROM HospedesReservas WHERE StatusReservaHospede = 'Desativada'";
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader result = command.ExecuteReader();
                while (result.Read())
                {
                    reservasListadas.Add(new Hospedes()
                    {
                        Nome = result["Nome"].ToString(),
                        CPF = result["CPF"].ToString(),
                        Email = result["Email"].ToString(),
                        Celular = result["Celular"].ToString(),
                        Status = result["StatusHospede"].ToString(),
                        Status_Reserva = result["StatusReservaHospede"].ToString(),
                        Numero_Cartao = result["NumCartao"].ToString(),
                        CheckIn = DateTime.Parse(result["CheckIn"].ToString()),
                        CheckOut = DateTime.Parse(result["CheckOut"].ToString()),
                        Numero_Quarto = result["NumeroQuarto"].ToString(),
                        Categoria_Quarto = result["CategoriaQuarto"].ToString(),
                        Preco_Categoria = int.Parse(result["CategoriaPreco"].ToString())
                    });
                }
                return reservasListadas;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }

        public Hospedes ConsultarHospedesReservas(string cpf, out string retorno)
        {
            Hospedes hospedes = new Hospedes();
            retorno = "";
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand command = new SqlCommand("ConsultarReservaHospede", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("PesquisarCPF", SqlDbType.VarChar).Value = cpf;
                command.Parameters.Add("RetornoConsulta", SqlDbType.VarChar, 50).Value = retorno;

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();
                hospedes.Nome = reader["Nome"].ToString();
                hospedes.CPF = reader["CPF"].ToString();
                hospedes.Email = reader["Email"].ToString();
                hospedes.Celular = reader["Celular"].ToString();
                hospedes.Status = reader["StatusHospede"].ToString();
                hospedes.Status_Reserva = reader["StatusReservaHospede"].ToString();
                hospedes.Numero_Cartao = reader["NumCartao"].ToString();
                // Reserva
                hospedes.CheckIn = DateTime.Parse(reader["CheckIn"].ToString());
                hospedes.CheckOut = DateTime.Parse(reader["CheckOut"].ToString());
                // Quarto
                hospedes.Numero_Quarto = reader["NumeroQuarto"].ToString();
                hospedes.Categoria_Quarto = reader["CategoriaQuarto"].ToString();
                hospedes.Preco_Categoria = int.Parse(reader["CategoriaPreco"].ToString());
                retorno = "Hóspede Localizado com Sucesso";

                return hospedes;
            }
            catch (Exception err)
            {
                retorno = "Hóspede não pode ser localizado";
                return null;
            }
        }
        public string AlterarFichaHospede(Hospedes hospedes, string pesquisa)
        {
            string procedureExito = "";
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("AlterarFichaReservaHospede", connection);
                sqlProcedure.CommandType = CommandType.StoredProcedure;

                sqlProcedure.Parameters.Add("Nome", SqlDbType.VarChar).Value = hospedes.Nome;
                sqlProcedure.Parameters.Add("CPF", SqlDbType.VarChar).Value = hospedes.CPF;
                sqlProcedure.Parameters.Add("Email", SqlDbType.VarChar).Value = hospedes.Email;
                sqlProcedure.Parameters.Add("Celular", SqlDbType.VarChar).Value = hospedes.Celular;
                sqlProcedure.Parameters.Add("StatusHospede", SqlDbType.VarChar).Value = hospedes.Status;
                sqlProcedure.Parameters.Add("StatusReservaHospede", SqlDbType.VarChar).Value = hospedes.Status_Reserva;
                sqlProcedure.Parameters.Add("NumCartao", SqlDbType.VarChar).Value = hospedes.Numero_Cartao;

                sqlProcedure.Parameters.Add("CheckIn", SqlDbType.DateTime).Value = hospedes.CheckIn;
                sqlProcedure.Parameters.Add("CheckOut", SqlDbType.DateTime).Value = hospedes.CheckOut;

                sqlProcedure.Parameters.Add("NumeroQuarto", SqlDbType.VarChar).Value = hospedes.Numero_Quarto;
                sqlProcedure.Parameters.Add("CategoriaQuarto", SqlDbType.VarChar).Value = hospedes.Categoria_Quarto;
                sqlProcedure.Parameters.Add("CategoriaPreco", SqlDbType.VarChar).Value = hospedes.Preco_Categoria;
                sqlProcedure.Parameters.Add("PesquisarCPF", SqlDbType.VarChar).Value = pesquisa;

                sqlProcedure.ExecuteNonQuery();

                return procedureExito = "Dados alterados com Sucesso";
            }
            catch(SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
