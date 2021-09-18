namespace BakeryOpenning
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //List<Employee> employees = new List<Employee>();
            Bakery bakery = new Bakery("Barny", 10);            
            Employee employee = new Employee("Stephen", 40, "Bulgaria");
            
            Console.WriteLine(employee);                       
            bakery.Add(employee);
            
            Console.WriteLine(bakery.Remove("Employee name")); //false

            Employee secondEmployee = new Employee("Mark", 34, "UK");

            //Add Employee
            bakery.Add(secondEmployee);

            Employee oldestEmployee = bakery.GetOldestEmployee(); // Employee with name Stephen
            Employee employeeStephen = bakery.GetEmployee("Stephen"); // Employee with name Stephen
            Console.WriteLine(oldestEmployee); //Employee: Stephen, 40 (Bulgaria)
            Console.WriteLine(employeeStephen); //Employee: Stephen, 40 (Bulgaria)

            Console.WriteLine(bakery.Count); //2

            Console.WriteLine(bakery.Report());
            //Employees working at Bakery Barny:
            //Employee: Stephen, 40 (Bulgaria)
            //Employee: Mark, 34 (UK)

        }
    }
}
