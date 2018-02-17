using System;
using System.Linq;
using System.Configuration;

namespace LINQtoSQL
{
    class Program
    {
        static void Main(string[] args)
        {

            //string connectString = System.Configuration.ConfigurationManager.ConnectionStrings["LINQtoSQL.Properties.Settings.LINQ_PracticeConnectionString"].ToString();
            //LINQ2SqlPracticeDataContext db = new LINQ2SqlPracticeDataContext(connectString);

            // For Inserting Students
            //InsertSchools();
            
            // For Inserting Schools
            InsertStudents();

            //var CountStudents = db.TblStudents.Count();
            //LinqToSQLDataContext db = new LinqToSQLDataContext(connectString);           


            //Create New School



            //Console.WriteLine("Name : {0}, Area : {1}, City : {2}, PinCode : {3}, Location : {4}", newSchool.Sch_Name, newSchool.Sch_Area, newSchool.Sch_City, newSchool.Sch_Pincode, newSchool.Sch_Location);

            //Create new Employee

            //Employee newEmployee = new Employee();
            //newEmployee.Name = "Michael";
            //newEmployee.Email = "yourname@companyname.com";
            //newEmployee.ContactNo = "343434343";
            //newEmployee.DepartmentId = 3;
            //newEmployee.Address = "Michael - USA";

            ////Add new Employee to database
            //db.Employees.InsertOnSubmit(newEmployee);

            ////Save changes to Database.
            //db.SubmitChanges();

            ////Get new Inserted Employee            
            //Employee insertedEmployee = db.Employees.FirstOrDefault(e ⇒e.Name.Equals("Michael"));

            //Console.WriteLine("Employee Id = {0} , Name = {1}, Email = {2}, ContactNo = {3}, Address = {4}",
            //                 insertedEmployee.EmployeeId, insertedEmployee.Name, insertedEmployee.Email, 
            //                 insertedEmployee.ContactNo, insertedEmployee.Address);

            //Console.WriteLine("Students : " + CountStudents.ToString());
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        static void InsertSchools()
        {

            LINQ2SqlPracticeDataContext db;
            db = GetDBContext();

            TblSchool sch1 = new TblSchool();
            sch1.Sch_Id = 1;
            sch1.Sch_Name = "ZPHS School";
            sch1.Sch_Area = "Dargamitta";
            sch1.Sch_City = "Nellore";
            sch1.Sch_State = "Andhra Pradesh";
            sch1.Sch_Country = "INDia";
            sch1.Sch_Location = "Nippo Back Side";
            sch1.Sch_Pincode = "524004";

            db.TblSchools.InsertOnSubmit(sch1);

            TblSchool sch2 = new TblSchool();
            sch2.Sch_Id = 2;
            sch2.Sch_Name = "MPUP School";
            sch2.Sch_Area = "BhakthaVatsala Nagar";
            sch2.Sch_City = "Nellore";
            sch2.Sch_State = "Andhra Pradesh";
            sch2.Sch_Country = "INDia";
            sch2.Sch_Location = "Current Office";
            sch2.Sch_Pincode = "524004";

            db.TblSchools.InsertOnSubmit(sch2);

            TblSchool sch3 = new TblSchool();
            sch3.Sch_Id = 3;
            sch3.Sch_Name = "Narayana Olympiad School";
            sch3.Sch_Area = "Haranadha Puram";
            sch3.Sch_City = "Nellore";
            sch3.Sch_State = "Andhra Pradesh";
            sch3.Sch_Country = "INDia";
            sch3.Sch_Location = "Haranadha Puram";
            sch3.Sch_Pincode = "524001";

            db.TblSchools.InsertOnSubmit(sch3);

            TblSchool sch4 = new TblSchool();
            sch4.Sch_Id = 4;
            sch4.Sch_Name = "Chaitanya E-Techno School";
            sch4.Sch_Area = "Kanuru";
            sch4.Sch_City = "Vijayawada";
            sch4.Sch_State = "Andhra Pradesh";
            sch4.Sch_Country = "INDia";
            sch4.Sch_Location = "Kanuru Village";
            sch4.Sch_Pincode = "514001";

            db.TblSchools.InsertOnSubmit(sch4);

            TblSchool sch5 = new TblSchool();
            sch5.Sch_Id = 5;
            sch5.Sch_Name = "Ravindra Bharathi School";
            sch5.Sch_Area = "Gajuwaka";
            sch5.Sch_City = "Vizag";
            sch5.Sch_State = "Andhra Pradesh";
            sch5.Sch_Country = "INDia";
            sch5.Sch_Location = "Gajuwaka";
            sch5.Sch_Pincode = "504002";

            db.TblSchools.InsertOnSubmit(sch5);
            db.SubmitChanges();

        }
        static void InsertStudents()
        {


            LINQ2SqlPracticeDataContext db;
            db = GetDBContext();

            //TblSchool newSchool = db.TblSchools.FirstOrDefault(e => e.Sch_Name.Contains("ZP"));
            //TblSchool newSchool = db.TblSchools.FirstOrDefault(e => e.Sch_Id.Equals(1));
            //Console.WriteLine(newSchool.Sch_Name);

            TblStudent stu1 = new TblStudent();
            stu1.Stu_Id = 1;
            stu1.Stu_Name = "Venu Pigilam";
            stu1.Stu_Gender = "Male";
            stu1.Stu_Father = "Arjun Rao";
            stu1.Stu_Mother = "Maha Lakshmi";
            stu1.Stu_Dob = new DateTime();
            stu1.Stu_Mobile = "9963456363";
             //= 1;
            //TblSchool tblsch = db.TblSchools.FirstOrDefault(xy => xy.Sch_Id.Equals(1));
            //stu1.Stu_School = tblsch.Sch_Id;

            db.TblStudents.InsertOnSubmit(stu1);

            //TblStudent stu2 = new TblStudent();
            //stu2.Stu_Id = 2;
            //stu2.Stu_Name = "Sujana Pigilam";
            //stu2.Stu_Gender = "FeMale";
            //stu2.Stu_Father = "Arjun Rao";
            //stu2.Stu_Mother = "Maha Lakshmi";
            //stu2.Stu_Dob = new DateTime();
            //stu2.Stu_Mobile = "9963451818";
            //stu2.Stu_School = 2;

            //db.TblStudents.InsertOnSubmit(stu2);

            //TblStudent stu3 = new TblStudent();
            //stu3.Stu_Id = 3;
            //stu3.Stu_Name = "Sree Vidya";
            //stu3.Stu_Gender = "Male";
            //stu3.Stu_Father = "Arjun Rao";
            //stu3.Stu_Mother = "Maha Lakshmi";
            //stu3.Stu_Dob = new DateTime();
            //stu3.Stu_Mobile = "9963456363";
            //stu3.Stu_School = 3;

            //db.TblStudents.InsertOnSubmit(stu3);

            //TblStudent stu4 = new TblStudent();
            //stu4.Stu_Id = 4;
            //stu4.Stu_Name = "Muni dinakar";
            //stu4.Stu_Gender = "Male";
            //stu4.Stu_Father = "Ramanaih";
            //stu4.Stu_Mother = "Muni Lakshmi";
            //stu4.Stu_Dob = new DateTime();
            //stu4.Stu_Mobile = "9441271662";
            //stu4.Stu_School = 4;

            //db.TblStudents.InsertOnSubmit(stu4);

            //TblStudent stu5 = new TblStudent();
            //stu5.Stu_Id = 5;
            //stu5.Stu_Name = "Venkata Suneel";
            //stu5.Stu_Gender = "Male";
            //stu5.Stu_Father = "Manohar";
            //stu5.Stu_Mother = "Rajeswari";
            //stu5.Stu_Dob = new DateTime();
            //stu5.Stu_Mobile = "9704462687";
            //stu5.Stu_School = 5;

            //db.TblStudents.InsertOnSubmit(stu5);
            db.SubmitChanges();

        }
        static LINQ2SqlPracticeDataContext GetDBContext()
        {
            string connectString = System.Configuration.ConfigurationManager.ConnectionStrings["LINQtoSQL.Properties.Settings.LINQ_PracticeConnectionString"].ToString();
            LINQ2SqlPracticeDataContext db = new LINQ2SqlPracticeDataContext(connectString);

            return db;
        }

    }
}
