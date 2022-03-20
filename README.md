# CMA - Controle de Manutenção Automotiva

<p>Aplicação em Windows Forms no padrão MVC criada para registrar o controle de manutenção de veículos.</p>

## Ferramentas utilizadas

- Csharp
- ODBC
- Microsoft SQL Server

## Preparação do ambiente
Para rodar o projeto, utlize a IDE que você mais se identifique **(no meu caso, utilizo o Visual Studio Community)**, em seguida, altere a classe **dbstring.cs** para que o projeto se adeque ao seu **banco de dados**:

**Trecho da classe que deve ser alterado**:

````csharp
    public class Dbstring
    {
        public static string Cnx = @"Data Source=KBMNITRO\KBMNITRO;Initial Catalog=ManutencaoVeicular;
Persist Security Info=False;User ID=sa;Password=Dev2020@;MultipleActiveResultSets=False;Encrypt=False;
TrustServerCertificate=False;Connection Timeout=30;";
    }
````

Também se faz necessário criar o banco de dados, rodando o script abaixo:

````tsql
-- ########################################## --
--  ------------ MANUTENÇÃO VEICULAR -----------
-- ########################################## --
-- Este banco de dados foi desenvolvido para um sistema de Controle  
--de manutenção veicular, para que o proprietário do automóvel possa 
--registrar, periodicamente, suas manutenções concluídas, tendo um 
--controle preciso sobre as manutenções de seu veículo.
--
-- ************************************************ --
--   Sistema de Controle para manutenção veicular   --
-- ************************************************ --

Create database ManutencaoVeicular
go

Use ManutencaoVeicular
go

Create table Componente
(
	IDComponente int identity primary key not null,
	Componente varchar(75) not null
)

Create table Fabricante
(
	IDFabricante int identity primary key not null,
	Fabricante varchar(45) not null
)

Create table TipoManutencao
(
	IDTipoManutencao int identity primary key not null,
	TipoManutencao varchar(45) not null
)

Create table Veiculo
(
	IDVeiculo int identity primary key not null,
	Apelido varchar(45),
	Montadora varchar(45) not null,
	Modelo varchar(75) not null,
	Ano date not null
)

Create table HistoricoManutencao
(
	IDHistoricoManutencao int identity primary key not null,
	Km decimal(7) not null,
	DataManutencao date not null,
	KmProxTroca decimal(7),
	Valor decimal(7,2) not null,
	FKFabricante int not null,
	FKTipoManutencao int not null,
	FKComponente int not null,
	FKApelido int not null
)

Create table Estabelecimento
(
	IDEstabelecimento int identity primary key not null,
	Estabelecimento varchar(100) not null
)

Create table Planejadas
(
	IDPlanejadas int identity primary key not null,
	Agendamento date,
	Descricao varchar(200),
	Executado int not null,
	FKApelido int not null,
	FKEstabelecimento int
)

Create table Compras
(
	IDCompras int identity primary key not null,
	Descricao varchar(200) not null,
	FKComponente int not null,
)

alter table Compras add Quantidade int not null, Executado int not null;

go

/*Relacionamento entre Histórico de manutenção e Veículo */

alter table HistoricoManutencao add constraint FK_B002FKApelido  foreign key (FKApelido) 
references Veiculo (IDVeiculo)

go

/*Relacionamento entre Histórico de manutenção e Fabricante */

alter table HistoricoManutencao add constraint FK_B002FKFabricante  foreign key (FKFabricante) 
references Fabricante (IDFabricante)

go

/*Relacionamento entre Histórico de manutenção e Tipo de manutenção */

alter table HistoricoManutencao add constraint FK_B002FKTipoManutencao foreign key (FKTipoManutencao)
references TipoManutencao (IDTipoManutencao)

go

/*Relacionamento entre Histórico de manutenção e Componente */

alter table HistoricoManutencao add constraint FK_B002FKComponente foreign key (FKComponente)
references Componente (IDComponente)

go

/*Relacionamento entre Planejadas e Veiculo */

alter table Planejadas add constraint FK_PlanejadasVeiculo foreign key (FKApelido)
references Veiculo (IDVeiculo)

