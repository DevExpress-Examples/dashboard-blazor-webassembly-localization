using System;
using System.Collections.Generic;

namespace BlazorDashboardApp.Server {
    public class Employee {
        public readonly static List<Employee> Employees = GetEmployees();
        static List<Employee> GetEmployees() {
            List<Employee> data = new List<Employee>();
            string[] names = { "Andrew Fuller", "Michael Suyama",
                                "Robert King", "Nancy Davolio",
                                "Margaret Peacock", "Laura Callahan",
                                "Steven Buchanan", "Janet Leverling" };
            var rnd = new Random();
            for(int i = 0; i < 10; i++) {
                Employee record = new Employee();
                record.ID = i;
                record.Name = names[rnd.Next(0, names.Length)];
                int year = 2010 + rnd.Next(0, 10);
                int month = rnd.Next(1, 12);
                int day = rnd.Next(1, DateTime.DaysInMonth(year, month));
                record.HireDate = new DateTime(year, month, day);
                record.Department = "Dept. #" + (i % 3 + 1);
                record.Salary = rnd.Next(1000, 10000) + rnd.Next(0, 99) * 0.01;
                data.Add(record);
            }
            return data;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime HireDate { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

    }
}
