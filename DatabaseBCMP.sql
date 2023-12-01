use master
go
create database BCMP
go
use BCMP
GO



CREATE TABLE Department
(
  Name VARCHAR(50) NOT NULL,
  DepartmentId INT NOT NULL identity,
  PRIMARY KEY (DepartmentId)
);
go

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
go

--alter table Project add DepartmentId int
--alter table Project add Constraint FK_Project_Department foreign key (DepartmentId) references Department(DepartmentId)
--them nguoi nhan project--



CREATE TABLE Role
(
  RoleId INT NOT NULL identity,
  title VARCHAR(20) NOT NULL,
  description VARCHAR(200) NOT NULL,
  PRIMARY KEY (RoleId)
);
go

CREATE TABLE Permission
(
  PermissionId INT NOT NULL identity,
  title VARCHAR(20) NOT NULL,
  description VARCHAR(200) NOT NULL,
  PRIMARY KEY (PermissionId)
);
go

CREATE TABLE Role_Permission
(
  RoleId INT NOT NULL,
  PermissionId INT NOT NULL,
  FOREIGN KEY (RoleId) REFERENCES Role(RoleId),
  FOREIGN KEY (PermissionId) REFERENCES Permission(PermissionId)
);
go
CREATE TABLE PartnerCode
(
  PartnerCodeId VARCHAR(10) NOT NULL,
  FunctionalPartner VARCHAR(50) NOT NULL,
  PRIMARY KEY (PartnerCodeId)
);
go
CREATE TABLE TypeOfDocument
(
  Type VARCHAR(5) NOT NULL,
  Description VARCHAR(255) NOT NULL,
  PRIMARY KEY (Type)
);
go
CREATE TABLE Employee
(
  Email VARCHAR(100) NOT NULL,
  Password VARCHAR(255) NOT NULL,
  IsDeactivated INT NOT NULL,
  PhoneNumber VARCHAR(11) NOT NULL,
  UserId VARCHAR(50) NOT NULL,
  DepartmentId INT NOT NULL,
  RoleId INT NOT NULL,
  fullname nvarchar(255) not null,
  TypeEmployee int not null,
  PRIMARY KEY (UserId),
  FOREIGN KEY (DepartmentId) REFERENCES Department(DepartmentId),
  FOREIGN KEY (RoleId) REFERENCES Role(RoleId)
);
go



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
go

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
go

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
go

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
go

CREATE TABLE TagItem
(
  TagItemId INT NOT NULL identity,
  TagId INT NOT NULL,
  UserId VARCHAR(50) NOT NULL,
  PRIMARY KEY (TagItemId),
  FOREIGN KEY (TagId) REFERENCES Tag(TagId),
  FOREIGN KEY (UserId) REFERENCES Employee(UserId)
);
go

CREATE TABLE MissionPrerequisite
(
  MissionId INT NOT NULL,
  MissionPreId INT NOT NULL,
  FOREIGN KEY (MissionId) REFERENCES Misson(MissionId),
  FOREIGN KEY (MissionPreId) REFERENCES Misson(MissionId)
);
go
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
  DepartmentId int default 0,
  PRIMARY KEY (SerialNumber),
  FOREIGN KEY (ProjectId) REFERENCES Project(ProjectId),
  FOREIGN KEY (MissionId) REFERENCES Misson(MissionId),
  FOREIGN KEY (UserId) REFERENCES Employee(UserId),
  FOREIGN KEY (PartnerCodeId) REFERENCES PartnerCode(PartnerCodeId),
  FOREIGN KEY (Type) REFERENCES TypeOfDocument(Type),
  FOREIGN KEY (DepartmentId) REFERENCES Department(DepartmentId)
);
go

CREATE TABLE AuthorizeDocument
(
  UserId VARCHAR(50) NOT NULL,
  SerialNumber VARCHAR(50) NOT NULL,
  PRIMARY KEY (UserId, SerialNumber),
  FOREIGN KEY (UserId) REFERENCES Employee(UserId),
  FOREIGN KEY (SerialNumber) REFERENCES Document(SerialNumber)
);
go


--Department--
create procedure USP_InsertDepartment
@name varchar(50)
as
begin
	insert into Department values(@name)
end
go


create procedure USP_GetDepartment
as
begin
	select * from Department
end
go

create procedure USP_GetDepartmentById
@departmentId int
as
begin
	select * from Department where DepartmentId = @departmentId
end
go



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


