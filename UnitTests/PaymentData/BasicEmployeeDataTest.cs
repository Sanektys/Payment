using System;
using NUnit.Framework;
using PaymentData;

namespace UnitTests.PaymentData
{
    /// <summary>
    /// Класс тестирования ввода некоторых базовых данных сотрудников (стаж, должность, образование)
    /// </summary>
    [TestFixture]
    public class BasicEmployeeDataTest
    {
        /// <summary>
        /// Тестирование ввода стажа работы (диапазон от 0 до 80)
        /// </summary>
        /// <param name="years">Стаж работы</param>
        [Test]
        [TestCase(0, TestName = "Тестирование ввода стажа при значении <0>")]
        [TestCase(80, TestName = "Тестирование ввода стажа при значении <80>")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода стажа при значении <-1>")]
        [TestCase(81, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода стажа при значении <81>")]
        public void WorkExperienceTest(int years)
        {
            var basicData = new BasicEmployeeData();
            basicData.WorkExperience = years;
        }
        /// <summary>
        /// Тестирование ввода должности (на основе перечисления)
        /// </summary>
        /// <param name="position">Должность сотрудника</param>
        [Test]
        [TestCase(Position.OfficeWorker, TestName = "Тестирование ввода профессии <Офисный сотрудник>")]
        public void PositionTest(Position position)
        {
            var basicData = new BasicEmployeeData();
            basicData.Position = position;
        }
        /// <summary>
        /// Тестирование ввода образования сотрудника (на основе перечисления)
        /// </summary>
        /// <param name="education">Уровень образования сотрудника</param>
        [Test]
        [TestCase(Education.Higher, TestName = "Тестирование ввода образования <Высшее>")]
        public void EducationTest(Education education)
        {
            var basicData = new BasicEmployeeData();
            basicData.Education = education;
        }
    }
}
