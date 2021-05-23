using Moq;
using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args is null)
                throw new ArgumentNullException(nameof(args));

            const int hours = 55, wage = 70;
            // List<Employee> employees = Utils.GetEmployees();

            var mock = new Mock<Utils>();
            mock.Setup(m => m.GetMockEmployees()).Returns(() =>
                new List<Employee> { new Contractor(), new Employee() });

            List<Employee> employees = mock.Object.GetMockEmployees();

            foreach (var e in employees)
            {
                e.CalculateWeeklySalary(hours, wage);
            }
        }
    }
}