create procedure USP_UpdateProject
@projectId varchar(50),
@name VARCHAR(50),
@desciption VARCHAR(255),
@plannedStartDate DATE,
@plannedEndDate DATE,
@departmentId int
as
begin
	update Project set Name =@name, Desciption = @desciption, PlannedStartDate = @plannedStartDate, PlannedEndDate = @plannedEndDate, DepartmentId = @departmentId where ProjectId = @projectId
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
go

create procedure USP_GetPermission
as
begin
	select * from Permission
end
go

create procedure USP_UpdatePermission
	@permissionId int,
	@title varchar(20),
	@description varchar(200)
as
begin
	update Permission set title = @title, description = @description where PermissionId = @permissionId	
end
go

create procedure USP_DeletePermission
@permissionId int
as
begin
	delete from Permission where PermissionId = @permissionId
end
go

--Role_Permission

create procedure USP_InsertRole_Permission
@roleId int,
@permissionId int
as
begin
	insert into Role_Permission values(@roleId, @permissionId)
end
go

create procedure USP_GetRole_Permission
as
begin
	select * from Role_Permission
end
go

create procedure USP_UpdateRole_Permission
@roleId int,
@permissionId int
as
begin
	update Role_Permission set RoleId = @roleId, PermissionId = @permissionId where RoleId = @roleId and PermissionId = @permissionId
end
go

create procedure USP_DeleteRole_Permission
@roleId int,
@permissionId int
as
begin
	delete from Role_Permission where RoleId =@roleId and PermissionId = @permissionId
end
go

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

create procedure USP_GetMission
as
begin
	select * from Misson
end
go

create procedure USP_GetMissionById
@missionId int
as
begin
	select * from Misson where MissionId = @missionId and Status != 'Added'
end
go

create procedure USP_GetMissionByUserId
@userId varchar(50)
as
begin
	select * from Misson where userId = @userId and Status != 'Added'
end
go

create procedure USP_GetMissionByProjectId
@projectId varchar(50)
as
begin 
	select * from Misson where ProjectId = @projectId and Status != 'Added'
end
go


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

create procedure USP_UpdateStatusMission
@missionId int,
@status varchar(20)
as
begin
	update Misson set Status = @status where MissionId = @missionId
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
create  procedure USP_InsertDocument
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
  @type VARCHAR(5),
  @departmentId int
as
begin
	if(@departmentId = 0)
		insert into Document values(@name,@path,@releaseDate,@typeFile,@serialNumber,@status,@projectId,@missionId,@userId,@partnerCodeId,@type,null)
	else 
		insert into Document values(@name,@path,@releaseDate,@typeFile,@serialNumber,@status,@projectId,@missionId,@userId,@partnerCodeId,@type,@departmentId)
end
go


create procedure USP_GetDocument
as
begin
	select * from Document
end
go

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
go

create procedure USP_DeleteDocument
@serialNumber varchar(10)
as
begin
	delete from Document where SerialNumber = @serialNumber
end
go

--Employee
create procedure USP_InsertEmployee
  @email VARCHAR(100),
  @password VARCHAR(255),
  @isDeactivated INT,
  @phoneNumber VARCHAR(11),
  @userId VARCHAR(50),
  @departmentId INT,
  @roleId INT,
  @fullname nvarchar(255),
  @typeEmployee int
as
begin
	insert into Employee values(@email, @password, @isDeactivated, @phoneNumber, @userId,@departmentId,@roleId,@fullname,@typeEmployee)
end
go


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
  @roleId INT,
  @fullname nvarchar(255),
  @typeEmployee int
as
begin
	update Employee set Email = @email, Password = @password, IsDeactivated = @isDeactivated, PhoneNumber = @phoneNumber, DepartmentId = @departmentId, RoleId = @roleId, fullname = @fullname, TypeEmployee = @typeEmployee  where UserId = @userId
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

create procedure USP_UpdatePasswordEmployee
@userId varchar(50),
@newpassword varchar(255)
as
begin
	update Employee set Password = @newpassword where UserId = @userId
end
go

create procedure USP_UpdateIsDeactivatedEmployee
@userId varchar(50),
@isDeactivated int
as
begin
	update Employee set IsDeactivated = @isDeactivated where UserId = @userId
end
go

--PartnerCode
create procedure USP_InsertPartnerCode
	@partnerCodeId VARCHAR(10),
	@functionalPartner VARCHAR(50)
