using System;
using System.Collections.Generic;
using System.Text;
using testxamarin.Models;

namespace testxamarin.ViewModel
{
    public class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }

        public EmployeeViewModel()
        {
            Employees = new Employee().getEmployee();
        }
    }
}
