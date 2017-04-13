using System;
using PaymentData;
using NUnit.Framework;

namespace UnitTests.PaymentData
{
    /// <summary>
    /// Класс тестирования ввода отработанных часов и вывода итоговой зарплаты
    /// </summary>
    [TestFixture]
    class HourlyPayTest
    {
        /// <summary>
        /// Тестирование ввода отработанных часов (диапазон от 0 до 176)
        /// </summary>
        /// <param name="hours">Количество отработанных часов</param>
        [Test]
        [TestCase(0, TestName = "Тестирование ввода отработанных часов при значении <0>")]
        [TestCase(176, TestName = "Тестирование ввода отработанных часов при значении <176>")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода отработанных часов при значении <-1>")]
        [TestCase(177, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода отработанных часов при значении <177>")]
        public void HoursWorkedTest(int hours)
        {
            var hourlyPay = new HourlyPay();
            hourlyPay.HoursWorked = hours;
        }
        /// <summary>
        /// Тестирование вывода итоговой заработной платы сотрудника по отработанным часам
        /// </summary>
        /// <param name="workExperience">Стаж работы сотрудника</param>
        /// <param name="education">Уровень образования сотрудника</param>
        /// <param name="position">Должность сотрудника</param>
        /// <param name="hoursWorked">Количество отработанных часов</param>
        /// <returns>Итоговая плата за месяц</returns>
        [Test]
        [TestCase(21, Education.Secondary, Position.Workman, 134, ExpectedResult = 20324.16, TestName = "Тестирование итогового расчета зарплаты по часам")]
        public double FinalSalaryTest(int workExperience, Education education, Position position, int hoursWorked)
        {
            var hourlyPay = new HourlyPay();
            hourlyPay.WorkExperience = workExperience;
            hourlyPay.Education = education;
            hourlyPay.Position = position;
            hourlyPay.HoursWorked = hoursWorked;
            return hourlyPay.FinalSalary();
        }
    }
}
