create database ingatlan
go
use ingatlan
go
create table kategoria
(
	id int identity(1,1),
	nev varchar(40) Unique not null,
	primary key(id)

)
go
create table ingatlanok
(
	id int identity(1,1),
	kategoria int not null,
	leiras varchar(MAX),
	hirdetesDatuma date default(cast(getdate() as date)),
	tehermentes bit not null,
	ar int not null,
	kepUrl varchar(MAX),
	primary key(id)
	)
go
alter table ingatlanok
add foreign key(kategoria) references kategoria(id)