as
begin
	insert into PartnerCode values (@partnerCodeId,@functionalPartner)
end
go

create procedure USP_GetPartnercode
as
begin
	select *from PartnerCode
end
go

create procedure USP_UpdatePartnerCode
	@partnerCodeId VARCHAR(10),
	@functionalPartner VARCHAR(50)
as
begin
	update PartnerCode set FunctionalPartner = @functionalPartner where PartnerCodeId = @partnerCodeId
end
go


create procedure USP_DeletePartnerCode
	@partnerCodeId VARCHAR(10)
as
begin
	delete from PartnerCode where PartnerCodeId = @partnerCodeId
end
go

--TypeOfDocument
create procedure USP_InsertTypeOfDocument
	@type VARCHAR(5),
	@description VARCHAR(255)
as
begin
	insert into TypeOfDocument values (@type, @description)
end
go

create procedure USP_GetTypeOfDocument
as
begin
	select *from TypeOfDocument
end
go

create procedure USP_UpdateTypeOfDocument
	@type VARCHAR(5),
	@description VARCHAR(255)
as 
begin
	update TypeOfDocument set Description = @description where Type = @type
end
go

create procedure USP_DeleteTypeOfDocument
	@type VARCHAR(5)
as
begin
	delete from TypeOfDocument where Type = @type
end
go

--Comment
create procedure USP_InsertComment
	@description VARCHAR(255),
	@createdDate DATE,
	@updatedDate DATE,
	@userId varchar(50),
	@missionId int
as
begin
	insert into Comment values (@description, @createdDate, @updatedDate,@userId,@missionId)
end
go

create procedure USP_getComment
as
begin
	select *from Comment
end
go

create procedure USP_UpdateComment
	@description VARCHAR(255),
	@id INT,
	@createdDate DATE,
	@updatedDate DATE
as
begin
	update Comment set Description = @description, CreatedDate = @createdDate, UpdatedDate = @updatedDate where Id = @id
end
go

create procedure USP_DeleteComment
	@id INT
as
begin
	delete from Comment where Id = @id
end
go

--Notification
create procedure USP_InsertNotification
	@description VARCHAR(255),
	@title VARCHAR(20),
	@createdDate DATE,
	@isRead INT,
	@missionId int,
	@userId varchar(50)
as
begin
	insert into Notification values (@description, @title, @createdDate, @isRead,@missionId,@userId)
end
go

create procedure USP_GetNotification
as
begin
	select *from Notification
end 
go

create procedure USP_GetNotificationByUserId
@userId varchar(50)
as
begin
	select *from Notification where UserId = @userId
end 
go


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
go

create procedure USP_DeleteNotification
	@notificationId INT
as
begin
	delete from Notification where NotificationId = @notificationId
end
go

--Tag
create procedure USP_InsertTag
	@description VARCHAR(255),
	@missionId int,
	@userId varchar(50)
as
begin
	insert into Tag values (@description, @missionId, @userId)
end
go

create procedure USP_GetTag
as
begin
	select *from Tag
end
go

create procedure USP_UpdateTag
	@tagId INT,
	@description VARCHAR(255)
as
begin
	update Tag set Description = @description where TagId = @tagId
end
go

create procedure USP_DeleteTag
	@tagId INT
as
begin
	delete from Tag where TagId = @tagId
end
go

--TagItem
create procedure USP_InsertTagItem
	@tagId INT,
	@userId VARCHAR(50)
as
begin
	insert into TagItem values (@tagId,@userId)
end
go

create procedure USP_GetTagItem
as
begin
	select *from TagItem
end
go

create procedure USP_UpdateTagItem
	@tagItemId INT,
	@tagId INT,
	@userId VARCHAR(50)
as
begin
	update TagItem set TagId = @tagId, UserId = @userId where TagId = @tagId and UserId = @userId and TagItemId = @tagItemId
end
go

create procedure USP_DeleteTagItem
	@tagItemId INT
as
begin
	delete from TagItem where TagItemId = @tagItemId
end
go

--MissionPrerequisite
create procedure USP_InsertMissionPrerequisite
	@missionId INT,
	@missionPreId INT
as
begin
	insert into MissionPrerequisite values (@missionId,@missionPreId)
end
go

create procedure USP_GetMissionPrerequisite
as
begin
	select *from MissionPrerequisite
end
go

create procedure USP_UpdateMissionPrerequisite
	@missionId INT,
	@missionPreId INT
