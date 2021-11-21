CREATE DATABASE DB_HotelPIMheiros

USE DB_HotelPIMheiros
GO

CREATE TABLE LoginHotel(
	LoginID INT IDENTITY PRIMARY KEY,
	UsuarioLogin VARCHAR(150) NOT NULL,
	SenhaLogin VARCHAR(150) NOT NULL,
	Descricao VARCHAR(100) NOT NULL,
) DROP TABLE LoginHotel

INSERT INTO LoginHotel VALUES('Admin', 'Ger�ncia', 'Gerente')
INSERT INTO LoginHotel VALUES('Recep��o', 'Funcionario', 'Funcion�rio')

SELECT UsuarioLogin, SenhaLogin FROM LoginHotel

-- RETORNA TODOS OS NOMES, CPFs E E-MAILs DA TABELA
SELECT Nome, CPF, Email FROM FuncionariosHotel

CREATE TABLE FuncionariosHotel(
	Funcionario_ID INT IDENTITY PRIMARY KEY,
	-- Dados Pessoais
	Nome VARCHAR(150) NOT NULL,
	CPF VARCHAR(11) NOT NULL,
	CTPS VARCHAR(11) NOT NULL,
	Email VARCHAR(150) NOT NULL,
	Cargo VARCHAR(50) NOT NULL,
	FuncStatus VARCHAR(12) NOT NULL, -- Ativo || Inativo
	FichaFuncStatus VARCHAR(17) NOT NULL, -- Desativada || Ativada
) DROP TABLE FuncionariosHotel

CREATE TABLE HospedesReservas(
	Hospede_ID INT IDENTITY PRIMARY KEY,
	-- Dados Pessoais
	Nome VARCHAR(150) NOT NULL,
	CPF VARCHAR(11) NOT NULL,
	Email VARCHAR(150) NOT NULL,
	Celular VARCHAR(11) NOT NULL,
	StatusHospede VARCHAR(12) NOT NULL,
	StatusReservaHospede VARCHAR(15) NOT NULL,
	NumCartao VARCHAR(16) NOT NULL,
	CheckIn DateTime NOT NULL,
	CheckOut DateTime NOT NULL,
	NumeroQuarto INT NOT NULL,
	CategoriaQuarto VARCHAR(50) NOT NULL,
	CategoriaPreco INT NOT NULL
) DROP TABLE HospedesReservas

SELECT * FROM LoginHotel
SELECT * FROM HospedesReservas
SELECT * FROM FuncionariosHotel

INSERT INTO FuncionariosHotel VALUES('Karina Gimenez', '00000000000', '00000000000', 'karina.teste@gmail.com', 'Recepcionista', 'Ativo', 'Ativada', 'KarinaG', 'KarinaRecep')

INSERT INTO HospedesReservas VALUES('Fernanda de Oliveira', '00000000000', 'fernanda.teste@gmail.com', '11944550098', 'Ativo', 'Ativada', '0000000000000000')
INSERT INTO HospedesReservas VALUES('Alan Graton', '11111111111', 'alan.teste@gmail.com', '11944550098', 'Ativo', 'Ativada', '1111111111111111')
INSERT INTO HospedesReservas VALUES('Marcos de Brito', '22222222222', 'marcos.teste@gmail.com', '11944550098', 'Ativo', 'Ativada', '2222222222222222')
INSERT INTO HospedesReservas VALUES('Debora Graton Louren�o', '33333333333', 'debora.teste@gmail.com', '11944550098', 'Ativo', 'Ativada', '3333333333333333')

-- Procedure para CALCULAR O GANHO TOTAL DO HOTEL
DROP PROCEDURE CalcGanhoTotalHotel
CREATE PROCEDURE CalcGanhoTotalHotel

AS
	BEGIN
		SELECT SUM(CategoriaPreco) AS Ganho FROM HospedesReservas
	END
GO

EXEC CalcGanhoTotalHotel

