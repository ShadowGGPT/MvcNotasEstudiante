create database MvcNotasEstudiante
go
use MvcNotasEstudiante
go
create table Notas(
[Id] int identity(1,1) primary key,
[No.] as ([Id]),
[Carnet] varchar(10),
[Apellidos y Nombres] varchar(100),
[I P] int,
[II P] int,
[SIST] int,
[PROY] int,
[N.F] int)
go
create trigger dbo.[N.F.Update]
on
dbo.Notas
after update
as
begin
update dbo.Notas 
set [N.F] = [I P]+[II P]+[SIST]+[PROY]
end
go
create trigger dbo.[N.F.Insert]
on
dbo.Notas
after insert
as
begin
update dbo.Notas 
set [N.F] = [I P]+[II P]+[SIST]+[PROY]
end

