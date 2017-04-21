using System;
using System.Runtime.Serialization;

namespace PaymentData
{
    /// <summary>
    /// Расчёт заработной платы сотрудника по отработанным сменам (ставке)
    /// </summary>
    [DataContract]
    public class Rate : BasicEmployeeData
    {
        /// <summary>
        /// Количество отработанных смен сотрудником
        /// </summary>
        [DataMember]
        private int _workedShift;
        /// <summary>
        /// Принятая ставка за одну отработанную смену
        /// </summary>
        [DataMember]
        private int _shiftRate = 2500;
        /// <summary>
        /// Метод задания и вывода количества отработанных смен
        /// </summary>
        public int WorkedShift
        {
            get { return _workedShift; }
            set
            {
                _workedShift = value;
                if (_workedShift < 0 || _workedShift > 14)
                {
                    throw new ArgumentException("Количество отработанных смен меньше нуля или превышает норматив");
                }
            }
        }
        /// <summary>
        /// Метод расчёта окончательной платы сотруднику за месяц по отработанным сменам и коэффициентам оплаты со ставкой за смену
        /// </summary>
        public override double FinalSalary()
        {
            if (_workedShift == 0)
            {
                return 0;
            }
            return Math.Round(((_workedShift * _shiftRate) + (_workExperience * 40.8)) * PaymentRatios(), 2);
        }
    }
}