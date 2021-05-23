using NUnit.Framework;

namespace Polymorphism.Tests
{
    public class PolymorphismTests
    {
        private Employee employee;
        private Contractor contractor;

        [SetUp]
        public void Setup()
        {
            employee = new Employee();
            contractor = new Contractor();
        }

        [Test]
        public void CalculateWeeklySalaryForEmployeeTest_70wage55hours_Returns2800Dollars()
        {
            int weeklyHours = 40;
            int wage = 70;
            int salary = weeklyHours * wage;

            string expected = string.Format("This ANGRY EMPLOYEE worked {0} hrs. " +
                              "Paid for 40 hrs at $ {1}" +
                              "/hr = ${2}", weeklyHours, wage, salary);

            string response = employee.CalculateWeeklySalary(weeklyHours, wage);

            Assert.AreEqual(response, expected);
        }

        [Test]
        public void CalculateWeeklySalaryForContractorTest_70wage55hours_Returns2800Dollars()
        {
            int weeklyHours = 40;
            int wage = 70;
            int salary = weeklyHours * wage;

            string expected = string.Format("This HAPPY CONTRACTOR worked {0} hrs. " +
                              "Paid for {0} hrs at $ {1}" +
                              "/hr = ${2}", weeklyHours, wage, salary);

            string response = contractor.CalculateWeeklySalary(weeklyHours, wage);

            Assert.AreEqual(response, expected);
        }

        [Test]
        public void CalculateWeeklySalaryForEmployeeTest_70wage55hours_IncorrectReturn()
        {
            int weeklyHours = 55;
            int wage = 70;
            int salary = 1;

            string expected = string.Format("This ANGRY EMPLOYEE worked {0} hrs. " +
                              "Paid for 40 hrs at $ {1}" +
                              "/hr = ${2}", weeklyHours, wage, salary);

            string response = employee.CalculateWeeklySalary(weeklyHours, wage);

            Assert.AreNotEqual(response, expected);
        }

        [Test]
        public void CalculateWeeklySalaryForContractorTest_70wage55hours_IncorrectReturn()
        {
            int weeklyHours = 55;
            int wage = 70;
            int salary = 1;

            string expected = string.Format("This HAPPY CONTRACTOR worked {0} hrs. " +
                              "Paid for {0} hrs at $ {1}" +
                              "/hr = ${2}", weeklyHours, wage, salary);

            string response = employee.CalculateWeeklySalary(weeklyHours, wage);

            Assert.AreNotEqual(response, expected);
        }
    }
}