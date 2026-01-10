CREATE DATABASE CourseRegistrationDB;
USE CourseRegistrationDB;

CREATE TABLE Departments (
    Department_ID INT PRIMARY KEY,
    Department_Name VARCHAR(50) NOT NULL UNIQUE
);


CREATE TABLE Instructors (
    Instructor_ID INT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Department_ID INT,
    Email VARCHAR(50),
    FOREIGN KEY (Department_ID) REFERENCES Departments(Department_ID)
);


CREATE TABLE Courses (
    Course_ID INT PRIMARY KEY,
    Course_Name VARCHAR(50) NOT NULL,
    Instructor_ID INT,
    Credits INT,
    Department_ID INT,
    FOREIGN KEY (Instructor_ID) REFERENCES Instructors(Instructor_ID),
    FOREIGN KEY (Department_ID) REFERENCES Departments(Department_ID)
);


CREATE TABLE Students (
    Student_ID INT PRIMARY KEY,
    First_Name VARCHAR(30),
    Last_Name VARCHAR(30),
    Email VARCHAR(50),
    Phone_Number VARCHAR(15),
    Enrollment_Date DATE
);


CREATE TABLE Enrollments (
    Enrollment_ID INT PRIMARY KEY,
    Student_ID INT,
    Course_ID INT,
    Enrollment_Date DATE,
    Status VARCHAR(20) CHECK (Status IN ('Enrolled','Completed','Withdrawn')),
    FOREIGN KEY (Student_ID) REFERENCES Students(Student_ID),
    FOREIGN KEY (Course_ID) REFERENCES Courses(Course_ID)
);


CREATE TABLE Course_Requirements (
    Course_ID INT,
    Prerequisite_Course_ID INT,
    FOREIGN KEY (Course_ID) REFERENCES Courses(Course_ID),
    FOREIGN KEY (Prerequisite_Course_ID) REFERENCES Courses(Course_ID)
);



INSERT INTO Departments VALUES
(1,'Computer Science'),
(2,'Information Technology'),
(3,'Engineering'),
(4,'Business'),
(5,'Math');

INSERT INTO Instructors VALUES
(1,'Dr. Ahmad',1,'ahmad@uni.com'),
(2,'Dr. Lina',2,'lina@uni.com'),
(3,'Dr. Omar',3,'omar@uni.com'),
(4,'Dr. Sara',4,'sara@uni.com'),
(5,'Dr. Ali',5,'ali@uni.com');

INSERT INTO Courses VALUES
(101,'Databases',1,2,1),
(102,'Networks',2,3,2),
(103,'Mechanics',3,4,3),
(104,'Marketing',4,3,4),
(105,'Calculus',5,4,5);

INSERT INTO Students VALUES
(1,'Yara','Atoom','yara@gmail.com','0791111111','2024-09-01'),
(2,'Rama','Dallou','rama@gmail.com','0792222222','2024-09-01'),
(3,'Jood','Atoom','jood@gmail.com','0793333333','2024-09-01'),
(4,'Hala','Abu_Dalo','hala@jmail.com','0794444444','2024-09-01'),
(5,'Rahaf','Rasheed','rahaf@gmail.com','0795555555','2024-09-01');

INSERT INTO Enrollments VALUES
(1,1,101,'2024-09-10','Enrolled'),
(2,2,101,'2024-09-10','Completed'),
(3,3,102,'2024-09-11','Completed'),
(4,4,103,'2024-09-12','Withdrawn'),
(5,5,104,'2024-09-13','Enrolled');




SELECT Students.First_Name, Students.Last_Name
FROM Students
JOIN Enrollments ON Students.Student_ID = Enrollments.Student_ID
WHERE Enrollments.Course_ID = 101;


INSERT INTO Students
VALUES (6,'Yara','Atoom','yara@mail.com','0796666666','2024-09-01');


UPDATE Enrollments
SET Status = 'Completed'
WHERE Enrollment_ID = 1;


SELECT Course_Name
FROM Courses
WHERE Instructor_ID = 1;


SELECT Students.First_Name, Students.Last_Name
FROM Students
JOIN Enrollments ON Students.Student_ID = Enrollments.Student_ID
WHERE Enrollments.Course_ID = 101
AND Enrollments.Status = 'Completed';


SELECT Course_Name
FROM Courses
WHERE Department_ID = 1;


INSERT INTO Enrollments
VALUES (6,6,105,'2024-10-01','Enrolled');


SELECT DISTINCT Students.First_Name, Students.Last_Name
FROM Students
JOIN Enrollments ON Students.Student_ID = Enrollments.Student_ID
WHERE Enrollments.Status != 'Completed';
