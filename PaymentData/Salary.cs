using System;
using System.Runtime.Serialization;

namespace PaymentData
{
    /// <summary>
    /// Расчёт заработной платы сотрудника по отработанным дням (окладу)
    /// </summary>
    [DataContract]
    public class Salary : BasicEmployeeData
    {
        /// <summary>
        /// Количество отработанных дней сотрудником
        /// </summary>
        [DataMember]
        private int _spentDays;
        /// <summary>
        /// Установленный оклад за все рабочие дни месяца
        /// </summary>
        [DataMember]
        private int _monthlySalary = 20000;
        /// <summary>
        /// Условное среднее количество рабочих дней в месяце
        /// </summary>
        [DataMember]
        private int _regulatoryDays = 25;
        /// <summary>
        /// Метод задания и вывода количества отработанных дней
        /// </summary>
        [DataMember]
        public int SpentDays
        {
            get { return _spentDays; }
            set
            {
                _spentDays = value;
                if (_spentDays < 0 || _spentDays > 25)
                {
                    throw new ArgumentException("Количество отработанных дней меньше нуля или превышает норматив");
                }
            }
        }
        /// <summary>
        /// Метод расчёта окончательной платы сотруднику за месяц по отработанным дням и коэффициентам оплаты
        /// </summary>
        public override double FinalSalary()
        {
            if (_spentDays == 0)
            {
                return 0;
            }
            return ((_monthlySalary / _regulatoryDays) * _spentDays + (_workExperience * 40.8)) * PaymentRatios();
        }
    }
}