using System;
using PaymentData;
using NUnit.Framework;

namespace UnitTests.PaymentData
{
    /// <summary>
    /// Класс тестирование ввода отработанных дней и вывода итоговой зарплаты
    /// </summary>
    [TestFixture]
    class SalaryTest
    {
        /// <summary>
        /// Тестирование ввода отработанных дней (диапазон от 0 до 25)
        /// </summary>
        /// <param name="days">Отработанные дни</param>
        [Test]
        [TestCase(0, TestName = "Тестирование ввода отработанных дней при значении <0>")]
        [TestCase(25, TestName = "Тестирование ввода отработанных дней при значении <25>")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода отработанных дней при значении <-1>")]
        [TestCase(26, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода отработанных дней при значении <26>")]
        public void SpentDaysTest(int days)
        {
            var salary = new Salary();
            salary.SpentDays = days;
        }
        /// <summary>
        /// Тестирование вывода итоговой заработной платы сотрудника по отработанным дням
        /// </summary>
        /// <param name="workExperience">Стаж работы сотрудника</param>
        /// <param name="education">Уровень образования сотрудника</param>
        /// <param name="position">Должность сотрудника</param>
        /// <param name="spentDays">Отработанные дни</param>
        /// <returns>Итоговая плата за месяц</returns>
        [Test]
        [TestCase(35, Education.Missing, Position.OfficeWorker, 24, ExpectedResult = 21659.4, TestName = "Тестирование итогового расчета зарплаты по окладу")]
        public double FinalSalaryTest(int workExperience, Education education, Position position, int spentDays)
        {
            var salary = new Salary();
            salary.WorkExperience = workExperience;
            salary.Education = education;
            salary.Position = position;
            salary.SpentDays = spentDays;
            return salary.FinalSalary();
        }
    }
}
