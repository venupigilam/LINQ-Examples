using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqSampels LS = new LinqSampels();
            LS.LinqCount();
            

            SqlConnection con;
            SqlDataReader reader;
            try
            {
                int id;
                con = new SqlConnection(Properties.Settings.Default.ConStr);

                con.Open();
                Console.WriteLine("Enter Employee Id");
                id = int.Parse(Console.ReadLine());
                //reader = new SqlCommand("select * from TblStudent where EmpId=" + id, con).ExecuteReader();

                reader = new SqlCommand("select * from TblStudent where Stu_Id =" + id, con).ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("EmpID | EmpName | EmpSalary \n {0}  |   {1}  |   {2}", reader.GetInt32(0),
                        reader.GetString(1), reader.GetDateTime(2));
                        //, reader.GetInt32(2)
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class LinqSampels
    {

        int[] Numbers = { 1, 3, 5, 4, 5, 10, 1, 34, 14 };

        public void LinqCount()
        {
            int CountNumbers = Numbers.Count();

            Console.WriteLine("There are {0} in Numebrs.", CountNumbers);
        }

        public void LinqUniqueCount()
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };

            int uniqueFactors = factorsOf300.Distinct().Count();

            Console.WriteLine("There are {0} unique factors of 300.", uniqueFactors);
        }

    }
}
