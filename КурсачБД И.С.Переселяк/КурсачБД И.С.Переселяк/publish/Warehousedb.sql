Create database ��������
go
use ��������
create table  ���������(
id int identity not null primary key,
������������������ varchar(30),
������ varchar(30), 
)

create table ��������(
id int identity not null primary key,
����� varchar(30),
��������� varchar(30),
������������ datetime,
����������� int,
���������������������� int,
)

create table �����(
id int identity not null primary key,
������������������ varchar(30),
����������� varchar(30),
����������� int
)

create table �����(
id int identity not null primary key,
����������� int,
��������� int,
����������� int, 
��������������� int,
)
insert into ��������� values ('������ �������','������� �������'),('SunshineFruit','�.�����,��.��������,��� 2'),('EmperorsFruits','�.�����,��.�������������,��� 5'),
('Mumbasa Fruit Company','�.�����,��.����,��� 18'),('�����','�.�����,��.��������,��� 6');

insert into �����(������������������,�����������,�����������) values('������','��',5),('���������','��',10),('��������','��',8),('�����','��',6),('������','��',20);

Insert into ��������.dbo.����� (�����������,���������,�����������) values 
((Select id from ��������� where id=1),(Select id from ����� where id=1),5),
((Select id from ��������� where id=2),(Select id from ����� where id=2),5),
((Select id from ��������� where id=3),(Select id from ����� where id=3),10),
((Select id from ��������� where id=4),(Select id from ����� where id=4),50),
((Select id from ��������� where id=5),(Select id from ����� where id=5),10);
UPDATE ����� SET ���������������=(Select ����������� from ����� where id=1)*����������� where id=1;
UPDATE ����� SET ���������������=(Select ����������� from ����� where id=2)*����������� where id=2;
UPDATE ����� SET ���������������=(Select ����������� from ����� where id=3)*����������� where id=3;
UPDATE ����� SET ���������������=(Select ����������� from ����� where id=4)*����������� where id=4;
UPDATE ����� SET ���������������=(Select ����������� from ����� where id=5)*����������� where id=5;

insert into ��������(��������������,������������������,������������,�����������������) values 
((Select ������������������ from ����� where id=1),(Select ������������������ from ��������� where id=1),2023-02-12,5);
UPDATE �������� SET ����������������������=(Select ����������� from ����� where id=1)*����������������� where id=1;
Truncate table ���������
Truncate table ��������
Truncate table �����
Truncate table �����
