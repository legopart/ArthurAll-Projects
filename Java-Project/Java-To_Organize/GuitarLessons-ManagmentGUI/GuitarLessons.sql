/*RUN BY ROW 1-4*/
/*1*/
USE master
DROP DATABASE IF EXISTS GuitarLesson
GO
/*2*/
Create DataBase GuitarLesson
GO
/*3*/
USE GuitarLesson
	Create Table Admin (
						AdminId varchar(10) not null unique , 
						Password varchar(20) not null, 
						primary key (AdminId, Password)
						)


	Create Table Teacher (
							TeacherId varchar(10) not null primary key, 
							FirstName varchar(15) not null,
							LastName varchar(15) not null,
							Address varchar(60) default null null,
							PhoneNumber varchar(15) default null null,
							Instrument varchar(15) default null null,
							Gender varchar(15) default null null,
							BegingTeachingDate Date default null null,
							LessonMinutesLong int default 0  not null,
							Salary decimal(5,2) default 0.0 not null,
							StillTeaching bit,
							check (Gender in ('Male', 'Female')),
							check (Instrument in ('Guitar', 'Piano', 'Accuardion')),
							check (lessonMinutesLong>=0),
							check (salary>=0.0)
						)


	Create Table Student (
		StudentId varchar(10) not null primary key, 
		FirstName varchar(15) not null,
		LastName varchar(15) not null,
		Address varchar(60) default null null,
		PhoneNumber varchar(15) default null null,
		Instrument varchar(15) default null null,
		Gender varchar(15) default null null,
		BegingStudyDate Date default null null,
		AcchivementYears int default 0 not null,
		StillStuding bit,
		check (Gender in ('Male', 'Female')),
		check (Instrument in ('Guitar', 'Piano', 'Accuardion')),
		check (acchivementYears>=0)
	)


	Create Table Lesson (
							StudentId varchar(10) not null foreign key references Student(StudentId) on delete cascade, 
							TeacherId varchar(10) not null foreign key references Teacher(TeacherId) on delete cascade, 
							Location varchar(60) default null null,
							FullDate datetime not null, 
							primary key (StudentId, TeacherId,FullDate)
						)

	Create Table Teaching (
							StudentId varchar(10) not null foreign key references Student(StudentId) on delete cascade, 
							TeacherId varchar(10) not null foreign key references Teacher(TeacherId) on delete cascade, 
							Instrument varchar(15) not null,
							check (Instrument in ('Guitar', 'Piano', 'Accuardion')),
							primary key (StudentId, TeacherId, Instrument)
						)


	Create Table Test (
							TestID int identity(1,1) not null primary key,
							TestName varchar(30) not null,
							TestDate datetime not null, 
						)
						

							
	Create Table TestMark (
							TestID int not null foreign key references Test(TestID) on delete cascade,
							StudentId varchar(10) not null foreign key references Student(StudentId) on delete cascade, 
							TeacherId varchar(10) null foreign key references Teacher(TeacherId) on delete cascade,
 
							Mark int default 0 not null,
							check (Mark>=0 and Mark<=100),
							primary key (TestID, StudentId) /*, TeacherId */
						)

	Create Table Users (
						UserId varchar(10) not null unique foreign key references Teacher(TeacherId) on delete cascade, 
						Password varchar(20) not null , 
						primary key (UserId, Password)
						)
GO




	Create Trigger create_user On Teacher 
	after Insert as
	 begin
		Insert into Users 	select TeacherId, '123'	from inserted
	 end
GO
	 Create Trigger delete_from_list On Teacher
	 after Update  as
	 begin
		Delete from users where userId in (
			select TeacherId	from inserted	where StillTeaching=0
		)
	 end
GO
	 Create Trigger delete_Teacher_Lesson On Teacher
	 after Update  as
	 begin
		Delete from Lesson where TeacherId in (
			select T.TeacherId	from inserted T join Lesson L on T.TeacherId=L.TeacherId	where StillTeaching=0
		)
	 end
GO
	 Create Trigger delete_Student_Lesson On Student
	 after Update  as
	 begin
		Delete from Lesson where StudentId in (
			select S.StudentId	from inserted S join Lesson L on S.StudentId=L.StudentId	where StillStuding=0
		)
	 end
GO

