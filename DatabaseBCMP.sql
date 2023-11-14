	use master
go
create database BCMP
use BCMP
GO



CREATE TABLE Department
(
  Name VARCHAR(50) NOT NULL,
  DepartmentId INT NOT NULL identity,
  PRIMARY KEY (DepartmentId)
);

CREATE TABLE Project
(
  ProjectId varchar(50) NOT NULL,
  Name VARCHAR(50) NOT NULL,
  Desciption VARCHAR(255) NOT NULL,
  PlannedStartDate DATE NOT NULL,
  PlannedEndDate DATE NOT NULL,
  ActualStartDate DATE default null ,
  ActualEndDate DATE default null ,
  DepartmentId int,
  Foreign key(DepartmentId) references Department(DepartmentId),
  PRIMARY KEY (ProjectId),
);

select * from Project

--alter table Project add DepartmentId int
--alter table Project add Constraint FK_Project_Department foreign key (DepartmentId) references Department(DepartmentId)
--them nguoi nhan project--

select * from Employee

CREATE TABLE Role
(
  RoleId INT NOT NULL identity,
  title VARCHAR(20) NOT NULL,
  description VARCHAR(200) NOT NULL,
  PRIMARY KEY (RoleId)
);

CREATE TABLE Permission
(
  PermissionId INT NOT NULL identity,
  title VARCHAR(20) NOT NULL,
  description VARCHAR(200) NOT NULL,
  PRIMARY KEY (PermissionId)
);

CREATE TABLE Role_Permission
(
  RoleId INT NOT NULL,
  PermissionId INT NOT NULL,
  FOREIGN KEY (RoleId) REFERENCES Role(RoleId),
  FOREIGN KEY (PermissionId) REFERENCES Permission(PermissionId)
);

CREATE TABLE PartnerCode
(
  PartnerCodeId VARCHAR(10) NOT NULL,
  FunctionalPartner VARCHAR(50) NOT NULL,
  PartnerAddress VARCHAR(255) NOT NULL,
  Representative VARCHAR(2555) NOT NULL,
  TaxCode VARCHAR(100) NOT NULL,
  PRIMARY KEY (PartnerCodeId)
);

CREATE TABLE TypeOfDocument
(
  Type VARCHAR(5) NOT NULL,
  Description VARCHAR(255) NOT NULL,
  PRIMARY KEY (Type)
);

CREATE TABLE Employee
(
  Email VARCHAR(100) NOT NULL,
  Password VARCHAR(255) NOT NULL,
  IsDeactivated INT NOT NULL,
  PhoneNumber VARCHAR(11) NOT NULL,
  UserId VARCHAR(50) NOT NULL,
  DepartmentId INT NOT NULL,
  RoleId INT NOT NULL,
  PRIMARY KEY (UserId),
  FOREIGN KEY (DepartmentId) REFERENCES Department(DepartmentId),
  FOREIGN KEY (RoleId) REFERENCES Role(RoleId)
);
select * from Employee

CREATE TABLE Misson
(
  MissionId INT NOT NULL identity,
  Title VARCHAR(50) NOT NULL,
  Description VARCHAR(255) NOT NULL,
  Progress FLOAT NOT NULL,
  PlannedEndDate DATE NOT NULL,
  PlannedStartDate DATE NOT NULL,
  ActualStartDate DATE default null,
  ActualEndDate DATE default null,
  IsPublic INT NOT NULL,
  Status VARCHAR(20) NOT NULL,
  ProjectId varchar(50) NOT NULL,
  UserId VARCHAR(50) NOT NULL,
  PRIMARY KEY (MissionId),
  FOREIGN KEY (ProjectId) REFERENCES Project(ProjectId),
  FOREIGN KEY (UserId) REFERENCES Employee(UserId)
);

--alter table Misson drop column ActualEndDate
--alter table Misson add ActualEndDate date