-- Procedure para CALCULAR TOTAL DE H�SPEDES COM RESERVAS ATIVAS
DROP PROCEDURE QntReservasAtivas
CREATE PROCEDURE QntReservasAtivas

AS
	BEGIN
		SELECT COUNT(*) AS ReservaAtiva FROM HospedesReservas WHERE StatusReservaHospede = 'Ativada'
	END
GO

EXEC QntReservasAtivas

-- CALCULAR TOTAL DE FUNCION�RIOS ATIVOS NO SISTEMA
DROP PROCEDURE QntFuncionariosAtivos
CREATE PROCEDURE QntFuncionariosAtivos
AS
	BEGIN
		SELECT COUNT(*) AS Valor FROM FuncionariosHotel WHERE FichaFuncStatus = 'Ativada'
	END
GO
EXEC QntFuncionariosAtivos

-- CALCULAR TOTAL DE FUNCION�RIOS INATIVOS NO SISTEMA
DROP PROCEDURE QntFuncionariosInativos
CREATE PROCEDURE QntFuncionariosInativos
AS
	BEGIN
		SELECT COUNT(*) AS Valor FROM FuncionariosHotel WHERE FichaFuncStatus = 'Desativada'
	END
GO

EXEC QntFuncionariosInativos

-- Procedure para SE HOTEL EST� COM CAPACIDADE TOTAL
DROP PROCEDURE CapacidadeTotal
CREATE PROCEDURE CapacidadeTotal(
	@Retorno VARCHAR(50) OUTPUT
)

AS
	BEGIN
		DECLARE @CalcCapacidade INT
		SELECT @CalcCapacidade = COUNT(*) FROM HospedesReservas WHERE StatusReservaHospede = 'Ativada'
		IF(@CalcCapacidade < 75)
			BEGIN
				SET @Retorno = 'Vagas'
			END
		ELSE IF (@CalcCapacidade = 75)
			BEGIN
				SET @Retorno = 'Lotado'
			END
	END
GO

DECLARE @Retorno VARCHAR(50)
EXEC CapacidadeTotal @Retorno OUTPUT

SELECT * FROM HospedesReservas WHERE StatusReservaHospede = 'Ativada'
SELECT * FROM FuncionariosHotel WHERE FichaFuncStatus = 'Ativada'


-- Procedure para VALIDAR LOGIN AO SISTEMA
DROP PROCEDURE ValidarLogin
GO
CREATE PROCEDURE ValidarLogin(
	@UsuarioLogin VARCHAR(150),
	@SenhaLogin VARCHAR(150),
	@DescricaoLogin VARCHAR(150) OUTPUT
)

AS
	BEGIN
		IF NOT EXISTS(SELECT * FROM LoginHotel WHERE UsuarioLogin = @UsuarioLogin AND SenhaLogin = @SenhaLogin)
			BEGIN
				SELECT 'Login Inv�lido' AS Retorno
			END
		ELSE
			BEGIN
				IF EXISTS(SELECT * FROM LoginHotel WHERE Descricao = 'Gerente' AND UsuarioLogin = @UsuarioLogin AND SenhaLogin = @SenhaLogin)
					BEGIN
						SELECT 'Gerente Encontrado' AS SucessoGerente
						SET @DescricaoLogin = 'Gerente'
					END
				IF EXISTS(SELECT * FROM LoginHotel WHERE Descricao = 'Funcion�rio' AND UsuarioLogin = @UsuarioLogin AND SenhaLogin = @SenhaLogin)
					BEGIN
						SELECT 'Funcion�rio Encontrado' AS SucessoFuncionario
						SET @DescricaoLogin = 'Funcion�rio'
					END
			END
	END
GO

DECLARE @DescricaoLogin VARCHAR
EXEC ValidarLogin 'Admin', 'Admin', @DescricaoLogin OUTPUT
SELECT @DescricaoLogin

DECLARE @DescricaoLogin VARCHAR
EXEC ValidarLogin 'Recep��o', 'Func', @DescricaoLogin OUTPUT
SELECT @DescricaoLogin

