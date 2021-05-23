using NUnit.Framework;

namespace SalaryCalculator.Tests
{
    /*		
    To get hourly, divide annual salary by 2080     
    $100,006.40 / 2080 = $48.08  hr

    To get annual, multiply hourly by 2080 
    $48.08 * 2080 = $100,006.40
    */

    public class CalculatorTests
    {
        private SalaryCalculator sc;

        [SetUp]
        public void Setup()
        {
            sc = new SalaryCalculator();
        }

        [Test]
        public void AnnualSalaryTest()
        {           
            decimal annualSalary = sc.GetAnnualSalary(50);
            Assert.AreEqual(104000, annualSalary);
        }

        [Test]
        public void HourlyWageTest()
        {
            decimal hourlyWage = sc.GetHourlyWage(52000);
            Assert.AreEqual(25, hourlyWage);
        }
    }
}