CREATE TABLE Comment
(
  Description VARCHAR(255) NOT NULL,
  Id INT NOT NULL identity,
  CreatedDate DATE NOT NULL,
  UpdatedDate DATE NOT NULL,
  UserId VARCHAR(50) NOT NULL,
  MissionId INT NOT NULL,
  PRIMARY KEY (Id),
  FOREIGN KEY (UserId) REFERENCES Employee(UserId),
  FOREIGN KEY (MissionId) REFERENCES Misson(MissionId)
);

CREATE TABLE Notification
(
  Description VARCHAR(255) NOT NULL,
  Title VARCHAR(20) NOT NULL,
  NotificationId INT NOT NULL identity,
  CreatedDate DATE NOT NULL,
  IsRead INT NOT NULL,
  MissionId INT,
  UserId VARCHAR(50) NOT NULL,
  PRIMARY KEY (NotificationId),
  FOREIGN KEY (MissionId) REFERENCES Misson(MissionId),
  FOREIGN KEY (UserId) REFERENCES Employee(UserId)
);

CREATE TABLE Tag
(
  TagId INT NOT NULL identity,
  Description VARCHAR(255) NOT NULL,
  MissionId INT NOT NULL,
  UserId VARCHAR(50) NOT NULL,
  PRIMARY KEY (TagId),
  FOREIGN KEY (MissionId) REFERENCES Misson(MissionId),
  FOREIGN KEY (UserId) REFERENCES Employee(UserId)
);

CREATE TABLE TagItem
(
  TagItemId INT NOT NULL identity,
  TagId INT NOT NULL,
  UserId VARCHAR(50) NOT NULL,
  PRIMARY KEY (TagItemId),
  FOREIGN KEY (TagId) REFERENCES Tag(TagId),
  FOREIGN KEY (UserId) REFERENCES Employee(UserId)
);

CREATE TABLE MissionPrerequisite
(
  MissionId INT NOT NULL,
  MissionPreId INT NOT NULL,
  FOREIGN KEY (MissionId) REFERENCES Misson(MissionId),
  FOREIGN KEY (MissionPreId) REFERENCES Misson(MissionId)
);

CREATE TABLE Document
(
  Name VARCHAR(50) NOT NULL,
  Path VARCHAR(255) NOT NULL,
  ReleaseDate DATE NOT NULL,
  TypeFile VARCHAR(20) NOT NULL,
  SerialNumber VARCHAR(50) NOT NULL,
  Status VARCHAR(50) NOT NULL,
  ProjectId varchar(50) NOT NULL,
  MissionId INT,
  UserId VARCHAR(50) NOT NULL,
  PartnerCodeId VARCHAR(10) NOT NULL,
  Type VARCHAR(5) NOT NULL,
  PRIMARY KEY (SerialNumber),
  FOREIGN KEY (ProjectId) REFERENCES Project(ProjectId),
  FOREIGN KEY (MissionId) REFERENCES Misson(MissionId),
  FOREIGN KEY (UserId) REFERENCES Employee(UserId),
  FOREIGN KEY (PartnerCodeId) REFERENCES PartnerCode(PartnerCodeId),
  FOREIGN KEY (Type) REFERENCES TypeOfDocument(Type)
);

CREATE TABLE AuthorizeDocument
(
  UserId VARCHAR(50) NOT NULL,
  SerialNumber VARCHAR(50) NOT NULL,
  PRIMARY KEY (UserId, SerialNumber),
  FOREIGN KEY (UserId) REFERENCES Employee(UserId),
  FOREIGN KEY (SerialNumber) REFERENCES Document(SerialNumber)
);


--Department--
create procedure USP_InsertDepartment
@name varchar(50)
as
begin
	insert into Department values(@name)
end
go

exec dbo.USP_InsertDepartment @name = 'Information Technology'
select * from Department



create procedure USP_GetDepartment
as
begin
	select * from Department
end

create procedure USP_UpdateDepartment
@name varchar(50), @departmentId int
as
begin
	update Department set Name = @name where DepartmentId = @departmentId
