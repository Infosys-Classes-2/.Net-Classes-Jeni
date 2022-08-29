CREATE TABLE [dbo].[Person]
(
[Id] INT NOT NULL IDENTITY PRIMARY KEY,
[Name] VARCHAR(50),
[Address] VARCHAR(50)
)
--iNSERT DATA INTO TABLE
INSERT INTO Person(Name, Address)
VALUES('Jenny Maharjan','ktm, Nepal');

INSERT INTO Person(Name, Address)
VALUES('Bishnu Rawal','ktm, Nepal');

INSERT INTO Person(Name, Address)
VALUES('abc','ktm, Nepal');

--Query
SELECT * from Person 


CREATE TABLE [dbo].[Employee]
(
[Id] INT NOT NULL IDENTITY PRIMARY KEY,
[Name] VARCHAR(50),
[Address] VARCHAR(50),
[DeptId] INT NULL ,
CONSTRAINT FK_Employee_Department FOREIGN KEY ([DeptId])
REFERENCES Department ([DeptId])
ON DELETE CASCADE
ON UPDATE CASCADE);


CREATE TABLE [dbo].[Department]
(
[DeptId] INT NOT NULL IDENTITY PRIMARY KEY,
[DeptName] VARCHAR(50)
);

insert into Department(DeptName)
values('HR');

insert into Department(DeptName)
values('R&D');
insert into Department(DeptName)
values('Accounts');

select * from Department;


insert into Employee(Name,Address,DeptId)
values('Jenny Maharjan','ktm',1);


insert into Employee(Name,Address,DeptId)
values('Kanchan Sah','ktm',2);

insert into Employee(Name,Address,DeptId)
values('Adarsh Bhattarai','ktm',2);

insert into Employee(Name,Address,DeptId)
values('Tak bdr Shrestha','ktm',1);

insert into Employee(Name,Address,DeptId)
values('Dinesh Dangol','Ltp',3);

insert into Employee(Name,Address,DeptId)
values('Krishna Subedi','Ltp',3);

commit;







