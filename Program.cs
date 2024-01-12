using System;



namespace OverloadingOperatorsAssignment

{
    class Program

    {
        static void Main(string[] args)

        {
            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.FirstName = "Bob";
            emp1.LastName = "Jones";

            Employee emp2 = new Employee();
            emp2.Id = 1;
            emp2.FirstName = "Bob";
            emp2.LastName = "Jones";


            if (emp1 == emp2)
            {
                Console.WriteLine("emp1 is equal to emp2");
            }
            else
            {
                Console.WriteLine("emp1 is not equal to emp2");
            }
            Console.ReadLine();
        }

        public class Employee

        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            
            
            public static bool operator ==(Employee emp1, Employee emp2)
            {
                if (emp1.Id.Equals(emp2.Id))
                {
                    return true;
                }
                return false;
            }

            public static bool operator !=(Employee emp1, Employee emp2)
            {
                if (!emp1.Id.Equals(emp2.Id))
                {
                    return true;
                }
                return false;
            }
            public override bool Equals(object obj)
            {
                Employee employee = obj as Employee;
                if (employee != null)
                {
                    return employee.Id.Equals(this.Id);
                }
                return false;
            }

        }

    }
}