-- Procedure CRIAR NOVA SENHA
DROP PROCEDURE CriaNovaSenha
GO
CREATE PROCEDURE CriaNovaSenha(
	@UsuarioLogin VARCHAR(150),
	@SenhaLogin VARCHAR(150)
)

AS
	BEGIN
		IF NOT EXISTS(SELECT * FROM LoginHotel WHERE UsuarioLogin = @UsuarioLogin)
			BEGIN
				SELECT 'Usu�rio Inv�lido' AS Retorno
			END
		ELSE
			UPDATE LoginHotel SET SenhaLogin = @SenhaLogin WHERE UsuarioLogin = @UsuarioLogin
	END
GO
EXEC CriaNovaSenha 'Admin', 'Admin'
--SELECT * FROM LoginHotel
EXEC CriaNovaSenha 'Recep��o', 'Func'
SELECT * FROM LoginHotel

-- Procedure para ALTERAR CREDENCIAIS DE LOGIN
DROP PROCEDURE AlterarCredenciaisLogin
GO
CREATE PROCEDURE AlterarCredenciaisLogin(
	@UsuarioLogin VARCHAR(150),
	@SenhaLogin VARCHAR(150),
	@Descricao VARCHAR(50)
)

AS
	BEGIN
		UPDATE LoginHotel SET UsuarioLogin = @UsuarioLogin, SenhaLogin = @SenhaLogin WHERE Descricao = @Descricao
	END
GO

DELETE FROM FuncionariosHotel WHERE CPF = ''
SELECT * FROM FuncionariosHotel

EXEC AlterarCredenciaisLogin 'Admin', 'Admin', 'Gerente'
EXEC AlterarCredenciaisLogin 'Funcion�rios', 'Recep', 'Funcion�rio'


-- Procedure para Cadastro de Funcion�rios
DROP PROCEDURE CadastrarFuncionariosHotel
GO
CREATE PROCEDURE CadastrarFuncionariosHotel(
	@Nome VARCHAR(100),
	@CPF VARCHAR(11),
	@CTPS VARCHAR(11),
	@Email VARCHAR(150),
	@Cargo VARCHAR(50),
	@FuncStatus VARCHAR(12),
	@FichaFuncStatus VARCHAR(17),
	@RetornoCadastro VARCHAR(50) OUTPUT
)

AS 
BEGIN
	IF EXISTS (SELECT * FROM FuncionariosHotel WHERE CPF = @CPF)
		BEGIN 
			SET @RetornoCadastro = 'Erro'
		END
	ELSE
		BEGIN
			INSERT INTO FuncionariosHotel VALUES(@Nome, @CPF, @CTPS, @Email, @Cargo, @FuncStatus, @FichaFuncStatus)
			SET @RetornoCadastro = 'Sucesso'
		END
END
GO

-- Procedure para CONSULTAR FICHA DE FUNCION�RIO
DROP PROCEDURE ConsultarFichaFuncionario
GO
CREATE PROCEDURE ConsultarFichaFuncionario(
	@PesquisaCPF VARCHAR(11),
	@RetornoConsulta VARCHAR(50) = 'Funcion�rio n�o pode ser localizado'
)

AS
	BEGIN
		IF NOT EXISTS(SELECT * FROM FuncionariosHotel WHERE CPF = @PesquisaCPF)
			BEGIN
				SELECT @RetornoConsulta
				--SET @RetornoConsulta = 'Erro'
				--SELECT @RetornoConsulta AS Retorno
			END
		ELSE
			BEGIN
				SELECT * FROM FuncionariosHotel WHERE CPF = @PesquisaCPF
				--SET @RetornoConsulta = 'Sucesso' 
				--SELECT @RetornoConsulta AS Retorno
			END
	END
GO

DECLARE @RetornoConsulta VARCHAR(10)
EXEC ConsultarFichaFuncionario '00000000000', @RetornoConsulta OUTPUT
EXEC ConsultarFichaFuncionario '37284612731', @RetornoConsulta OUTPUT