end
go

create procedure USP_DeleteDepartment
@departmentId int
as
begin
	delete from Department where DepartmentId = @departmentId
end
go

--Project--
create procedure USP_InsertProject
@projectid varchar(50),
@name VARCHAR(50),
@description VARCHAR(255),
@plannedStartDate DATE,
@plannedEndDate DATE,
@departmentId int
as
begin
	insert into Project(ProjectId,Name,Desciption,PlannedStartDate,PlannedEndDate,DepartmentId) values(@projectid,@name,@description,@plannedStartDate,@plannedEndDate,@departmentId)
end
go

exec dbo.USP_InsertProject @projectid = 'BCMP',@name = 'Project System', @description = 'Sleeping', @plannedStartDate = '2023-10-26' , @plannedEndDate = '2023-10-26' 

select * from Project

create procedure USP_UpdateProject
@projectId varchar(50),
@name VARCHAR(50),
@desciption VARCHAR(255),
@plannedStartDate DATE,
@plannedEndDate DATE
as
begin
	update Project set Name =@name, Desciption = @desciption, PlannedStartDate = @plannedStartDate, PlannedEndDate = @plannedEndDate where ProjectId = @projectId
end
go

create procedure USP_UpdateActualStartProject
@projectId varchar(50),
@actualStartDate date
as
begin
	update Project set ActualStartDate = @actualStartDate where ProjectId = @projectId
end
go

create procedure USP_UpdateAcutalEndProject
@projectId varchar(50),
@actualEndDate date
as
begin
	update Project set ActualEndDate = @actualEndDate where ProjectId = @projectId
end
go

create procedure USP_GetProject
as
begin
	select * from Project
end
go

create procedure USP_DeleteProject
@projectId varchar(50)
as
begin
	delete from Project where ProjectId = @projectId
end
go

create procedure USP_GetProjectById
@projectId varchar(50)
as
begin
	select * from Project where ProjectId = @projectId
end
go

exec dbo.USP_GetProjectById @projectId = 'BCMP1'

--Role--
create procedure USP_InsertRole
  @title VARCHAR(20),
  @description VARCHAR(200)
as
begin
	insert into Role values(@title,@description)
end
go

create procedure USP_GetRole
as
begin
	select * from Role
end
go

exec dbo.USP_InsertRole @title = 'admin', @description = 'admin'
select * from Role

create procedure USP_UpdateRole
@roleId int,
@title varchar(20),
@decription varchar(200)
as
begin
	update Role set title = @title, description = @decription where RoleId = @roleId
end
go

create procedure USP_DeleteRole
@roleId int
as
begin
	delete from Role where RoleId = @roleId
end
go

create procedure USP_GetRoleById
@userId int
as
begin
	select * from Role where RoleId = @userId
end
go

--Permision--
create procedure USP_InsertPermission
  @title VARCHAR(20),
  @description VARCHAR(200)
as
begin
	insert into Permission values(@title, @description)
end


create procedure USP_GetPermission
as
begin
	select * from Permission
end

create procedure USP_UpdatePermission
	@permissionId int,
	@title varchar(20),
	@description varchar(200)
as
begin
	update Permission set title = @title, description = @description where PermissionId = @permissionId	
end

create procedure USP_DeletePermission
@permissionId int
as
begin
	delete from Permission where PermissionId = @permissionId
end

--Role_Permission

create procedure USP_InsertRole_Permission
@roleId int,
@permissionId int
as
begin
	insert into Role_Permission values(@roleId, @permissionId)
end

create procedure USP_GetRole_Permission
as
begin
	select * from Role_Permission
end

create procedure USP_UpdateRole_Permission
@roleId int,
@permissionId int
as
begin
	update Role_Permission set RoleId = @roleId, PermissionId = @permissionId where RoleId = @roleId and PermissionId = @permissionId
end

