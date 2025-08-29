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

            #endregion
        }
    }
}