go

/*Relacionamento entre Planejadas e Estabelecimento */

alter table Planejadas add constraint FK_PlanejadasEstabelecimento foreign key (FKEstabelecimento)
references Estabelecimento (IDEstabelecimento)

go

/*Relacionamento entre Compras e Componente */

alter table Compras add constraint FK_ComprasComponente foreign key (FKComponente)
references Componente (IDComponente)

go


-- ######################### --
--  CRIAÇÃO DAS PROCEDURES   --
-- ######################### --

-- *********************** --
--  Procedures Fabricante  --
-- *********************** --

-- Procedure para cadastro de Fabricantes --

create proc ProcCadastrarFabricante
@IDFabricante int output,
@Fabricante varchar(45)
as
insert into Fabricante (Fabricante) values (@Fabricante)
go

-- Procedure para exibir Fabricantes --

create proc ProcExibirFabricante
as
select * from Fabricante
order by IDFabricante desc
go

-- Procedure para editar Fabricantes --

create proc ProcEditarFabricante
@IDFabricante int,
@Fabricante varchar(45)
as 
update Fabricante set Fabricante = @Fabricante where IDFabricante = @IDFabricante
go

-- Procedure para excluir Fabricantes --

create proc ProcExcluirFabricante
@IDFabricante int
as
delete from Fabricante where IDFabricante = @IDFabricante
go

-- Procedure para pesquisar Fabricantes --

create proc ProcPesquisarFabricante
@PesquisarFabricante varchar(45)
as
select * from Fabricante where Fabricante like @PesquisarFabricante + '%'
go


-- *********************** --
--  Procedures Componente  --
-- *********************** --

-- Procedure para cadastro de Componentes --

create proc ProcCadastrarComponente
@IDComponente int output,
@Componente varchar(75)
as
insert into Componente (Componente) values (@Componente)
go

-- Procedure para exibir Componentes --

create proc ProcExibirComponente
as
select * from Componente
order by IDComponente desc
go

-- Procedure para editar Componentes --

create proc ProcEditarComponente
@IDComponente int,
@Componente varchar(75)
as 
update Componente set Componente = @Componente where IDComponente = @IDComponente
go

-- Procedure para excluir Componentes --

create proc ProcExcluirComponente
@IDComponente int
as
delete from Componente where IDComponente = @IDComponente
go

-- Procedure para pesquisar Componentes --

create proc ProcPesquisarComponente
@PesquisarComponente varchar(75)
as
select * from Componente where Componente like @PesquisarComponente + '%'
go

-- *************************** --
--  Procedures TipoManutencao  --
-- *************************** --

-- Procedure para cadastro de Tipos de Manutenção --

create proc ProcCadastrarTipoManutencao
@IDTipoManutencao int output,
@TipoManutencao varchar(45)
as
insert into TipoManutencao (TipoManutencao) values (@TipoManutencao)
go

-- Procedure para exibir Tipos de manutenção --

create proc ProcExibirTipoManutencao
as
select * from TipoManutencao
order by IDTipoManutencao desc
go

-- Procedure para editar Tipos de Manutenção --

create proc ProcEditarTipoManutencao
@IDTipoManutencao int,
@TipoManutencao varchar(45)
as 
update TipoManutencao set TipoManutencao = @TipoManutencao where IDTipoManutencao = @IDTipoManutencao
go

-- Procedure para excluir Tipos de Manutenção --

create proc ProcExcluirTipoManutencao
@IDTipoManutencao int
as
delete from TipoManutencao where IDTipoManutencao = @IDTipoManutencao
go

-- Procedure para pesquisar Tipos de Manutenção --

create proc ProcPesquisarTipoManutencao
@PesquisarTipoManutencao varchar(45)
as
select * from TipoManutencao where TipoManutencao like @PesquisarTipoManutencao + '%'
go

-- ************************************ --
--  Procedures Histórico de Manutencao  --
-- ************************************ --

-- Procedure para cadastro dos Históricos de Manutenção

