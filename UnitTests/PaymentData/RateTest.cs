using System;
using PaymentData;
using NUnit.Framework;

namespace UnitTests.PaymentData
{
    /// <summary>
    /// Класс тестирования ввода отработанных смен и вывода итоговой зарплаты
    /// </summary>
    [TestFixture]
    class RateTest
    {
        /// <summary>
        /// Тестирование ввода отработанных смен (диапазон от 0 до 14)
        /// </summary>
        /// <param name="shifts">Отработанные смены</param>
        [Test]
        [TestCase(0, TestName = "Тестирование ввода отработанных смен при значении <0>")]
        [TestCase(14, TestName = "Тестирование ввода отработанных смен при значении <14>")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода отработанных смен при значении <-1>")]
        [TestCase(15, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода отработанных смен при значении <15>")]
        public void WorkedShiftTest(int shifts)
        {
            var rate = new Rate();
            rate.WorkedShift = shifts;
        }
        /// <summary>
        /// Тестирование вывода итоговой заработной платы сотрудника по отработанным сменам
        /// </summary>
        /// <param name="workExperience">Стаж работы сотрудника</param>
        /// <param name="education">Уровень образования сотрудника</param>
        /// <param name="position">Должность сотрудника</param>
        /// <param name="workedShift">Отработанные смены</param>
        /// <returns>Итоговая плата за месяц</returns>
        [Test]
        [TestCase(14, Education.Higher, Position.Engineer, 12, ExpectedResult = 51359.616, TestName = "Тестирование итогового расчета зарплаты по ставке")]
        public double FinalSalaryTest(int workExperience, Education education, Position position, int workedShift)
        {
            var rate = new Rate();
            rate.WorkExperience = workExperience;
            rate.Education = education;
            rate.Position = position;
            rate.WorkedShift = workedShift;
            return rate.FinalSalary();
        }
    }
}
