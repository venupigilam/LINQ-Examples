using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Examples_New
{
    /// <summary>
    /// LINQ Examples 
    /// Reference : https://www.tutorialspoint.com/linq/index.htm
    /// Author : Venu Pigilam , 2018
    /// </summary>
    class Program
    {

        #region "Support classes
        class DeptClass
        {
            public int DeptId { get; set; }
            public String Deptname { get; set; }
        }
        class EmployeeClass
        {
            public int EmpId { get; set; }
            public String EmpName { get; set; }
            public int DeptId { get; set; }
        }
        class StudentClass
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int StudentAge { get; set; }
        }
        class Plant
        {
            public String Name { get; set; }
        }
        class CarnivousPlant : Plant
        {
            public string TrapType { get; set; }
        }
        class Pet
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static Pet[] GetCats()
        {
            Pet[] Cats = new Pet[]{
                new Pet{ Name = "Barley",Age=6},
                new Pet{Name = "Boots",Age=5},
                new Pet{Name = "Whiskers",Age=7}
            };
            return Cats;
        }

        static Pet[] GetDogs()
        {
            Pet[] Dogs = new Pet[]{
                new Pet { Name = "Bounder", Age=12},
                new Pet{ Name = "Snoopy",Age=10},
                new Pet{Name ="Fido",Age=8}
            };

            return Dogs;

        }
        #endregion

        static void Main(string[] args)
        {
            Program p = new Program();

            // <*> Conditional Operator <*>
            // p.ExampleWhere(); // Where

            //<*> Join Operators <*>
            //p.ExampleJoin(); // Join

            //<*> Projection Operations <*>
            //p.ExampleSelect(); //Select
            //p.ExampleSelectMany();// SelectMany

            //<*> Sorting Operators in LINQ <*>
            //p.ExampleOrderBy(); //OrderBy, Orderby Descending

            //ThenBy, ThenBy Descending
            //p.ExampleThenBy();
            //GroupBy
            //p.ExampleGroupBy();

            //Conversions - Cast
            //p.ExampleCast();

            //Concatenation
            //p.ExampleConcat();

            //OfType
            p.ExampleOfType();

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();

        }

        private void ExampleWhere()
        {
            //Using Strings

            string[] names = { "Sachin", "Ganguly", "Dravid", "Sehwag", "Yuvraj" };
            Console.WriteLine("------------------");
            Console.WriteLine("Query (Comprehension) Syntax - Strings");
            Console.WriteLine("------------------");
            var strName = from name in names where name.Length == 6 select name;
            foreach (var strn in strName)
            {
                Console.WriteLine(strn);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Lamda (Method) Syntax - Strings");
            Console.WriteLine("------------------");
            var longwords = names.Where(w => w.Length == 6);
            foreach (var lng in longwords)
            {
                Console.WriteLine(lng);
            }

            //Using Numbers
            Console.WriteLine("Numbers greater than : 80");

            int[] numbers = { 101, 85, 79, 91, 203 };
            Console.WriteLine("------------------");
            Console.WriteLine("Query (Comprehension) Syntax");
            Console.WriteLine("------------------");
            IEnumerable<int> Comp_Nums = from cmp in numbers where cmp > 80 select cmp;
            foreach (int cnum in Comp_Nums)
            {
                Console.WriteLine(cnum);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Lamda Expression");
            Console.WriteLine("------------------");
            var ints = numbers.Where(w => w > 90);
            foreach (int cnum in ints)
            {
                Console.WriteLine(cnum);
            }
        }
        private void ExampleJoin()
        {
            List<DeptClass> dept = new List<DeptClass>();
            dept.Add(new DeptClass { DeptId = 1, Deptname = "IT" });
            dept.Add(new DeptClass { DeptId = 2, Deptname = "Revenue" });
            dept.Add(new DeptClass { DeptId = 3, Deptname = "Academic" });

            List<EmployeeClass> emp = new List<EmployeeClass>();
            emp.Add(new EmployeeClass { EmpId = 1, EmpName = "Venu Pigilam", DeptId = 1 });
            emp.Add(new EmployeeClass { EmpId = 2, EmpName = "Anil Podili", DeptId = 1 });
            emp.Add(new EmployeeClass { EmpId = 3, EmpName = "Janga Reddy", DeptId = 1 });

            emp.Add(new EmployeeClass { EmpId = 4, EmpName = "Veerendra", DeptId = 2 });

            emp.Add(new EmployeeClass { EmpId = 5, EmpName = "Ramchandar", DeptId = 3 });

            var EmployeeDepts = from e in emp
                                join d in dept on e.DeptId equals d.DeptId
                                select new
                                {
                                    EmpId = e.EmpId,
                                    EmpName = e.EmpName,
                                    DeptId = d.DeptId,
                                    DeptName = d.Deptname
                                }
                                ;

            foreach (var e in EmployeeDepts)
            {
                Console.WriteLine("EmpId : {0}, Name : {1}, DeptId : {2}, DeptName : {3}", e.EmpId, e.EmpName, e.DeptId, e.DeptName);
            }

        }
        private void ExampleSelect()
        {
            List<String> StrProverbs = new List<String>() { "Any", "Body", "Can", "Dance" };
            //List<String> StrProverbs = new List<String>() { "Apple a Day", "keeps Doctor Away" };

            var query = from Sp in StrProverbs select Sp.Substring(0, 1);
            foreach (string st in query)
            {
                Console.WriteLine(st);

            }
        }
        private void ExampleSelectMany()
        {
            List<string> phrases = new List<string>() { "an apple a day", "the quick brown fox" };

            var Query = from phrase in phrases
                        from word in phrase.Split(' ')
                        select word;

            foreach (string s in Query)
            {
                Console.WriteLine(s);
            }
        }
        private void ExampleOrderBy()
        {
            Console.WriteLine("-------- Ascending--------------");
            int[] Numbers = { 1, 2, -5, 7, -99, 0, 12, 25 };
            var NumbersAsc = from num in Numbers
                             orderby num
                             select num;
            foreach (int numasc in NumbersAsc)
            {
                Console.WriteLine(numasc);
            }
            Console.WriteLine("-------- Decending--------------");
            var NumbersDesc = from num in Numbers
                              orderby num descending
                              select num;
            foreach (int numdesc in NumbersDesc)
            {
                Console.WriteLine(numdesc);
            }
        }
        private void ExampleThenBy()
        {
            IList<StudentClass> Sclass = new List<StudentClass>();

            Sclass.Add(new StudentClass { StudentID = 1, StudentName = "Mohan Reddy", StudentAge = 26 });
            Sclass.Add(new StudentClass { StudentID = 2, StudentName = "Sudheer Reddy", StudentAge = 30 });
            Sclass.Add(new StudentClass { StudentID = 3, StudentName = "Praveen", StudentAge = 29 });
            Sclass.Add(new StudentClass { StudentID = 4, StudentName = "Subba Reddy", StudentAge = 30 });
            Sclass.Add(new StudentClass { StudentID = 5, StudentName = "Janga Reddy", StudentAge = 35 });
            Sclass.Add(new StudentClass { StudentID = 6, StudentName = "Anil Podili", StudentAge = 31 });
            Sclass.Add(new StudentClass { StudentID = 7, StudentName = "Venu Pigilam", StudentAge = 41 });

            //Console.WriteLine("Order by Normal Select syntax with multiple arguments");
            //Console.WriteLine("------------------------------------------------");
            //var StuList = from sc in Sclass
            //              orderby sc.StudentName, sc.StudentAge
            //              select sc;

            //foreach (StudentClass scn in StuList)
            //{
            //    Console.WriteLine("Id : {0}, Name : {1}, Age : {2}", scn.StudentID, scn.StudentName, scn.StudentAge);
            //}
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(" Thenby with arguments ");
            Console.WriteLine("------------------------------------------------");
            var stuList1 = Sclass.OrderBy(s => s.StudentName).ThenBy(s => s.StudentAge);
            foreach (StudentClass st in stuList1)
            {
                Console.WriteLine("Id : {0}, Name : {1}, Age : {2}", st.StudentID, st.StudentName, st.StudentAge);
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(" ThenbyDesc with arguments ");
            Console.WriteLine("------------------------------------------------");
            var stuList2 = Sclass.OrderByDescending(s => s.StudentName).ThenByDescending(s => s.StudentAge);
            foreach (StudentClass st in stuList2)
            {
                Console.WriteLine("Id : {0}, Name : {1}, Age : {2}", st.StudentID, st.StudentName, st.StudentAge);
            }
        }
        private void ExampleGroupBy()
        {
            List<int> integers = new List<int> { 2, 206, 348, 125, 2015, 1095, 106, 786, 564, 321, 975 };

            var ints = from it in integers
                       group it by it % 2;

            //IEnumerable<IGrouping<int, int>> ints = from it in integers
            //group it by it % 2;
            foreach (var group in ints)
            {
                Console.WriteLine(group.Key == 0 ? "\nEven numbers:" : "\nOdd numbers:");

                foreach (var num in group)
                {
                    Console.WriteLine(num);
                }
            }

        }
        private void ExampleCast()
        {
            Plant[] plants = new Plant[]{ 
                new CarnivousPlant { Name = "Plant - 1" , TrapType ="Type-1" }, 
                new CarnivousPlant { Name =  "Plant - 2", TrapType = "Type-2"},
                new CarnivousPlant{Name =  "Plant - 3", TrapType = "Type-1"},
                new CarnivousPlant{Name =  "Plant - 4", TrapType = "Type-2"}
            };

            var CPlants = from CarnivousPlant Cplant in plants
                          where Cplant.TrapType == "Type-1"
                          select Cplant;

            foreach (var cp in CPlants)
            {
                Console.WriteLine("Name : {0}, Plantype : {1}", cp.Name, cp.TrapType);
            }

        }
        private void ExampleConcat()
        {
            Pet[] cats = GetCats();
            Pet[] dogs = GetDogs();

            IEnumerable<String> Query = cats.Select(c => c.Name).Concat(dogs.Select(d => d.Name));
            foreach (String StrCon in Query)
            {
                Console.WriteLine(StrCon);
            }
        }
        private void ExampleOfType()
        {
            // Create an object array for the demonstration.
            object[] array = new object[4];
            array[0] = new StringBuilder();
            array[1] = "Venu Pigialm";
            array[2] = new int[1];
            array[3] = "Sujana Pigilam";

            var result = array.OfType<String>();
            // Filter the objects by their type.
            // ... Only match strings.
            // ... Print those strings to the screen.
            foreach (var element in result)
            {
                Console.WriteLine(element);
            }

        }
    }
}
