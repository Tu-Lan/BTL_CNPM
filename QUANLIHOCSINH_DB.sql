create DATABASE QUANLIHOCSINH
USE QUANLIHOCSINH

-- Tao bang dang nhap (sign in)
CREATE TABLE tblSignIn(
	sUserName  NVARCHAR(30) PRIMARY KEY NOT NULL,
	sPassWord NVARCHAR(30) NOT NULL,
	sRole NVARCHAR(30) NOT NULL
);
SELECT * FROM dbo.tblSignIn
-- insert account 
INSERT INTO dbo.tblSignIn
VALUES
(   N'admin',N'admin',N'admin'),
(   N'thao',N'thao',N'gv'),
(   N'minh',N'minh',N'gv'),
(   N'thanh',N'thanh',N'hs')
-- T?o b?ng tblStudent
CREATE TABLE tblStudent (
    PK_sStudentID varchar(10) PRIMARY KEY,
    sFullName nvarchar(70),
    bGender bit,
    sAddress nvarchar(255),
    dNgaysinh date,
	FK_ClassID varchar(10) ,
	FOREIGN KEY (FK_ClassID) REFERENCES tblClass(PK_sClassID)
	
);

-- T?o b?ng tblTeacher
CREATE TABLE tblTeacher (
    PK_sTeacherID varchar(10) PRIMARY KEY,
    sName nvarchar(100),
    bGender bit,
    fSalary float,
    sPhone varchar(15),
    sAddress nvarchar(255)
);

-- T?o b?ng tblSubject
CREATE TABLE tblSubject (
    PK_sSubjectID varchar(10) PRIMARY KEY,
    sName nvarchar(50),
    FK_sStudentID varchar(10),
    FK_sTeacherID varchar(10)
    --FOREIGN KEY (FK_sStudentID) REFERENCES tblStudent(PK_sStudentID),
    --FOREIGN KEY (FK_sTeacherID) REFERENCES tblTeacher(PK_sTeacherID)
);

-- T?o b?ng tblScore
CREATE TABLE tblScore (
    PK_sScoreID varchar(10) PRIMARY KEY,
    FK_sSubjectID varchar(10),
    fMidTerm float,
    fFinal float,
    fOral float,
    FOREIGN KEY (FK_sSubjectID) REFERENCES tblSubject(PK_sSubjectID)
);

-- T?o b?ng tblClass
CREATE TABLE tblClass (
    PK_sClassID varchar(10) PRIMARY KEY,
    sName nvarchar(100),
    FK_sTeacherID varchar(10),
    FK_sTermID varchar(10),
    FOREIGN KEY (FK_sTeacherID) REFERENCES tblTeacher(PK_sTeacherID),
    FOREIGN KEY (FK_sTermID) REFERENCES tblTerm(PK_sTermID) -- Ð?t khóa ngo?i t?i b?ng tblTerm (gi? s? b?ng h?c k? dã du?c t?o)
);

-- T?o b?ng tblTerm
CREATE TABLE tblTerm (
    PK_sTermID varchar(10) PRIMARY KEY,
    sTermName nvarchar(100),
    dStartDate date,
    dEndDate date
);

-- T?o b?ng tblClassSchedule
CREATE TABLE tblClassSchedule (
    PK_sSchedule varchar(10) PRIMARY KEY,
    dDayOfWeek date,
    iClassPeriod int,
    sClassRoom nvarchar(10),
    FK_sClassID varchar(10),
    FOREIGN KEY (FK_sClassID) REFERENCES tblClass(PK_sClassID)
);

-- T?o b?ng tblFee
CREATE TABLE tblFee (
    FK_sFeeID varchar(10) PRIMARY KEY,
    FK_sStudentID varchar(10),
    fTotalFee float,
    dDateofFee date,
    FOREIGN KEY (FK_sStudentID) REFERENCES tblStudent(PK_sStudentID)
);

