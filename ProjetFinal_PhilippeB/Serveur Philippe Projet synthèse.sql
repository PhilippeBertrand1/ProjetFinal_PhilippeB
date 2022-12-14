create database Bibliotheque

create table Employe(
ID varchar(15) primary key,
Prenom varchar(30),
Nom varchar(30),
NumTelephone char(12) default '000-000-0000',
Sexe char(5),
Adresse varchar(50),
TauxHoraire int
)

create table Client(
ID varchar(15) primary key,
Prenom varchar(30),
Nom varchar(30),
NumTelephone char(12) default '000-000-0000',
Sexe char(5),
Adresse varchar(50)
)

create table Livre(
LivreID char (2) primary key,
Auteur varchar(30),
Titre varchar (30),
AnneeParution int,
)

select * from Livre

insert into Employe(ID,Prenom,Nom,NumTelephone,Sexe,Adresse,TauxHoraire)
values('A23KL','Philippe','Bertrand','819-827-4693','Homme','104 Rue de Bouchette, Cantley, QC',50)

insert into Livre(LivreID,Auteur,Titre,AnneeParution)
values ('10','Philippe Bertrand', 'Mein Khampf', '1990'),
	   ('20','Guillaume Paoli', '3 petits cochons',	'1999')	


