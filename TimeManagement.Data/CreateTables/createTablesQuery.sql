create Database TimeManagementDB

--use TimeManagementDB
--Create Table Customer(
--	CustomerId int not null identity(1,1) primary key,
--	CustomerName nvarchar (40) not null,
--	CustomerFamily nvarchar (70) not null,
--	PhoneNumber nvarchar (20) not null,
--	TelNumber nvarchar (20) ,
--	CustomerAddress nvarchar (max) not null)

--create table Stuff(
--	StuffId int not null identity(1,1) primary key,
--	StuffTitle nvarchar (70) not null)


--create table EventPriority(
--	PriorityId int not null identity(1,1) primary key,
--	PriorityTitle nvarchar(50) not null)


--create table EventStatus(
--	StatusId int not null identity(1,1) primary key,
--	StatusTitle nvarchar (50) not null)


--create table Process(
--	ProcessId int not null identity(1,1) primary key,
--	ProcessTitle nvarchar(100) not null,
--	Comment nvarchar(max),

--	CustomerId int foreign key references Customer(CustomerId)
--	)

--create table ProcessStuffes(
--	ProcessId int not null,
--	StuffId int not null,
--	Num int,
--	Comment nvarchar(max),
--	primary key(ProcessId , StuffId),
--	foreign key(ProcessId) references Process(ProcessId),
--	foreign key(StuffId) references Stuff(StuffId),
--	)

--create table ProcessEvent(
--	EventId int not null identity(1,1) primary key,
--	EventTitle nvarchar (50) not null,
--	Comment nvarchar(max) ,
--	CreateDate DateTime not null,
--	CallTime DateTime not null,
--	IsRepeat bit not null,
--	Interval int,
--	IsComplete bit not null,
--	PriorityId int not null,
--	StatusId int not null,
--	ProcessId int not null,
--	ParentEventId int,
--	foreign key(PriorityId) references EventPriority(PriorityId),
--	foreign key(StatusId) references EventStatus(StatusId),
--	foreign key(ProcessId) references Process(ProcessId),
--	foreign key(ParentEventId) references ProcessEvent(EventId))

--create table Operation(
--	OperationId int not null identity(1,1) primary key,
--	FromEvent int not null,
--	ToEvent int not null,
--	Comment nvarchar(max) not null,
--	foreign key(FromEvent) references ProcessEvent(EventId),
--	foreign key(ToEvent) references ProcessEvent(EventId))