CREATE TABLE tblSubject_Teacher (
    FK_sSubjectID varchar(10),
    FK_sTeacherID varchar(10),
    PRIMARY KEY (FK_sSubjectID, FK_sTeacherID),
    FOREIGN KEY (FK_sTeacherID) REFERENCES tblTeacher(PK_sTeacherID),
    FOREIGN KEY (FK_sSubjectID) REFERENCES tblSubject(PK_sSubjectID)
);
CREATE TABLE tblSubject_Student (
    FK_sSubjectID varchar(10),
    FK_sStudentID varchar(10),
    PRIMARY KEY (FK_sSubjectID, FK_sStudentID),
    FOREIGN KEY (FK_sSubjectID) REFERENCES tblSubject(PK_sSubjectID),
    FOREIGN KEY (FK_sStudentID) REFERENCES tblStudent(PK_sStudentID)
);
SELECT *FROM tblTerm
-- Insert 10 records into tblStudent
INSERT INTO tblStudent (PK_sStudentID, sFullName, bGender, sAddress, dNgaysinh, FK_ClassID) 
VALUES 
('STU001', 'Nguyen Van A', 1, '123 ABC Street', '2000-01-01', 'CLS006'),
('STU002', 'Tran Thi B', 0, '456 XYZ Street', '2001-02-02', 'CLS005'),
('STU003', 'Le Van C', 1, '789 DEF Street', '2002-03-03', 'CLS001'),
('STU004', 'Pham Thi D', 0, '321 GHI Street', '2003-04-04', 'CLS002'),
('STU005', 'Hoang Van E', 1, '654 JKL Street', '2004-05-05', 'CLS009'),
('STU006', 'Vo Thi F', 0, '987 MNO Street', '2005-06-06', 'CLS001'),
('STU007', 'Tran Van G', 1, '159 PQR Street', '2006-07-07', 'CLS001'),
('STU008', 'Le Thi H', 0, '357 STU Street', '2007-08-08', 'CLS005'),
('STU009', 'Nguyen Van I', 1, '258 VWX Street', '2008-09-09', 'CLS003'),
('STU010', 'Pham Van K', 1, '852 YZA Street', '2009-10-10', 'CLS002');

-- Insert 10 records into tblTeacher
INSERT INTO tblTeacher (PK_sTeacherID, sName, bGender, fSalary, sPhone, sAddress) 
VALUES 
('T1', 'Nguyen Van Teacher', 1, 2000.50, '123456789', '123 Teacher Street'),
('T2', 'Tran Thi Teacher', 0, 1800.75, '987654321', '456 Teacher Street'),
('T3', 'Le Van Teacher', 1, 2200.25, '456123789', '789 Teacher Street'),
('T4', 'Pham Thi Teacher', 0, 1900.30, '789456123', '321 Teacher Street'),
('T5', 'Hoang Van Teacher', 1, 2050.80, '654987321', '654 Teacher Street'),
('T6', 'Vo Thi Teacher', 0, 1950.40, '987321654', '987 Teacher Street'),
('T7', 'Tran Van Teacher', 1, 2100.60, '159357258', '159 Teacher Street'),
('T8', 'Le Thi Teacher', 0, 1850.70, '357258159', '357 Teacher Street'),
('T9', 'Nguyen Van T', 1, 2250.90, '258159357', '258 Teacher Street'),
('T10', 'Pham Van T', 1, 2300.95, '852963147', '852 Teacher Street');

-- Insert 10 records into tblSubject
INSERT INTO tblSubject (PK_sSubjectID, sName, FK_sStudentID, FK_sTeacherID) 
VALUES 
('SUB1', 'Math', 'STU001', 'T1'),
('SUB2', 'Physics', 'STU003', 'T2'),
('SUB3', 'Chemistry', 'STU003', 'T3'),
('SUB4', 'Biology', 'STU005', 'T4'),
('SUB5', 'History', 'STU005', 'T5'),
('SUB6', 'Geography', 'STU004', 'T6'),
('SUB7', 'Literature', 'STU004', 'T7'),
('SUB8', 'English', 'STU008', 'T8'),
('SUB9', 'Computer Science', 'STU009', 'T9'),
('SUB10', 'Art', 'STU010', 'T10');

-- Insert 10 records into tblScore
INSERT INTO tblScore (PK_sScoreID, FK_sSubjectID, fMidTerm, fFinal, fOral) 
VALUES 
('SCORE1', 'SUB1', 8.5, 9.0, 8.0),
('SCORE2', 'SUB2', 7.0, 8.5, 9.0),
('SCORE3', 'SUB3', 9.0, 8.0, 8.5),
('SCORE4', 'SUB4', 8.0, 9.0, 7.5),
('SCORE5', 'SUB5', 9.5, 9.0, 8.5),
('SCORE6', 'SUB6', 8.0, 8.0, 8.0),
('SCORE7', 'SUB7', 7.5, 9.0, 9.0),
('SCORE8', 'SUB8', 8.5, 8.5, 8.0),
('SCORE9', 'SUB9', 9.0, 9.0, 9.0),
('SCORE10', 'SUB10', 8.0, 8.5, 8.5);

-- Insert 10 records into tblClass
INSERT INTO tblClass (PK_sClassID, sName, FK_sTeacherID, FK_sTermID) 
VALUES 
('CLS001', 'Class A', 'T1', 'TERM1'),
('CLS002', 'Class B', 'T2', 'TERM1'),
('CLS003', 'Class C', 'T3', 'TERM2'),
('CLS004', 'Class D', 'T4', 'TERM2'),
('CLS005', 'Class E', 'T5', 'TERM3'),
('CLS006', 'Class F', 'T6', 'TERM3'),
('CLS007', 'Class G', 'T7', 'TERM4'),
('CLS008', 'Class H', 'T8', 'TERM4'),
('CLS009', 'Class I', 'T9', 'TERM5'),
('CLS010', 'Class J', 'T10', 'TERM5');

