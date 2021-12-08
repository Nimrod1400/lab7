using System;
using System.Collections.Generic;


namespace Lab7
{
    class Commander
    {
        public List<Employee> AllEmployees { get; set; } = new List<Employee>();
        public List<Employee> TommorowAtWork { get; set; } = new List<Employee>();

        public void PrintTeam()
        {
            foreach (Employee employee in TommorowAtWork)
            {
                Console.WriteLine(employee.GetFullName());
            }
        }

        public void PrintBadge(Cashier cashier)
        {
            Console.WriteLine(cashier.GetFullName());
        }

        public void PrintBadgeForAllCashiers()
        {
            foreach (Employee employee in AllEmployees)
            {
                if (employee is Cashier)
                {
                    PrintBadge((Cashier)employee);
                }
            }
        }
    }
}
