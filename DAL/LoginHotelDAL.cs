using Classes;
using Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginHotelDAL
    {
        public string ValidarLoginHotel(LoginHotel login, out string retornoDescricaoLogin)
        {
            retornoDescricaoLogin = "";
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("ValidarLogin", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                sqlProcedure.Parameters.Add("UsuarioLogin", System.Data.SqlDbType.VarChar).Value = login.UsuarioHotel;
                sqlProcedure.Parameters.Add("SenhaLogin", System.Data.SqlDbType.VarChar).Value = login.SenhaHotel;
                sqlProcedure.Parameters.Add("DescricaoLogin", System.Data.SqlDbType.VarChar, 50).Direction = System.Data.ParameterDirection.Output;

                sqlProcedure.ExecuteNonQuery();
                
                retornoDescricaoLogin = sqlProcedure.Parameters["DescricaoLogin"].Value.ToString();

                return retornoDescricaoLogin;
            }
            catch(SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        // "Esqueci Minha Senha"
        public string CriarNovaSenha(LoginHotel login)
        {
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("CriaNovaSenha", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                sqlProcedure.Parameters.Add("UsuarioLogin", System.Data.SqlDbType.VarChar).Value = login.UsuarioHotel;
                sqlProcedure.Parameters.Add("SenhaLogin", System.Data.SqlDbType.VarChar).Value = login.SenhaHotel;

                sqlProcedure.ExecuteNonQuery();

                return "Senha atualizada com Sucesso";
            }
            catch(SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        // Configurações - Alterar Credenciais de Login
        public string AlterarCredenciaisLogin(LoginHotel login, string descricao)
        {
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("AlterarCredenciaisLogin", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                sqlProcedure.Parameters.Add("UsuarioLogin", System.Data.SqlDbType.VarChar).Value = login.UsuarioHotel;
                sqlProcedure.Parameters.Add("SenhaLogin", System.Data.SqlDbType.VarChar).Value = login.SenhaHotel;
                sqlProcedure.Parameters.Add("Descricao", System.Data.SqlDbType.VarChar).Value = descricao;

                sqlProcedure.ExecuteNonQuery();

                return "Credenciais Alteradas com Sucesso";
            }
            catch(SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}