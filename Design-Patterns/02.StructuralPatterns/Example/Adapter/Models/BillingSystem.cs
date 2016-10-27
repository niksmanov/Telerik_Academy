using Adapter.Contracts;
using System;
using System.Collections.Generic;

namespace Adapter.Models
{
    public class BillingSystem
    {
        private ITarget employees;

        public BillingSystem(ITarget employees)
        {
            this.employees = employees;
        }

        public void ShowEmployeeList()
        {
            List<string> employee = employees.GetEmployeeList();

            Console.WriteLine(string.Join(" ", employee));
        }
    }
}
