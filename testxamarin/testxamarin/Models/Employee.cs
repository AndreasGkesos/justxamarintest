using System;
using System.Collections.Generic;
using System.Text;

namespace testxamarin.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Designation { get; set; }

        public List<Employee> getEmployee()
        {
            List<Employee> listEmployee = new List<Employee>()
            {
                new Employee() {
                    Name = "employee1",
                    Address = "address 1",
                    Designation = "designation 1"
                },
                new Employee() {
                    Name = "employee2",
                    Address = "address 2",
                    Designation = "designation 2"},
                new Employee() {
                    Name = "employee3",
                    Address = "address 3",
                    Designation = "designation 3"
                }
            };
            return listEmployee;
        }
    }
}