-- Insert 10 records into tblTerm
INSERT INTO tblTerm (PK_sTermID, sTermName, dStartDate, dEndDate) 
VALUES 
('TERM1', 'Term 1', '2023-09-01', '2023-12-20'),
('TERM2', 'Term 2', '2024-01-10', '2024-04-30'),
('TERM3', 'Term 3', '2024-05-15', '2024-08-31'),
('TERM4', 'Term 4', '2024-09-10', '2024-12-30'),
('TERM5', 'Term 5', '2008-01-10', '2008-04-30'),
('TERM6', 'Term 6', '2014-09-01', '2014-12-20'),
('TERM7', 'Term 7', '2015-01-10', '2015-04-30'),
('TERM8', 'Term 8', '2017-05-15', '2017-08-31'),
('TERM9', 'Term 9', '2018-09-10', '2018-12-30'),
('TERM10', 'Term 10', '2019-01-10', '2019-04-30');

-- Insert 10 records into tblClassSchedule
-- Inserting records into tblClassSchedule
INSERT INTO tblClassSchedule (PK_sSchedule, dDayOfWeek, iClassPeriod, sClassRoom, FK_sClassID)
VALUES
('CS001', '2024-03-25', 1, 'A101', 'CLS001'),
('CS002', '2024-03-25', 2, 'A102', 'CLS002'),
('CS003', '2024-03-26', 1, 'A103', 'CLS003'),
('CS004', '2024-03-26', 2, 'A104', 'CLS004'),
('CS005', '2024-03-27', 1, 'A105', 'CLS005');

-- Inserting records into tblFee
INSERT INTO tblFee (FK_sFeeID, FK_sStudentID, fTotalFee, dDateofFee)
VALUES
('FEE001', 'STU001', 100.00, '2024-03-25'),
('FEE002', 'STU002', 150.00, '2024-03-25'),
('FEE003', 'STU003', 200.00, '2024-03-26'),
('FEE004', 'STU004', 250.00, '2024-03-26'),
('FEE005', 'STU005', 300.00, '2024-03-27');

-- Inserting records into tblSubject_Teacher
INSERT INTO tblSubject_Teacher (FK_sSubjectID, FK_sTeacherID)
VALUES
('SUB7', 'T1'),
('SUB2', 'T2'),
('SUB1', 'T3'),
('SUB3', 'T3'),
('SUB5', 'T5'),
('SUB10', 'T1'),
('SUB2', 'T8'),
('SUB9', 'T3'),
('SUB4', 'T9'),
('SUB5', 'T10');

-- Inserting records into tblSubject_Student
INSERT INTO tblSubject_Student (FK_sSubjectID, FK_sStudentID)
VALUES
('SUB7', 'STU001'),
('SUB6', 'STU002'),
('SUB2', 'STU003'),
('SUB3', 'STU004'),
('SUB4', 'STU007'),
('SUB1', 'STU008'),
('SUB10', 'STU005');





SELECT
    s.PK_sStudentID AS StudentID,
    s.sFullName AS FullName,
    su.PK_sSubjectID AS SubjectID,
    su.sName AS SubjectName,
    sc.fMidTerm AS MidTerm,
    sc.fFinal AS Final,
    sc.fOral AS Oral
FROM
    tblStudent s
INNER JOIN
    tblSubject_Student ss ON s.PK_sStudentID = ss.FK_sStudentID
INNER JOIN
    tblSubject su ON ss.FK_sSubjectID = su.PK_sSubjectID
LEFT JOIN
    tblScore sc ON su.PK_sSubjectID = sc.FK_sSubjectID
WHERE
    s.sFullName = N'Hoang Van E';


	SELECT * FROM dbo.tblScore

SELECT
    s.PK_sStudentID AS StudentID,
    s.sFullName AS FullName,
    sc.PK_sScoreID AS ScoreID,
    sb.sName AS SubjectName,
    sc.fMidTerm AS MidTerm,
    sc.fFinal AS Final,
    sc.fOral AS Oral
FROM
    tblStudent s
INNER JOIN
    tblSubject_Student ss ON s.PK_sStudentID = ss.FK_sStudentID
INNER JOIN
    tblSubject sb ON ss.FK_sSubjectID = sb.PK_sSubjectID
LEFT JOIN
    tblScore sc ON sb.PK_sSubjectID = sc.FK_sSubjectID
WHERE
    s.PK_sStudentID = 'STU005';
