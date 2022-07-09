create schema AutumnERS;

--The constraint is found by running the second command and copy-pasting the specified constraint in the error msg

alter table AutumnERS.users drop constraint PK__users__CBA1B257E40D9164;
-- alter table AutumnERS.users drop constraint UQ__users__CBA1B256FC922998;
alter table AutumnERS.users drop column userid;

alter table AutumnERS.tickets drop column author_fk;
alter table AutumnERS.tickets drop constraint FK__tickets__author___70A8B9AE;

alter table AutumnERS.tickets drop column resolver_fk;
alter table AutumnERS.tickets drop constraint FK__tickets__resolve__719CDDE7;

drop table AutumnERS.users;

create table AutumnERS.users(
	userID int identity (1,1) unique not null,
	userName varchar (50) unique not null,
	password varchar (50) not null,
	userRole varchar (50) default 'employee',
	primary key (userID)
);

drop table AutumnERS.tickets;

create table AutumnERS.tickets(
	ticketID int identity (1,1) not null,
	author_fk int foreign key references AutumnERS.users(userID) not null,
	resolver_fk int foreign key references AutumnERS.users(userID),
	description varchar (255) not null,
	status varchar (50) default 'pending',
	amount money not null,
	primary key(ticketID)
);

insert into AutumnERS.users (userName, password, userRole) values ('paulstanley', 'kiss', 'manager');
insert into AutumnERS.users (userName, password, userRole) values ('genesimmons', 'kiss', 'manager');
insert into AutumnERS.users (userName, password) values ('petercriss', 'kiss');
insert into AutumnERS.users (userName, password) values ('acefrehley', 'kiss');

insert into AutumnERS.tickets (author_fk, description, amount) values (3, 'kitty litter', 34.99);
insert into AutumnERS.tickets (author_fk, description, amount) values (4, 'cocaine', 678.99);
insert into AutumnERS.tickets (author_fk, description, amount) values (4, 'guitar strings', 22.99);
insert into AutumnERS.tickets (author_fk, description, amount) values (4, 'alcohol', 965.32);
