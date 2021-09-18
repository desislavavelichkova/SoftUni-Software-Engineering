using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        private List<Employee> data;
        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Employee>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
                
        public int Count { get { return data.Count; } }
        public void Add(Employee employee)
        {
            if (data.Count < Capacity)
            {
                data.Add(employee);
            }         
        }
        public bool Remove(string name)
        {
            Employee employee = data.FirstOrDefault(x => x.Name == name);
            if (employee == null)
            {
                return false;
            }
            else
            {
                data.Remove(employee);
                return true;
            }
        }
        public Employee GetOldestEmployee()
        {
            return data.OrderByDescending(x => x.Age).FirstOrDefault();
           
        }
        public  Employee GetEmployee(string name)
        {
            Employee employee = data.FirstOrDefault(x => x.Name == name);
            return employee;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Employees working at Bakery {Name}:\n");
            foreach (var employee in data)
            {
                sb.Append($"{employee.ToString()}\n");
            }
            
            return sb.ToString();
        }


    }
}
