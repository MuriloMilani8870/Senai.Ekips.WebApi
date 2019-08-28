--DDL--
CREATE DATABASE M_Ekips;

USE M_Ekips;

CREATE TABLE Usuarios (
	IdUsuario		INT PRIMARY KEY IDENTITY NOT NULL
	,Email			VARCHAR(255) NOT NULL UNIQUE
	,Permissao		VARCHAR(255) NOT NULL
);

CREATE TABLE Departamentos (
	IdDepartamento				INT PRIMARY KEY IDENTITY NOT NULL
	,NomeDepartamento			VARCHAR(255) UNIQUE NOT NULL
);

CREATE TABLE Cargos (
	IdCargo			INT PRIMARY KEY IDENTITY NOT NULL
	,NomeCargo		VARCHAR(255) NOT NULL UNIQUE
	,Ativo			CHAR(3) NOT NULL
);

CREATE TABLE Funcionarios (
	IdFuncionario	INT PRIMARY KEY IDENTITY NOT NULL
	,Nome			VARCHAR(255) NOT NULL UNIQUE
	,CPF			CHAR(11) NOT NULL UNIQUE
	,DataNascimento DATE NOT NULL
	,Salario		FLOAT NOT NULL
	,IdDepartamento	INT FOREIGN KEY REFERENCES Departamentos (IdDepartamento)
	,IdCargo		INT FOREIGN KEY REFERENCES Cargos (IdCargo)
	,IdUsuario		INT FOREIGN KEY REFERENCES Usuarios (IdUsuario)
);

--DML--

INSERT INTO Usuarios (Email, Permissao)
	VALUES	('helena@gmail.com', 'ADMINISTRADOR')
			,('erik@gmail.com', 'COMUM');

INSERT INTO Departamentos (NomeDepartamento)
	VALUES	('Tecnologia')
			,('Administração')
			,('Jurídico');

INSERT INTO Cargos (NomeCargo, Ativo)
	VALUES	('Product Owner', 'SIM')
			,('Advogado Trabalhista','SIM')
			,('Engenheiro','NAO');

INSERT INTO Funcionarios (Nome, CPF, DataNascimento, Salario, IdDepartamento, IdCargo, IdUsuario)
	VALUES	('Helena', '87368831821', '2012-12-12', '3000', 1, 1, 1)
			,('Erik', '34295572918', '2011-11-11', '1500', 3, 2, 2);

--DQL--

SELECT * FROM Usuarios;

SELECT * FROM Departamentos;

SELECT * FROM Cargos;

SELECT * FROM Funcionarios;

Alter Table Usuarios
add Senha varchar (255);

INSERT INTO Usuarios (Email, Permissao)
	VALUES	('Pieri@gmail.com', 'ADMINISTRADOR')