create procedure USP_DeleteRole_Permission
@roleId int,
@permissionId int
as
begin
	delete from Role_Permission where RoleId =@roleId and PermissionId = @permissionId
end

--Mission--
create procedure USP_InsertMission
  @title VARCHAR(50),
  @description VARCHAR(255),
  @progress FLOAT,
  @plannedEndDate DATE,
  @plannedStartDate DATE,
  @isPublic INT,
  @status VARCHAR(20),
  @projectId varchar(50),
  @userId VARCHAR(50)
as
begin
	insert into Misson(Title,Description,Progress,PlannedStartDate,PlannedEndDate,IsPublic,Status,ProjectId,UserId) values(@title,@description,@progress,@plannedStartDate,@plannedEndDate,@isPublic,@status,@projectId,@userId)
end
go

exec USP_InsertMission @title = 'ABC', @description = 'dasdasd',@progress = 0.01, @plannedStartDate = '2023-10-27', @plannedEndDate = '2023-10-27',@isPublic = 0, @status = 'TO DO', @projectId = 'BCMP1' , @userId = 'admin'
select * from Misson

create procedure USP_GetMission
as
begin
	select * from Mission
end
go

create procedure USP_GetMissionByProjectId
@projectId varchar(50)
as
begin 
	select * from Misson where ProjectId = @projectId
end
go

exec dbo.USP_GetMissionByProjectId @projectId = 'BCMP1'

create procedure USP_UpdateMission
@missionId int,
@title VARCHAR(50),
  @description VARCHAR(255),
  @progress FLOAT,
  @plannedEndDate DATE,
  @plannedStartDate DATE,
  @isPublic INT,
  @status VARCHAR(20),
  @projectId varchar(50),
  @userId VARCHAR(50)
as
begin
	update Misson set Title = @title, Description = @description, Progress = @progress, PlannedStartDate = @plannedStartDate, PlannedEndDate = @plannedEndDate 
					  ,IsPublic = @isPublic,Status = @status, ProjectId = @projectId, UserId = @userId
					where MissionId = @missionId
end
go

create procedure USP_UpdateActualStartMission
@missionId int,
@actualStartDate date
as
begin
	update Misson set ActualStartDate = @actualStartDate where MissionId = @missionId
end
go

create procedure USP_UpdateActualEndMission
@missionId int,
@actualEndDate date
as
begin
	update Misson set ActualEndDate = @actualEndDate where MissionId = @missionId
end
go

create procedure USP_DeleteMission
@missionId int
as
begin
	delete from Misson where MissionId = @missionId
end
go

create procedure USP_UpdateStatusMissionByMissionId
@missionId int,
@status varchar(20)
as
begin
	update Misson set Status = @status where MissionId = @missionId
end
go

create procedure USP_UpdateDescriptionMissionByMissionId
@missionId int,
@description varchar(200)
as
begin
	update Misson set Description = @description where MissionId = @missionId
end
go

--Document--
create procedure USP_InsertDocument
  @name VARCHAR(50),
  @path VARCHAR(255),
  @releaseDate DATE,
  @typeFile VARCHAR(20),
  @serialNumber VARCHAR(50),
  @status VARCHAR(50),
  @projectId varchar(50),
  @missionId INT,
  @userId VARCHAR(50),
  @partnerCodeId VARCHAR(10),
  @type VARCHAR(5)
as
begin
	insert into Document values(@name,@path,@releaseDate,@typeFile,@serialNumber,@status,@projectId,@missionId,@userId,@partnerCodeId,@type)
end

create procedure USP_GetDocument
as
begin
	select * from Document
end

