using System;

namespace Polymorphism
{
    public class Employee
    {
        public virtual string CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = 40 * wage;
            string result = string.Format("This ANGRY EMPLOYEE worked {0} hrs. " +
                              "Paid for 40 hrs at $ {1}" +
                              "/hr = ${2}", weeklyHours, wage, salary);

            Console.WriteLine($"\n{result}\n");
            Console.WriteLine("---------------------------------------------\n");
            return result;
        }
    }
}