as
begin
	update MissionPrerequisite set MissionId = @missionId, MissionPreId = @missionPreId where MissionId = @missionId and MissionPreId = @missionPreId
end
go

create procedure USP_DeleteMissionPrerequisite
	@missionId INT,
	@missionPreId INT
as
begin
	delete from MissionPrerequisite where MissionId = @missionId and MissionPreId = @missionPreId
end
go

--AuthorizeDocument
create procedure USP_InsertAuthorizeDocument
	@userId VARCHAR(50),
	@serialNumber VARCHAR(50)
as
begin
	insert into AuthorizeDocument values (@userId, @serialNumber)
end
go

create procedure USP_GetAuthorizeDocument
as
begin
	select *from AuthorizeDocument
end
go

create procedure USP_UpdateAuthorizeDocument
	@userId VARCHAR(50),
	@serialNumber VARCHAR(50)
as
begin
	update AuthorizeDocument set UserId = @userId, SerialNumber = @serialNumber where  UserId = @userId and SerialNumber = @serialNumber
end
go

create procedure USP_DeleteAuthorizeDocument
	@userId VARCHAR(50),
	@serialNumber VARCHAR(50)
as
begin
	delete from AuthorizeDocument where UserId = @userId and SerialNumber = @serialNumber
end
go

create procedure USP_Login
@userid varchar(50), @password varchar(255)
as
begin
	select * from Employee where UserId = @userid and Password = @password
end
go

create FUNCTION remove_accents(@input_str NVARCHAR(255))
RETURNS NVARCHAR(255)
BEGIN
    DECLARE @output_str NVARCHAR(255);
    SET @output_str = @input_str;
    SET @output_str = REPLACE(@output_str, N'ă', 'a');
    SET @output_str = REPLACE(@output_str, N'ắ', 'a');
    SET @output_str = REPLACE(@output_str, N'ằ', 'a');
    SET @output_str = REPLACE(@output_str, N'ẵ', 'a');
	SET @output_str = REPLACE(@output_str, N'ặ', 'a');
    SET @output_str = REPLACE(@output_str, N'ẳ', 'a');
    SET @output_str = REPLACE(@output_str, N'â', 'a');
	SET @output_str = REPLACE(@output_str, N'ấ', 'a');
	SET @output_str = REPLACE(@output_str, N'ẫ', 'a');
	SET @output_str = REPLACE(@output_str, N'ẩ', 'a');
	SET @output_str = REPLACE(@output_str, N'ậ', 'a');
    SET @output_str = REPLACE(@output_str, N'đ', 'd');
    SET @output_str = REPLACE(@output_str, N'ê', 'e');
	SET @output_str = REPLACE(@output_str, N'ế', 'e');
	SET @output_str = REPLACE(@output_str, N'ề', 'e');
	SET @output_str = REPLACE(@output_str, N'ễ', 'e');
	SET @output_str = REPLACE(@output_str, N'ể', 'e');
	SET @output_str = REPLACE(@output_str, N'ệ', 'e');
    SET @output_str = REPLACE(@output_str, N'ô', 'o');
	SET @output_str = REPLACE(@output_str, N'ố', 'o');
	SET @output_str = REPLACE(@output_str, N'ồ', 'o');
	SET @output_str = REPLACE(@output_str, N'ổ', 'o');
	SET @output_str = REPLACE(@output_str, N'ỗ', 'o');
	SET @output_str = REPLACE(@output_str, N'ộ', 'o');
    SET @output_str = REPLACE(@output_str, N'ơ', 'o');
	SET @output_str = REPLACE(@output_str, N'ớ', 'o');
	SET @output_str = REPLACE(@output_str, N'ờ', 'o');
	SET @output_str = REPLACE(@output_str, N'ỡ', 'o');
	SET @output_str = REPLACE(@output_str, N'ở', 'o');
    SET @output_str = REPLACE(@output_str, N'ợ', 'u');
    SET @output_str = REPLACE(@output_str, N'ứ', 'u');
    SET @output_str = REPLACE(@output_str, N'ừ', 'u');
    SET @output_str = REPLACE(@output_str, N'ự', 'u');
	SET @output_str = REPLACE(@output_str, N'ữ', 'u');
    SET @output_str = REPLACE(@output_str, N'ử', 'u');
    SET @output_str = REPLACE(@output_str, N'à', 'a');
    SET @output_str = REPLACE(@output_str, N'á', 'a');
    SET @output_str = REPLACE(@output_str, N'ả', 'a');
    SET @output_str = REPLACE(@output_str, N'ã', 'a');
    SET @output_str = REPLACE(@output_str, N'ạ', 'a');
    SET @output_str = REPLACE(@output_str, N'è', 'e');
    SET @output_str = REPLACE(@output_str, N'é', 'e');
    SET @output_str = REPLACE(@output_str, N'ẻ', 'e');
    SET @output_str = REPLACE(@output_str, N'ẽ', 'e');
    SET @output_str = REPLACE(@output_str, N'ẹ', 'e');
    SET @output_str = REPLACE(@output_str, N'ì', 'i');
    SET @output_str = REPLACE(@output_str, N'í', 'i');
    SET @output_str = REPLACE(@output_str, N'ỉ', 'i');
    SET @output_str = REPLACE(@output_str, N'ĩ', 'i');
    SET @output_str = REPLACE(@output_str, N'ị', 'i');
    SET @output_str = REPLACE(@output_str, N'ò', 'o');
    SET @output_str = REPLACE(@output_str, N'ó', 'o');
    SET @output_str = REPLACE(@output_str, N'ỏ', 'o');
    SET @output_str = REPLACE(@output_str, N'õ', 'o');
    SET @output_str = REPLACE(@output_str, N'ọ', 'o');
    SET @output_str = REPLACE(@output_str, N'ù', 'u');
    SET @output_str = REPLACE(@output_str, N'ú', 'u');
    SET @output_str = REPLACE(@output_str, N'ủ', 'u');
    SET @output_str = REPLACE(@output_str, N'ũ', 'u');
    SET @output_str = REPLACE(@output_str, N'ụ', 'u');
    SET @output_str = REPLACE(@output_str, N'ỳ', 'y');
    SET @output_str = REPLACE(@output_str, N'ý', 'y');
    SET @output_str = REPLACE(@output_str, N'ỷ', 'y');
    SET @output_str = REPLACE(@output_str, N'ỹ', 'y');
    SET @output_str = REPLACE(@output_str, N'ỵ', 'y');
    RETURN @output_str;
