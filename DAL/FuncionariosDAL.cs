using Classes;
using Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class FuncionariosDAL
    {
        /*MÉTODOS PARA FUNCIONÁRIOS*/
        public string CadastrarFuncionariosHotel(FuncionariosHotel funcionarios)
        {
            // Retorna Validação de Cadastro
            string saidaProcedure = "";
            // Retorno mensagem de Falha/Êxito
            string mensagemRetorno = "";
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("CadastrarFuncionariosHotel", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                sqlProcedure.Parameters.Add("Nome", SqlDbType.VarChar).Value = funcionarios.Nome;
                sqlProcedure.Parameters.Add("CPF", SqlDbType.VarChar).Value = funcionarios.CPF;
                sqlProcedure.Parameters.Add("CTPS", SqlDbType.VarChar).Value = funcionarios.CTPS;
                sqlProcedure.Parameters.Add("Email", SqlDbType.VarChar).Value = funcionarios.Email;
                sqlProcedure.Parameters.Add("Cargo", SqlDbType.VarChar).Value = funcionarios.Cargo;
                sqlProcedure.Parameters.Add("FuncStatus", SqlDbType.VarChar).Value = funcionarios.Status;
                sqlProcedure.Parameters.Add("FichaFuncStatus", SqlDbType.VarChar).Value = funcionarios.Status_Ficha;
                sqlProcedure.Parameters.Add("RetornoCadastro", SqlDbType.VarChar, 50).Direction = System.Data.ParameterDirection.Output;

                sqlProcedure.ExecuteNonQuery();

                saidaProcedure = sqlProcedure.Parameters["RetornoCadastro"].Value.ToString();

                if (saidaProcedure == "Erro")
                {
                    mensagemRetorno = "O CPF informado já consta no Sistema";

                }
                else if (saidaProcedure == "Sucesso")
                {
                    mensagemRetorno = "Funcionário Cadastrado com Sucesso";
                }

                return mensagemRetorno;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }

        // Listar Fichas Ativadas/Desativadas de Funcionários
        public List<FuncionariosHotel> ListarFichasAtivadasFuncionariosHotel()
        {
            List<FuncionariosHotel> funcionariosListados = new List<FuncionariosHotel>();
            SqlConnection connection = new StrConexao().GetConnection();
            try
            {
                string Query = "SELECT * FROM FuncionariosHotel WHERE FichaFuncStatus = 'Ativada'";
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader result = command.ExecuteReader();
                while (result.Read())
                {
                    funcionariosListados.Add(new FuncionariosHotel()
                    {
                        Nome = result["Nome"].ToString(),
                        CPF = result["CPF"].ToString(),
                        CTPS = result["CTPS"].ToString(),
                        Email = result["Email"].ToString(),
                        Cargo = result["Cargo"].ToString(),
                        Status = result["FuncStatus"].ToString(),
                        Status_Ficha = result["FichaFuncStatus"].ToString(),
                    });
                }
                return funcionariosListados;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public List<FuncionariosHotel> ListarFichasDesativadasFuncionariosHotel()
        {
            List<FuncionariosHotel> funcionariosListados = new List<FuncionariosHotel>();
            SqlConnection connection = new StrConexao().GetConnection();
            try
            {
                string Query = "SELECT * FROM FuncionariosHotel WHERE FichaFuncStatus = 'Desativada'";
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader result = command.ExecuteReader();
                while (result.Read())
                {
                    funcionariosListados.Add(new FuncionariosHotel()
                    {
                        Nome = result["Nome"].ToString(),
                        CPF = result["CPF"].ToString(),
                        CTPS = result["CTPS"].ToString(),
                        Email = result["Email"].ToString(),
                        Cargo = result["Cargo"].ToString(),
                        Status = result["FuncStatus"].ToString(),
                        Status_Ficha = result["FichaFuncStatus"].ToString(),
                    });
                }
                return funcionariosListados;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public List<FuncionariosHotel> ListarTodasFichasFuncionariosHotel()
        {
            List<FuncionariosHotel> funcionariosListados = new List<FuncionariosHotel>();
            SqlConnection connection = new StrConexao().GetConnection();
            try
            {
                string Query = "SELECT * FROM FuncionariosHotel";
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader result = command.ExecuteReader();
                while (result.Read())
                {
                    funcionariosListados.Add(new FuncionariosHotel()
                    {
                        Nome = result["Nome"].ToString(),
                        CPF = result["CPF"].ToString(),
                        CTPS = result["CTPS"].ToString(),
                        Email = result["Email"].ToString(),
                        Cargo = result["Cargo"].ToString(),
                        Status = result["FuncStatus"].ToString(),
                        Status_Ficha = result["FichaFuncStatus"].ToString(),
                    });
                }
                return funcionariosListados;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
         // Consulta e Alteração de Dados
        public FuncionariosHotel ConsultarFichaFuncionariosHotel(string cpf, out string mensagem)
        {
            mensagem = "";
            FuncionariosHotel funcionarios = new FuncionariosHotel();
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand command = new SqlCommand("ConsultarFichaFuncionario", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("PesquisaCPF", SqlDbType.VarChar).Value = cpf;
                command.Parameters.Add("RetornoConsulta", SqlDbType.VarChar, 10).Value = mensagem;

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();
                funcionarios.Nome = reader["Nome"].ToString();
                funcionarios.CPF = reader["CPF"].ToString();
                funcionarios.CTPS = reader["CTPS"].ToString();
                funcionarios.Email = reader["Email"].ToString();
                funcionarios.Cargo = reader["Cargo"].ToString();
                funcionarios.Status = reader["FuncStatus"].ToString();
                funcionarios.Status_Ficha = reader["FichaFuncStatus"].ToString();
                mensagem = "Funcionário Localizado com Sucesso";

                return funcionarios;
            }
            catch (Exception err)
            {
                mensagem = "Funcionário não pode ser localizado";
                return null;
            }
        }
        public string AlterarFichaAdmissaoFuncionarios(FuncionariosHotel funcionarios, string pesquisa)
        {
            string procedureExito = "";
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("AlterarFichasFuncionarios", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                sqlProcedure.Parameters.Add("Nome", SqlDbType.VarChar).Value = funcionarios.Nome;
                sqlProcedure.Parameters.Add("CPF", SqlDbType.VarChar).Value = funcionarios.CPF;
                sqlProcedure.Parameters.Add("CTPS", SqlDbType.VarChar).Value = funcionarios.CTPS;
                sqlProcedure.Parameters.Add("Email", SqlDbType.VarChar).Value = funcionarios.Email;
                sqlProcedure.Parameters.Add("Cargo", SqlDbType.VarChar).Value = funcionarios.Cargo;
                sqlProcedure.Parameters.Add("FuncStatus", SqlDbType.VarChar).Value = funcionarios.Status;
                sqlProcedure.Parameters.Add("FichaFuncStatus", SqlDbType.VarChar).Value = funcionarios.Status_Ficha;
                sqlProcedure.Parameters.Add("PesquisaCPF", SqlDbType.VarChar).Value = pesquisa;

                sqlProcedure.ExecuteNonQuery();

                return procedureExito = "Ficha de Admissão Alterada com Sucesso";
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }

        /*MÉTODOS PARA RELATÓRIOS - Página 'Relatórios'*/
        /*
         * -- CALCULAR GANHO TOTAL DO HOTEL
            SELECT SUM(CategoriaPreco) FROM HospedesReservas
            GO

            -- CALCULAR TOTAL DE HÓSPEDES COM RESERVAS ATIVAS
            SELECT COUNT(*) FROM HospedesReservas WHERE StatusReservaHospede = 'Ativada'
            GO

            -- CALCULAR TOTAL DE FUNCIONÁRIOS ATIVOS NO SISTEMA
            SELECT COUNT(*) FROM FuncionariosHotel WHERE FichaFuncStatus = 'Ativada'
            GO
         */
        public string GanhoTotalHotel()
        {
            string label = "";

            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("CalcGanhoTotalHotel", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader result = sqlProcedure.ExecuteReader();

                if (result.Read())
                {
                    label = result["Ganho"].ToString();
                }
                else
                {
                    label = "Erro ao atualizar os relatórios";
                }

                return label;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public string QntHospedesAtivos()
        {
            string label = "";
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("QntReservasAtivas", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader result = sqlProcedure.ExecuteReader();

                if (result.Read())
                {
                    label = result["ReservaAtiva"].ToString();
                }
                else
                {
                    label = "Erro ao atualizar os relatórios";
                }

                return label;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public string QntFuncionariosAtivos()
        {
            string label = "";
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("QntFuncionariosAtivos", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader result = sqlProcedure.ExecuteReader();

                if (result.Read())
                {
                    label = result["Valor"].ToString();
                }
                else
                {
                    label = "Erro ao atualizar os relatórios";
                }

                return label;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public string QntFuncionariosInativos()
        {
            string label = "";
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("QntFuncionariosInativos", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader result = sqlProcedure.ExecuteReader();

                if (result.Read())
                {
                    label = result["Valor"].ToString();
                }
                else
                {
                    label = "Erro ao atualizar os relatórios";
                }

                return label;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }

        // Verificar Capacidade do Hotel
        public string CapacidadeTotalHotel(out string capacidadeHotel)
        {
            capacidadeHotel = "";
            string mensagem = "";
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("CapacidadeTotal", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                sqlProcedure.Parameters.Add("Retorno", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                sqlProcedure.ExecuteNonQuery();

                capacidadeHotel = sqlProcedure.Parameters["Retorno"].Value.ToString();

                // Validação do retorno da Procedure
                switch (capacidadeHotel)
                {
                    case "Vagas":
                        mensagem = "Ainda há vagas no Hotel";
                        break;
                    case "Lotado":
                        mensagem = "Hotel Atingiu capacidade Máxima";
                        break;
                }

                return mensagem;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