create procedure USP_UpdateDocument
  @name VARCHAR(50),
  @path VARCHAR(255),
  @releaseDate DATE,
  @typeFile VARCHAR(20),
  @serialNumber VARCHAR(50),
  @status VARCHAR(50),
  @projectId varchar(50),
  @missionId INT,
  @userId VARCHAR(50),
  @partnerCodeId VARCHAR(10),
  @type VARCHAR(5)
 as
 begin
	update Document set Name = @name, Path = @path, ReleaseDate = @releaseDate, TypeFile = @typeFile, 
						Status = @status, ProjectId = @projectId, MissionId = @missionId, UserId = @userId, 
						PartnerCodeId = @partnerCodeId,Type = @type where SerialNumber = @serialNumber
end

create procedure USP_DeleteDocument
@serialNumber varchar(10)
as
begin
	delete from Document where SerialNumber = @serialNumber
end

--Employee
create procedure USP_InsertEmployee
  @email VARCHAR(100),
  @password VARCHAR(255),
  @isDeactivated INT,
  @phoneNumber VARCHAR(11),
  @userId VARCHAR(50),
  @departmentId INT,
  @roleId INT
as
begin
	insert into Employee values(@email, @password, @isDeactivated, @phoneNumber, @userId,@departmentId,@roleId)
end
go

exec dbo.USP_InsertEmployee @email = 'admin@gmail.com', @password ='adminbcmp', @isDeactivated = 0, @phoneNumber = '0934541496', @userId = 'admin', @departmentId = 2, @roleId = 1
select * from Employee

create procedure USP_GetEmployee
as
begin
	select * from Employee
end
go

create procedure USP_UpdateEmployee
  @email VARCHAR(100),
  @password VARCHAR(255),
  @isDeactivated INT,
  @phoneNumber VARCHAR(11),
  @userId VARCHAR(50),
  @departmentId INT,
  @roleId INT
as
begin
	update Employee set Email = @email, Password = @password, IsDeactivated = @isDeactivated, PhoneNumber = @phoneNumber, DepartmentId = @departmentId, RoleId = @roleId where UserId = @userId
end
go


create procedure USP_DeleteEmployee
@userId varchar(50)
as
begin
	delete from Employee where UserId = @userId
end
go

create procedure USP_GetEmployeeById
@userId varchar(50)
as
begin
	select * from Employee where UserId = @userId
end
go

--PartnerCode
create procedure USP_InsertPartnerCode
	@partnerCodeId VARCHAR(10),
	@functionalPartner VARCHAR(50),
	@partnerAddress VARCHAR(255),
	@representative VARCHAR(2555),
	@taxCode VARCHAR(100)
as
begin
	insert into PartnerCode values (@partnerCodeId,@functionalPartner,@partnerAddress,@representative,@taxCode)
end

create procedure USP_GetPartnercode
as
begin
	select *from PartnerCode
end

create procedure USP_UpdatePartnerCode
	@partnerCodeId VARCHAR(10),
	@functionalPartner VARCHAR(50),
	@partnerAddress VARCHAR(255),
	@representative VARCHAR(255),
	@taxCode VARCHAR(100)
as
begin
	update PartnerCode set FunctionalPartner = @functionalPartner, PartnerAddress = @partnerAddress, Representative = @representative, TaxCode = @taxCode where PartnerCodeId = @partnerCodeId
end


create procedure USP_DeletePartnerCode
	@partnerCodeId VARCHAR(10)
as
begin
	delete from PartnerCode where PartnerCodeId = @partnerCodeId
end

--TypeOfDocument
create procedure USP_InsertTypeOfDocument
	@type VARCHAR(5),
	@description VARCHAR(255)
as
begin
	insert into TypeOfDocument values (@type, @description)
end

create procedure USP_GetTypeOfDocument
as
begin
	select *from TypeOfDocument
end

create procedure USP_UpdateTypeOfDocument
	@type VARCHAR(5),
	@description VARCHAR(255)
as 
begin
	update TypeOfDocument set Description = @description where Type = @type
end

create procedure USP_DeleteTypeOfDocument
	@type VARCHAR(5)
as
begin
	delete from TypeOfDocument where Type = @type
end

--Comment
create procedure USP_InsertComment
	@description VARCHAR(255),
	@createdDate DATE,
	@updatedDate DATE
