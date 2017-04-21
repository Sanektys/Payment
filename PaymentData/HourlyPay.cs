using System;
using System.Runtime.Serialization;

namespace PaymentData
{
    /// <summary>
    /// Расчёт заработной платы сотрудника по отработанным часам
    /// </summary>
    [DataContract]
    public class HourlyPay : BasicEmployeeData
    {
        /// <summary>
        /// Установленная плата за один отработанный час
        /// </summary>
        [DataMember]
        private int _hourlyRate = 120;
        /// <summary>
        /// Количество отработанных часов сотрудником
        /// </summary>
        [DataMember]
        private int _hoursWorked;
        /// <summary>
        /// Метод задания и вывода количества отработанных часов
        /// </summary>
        public int HoursWorked
        {
            get { return _hoursWorked; }
            set
            {
                _hoursWorked = value;
                if (value < 0 || value > 176)
                {
                    throw new ArgumentException("Количество отработанных часов меньше нуля или превышает норматив");
                }
            }
        }
        /// <summary>
        /// Метод расчёта окончательной платы сотруднику за месяц по отработанным часам и коэффициентам оплаты
        /// </summary>
        public override double FinalSalary()
        {
            if (_hoursWorked == 0)
            {
                return 0;
            }
            return Math.Round(((_hoursWorked * _hourlyRate) + (_workExperience * 40.8)) * PaymentRatios(), 2);
        }
    }
}