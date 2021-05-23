using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class Utils
    {
        public static List<Employee> GetEmployees()
        {
            var someEmployee = new Employee();
            var someContractor = new Contractor();
            var everyone = new List<Employee> { someEmployee, someContractor };
            return everyone;
        }

        public virtual List<Employee> GetMockEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