as
begin
	insert into Comment values (@description, @createdDate, @updatedDate)
end

create procedure USP_getComment
as
begin
	select *from Comment
end

create procedure USP_UpdateComment
	@description VARCHAR(255),
	@id INT,
	@createdDate DATE,
	@updatedDate DATE
as
begin
	update Comment set Description = @description, CreatedDate = @createdDate, UpdatedDate = @updatedDate where Id = @id
end

create procedure USP_DeleteComment
	@id INT
as
begin
	delete from Comment where Id = @id
end

--Notification
create procedure USP_InsertNotification
	@description VARCHAR(255),
	@title VARCHAR(20),
	@createdDate DATE,
	@isRead INT
as
begin
	insert into Notification values (@description, @title, @createdDate, @isRead)
end

create procedure USP_GetNotification
as
begin
	select *from Notification
end 

create procedure USP_UpdateNotification
	@description VARCHAR(255),
	@title VARCHAR(20),
	@notificationId INT,
	@createdDate DATE,
	@isRead INT
as
begin
	update Notification set Description = @description, Title = @title, CreatedDate = @createdDate, IsRead = @isRead where NotificationId = @notificationId
end

create procedure USP_DeleteNotification
	@notificationId INT
as
begin
	delete from Notification where NotificationId = @notificationId
end

--Tag
create procedure USP_InsertTag
	@description VARCHAR(255)
as
begin
	insert into Tag values (@description)
end

create procedure USP_GetTag
as
begin
	select *from Tag
end

create procedure USP_UpdateTag
	@tagId INT,
	@description VARCHAR(255)
as
begin
	update Tag set Description = @description where TagId = @tagId
end

create procedure USP_DeleteTag
	@tagId INT
as
begin
	delete from Tag where TagId = @tagId
end

--TagItem
create procedure USP_InsertTagItem
	@tagId INT,
	@userId VARCHAR(50)
as
begin
	insert into TagItem values (@tagId,@userId)
end

create procedure USP_GetTagItem
as
begin
	select *from TagItem
end

create procedure USP_UpdateTagItem
	@tagItemId INT,
	@tagId INT,
	@userId VARCHAR(50)
as
begin
	update TagItem set TagId = @tagId, UserId = @userId where TagId = @tagId and UserId = @userId and TagItemId = @tagItemId
end

create procedure USP_DeleteTagItem
	@tagItemId INT
as
begin
	delete from TagItem where TagItemId = @tagItemId
end

--MissionPrerequisite
create procedure USP_InsertMissionPrerequisite
	@missionId INT,
	@missionPreId INT
as
begin
	insert into MissionPrerequisite values (@missionId,@missionPreId)
end

create procedure USP_GetMissionPrerequisite
as
begin
	select *from MissionPrerequisite
end

create procedure USP_UpdateMissionPrerequisite
	@missionId INT,
	@missionPreId INT
as
begin
	update MissionPrerequisite set MissionId = @missionId, MissionPreId = @missionPreId where MissionId = @missionId and MissionPreId = @missionPreId
end

create procedure USP_DeleteMissionPrerequisite
	@missionId INT,
	@missionPreId INT
as
begin
	delete from MissionPrerequisite where MissionId = @missionId and MissionPreId = @missionPreId
end

--AuthorizeDocument
create procedure USP_InsertAuthorizeDocument
	@userId VARCHAR(50),
	@serialNumber VARCHAR(50)
as
begin
	insert into AuthorizeDocument values (@userId, @serialNumber)
end

create procedure USP_GetAuthorizeDocument
as
begin
	select *from AuthorizeDocument
end

create procedure USP_UpdateAuthorizeDocument
	@userId VARCHAR(50),
	@serialNumber VARCHAR(50)
as
begin
	update AuthorizeDocument set UserId = @userId, SerialNumber = @serialNumber where  UserId = @userId and SerialNumber = @serialNumber