create proc ProcCadastrarHistoricoManutencao
@IDHistoricoManutencao int output,
@Km decimal(7),
@DataManutencao date,
@KmProxTroca decimal(7),
@Valor decimal(7),
@FKFabricante int,
@FKTipoManutencao int,
@FKComponente int,
@FKApelido int
as
insert into HistoricoManutencao (Km, DataManutencao, KmProxTroca, Valor, FKFabricante, FKTipoManutencao, FKComponente, 
FKApelido) values (@Km, @DataManutencao, @KmProxTroca, @Valor, @FKFabricante, @FKTipoManutencao, @FKComponente, @FKApelido)
go

-- Procedure para exibir Históricos de Manutenção --

create proc ProcExibirHistManutencao
as
select IDHistoricoManutencao, Apelido, DataManutencao, Km, Componente, Fabricante, TipoManutencao, Valor, KmProxTroca
from HistoricoManutencao
inner join Veiculo as V
on V.IDVeiculo = HistoricoManutencao.FKApelido
inner join TipoManutencao as T
on T.IDTipoManutencao = HistoricoManutencao.FKTipoManutencao
inner join Fabricante as F
on F.IDFabricante = HistoricoManutencao.FKFabricante
inner join Componente as C
on C.IDComponente = HistoricoManutencao.FKComponente
order by IDHistoricoManutencao desc
go


-- Procedure para editar Históricos de Manutenção --

create proc ProcEditarHistoricoManutencao
@IDHistoricoManutencao int,
@Km decimal(7),
@DataManutencao date,
@KmProxTroca decimal(7),
@Valor decimal(7),
@FKFabricante int,
@FKTipoManutencao int,
@FKComponente int,
@FKApelido int
as 
update HistoricoManutencao set Km = @Km, DataManutencao = @DataManutencao, KmProxTroca = @KmProxTroca, 
Valor = @Valor, FKFabricante = @FKFabricante, FKTipoManutencao = @FKTipoManutencao, 
FKComponente = @FKComponente, FKApelido = @FKApelido where IDHistoricoManutencao = @IDHistoricoManutencao
go

-- Procedure para excluir Histórico de Manutenção --

create proc ProcExcluirHistoricoManutencao
@IDHistoricoManutencao int
as
delete from HistoricoManutencao where IDHistoricoManutencao = @IDHistoricoManutencao
go

-- Procedure para pesquisar Históricos de Manutenção --

create proc ProcPesquisarHistoricoManutencao
@PesquisarHistoricoManutencao varchar(75)
as
select * from HistoricoManutencao where FKComponente like @PesquisarHistoricoManutencao + '%'
go


-- *********************** --
--  Procedures Planejadas  --
-- *********************** --

-- Procedure para cadastro de Manutenções Planejadas --

create proc ProcCadastrarPlanejada
@IDPlanejadas int output,
@Agendamento date,
@Descricao varchar(200),
@Executado int,
@FKApelido int,
@FKEstabelecimento int
as
insert into Planejadas(Agendamento, Descricao, Executado, FKApelido, FKEstabelecimento) values (@Agendamento,
@Descricao, @Executado, @FKApelido, @FKEstabelecimento)
go

-- Procedure para exibir Manutenções Planejadas --

create proc ProcExibirPlanejada
as
select * from Planejadas
order by IDPlanejadas desc
go

-- Procedure para editar Planejadas --

create proc ProcEditarPlanejada
@IDPlanejadas int,
@Agendamento date,
@Descricao varchar(200),
@Executado int,
@FKApelido int,
@FKEstabelecimento int
as 
update Planejadas set Agendamento = @Agendamento, Descricao = @Descricao, Executado = @Executado,
FKApelido = @FKApelido, FKEstabelecimento = @FKEstabelecimento where IDPlanejadas = @IDPlanejadas
go

-- Procedure para excluir Planejadas --

create proc ProcExcluirPlanejadas
@IDPlanejadas int
as
delete from Planejadas where IDPlanejadas = @IDPlanejadas
go

-- Procedure para pesquisar Planejadas --

create proc ProcPesquisarPlanejadas
@PesquisarPlanejadas varchar(200)
as
select * from Planejadas where Descricao like @PesquisarPlanejadas + '%'
go

