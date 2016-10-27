using Adapter.Contracts;
using System;
using System.Collections.Generic;

namespace Adapter.Models
{
    public class EmployeeAdapter : HRSystem, ITarget
    {
        public List<string> GetEmployeeList()
        {
            List<string> employeeList = new List<string>();
            string[][] employees = GetEmployees();
            foreach (string[] employee in employees)
            {
                employeeList.Add(employee[0]);
                employeeList.Add(employee[1]);
                employeeList.Add(employee[2]);
                employeeList.Add(Environment.NewLine);
            }

            return employeeList;
        }
    }
}
