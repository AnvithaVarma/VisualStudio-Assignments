using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Employee> employeeList = new List<Employee>()
            {
                new Employee() { EmployeeID = 12, EmployeeName = "Anvitha", EmployeeSalary = 86000,EmployeeDesignation="Engineer" },
            new Employee() { EmployeeID = 13, EmployeeName = "Swati", EmployeeSalary = 33000 ,EmployeeDesignation="Software Engineer" },
            new Employee() { EmployeeID = 14, EmployeeName = "Sravya", EmployeeSalary = 45000,EmployeeDesignation="Business" },
            new Employee() { EmployeeID = 15, EmployeeName = "Anku", EmployeeSalary = 67000 ,EmployeeDesignation="HR"},
            new Employee() { EmployeeID = 16, EmployeeName = "Venky", EmployeeSalary = 78000 ,EmployeeDesignation="Politician"},

        };
            var EmployeeName = employeeList.Where(s => s.EmployeeID > 14).Select(s => s).
                Where(st => st.EmployeeSalary > 70000).Select(s => s.EmployeeName);
            
            var EmployeeName1 = from s in employeeList where s.EmployeeID<13 || s.EmployeeID == 14
                               select new { employeeName = s.EmployeeName };

            var EmployeeName2 = from s in employeeList
                                where s.EmployeeDesignation == "HR" || s.EmployeeDesignation == "Business"
                                select new { employeeName = s.EmployeeName };
            var EmployeeName3 = from s in employeeList
                                where s.EmployeeID > 10 
                                select new { employeeName = s.EmployeeName };
            var EmployeeName4 = from s in employeeList
                                where s.EmployeeID < 13 || s.EmployeeID >= 14
                                //orderby s.Length(EmployeeSalary)
                                select new { employeeName = s.EmployeeName };
            var EmployeeName5 = from s in employeeList
                                where s.EmployeeID < 13 || s.EmployeeID > 14
                                select new { employeeName = s.EmployeeName };


            foreach (var name in EmployeeName)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("*********************************************************");

            EmployeeName1.ToList().ForEach(s => Console.WriteLine(s.employeeName));

            Console.WriteLine("*********************************************************");

            EmployeeName2.ToList().ForEach(s => Console.WriteLine(s.employeeName));
            Console.WriteLine("*********************************************************");
            EmployeeName3.ToList().ForEach(s => Console.WriteLine(s.employeeName));

            Console.WriteLine("*********************************************************");
            EmployeeName4.ToList().ForEach(s => Console.WriteLine(s.employeeName));
            Console.WriteLine("*********************************************************");
            EmployeeName5.ToList().ForEach(s => Console.WriteLine(s.employeeName));
            Console.WriteLine("*********************************************************");
            //employeeList.OrderBy(s => s.EmployeeSalary).ThenByDescending(s => s.EmployeeID);
            //employeeList.ToList().ForEach(s => Console.WriteLine(s.EmployeeSalary));

        }
    }
    public class Employee
    {
        public int EmployeeID { get; set; }
    
        public string EmployeeName { get; set; }

        public int EmployeeSalary { get; set; }

        public string EmployeeDesignation { get; set; }
    }
}
