create database DanaTravel;
use DanaTravel;

create table ROLE
(
	id int not null identity primary key,
	name nvarchar(30)
);

create table ACCOUNT
(
	id int not null identity primary key,
	username varchar(30),
	password varchar(20),
	status bit
);

create table ACCOUNT_ROLE
(
	account_id int,
	role_id int,
	constraint fk_role foreign key(role_id) references ROLE(id),
	constraint fk_account foreign key(account_id) references ACCOUNT(id),
	constraint pk_account_role primary key(account_id, role_id)
);

create table PERMISSION
(
	id int not null identity primary key,
	name nvarchar(30)
);

create table ROLE_PERMISSION
(
	role_id int,
	permission_id int,
	constraint fk_role_permission foreign key(role_id) references ROLE(id),
	constraint fk_permission foreign key(permission_id) references PERMISSION(id),
	constraint pk_role_permission primary key(role_id, permission_id)
);