end

create procedure USP_DeleteAuthorizeDocument
	@userId VARCHAR(50),
	@serialNumber VARCHAR(50)
as
begin
	delete from AuthorizeDocument where UserId = @userId and SerialNumber = @serialNumber
end

create procedure USP_Login
@userid varchar(50), @password varchar(255)
as
begin
	select * from Employee where UserId = @userid and Password = @password
end
go


exec dbo.USP_Login @userid = 'admin' , @password = 'adminbcmp'
update Employee set IsDeactivated = 0 where UserId = 'admin'

select * from Project

update Project set DepartmentId = 1 where ProjectId = 'BCMP1'
go

--insert sample values
select * from Department

INSERT INTO Department VALUES ('Human Resources'),
('Accounting'),
('Marketing'),
('Sales'),
('Research and Development'),
('Production'),
('Quality Control'),
('Engineering'),
('Finance'),
('Project Management')
, ('Customer Support'),
('Information Technology'),
('Legal'),
('Organizational and Personnel Management'),
('Risk Management')

select * from Department

Insert into Project values ('LDUCS','Complain Employee', 'Review, criticize, and reward employees', '2023-10-31', '2023-11-3' ,1,null,null),
('DNUCS','Create a Party', 'Create a playground, a place to eat and take photos for employees', '2023-11-1', '2023-11-6',5,null,null)

select * from Project

Insert into Role values ('Ceo', 'The most powerful person in the company'),
('Manager', 'The person who assigns work to employees'),
('Employee', 'Departmental staff')
select * from Role


select * from Permission
Insert into Permission values ('C', 'Ceo'),
('M', 'Manager'),
('E', 'Employee')

Insert into Employee values ('tona@gmail.com', '123',0, '0123456789', 'Tona',1,1),
('mtq@gmail.com', '123',0, '0123456789', 'MTQ',2,2),
('truc@gmail.com', '123',0, '0123456789', 'Truc',3,1),
('anh@gmail.com', '123',0, '0123456789', 'Anh',4,3),
('qa@gmail.com', '123',0, '0123456789', 'QA',4,1),
('han@gmail.com', '123',0, '0123456789', 'Hein',6,1)

select * from Misson
Insert into Misson values ('Review Employee', 'Evaluate the employee job performance level', 0.5, '2023-10-31', '2023-11-3', 1, 'TO DO', 'LDUCS', 'Tona',null, null),
('Criticize Employee', 'Criticize employees who are late and do their own work', 1.0, '2023-10-31', '2023-11-3', 0, 'DONE', 'LDUCS', 'Truc',null, null),
('Reward Employee', 'Reward employees who are positive at work', 0.8, '2023-10-31', '2023-11-3', 1, 'TO DO', 'LDUCS', 'MTQ',null, null),
('Create a playground', 'Create many interesting games', 0.05, '2023-11-1', '2023-11-6', 0, 'TO DO', 'DNUCS', 'Hein',null, null),
('Create a place to eat', 'Design a spacious dining area', 0.5, '2023-11-1', '2023-11-6', 1, 'DONE', 'DNUCS', 'Hein',null, null),
('Create a place to take photos for employees', 'Design an area specifically for photography', 0.7, '2023-11-1', '2023-11-6', 1, 'TO DO', 'DNUCS', 'QA',null, null),
('Review Employee', 'Evaluate the employee job performance level', 0.5, '2023-10-31', '2023-11-3', 1, 'TO DO', 'DNUCS', 'Tona',null, null)

Insert into Notification values ('Warning about delay', 'Warning', '2023-11-1',1,4,'Tona'),
('Warning about delay', 'Warning', '2023-11-2',0,6,'QA'),
('Warning about delay', 'Warning', '2023-11-1',0,7,'MTQ'),
('Warning about delay', 'Warning', '2023-11-1',1,5,'Tona'),
('Warning about delay', 'Warning', '2023-11-1',0,6,'Tona')