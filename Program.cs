using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffBetweenIsAndAs
{
    class Program
    {
        static void Main(string[] args)
        {
            // SCENARIO 1 - Mark is Employee
            #region
            //Employee emp = new Employee { ID = 101, Name = "Mark" };

            //// Returns true
            //if (emp is Employee)
            //    Console.WriteLine(emp.Name + " is Employee");
            //else
            //    Console.WriteLine(emp.Name + " is not Employee");


            //// Returns false
            //if(emp is PermanentEmployee)
            //    Console.WriteLine(emp.Name + " is PermanentEmployee");
            //else
            //    Console.WriteLine(emp.Name + " is not PermanentEmployee");

            //// Returns false
            //if (emp is ContractEmployee)
            //    Console.WriteLine(emp.Name + " is ContractEmployee");
            //else
            //    Console.WriteLine(emp.Name + " is not ContractEmployee");
            #endregion

            // SCENARIO 2 - Mark is PermanentEmployee + Employee
            #region
            //Employee emp = new PermanentEmployee { ID = 101, Name = "Mark" };

            //// Returns true
            //if (emp is Employee)
            //    Console.WriteLine(emp.Name + " is Employee");
            //else
            //    Console.WriteLine(emp.Name + " is not Employee");


            //// Returns false
            //if (emp is PermanentEmployee)
            //    Console.WriteLine(emp.Name + " is PermanentEmployee");
            //else
            //    Console.WriteLine(emp.Name + " is not PermanentEmployee");

            //// Returns false
            //if (emp is ContractEmployee)
            //    Console.WriteLine(emp.Name + " is ContractEmployee");
            //else
            //    Console.WriteLine(emp.Name + " is not ContractEmployee");
            #endregion

            // SCENARIO 3 - Employee Mark AS PermanentEmployee
            #region
            //Employee emp = new Employee { ID = 101, Name = "Mark" };

            //// CANNOT CAST BASE TYPE TO DERIVED TYPE
            //// Casting fails, so permanentEmployee will be null
            //PermanentEmployee permanentEmployee = emp as PermanentEmployee;

            //if (permanentEmployee == null)
            //    Console.WriteLine("permanentEmployee is NULL");
            //else
            //    Console.WriteLine("permanentEmployee is NOT NULL");

            //// CANNOT CAST BASE TYPE TO DERIVED TYPE
            //// Casting fails, so contractEmployee will be null
            //ContractEmployee contractEmployee = emp as ContractEmployee;

            //if (contractEmployee == null)
            //    Console.WriteLine("contractEmployee is NULL");
            //else
            //    Console.WriteLine("contractEmployee is NOT NULL");
            #endregion

            // SCENARIO 4 - PermanentEmployee AS PermanentEmployee
            #region
            //Employee emp = new PermanentEmployee { ID = 101, Name = "Mark" };

            //// DERIVED TYPES CAN BE CAST TO BASE TYPES
            //// Casting succeeds
            //PermanentEmployee permanentEmployee = emp as PermanentEmployee;

            //if (permanentEmployee == null)
            //    Console.WriteLine("permanentEmployee is NULL");
            //else
            //    Console.WriteLine("permanentEmployee is NOT NULL");

            //// Casting fails
            //ContractEmployee contractEmployee = emp as ContractEmployee;

            //if (contractEmployee == null)
            //    Console.WriteLine("contractEmployee is NULL");
            //else
            //    Console.WriteLine("contractEmployee is NOT NULL");
            #endregion

            // SCENARIO 5 - Mark and Mary
            #region
            //Employee emp1 = new PermanentEmployee { ID = 101, Name = "Mark" };
            //Employee emp2 = new ContractEmployee { ID = 102, Name = "Mary" };

            //// DERIVED TYPES CAN BE CAST TO BASE TYPES
            //// Casting succeeds
            //Employee employee1 = emp1 as Employee;

            //if (employee1 == null)
            //    Console.WriteLine("Employee1 is NULL");
            //else
            //    Console.WriteLine("Employee1 is NOT NULL");

            //// Casting succeeds
            //Employee employee2 = emp2 as Employee;

            //if (employee2 == null)
            //    Console.WriteLine("Employee2 is NULL");
            //else
            //    Console.WriteLine("Employee2 is NOT NULL");
            #endregion

            // SCENARIO 6 - Cast Operator instead of AS
            #region
            Employee emp = new Employee {ID = 101,Name = "Mark"};

            // This line will throw InvalidCastException, while using AS does not.
            // AS would return nothing, since of course, it would be NULL
            PermanentEmployee permanentEmployee = (PermanentEmployee)emp;
            #endregion
        }
    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class PermanentEmployee : Employee
    {
        public int AnnualSalary { get; set; }
    }

    class ContractEmployee : Employee
    {
        public int HourlySalary { get; set; }
    }
}