/*4*/
USE GuitarLesson
	Insert into Admin values ('123','Admin')

	Insert into Student values ('001', 'Shmoel', 'Leidman', 'Emek Izrael 11', '7676458', 'Guitar', 'Male', '2020-12-10', 2,1)
	Insert into Student values ('002', 'Rami', 'Sason', 'Emek Izrael 12', '6907656', 'Piano', 'Female', '2020-12-15', 1,1)
	Insert into Student values ('003', 'Eitan', 'Shaked', 'Emek Izrael 13', '8601780', 'Accuardion', 'Male', '2020-12-14', 0,1)
	Insert into Student values ('004', 'Rita', 'Keidar', 'Emek Izrael 14', '4904686', 'Guitar', 'Male', '2020-12-12', 0,1)
	Insert into Student values ('005', 'Oren', 'Shem', 'Emek Izrael 15', '6507552', 'Accuardion', 'Female', '2020-12-11', 1,1)

	Insert into Teacher values ('123', 'FirstName', 'LastName', 'Emek Izrael', '5459957', 'Piano', 'Male', '2020-10-10', 60, 200.0,1)
	Update Users set Password='User' where UserId='123'
	Insert into Teacher values ('101', 'Ori', 'Oved', 'Emek Izrael 1', '5459957', 'Guitar', 'Female', '2020-11-15', 45, 200.20,1)
	Update Users set Password='123' where UserId='101'
	Insert into Teacher values ('102', 'Sami', 'Sason', 'Emek Izrael 2', '5914964', 'Accuardion', 'Male', '2020-10-01', 45, 90,1)
	Update Users set Password='123' where UserId='102'
	Insert into Teacher values ('103', 'Shon', 'Shitrit', 'Emek Izrael 3', '6514537', 'Piano', 'Female', '2020-10-20', 45, 90.0,1)
	Update Users set Password='123' where UserId='103'
	Insert into Teacher values ('104', 'Oded', 'Menashe', 'Emek Izrael 4', '6130701', 'Accuardion', 'Male', '2021-03-02', 45, 90.0,1)
	Update Users set Password='123' where UserId='104'
	Insert into Teacher values ('105', 'Haim', 'Saban', 'Emek Izrael 5', '9263241', 'Piano', 'Female', '2021-02-01', 40, 100.0,1)
	Update Users set Password='123' where UserId='105'


	Insert into Lesson values ('002', '101', null, '2021-10-10 12:45')
	Insert into Lesson values ('002', '102', null, '2022-12-10 12:10')
	Insert into Lesson values ('003', '102', null, '2022-12-10 12:55')
	Insert into Lesson values ('004', '102', null, '2022-12-10 13:45')
	Insert into Lesson values ('005', '102', null, '2022-12-10 14:50')
	Insert into Lesson values ('001', '123', null, '2022-11-10 12:55')
	Insert into Lesson values ('002', '123', null, '2022-11-10 13:45')
	Insert into Lesson values ('003', '123', null, '2022-11-10 14:50')



	Insert into Teaching values ('002', '101', 'Piano')
	Insert into Teaching values ('001', '102', 'Guitar')
	Insert into Teaching values ('003', '102', 'Piano')
	Insert into Teaching values ('003', '103', 'Piano')
	Insert into Teaching values ('004', '104', 'Accuardion')
	Insert into Teaching values ('001', '105', 'Guitar')

	Insert into Test values ('Seminar','2020-10-12 10:50')
	Insert into Test values ('Annual','2021-05-22 12:20')
	Insert into Test values ('Addition','2022-05-22 12:20')

	Insert into TestMark values (1, '002', '101', 100)
	Insert into TestMark values (1, '001', '102', 50)
	Insert into TestMark values (1, '003', '102', 80)
	Insert into TestMark values (1, '004', '104', 58)
	Insert into TestMark values (2, '002', '101', 45)
	Insert into TestMark values (2, '001', '102', 23)
	Insert into TestMark values (2, '003', '102', 64)
	Insert into TestMark values (2, '004', '104', 35)
	Insert into TestMark values (3, '002', '101', 45)
	Insert into TestMark values (3, '001', '102', 23)
	Insert into TestMark values (3, '003', '102', 64)
	Insert into TestMark values (3, '004', null, 54)
GO