-- Procedure para ALTERAR FICHAS DE FUNCION�RIOS
DROP PROCEDURE AlterarFichasFuncionarios
GO
CREATE PROCEDURE AlterarFichasFuncionarios(
	@Nome VARCHAR(150),
	@CPF VARCHAR(11),
	@CTPS VARCHAR(11),
	@Email VARCHAR(150),
	@Cargo VARCHAR(50),
	@FuncStatus VARCHAR(12), 
	@FichaFuncStatus VARCHAR(17),
	@PesquisaCPF VARCHAR(11)
	-- Preciso adicionar um par�metro para comparar os CPFs corretamente
)

AS
	BEGIN
		IF NOT EXISTS (SELECT * FROM FuncionariosHotel WHERE CPF = @PesquisaCPF)
			BEGIN
				SELECT 'Usu�rio n�o encontrado' AS retorno
			END
		ELSE
			UPDATE FuncionariosHotel SET Nome=@Nome, CPF=@CPF, CTPS = @CTPS, Email=@Email, Cargo = @Cargo, 
				FuncStatus = @FuncStatus, 
				FichaFuncStatus = @FichaFuncStatus
			WHERE CPF = @PesquisaCPF
	END
GO

-- PROCEDURES PARA H�SPEDES

-- Procedure para CADASTRAR H�SPEDES
DROP PROCEDURE CadastroReservaHospede
GO
CREATE PROCEDURE CadastroReservaHospede(
	@Nome VARCHAR(150),
	@CPF VARCHAR(11),
	@Email VARCHAR(150),
	@Celular VARCHAR(11),
	@StatusHospede VARCHAR(12),
	@StatusReservaHospede VARCHAR(15),
	@NumCartao VARCHAR(16),
	@CheckIn DateTime,
	@CheckOut DateTime,
	@NumeroQuarto INT,
	@CategoriaQuarto VARCHAR(50),
	@CategoriaPreco INT
)

AS
	BEGIN
		IF EXISTS (SELECT * FROM HospedesReservas WHERE @NumeroQuarto = NumeroQuarto AND @CheckIn >= CheckIn AND @CheckOut <= CheckOut AND @CheckIn <= CheckOut AND StatusReservaHospede = 'Ativada')
			BEGIN
				SELECT 'Quarto Ocupado' AS Retorno
			END
		ELSE
			BEGIN
				INSERT INTO HospedesReservas VALUES(
					@Nome, @CPF, @Email, @Celular, @StatusHospede, @StatusReservaHospede, @NumCartao, 
					@CheckIn, @CheckOut, @NumeroQuarto, @CategoriaQuarto, @CategoriaPreco
				)
			END
	END
GO

DELETE FROM HospedesReservas WHERE Nome = 'Sla mano'

EXEC CadastroReservaHospede 'Louren�o de Brito', '11111111111', 'lourenco.teste@gmail.com', '11941402111', 'Ativo', 'Ativada', '4738237238230128', 

--CREATE PROCEDURE CadastroReservaHospede(
--	@Nome VARCHAR(150),
--	@CPF VARCHAR(11),
--	@Email VARCHAR(150),
--	@Celular VARCHAR(11),
--	@StatusHospede VARCHAR(12),
--	@StatusReservaHospede VARCHAR(15),
--	@NumCartao VARCHAR(16),
--	@CheckIn DateTime,
--	@CheckOut DateTime,
--	@NumeroQuarto INT,
--	@CategoriaQuarto VARCHAR(50),
--	@CategoriaPreco INT
--)

--AS
--	BEGIN
--		IF EXISTS (SELECT * FROM HospedesReservas WHERE CPF = @CPF AND CheckIn = @CheckIn AND CheckOut = @CheckOut AND NumeroQuarto = @NumeroQuarto)
--			BEGIN
--				SELECT 'Quarto Ocupado' AS Retorno
--			END
--		ELSE
--			BEGIN
--				INSERT INTO HospedesReservas VALUES(
--					@Nome, @CPF, @Email, @Celular, @StatusHospede, @StatusReservaHospede, @NumCartao, 
--					@CheckIn, @CheckOut, @NumeroQuarto, @CategoriaQuarto, @CategoriaPreco
--				)
--			END
--	END
--GO



