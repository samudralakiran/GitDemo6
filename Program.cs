// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

// 'override' modifier will overrides the base class implementation

namespace Demo
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

    class Developer: Employee
    {
        public override void Print() // overrides the base class implementation
        {
            Console.WriteLine($"{FirstName} {LastName} Developer");
        }
    }

    class Tester:Employee
    {
        public override void Print() // overrides the base class implementation
        {
            Console.WriteLine($"{FirstName} {LastName} Tester");
        }
    }

    class Manager:Employee
    {
        List<Employee> m_empList = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            m_empList.Add(employee);
        }

        public override void Print()
        {
            Console.WriteLine($"Manager {FirstName} {LastName}");

            foreach (Employee employee in m_empList)
                employee.Print();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager() { FirstName = "Sowmya", LastName = "Vadlmudi"};

            manager.AddEmployee(new Developer { FirstName = "Naveen", LastName = "Baratam" });
            manager.AddEmployee(new Tester { FirstName = "Bharath", LastName = "Moppuri" });

            manager.AddEmployee(new Developer { FirstName = "Narasimha", LastName = "K" });
            manager.AddEmployee(new Tester { FirstName = "Sujana", LastName = "Mannam" });
           
            manager.Print();
        }
    }
}
