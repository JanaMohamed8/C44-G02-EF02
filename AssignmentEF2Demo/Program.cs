using AssignmentEF2Demo.Data.Models;

namespace AssignmentEF2Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CRUD Operations
            //connection Syntax Sugar
            using ITIDbcontext dbContext = new ITIDbcontext();
            #region Department Table 
            #region create objects
            var department1 = new Department
            {
                Name = "Computer Science",
                Ins_ID = null,
                HiringDate = new DateTime(2020, 9, 1),
                ManagerId = null,
            };
            var department2 = new Department
            {
                Name = "IS",
                Ins_ID = null,
                HiringDate = new DateTime(2020, 9, 1),
                ManagerId = null,
            };
            //Console.WriteLine(dbContext.Entry(department1).State);
            //Console.WriteLine(dbContext.Entry(department2).State);
            #endregion
            #region Add Department
            //dbContext.Departments.Add(department1);
            //dbContext.Departments.Add(department2);
            //Console.WriteLine(dbContext.Entry(department1).State);
            //Console.WriteLine(dbContext.Entry(department2).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(department1).State);
            //Console.WriteLine(dbContext.Entry(department2).State);
            #endregion
            #region Add

            #endregion
            #endregion
            #region Instructor Table
            #region Objects
            Instructor instructor1 = new Instructor
            {
        
                Name = "Ahmed",
                Salary = 12000.50m,
                Address = "Cairo",
                HourRateBouns = 150.75m,
                Dept_ID = 2,   
                Dep_Id = 2 
            };
            Instructor instructor2 = new Instructor
            {
           
                Name = "Jana",
                Salary = 12000.50m,
                Address = "Cairo",
                HourRateBouns = 150.75m,
                Dept_ID = 1,
                Dep_Id = 1
            };
            //Console.WriteLine(dbContext.Entry(instructor1).State);/*Detached*/
            //Console.WriteLine(dbContext.Entry(instructor2).State);/*Detached*/

            #endregion
            #region Add Instructor
            //dbContext.Instructors.Add(instructor1);
            //dbContext.Instructors.Add(instructor2);
            ////Console.WriteLine(dbContext.Entry(instructor1).State);//Added
            ////Console.WriteLine(dbContext.Entry(instructor2).State);//Added
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(instructor1).State);//Unchanged
            //Console.WriteLine(dbContext.Entry(instructor2).State);//Unchanged
            #endregion
            #region Read 
            //var Instructor = (from I in dbContext.Instructors
            //                  where I.Id == 1
            //                  select I).FirstOrDefault();
            //Console.WriteLine(Instructor?.Name?? "Not Found");//Ahmed
            //var Instructor = (from I in dbContext.Instructors
            //                  where I.Id == 4
            //                  select I).FirstOrDefault();
            //Console.WriteLine(Instructor?.Name ?? "Not Found");//Not Found

            #endregion
            #region Update 
            //var UpdateInstructor = (from I in dbContext.Instructors
            //                        where I.Id == 1
            //                        select I).FirstOrDefault();
            //UpdateInstructor.Name = "Dalia";
            //Console.WriteLine(dbContext.Entry(UpdateInstructor).State);//Modified
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(UpdateInstructor).State);//Unchanged
            #endregion
            #region Delete
            //var DeleteInstructor = (from I in dbContext.Instructors
            //                        where I.Id == 1
            //                        select I).FirstOrDefault();
            //dbContext.Instructors.Remove(DeleteInstructor);
            //Console.WriteLine(dbContext.Entry(DeleteInstructor).State); /*Deleted*/
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(DeleteInstructor).State);/*Detached*/
            #endregion
            #endregion
            #region Student Table
            #region Object
            var student1 = new Student
            {
                FName = "Omar",
                LName = "Mohamed",
                Address = "Alexandria - Egypt",
                Age = 22,
                Dep_Id = 1  
            };
            var student2 = new Student
            {
                FName = "Jana",
                LName = "Mohamed",
                Address = "Alexandria - Egypt",
                Age = 21,
                Dep_Id = 2
            };
            //Console.WriteLine(dbContext.Entry(student1).State);//Detached
            //Console.WriteLine(dbContext.Entry(student2).State);//Detached
            #endregion
            #region Add Students
            //dbContext.Students.Add(student1);
            //dbContext.Students.Add(student2);
            //Console.WriteLine(dbContext.Entry(student1).State);//Addded
            //Console.WriteLine(dbContext.Entry(student2).State);//Addded
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(student1).State);//Unchanged
            //Console.WriteLine(dbContext.Entry(student2).State);//Unchanged
            #endregion
            #region Read / Return
            //var StudentRead = (from S in dbContext.Students
            //                   where S.Id == 1
            //                   select S).FirstOrDefault();
            //Console.WriteLine(StudentRead?.FName?? "Not Found");
            #endregion
            #region Update 
            //var StudentUpdate = (from S in dbContext.Students
            //                     where S.Id == 1
            //                     select S).FirstOrDefault();
            //StudentUpdate.FName = "Ahmed";
            //Console.WriteLine(dbContext.Entry( StudentUpdate).State);//Modified
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(StudentUpdate).State);//Unchanged
            #endregion
            #region Delete 
            //var StudentDelete = (from S in dbContext.Students
            //                     where S.Id == 1
            //                     select S).FirstOrDefault();
            //dbContext.Students.Remove(StudentDelete);
            //Console.WriteLine(dbContext.Entry(StudentDelete).State);//Deleted
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(StudentDelete).State);//Detached
            #endregion
            #endregion
            #region Topic Table
            #region object
            var Topic1 = new Topic()
            {
                Name = "oop"
            };
            var Topic2 = new Topic()
            {
                Name = "CS"
            };
            //Console.WriteLine(dbContext.Entry(Topic1).State);//Detached
            //Console.WriteLine(dbContext.Entry(Topic2).State);//Detached
            #endregion
            #region Add Topics
            //dbContext.Topics.Add(Topic1);
            //dbContext.Topics.Add(Topic2);
            //Console.WriteLine(dbContext.Entry(Topic1).State);//Added
            //Console.WriteLine(dbContext.Entry(Topic2).State);//Added
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(Topic1).State);//Unchanged
            //Console.WriteLine(dbContext.Entry(Topic2).State);//Unchanged
            #endregion
            #region Update
            //var TopicUpdate = (from T in dbContext.Topics
            //                   where T.Name == "oop"
            //                   select T).FirstOrDefault();
            //TopicUpdate.Name = "OS";
            //Console.WriteLine(dbContext.Entry(TopicUpdate).State);//Modified
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(TopicUpdate).State);//Unchanged
            #endregion
            #region Read
            //var TopicRead = (from T in dbContext.Topics
            //                   where T.Id == 1
            //                   select T).FirstOrDefault();
            //Console.WriteLine(TopicRead?.Name?? "Not Found");//OS
            //var TopicRead2 = (from T in dbContext.Topics
            //                 where T.Id == 4
            //                 select T).FirstOrDefault();
            //Console.WriteLine(TopicRead2?.Name ?? "Not Found");//Not Found
            #endregion
            #region Delete
            //var TopicDelete = (from T in dbContext.Topics
            //                 where T.Id == 1
            //                 select T).FirstOrDefault();
            //dbContext.Topics.Remove(TopicDelete);
            //Console.WriteLine(dbContext.Entry(TopicDelete).State);//Deleted
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(TopicDelete).State);//Detached
            #endregion
            #endregion
            #region Course Table 
            #region Object
            var course1 = new Course
            {

                Name = "C# Fundamentals",
                Description = "Learn the basics of C# programming language",
                Duration = 40,
                Top_ID = 2
            };
            var course2 = new Course
            {

                Name = "ASP.NET Core Web Development",
                Description = "Build modern web applications using ASP.NET Core MVC & Web API",
                Duration = 60,
                Top_ID = 2
            };
            //Console.WriteLine(dbContext.Entry(course1).State);//Detached
            //Console.WriteLine(dbContext.Entry(course2).State);//Detached 
            #endregion
            #region Create / Add
            //dbContext.Courses.Add(course1);
            //dbContext.Courses.Add(course2);
            //Console.WriteLine(dbContext.Entry(course1).State);//Added
            //Console.WriteLine(dbContext.Entry(course2).State);//Added
            //dbContext.SaveChanges();
            #endregion
            #region Update 
            //var CourseUpdate = (from c in dbContext.Courses
            //                    where c.Name == "C# Fundamentals"
            //                    select c).FirstOrDefault();
            //CourseUpdate.Name = "OOP";
            //Console.WriteLine(dbContext.Entry(CourseUpdate).State);//Modified
            //dbContext.SaveChanges();
            #endregion
            #region Read
            //var CourseRead = (from c in dbContext.Courses
            //                    where c.Id == 1
            //                    select c).FirstOrDefault();
            //Console.WriteLine(CourseRead?.Name?? "Not Found");//OOP
            #endregion
            #region Delete
            var CourseDelete = (from c in dbContext.Courses
                                where c.Name == "OOP"
                                select c).FirstOrDefault();
            dbContext.Courses.Remove(CourseDelete);
            Console.WriteLine(dbContext.Entry(CourseDelete).State);//Deleted
            dbContext.SaveChanges();
            #endregion
            #endregion
            #endregion
        }
    }
}