END;
go

create procedure USP_SearchEmployee
@fullname nvarchar(255)
as
begin
	select * from Employee where dbo.remove_accents(fullname) like N'%' + dbo.remove_accents(@fullname) + N'%'
end
go

create TRIGGER TR_InsertNotification
ON Misson
AFTER INSERT
AS
BEGIN
    -- Insert notification when a new mission is inserted
    INSERT INTO Notification (Description, Title, CreatedDate, IsRead, MissionId, UserId)
    SELECT
		case	 
			when m.Status ='Added' then 'You are joined in :'+ m.ProjectId
			else 'New mission: created in Project' + m.ProjectId
		end,-- Adjust the notification description as needed
		case	 
			when m.Status ='Added' then 'Join in Project'
			else 'New Mission Created'
		end,-- Adjust the notification description as needed
        GETDATE(), -- Use the current date and time as the created date
        0, -- Default value for IsRead (not read)
        m.MissionId,
        m.UserId
    FROM inserted m; -- "inserted" is a special table holding the newly inserted rows
END;
go


create procedure USP_GetListEmployeeNotInProject
@projectId varchar(50),
@departmentId varchar(50)
as
begin
	if(@departmentId = 0)
		select * from Employee where UserId not in (select UserId from Misson where ProjectId = @projectId and Status = 'Added') and IsDeactivated = 0
	else
		select * from Employee where UserId not in (select UserId from Misson where ProjectId = @projectId and Status = 'Added') and IsDeactivated = 0 and DepartmentId = @departmentId
end
go


create procedure USP_GetListEmployeeInProject
@projectId varchar(50),
@departmentId varchar(50)
as
begin
	if(@departmentId = 0)
		select * from Employee where UserId in (select UserId from Misson where ProjectId = @projectId and Status = 'Added') and IsDeactivated = 0
	else
		select * from Employee where UserId in (select UserId from Misson where ProjectId = @projectId and Status = 'Added') and IsDeactivated = 0 and DepartmentId = @departmentId
end
go

create procedure USP_GetListDepartmentInProject
@projectId varchar(50)
as
begin
	select * from Department where DepartmentId in (select DepartmentId from Employee where UserId in (select UserId from Misson where ProjectId = @projectId and Status = 'Added') and IsDeactivated = 0)
end
go