EXEC CadastroReservaHospede 'Alan Graton', '00000000000', 'alan.teste@gmail.com', '11941402300', 'Ativo', 'Ativada', '00000000000', '05/11/2021', '06/11/2021', 1, 'Standard', 150
-- Quartos STANDARD
INSERT INTO HospedesReservas VALUES ('Louren�o de Brito', '11111111111', 'lourenco.teste@gmail.com', '11941402111', 'Inativo', 'Desativada', '11111111111', '05/11/2021', '08/11/2021', 2, 'Standard', 150)
INSERT INTO HospedesReservas VALUES ('Amanda Azevedo', '22222222222', 'amanda.teste@gmail.com', '11941402111', 'Inativo', 'Desativada', '22222222222', '05/11/2021', '12/11/2021', 3, 'Standard', 150)
INSERT INTO HospedesReservas VALUES ('Karina Gonsalvez', '33333333333', 'karina.teste@gmail.com', '11941402111', 'Inativo', 'Desativada', '33333333333', '05/11/2021', '15/11/2021', 4, 'Standard', 150)
INSERT INTO HospedesReservas VALUES ('Karen Gabriella', '44444444444', 'karen.teste@gmail.com', '11941402111', 'Ativa', 'Ativada', '44444444444', '05/11/2021', '19/11/2021', 5, 'Standard', 150)
INSERT INTO HospedesReservas VALUES ('Murilo dos Santos', '55555555555', 'murilo.teste@gmail.com', '11941402111', 'Inativo', 'Desativada', '55555555555', '05/11/2021', '20/11/2021', 6, 'Standard', 150)
INSERT INTO HospedesReservas VALUES ('Paulo Henrique', '66666666666', 'paulo.teste@gmail.com', '11941402111', 'Ativa', 'Ativada', '66666666666', '05/11/2021', '23/11/2021', 7, 'Standard', 150)
INSERT INTO HospedesReservas VALUES ('Juan Oliveira', '77777777777', 'juan.teste@gmail.com', '11941402111', 'Inativo', 'Desativada', '77777777777', '05/11/2021', '26/11/2021', 8, 'Standard', 150)
INSERT INTO HospedesReservas VALUES ('Caleu Souza', '88888888888', 'caleu.teste@gmail.com', '11941402111', 'Ativa', 'Ativada', '88888888888', '05/11/2021', '30/11/2021', 9, 'Standard', 150)
-- Quartos MASTER
INSERT INTO HospedesReservas VALUES ('Armando da Silva', '99999999999', 'lourenco.teste@gmail.com', '11941402111', 'Ativo', 'Ativada', '99999999999', '01/11/2021', '06/11/2021', 10, 'Master', 250)
INSERT INTO HospedesReservas VALUES ('Mariana Bizarria', '10101010101', 'lourenco.teste@gmail.com', '11941402111', 'Inativo', 'Desativada', '10101010101', '02/11/2021', '06/11/2021', 11, 'Master', 250)
INSERT INTO HospedesReservas VALUES ('Maria Alvez', '01010101010', 'lourenco.teste@gmail.com', '11941402111', 'Ativo', 'Ativada', '01010101010', '05/11/2021', '03/11/2021', 12, 'Master', 250)
INSERT INTO HospedesReservas VALUES ('Layza Amaro', '20202020202', 'lourenco.teste@gmail.com', '11941402111', 'Inativo', 'Desativada', '20202020202', '04/11/2021', '06/11/2021', 13, 'Master', 250)
INSERT INTO HospedesReservas VALUES ('Tain� Souza', '02020202020', 'lourenco.teste@gmail.com', '11941402111', 'Ativo', 'Ativada', '02020202020', '06/11/2021', '06/11/2021', 14, 'Master', 250)
INSERT INTO HospedesReservas VALUES ('Matheus Gonsalvez', '30303030303', 'lourenco.teste@gmail.com', '11941402111', 'Inativo', 'Desativada', '30303030303', '07/11/2021', '06/11/2021', 15, 'Master', 250)
INSERT INTO HospedesReservas VALUES ('La�s da Silva', '03030303030', 'lourenco.teste@gmail.com', '11941402111', 'Inativo', 'Desativada', '03030303030', '08/11/2021', '06/11/2021', 16, 'Master', 250)
INSERT INTO HospedesReservas VALUES ('Arnaldo de Brito', '40404040404', 'lourenco.teste@gmail.com', '11941402111', 'Ativo', 'Ativada', '40404040404', '09/11/2021', '06/11/2021', 17, 'Master', 250)
INSERT INTO HospedesReservas VALUES ('Bruno Henrique', '04040404040', 'lourenco.teste@gmail.com', '11941402111', 'Inativo', 'Desativada', '04040404040', '10/11/2021', '06/11/2021', 18, 'Master', 250)
INSERT INTO HospedesReservas VALUES ('Vin�cius Rocha', '50505050505', 'lourenco.teste@gmail.com', '11941402111', 'Inativo', 'Desativada', '50505050505', '11/11/2021', '06/11/2021', 19, 'Master', 250)
-- Quartos DELUXE
INSERT INTO HospedesReservas VALUES ('Caique de Souza Silva', '05050505050', 'lourenco.teste@gmail.com', '11941402111', 'Ativo', 'Ativada', '05050505050', '01/11/2021', '06/11/2021', 20, 'Deluxe', 350)
INSERT INTO HospedesReservas VALUES ('Diego Barbosa', '60606060606', 'lourenco.teste@gmail.com', '11941402111', 'Ativo', 'Ativada', '60606060606', '02/11/2021', '06/11/2021', 21, 'Deluxe', 350)
INSERT INTO HospedesReservas VALUES ('Vin�cius Dourado', '07070707070', 'lourenco.teste@gmail.com', '11941402111', 'Inativo', 'Desativada', '07070707070', '03/11/2021', '06/11/2021', 22, 'Deluxe', 350)
INSERT INTO HospedesReservas VALUES ('Gustavo Fuzel', '70707070707', 'lourenco.teste@gmail.com', '11941402111', 'Inativo', 'Desativada', '70707070707', '04/11/2021', '06/11/2021', 23, 'Deluxe', 350)
INSERT INTO HospedesReservas VALUES ('Danilo Louren�o', '08080808080', 'lourenco.teste@gmail.com', '11941402111', 'Inativo', 'Desativada', '08080808080', '05/11/2021', '06/11/2021', 24, 'Deluxe', 350)
INSERT INTO HospedesReservas VALUES ('Rodney Am�ncio', '80808080808', 'lourenco.teste@gmail.com', '11941402111', 'Ativo', 'Ativada', '80808080808', '06/11/2021', '06/11/2021', 25, 'Deluxe', 350)
INSERT INTO HospedesReservas VALUES ('Roger Adriano', '09090909090', 'lourenco.teste@gmail.com', '11941402111', 'Inativo', 'Desativada', '09090909090', '07/11/2021', '06/11/2021', 26, 'Deluxe', 350)
INSERT INTO HospedesReservas VALUES ('Eduarda Vilete', '90909090909', 'lourenco.teste@gmail.com', '11941402111', 'Inativo', 'Desativada', '90909090909', '08/11/2021', '06/11/2021', 27, 'Deluxe', 350)
INSERT INTO HospedesReservas VALUES ('V�l�ria Maria de Souza', '11122233344', 'lourenco.teste@gmail.com', '11941402111', 'Inativo', 'Desativada', '11122233344', '09/11/2021', '06/11/2021', 28, 'Deluxe', 350)
INSERT INTO HospedesReservas VALUES ('Jo�o Pedro', '44455566677', 'lourenco.teste@gmail.com', '11941402111', 'Inativo', 'Desativada', '44455566677', '05/11/2021', '10/11/2021', 29, 'Deluxe', 350)
SELECT * FROM HospedesReservas