-- ******************** --
--  Procedures Compras  --
-- ******************** --

-- Procedure para cadastro de Compras --

create proc ProcCadastrarCompras
@IDCompras int output,
@Descricao varchar(200),
@FKComponente int,
@Quantidade int,
@Executado int
as
insert into Compras(Descricao, FKComponente, Quantidade, Executado) values (@Descricao,
@FKComponente, @Quantidade, @Executado)
go

-- Procedure para exibir Compras --

create proc ProcExibirCompras
as
select * from Compras
order by IDCompras desc
go

-- Procedure para editar Compras --

create proc ProcEditarCompras
@IDCompras int,
@Descricao varchar(200),
@FKComponente int,
@Quantidade int,
@Executado int
as 
update Compras set Descricao = @Descricao, FKComponente = @FKComponente, Quantidade = @Quantidade,
Executado = @Executado where IDCompras = @IDCompras
go

-- Procedure para excluir Compras --

create proc ProcExcluirCompras
@IDCompras int
as
delete from Compras where IDCompras = @IDCompras
go

-- Procedure para pesquisar Compras --

create proc ProcPesquisarCompras
@PesquisarCompras varchar(200)
as
select * from Compras where Descricao like @PesquisarCompras + '%'
go


-- **************************** --
--  Procedures Estabelecimento  --
-- **************************** --

-- Procedure para cadastro de Estabelecimento --

create proc ProcCadastrarEstabelecimento
@IDEstabelecimento int output,
@Estabelecimento varchar(100)
as
insert into Estabelecimento(Estabelecimento) values (@Estabelecimento)
go

-- Procedure para exibir Estabelecimentos --

create proc ProcExibirEstabelecimento
as
select * from Estabelecimento
order by IDEstabelecimento desc
go

-- Procedure para editar Estabelecimento --

create proc ProcEditarEstabelecimento
@IDEstabelecimento int,
@Estabelecimento varchar(100)
as 
update Estabelecimento set Estabelecimento = @Estabelecimento where IDEstabelecimento = @IDEstabelecimento
go

-- Procedure para excluir Estabelecimento --

create proc ProcExcluirEstabelecimento
@IDEstabelecimento int
as
delete from Estabelecimento where IDEstabelecimento = @IDEstabelecimento
go

-- Procedure para pesquisar Estabelecimento --

create proc ProcPesquisarEstabelecimento
@PesquisarEstabelecimento varchar(100)
as
select * from Estabelecimento where Estabelecimento like @PesquisarEstabelecimento + '%'
go

-- ******************** --
--  Procedures Veículo  --
-- ******************** --

-- Procedure para cadastro de Veículos --

create proc ProcCadastrarVeiculo
@IDVeiculo int output,
@Apelido varchar(45),
@Montadora varchar(45),
@Modelo varchar(75),
@Ano date
as
insert into Veiculo(Apelido, Montadora, Modelo, Ano) values (@Apelido, @Montadora, @Modelo, @Ano)
go

-- Procedure para exibir Veículos --

create proc ProcExibirVeiculo
as
select * from Veiculo
order by IDVeiculo desc
go

-- Procedure para editar Veículos --

create proc ProcEditarVeiculo
@IDVeiculo int,
@Apelido varchar(45),
@Montadora varchar(45),
@Modelo varchar(75),
@Ano date
as 
update Veiculo set Apelido = @Apelido, Montadora = @Montadora, Modelo = @Modelo, Ano = @Ano where IDVeiculo = @IDVeiculo
go

-- Procedure para excluir Veículos --

create proc ProcExcluirVeiculo
@IDVeiculo int
as
delete from Veiculo where IDVeiculo = @IDVeiculo
go

-- Procedure para pesquisar Veículos --

create proc ProcPesquisarVeiculo
@PesquisarVeiculo varchar(45)
as
select * from Veiculo where Apelido like @PesquisarVeiculo + '%'
go
````

Em seguida, basta rodar a classe Program.cs.


## Observação:

Este projeto é apenas um CRUD, feito para fins de portfólio, porém, até o momento, não tive o tempo necessário para criar a camada View completa e ligá-la ao resto do projeto.