create procedure USP_GetProjectByMissionId
@missionId int
as
begin
	select * from Project where ProjectId = (select ProjectId from Misson where MissionId = @missionId)
end
go

create procedure USP_GetAllDocumentInPublic
as
begin
	select * from Document where DepartmentId is null
end
go

create procedure USP_GetAllDocumentInProject
@projectId varchar(50)
as
begin
	select * from Document where DepartmentId is null and ProjectId = @projectId
end
go

create procedure USP_GetAllDocumentInPublicUser
@userId varchar(50)
as
begin
	select * from Document where DepartmentId is null and ProjectId in (select ProjectId from Misson where UserId = @userId and Status = 'Added')
end
go


create procedure USP_GetAllDocumentInMission
@missionId int
as
begin
	select * from Document where DepartmentId is null and MissionId = @missionId
end
go

create procedure USP_GetAllDocumentInDepartment
@departmentId int
as
begin
	select * from Document where DepartmentId = @departmentId
end
go

create procedure USP_DeleteDocumentBySerial
@serialNumber varchar(50)
as
begin
	delete Document where SerialNumber = @serialNumber
end
go



create  procedure USP_InsertDocumentInProject
  @name VARCHAR(50),
  @path VARCHAR(255),
  @releaseDate DATE,
  @typeFile VARCHAR(20),
  @serialNumber VARCHAR(50),
  @status VARCHAR(50),
  @projectId varchar(50),
  @userId VARCHAR(50),
  @partnerCodeId VARCHAR(10),
  @type VARCHAR(5),
  @departmentId int
as
begin
	if(@departmentId = 0)
		insert into Document values(@name,@path,@releaseDate,@typeFile,@serialNumber,@status,@projectId,null,@userId,@partnerCodeId,@type,null)
	else 
		insert into Document values(@name,@path,@releaseDate,@typeFile,@serialNumber,@status,@projectId,null,@userId,@partnerCodeId,@type,@departmentId)
end
go

create procedure USP_GetAllProjectByUserId
@userId varchar(50)
as
begin
	select * from Project where ProjectId in (select ProjectId from Misson where UserId = @userId and Status = 'Added')
end
go

create procedure USP_GetAllEmployeeByDepartment
@departmentId int
as
begin
	select * from Employee where DepartmentId = @departmentId
end
go


--insert sample values
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

Insert into Role values ('Admin','Admin'),
('Ceo', 'The most powerful person in the company'),
('Manager', 'The person who assigns work to employees'),
('Employee', 'Departmental staff')

select * from Permission
Insert into Permission values
('C', 'Ceo'),
('M', 'Manager'),
('E', 'Employee')

Insert into Employee (Email, Password, IsDeactivated, PhoneNumber, UserId, DepartmentId, RoleId, fullname, TypeEmployee) values
('tona@gmail.com', '123',0, '0123456789', 'Tona',1,1,N'Nguyễn Hữu Toàn', 1),
('mtq@gmail.com', '123',0, '0123456789', 'MTQ',2,2,N'Mã Trường Quang', 0),
('truc@gmail.com', '123',0, '0123456789', 'Truc',3,1,N'Trúc', 1),
('anh@gmail.com', '123',0, '0123456789', 'Anh',4,3,N'Nguyễn Quốc Anh', 1),
('qa@gmail.com', '123',0, '0123456789', 'QA',4,1,N'Nguyễn Quốc Anh', 1),
('han@gmail.com', '123',0, '0123456789', 'Hein',6,1,N'Nguyễn Thị Mỹ Hân', 1)

Insert into Project values 
('LDUCS','Complain Employee', 'Review, criticize, and reward employees', '2023-10-31', '2023-11-3' ,null,null,1),
('DNUCS','Create a Party', 'Create a playground, a place to eat and take photos for employees', '2023-11-1', '2023-11-6',null,null,5)

Insert into Misson (Title, Description, Progress, PlannedStartDate, PlannedEndDate, IsPublic, Status, ProjectId, UserId, ActualStartDate, ActualEndDate) 
values 
('Review Employee', 'Evaluate the employee job performance level', 0.5, '2023-10-31', '2023-11-3', 1, 'TO DO', 'LDUCS', 'Tona',null, null),
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

insert into PartnerCode values ('T*','Technical Consultant / Technical Advisor')

insert into TypeOfDocument values ('S','Specifications'),
('D','Drawing, Shecdules'),
('C','Calculation Sheet'),
('R','Requisitions'),
('Q','Reports,Records')

select * from Role