DECLARE @DescricaoLogin VARCHAR
EXEC ValidarLogin 'Admin', 'Admin', @DescricaoLogin OUTPUT
SELECT @DescricaoLogin

-- Procedure CONSULTAR H�SPEDE E SUA RESERVA
DROP PROCEDURE ConsultarReservaHospede
CREATE PROCEDURE ConsultarReservaHospede(
	@PesquisarCPF VARCHAR(11),
	@RetornoConsulta VARCHAR(70) = 'H�spede n�o localizado'
)

AS
	BEGIN
		DECLARE @Aviso VARCHAR(50)
		IF NOT EXISTS(SELECT * FROM HospedesReservas WHERE CPF = @PesquisarCPF)
			BEGIN
				SELECT @RetornoConsulta
			END
		ELSE
			BEGIN
				SELECT * FROM HospedesReservas WHERE CPF = @PesquisarCPF
			END
	END
GO
DECLARE @RetornoConsulta VARCHAR
EXEC ConsultarReservaHospede '42379487218', @RetornoConsulta OUTPUT
SELECT @RetornoConsulta as Aviso

DELETE FROM HospedesReservas WHERE Nome = 'Joana Darc'

-- Procedure ALTERAR FICHA/RESERVA DE H�SPEDES
DROP PROCEDURE AlterarFichaReservaHospede
CREATE PROCEDURE AlterarFichaReservaHospede(
	@Nome VARCHAR(150),
	@CPF VARCHAR(11),
	@Email VARCHAR(150),
	@Celular VARCHAR(11),
	@StatusHospede VARCHAR(12),
	@StatusReservaHospede VARCHAR(15),
	@NumCartao VARCHAR(16),
	@CheckIn DateTime,
	@CheckOut DateTime,
	@NumeroQuarto INT,
	@CategoriaQuarto VARCHAR(50),
	@CategoriaPreco INT,
	@PesquisarCPF VARCHAR(11)
)

