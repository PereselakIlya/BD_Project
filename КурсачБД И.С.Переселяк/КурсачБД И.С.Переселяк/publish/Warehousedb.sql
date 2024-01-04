Create database СкладПом
go
use СкладПом
create table  Поставщик(
id int identity not null primary key,
НазваниеПоставщика varchar(30),
Адресс varchar(30), 
)

create table Поставки(
id int identity not null primary key,
Товар varchar(30),
Поставщик varchar(30),
ДатаПоставки datetime,
Колличество int,
ОбщаяСтоимостьПоставки int,
)

create table Товар(
id int identity not null primary key,
НаименованиеТовара varchar(30),
ЕдИзмерения varchar(30),
СтоимостьЕд int
)

create table Склад(
id int identity not null primary key,
КодПоставки int,
КодТовара int,
КолвоТовара int, 
СтоимостьТовара int,
)
insert into Поставщик values ('Колхоз Яблычко','Деревня Луковая'),('SunshineFruit','г.Минск,ул.Димедова,дом 2'),('EmperorsFruits','г.Минск,ул.ВеликойПобеды,дом 5'),
('Mumbasa Fruit Company','г.Экеке,ул.Бумы,дом 18'),('БИВИФ','г.Минск,ул.Борщевая,дом 6');

insert into Товар(НаименованиеТовара,ЕдИзмерения,СтоимостьЕд) values('Яблоко','кг',5),('Аппельсин','кг',10),('Мандарин','кг',8),('Банан','кг',6),('Ананас','кг',20);

Insert into СкладПом.dbo.Склад (КодПоставки,КодТовара,КолвоТовара) values 
((Select id from Поставщик where id=1),(Select id from Товар where id=1),5),
((Select id from Поставщик where id=2),(Select id from Товар where id=2),5),
((Select id from Поставщик where id=3),(Select id from Товар where id=3),10),
((Select id from Поставщик where id=4),(Select id from Товар where id=4),50),
((Select id from Поставщик where id=5),(Select id from Товар where id=5),10);
UPDATE Склад SET СтоимостьТовара=(Select СтоимостьЕд from Товар where id=1)*КолвоТовара where id=1;
UPDATE Склад SET СтоимостьТовара=(Select СтоимостьЕд from Товар where id=2)*КолвоТовара where id=2;
UPDATE Склад SET СтоимостьТовара=(Select СтоимостьЕд from Товар where id=3)*КолвоТовара where id=3;
UPDATE Склад SET СтоимостьТовара=(Select СтоимостьЕд from Товар where id=4)*КолвоТовара where id=4;
UPDATE Склад SET СтоимостьТовара=(Select СтоимостьЕд from Товар where id=5)*КолвоТовара where id=5;

insert into Поставки(НазваниеТовара,НазваниеПоставщика,ДатаПоставки,КолличествоТовара) values 
((Select НаименованиеТовара from Товар where id=1),(Select НазваниеПоставщика from Поставщик where id=1),2023-02-12,5);
UPDATE Поставки SET ОбщаяСтоимостьПоставки=(Select СтоимостьЕд from Товар where id=1)*КолличествоТовара where id=1;
Truncate table Поставщик
Truncate table Поставки
Truncate table Товар
Truncate table Склад