AS
	BEGIN
		IF NOT EXISTS (SELECT * FROM HospedesReservas WHERE CPF = @PesquisarCPF)
			BEGIN
				SELECT 'Ficha n�o encontrada ;-;' AS Retorno
			END
			-- @NumeroQuarto = NumeroQuarto AND @CheckIn >= CheckIn AND @CheckOut <= CheckOut AND @CheckIn <= CheckOut AND StatusReservaHospede = 'Ativada'
		ELSE IF EXISTS (SELECT * FROM HospedesReservas WHERE @NumeroQuarto = NumeroQuarto AND @CheckIn = CheckIn AND @CheckOut = CheckOut AND StatusReservaHospede = 'Ativada')
			BEGIN
				SELECT 'Quarto Ocupado' AS Retorno
			END
		ELSE
			BEGIN
				UPDATE HospedesReservas SET Nome=@Nome, CPF=@CPF, Email=@Email, Celular=@Celular, StatusHospede=@StatusHospede, StatusReservaHospede=@StatusReservaHospede,
				NumCartao=@NumCartao, CheckIn=@CheckIn, CheckOut=@CheckOut, 
				NumeroQuarto=@NumeroQuarto, CategoriaQuarto=@CategoriaQuarto, CategoriaPreco=@CategoriaPreco WHERE CPF = @PesquisarCPF
			END
	END
GO

SELECT * FROM HospedesReservas


DECLARE @FK_Hospede INT
EXEC SalvarReservaHospede '06/10/2021', '07/10/2021', 10, 'Master', @FK_Hospede
EXEC SalvarReservaHospede '04/10/2021', '05/10/2021', 10, 'Deluxe', @FK_Hospede