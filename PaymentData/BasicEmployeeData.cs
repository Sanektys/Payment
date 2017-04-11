using System;
using System.Runtime.Serialization;

namespace PaymentData
{
    /// <summary>
    /// Базовая информация о сотрудниках
    /// </summary>
    [DataContract]
    [KnownType(typeof(HourlyPay))]
    [KnownType(typeof(Rate))]
    [KnownType(typeof(Salary))]
    public class BasicEmployeeData
    {
        /// <summary>
        /// Стаж работы сотрудника
        /// </summary>
        [DataMember]
        protected int _workExperience;
        /// <summary>
        /// Должность сотрудника
        /// </summary>
        [DataMember]
        protected Position _position;
        /// <summary>
        /// Уровень образования сотрудника
        /// </summary>
        [DataMember]
        protected Education _education;
        /// <summary>
        /// Имя сотрудника
        /// </summary>
        [DataMember]
        protected string _name;
        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
        [DataMember]
        protected string _surname;
        /// <summary>
        /// Метод задания и вывода имени сотрудника
        /// </summary>
        [DataMember]
        public string Name 
        {
            get { return _name; }
            set { _name = value; } 
        }
        /// <summary>
        /// Метод задания и вывода фамилии сотрудника
        /// </summary>
        [DataMember]
        public string Surname 
        { 
            get { return _surname; }
            set { _surname = value; } 
        }
        /// <summary>
        /// Метод задания и вывода стажа работы сотрудника
        /// </summary>
        [DataMember]
        public int WorkExperience
        {
            get { return _workExperience; }
            set 
            {
                _workExperience = value;
                if (_workExperience < 0 || _workExperience > 80)
                {
                    throw new ArgumentException("Введено некорректное значение трудового стажа");
                }
            } 
        }
        /// <summary>
        /// Метод задания должности сотрудника
        /// </summary>
        public Position Position 
        { 
            set  { _position = value; }
        }
        /// <summary>
        /// Метод вывода должности сотрудника строкой
        /// </summary>
        public string GetPosition
        {
            get
            {
                switch (_position)
                {
                    case Position.Workman: return "Рабочий";
                    case Position.JuniorStaff: return "Младший сотрудник";
                    case Position.Engineer: return "Инженер";
                    case Position.OfficeWorker: return "Офисный сотрудник";
                }
                return null;
            }
        }
        /// <summary>
        /// Метод задания информации об образовании сотрудника
        /// </summary>
        public Education Education
        {
            set { _education = value; }
        }
        /// <summary>
        /// Метод вывода информации об образовании сотрудника строкой
        /// </summary>
        public string GetEducation
        {
            get
            {
                switch (_education)
                {
                    case Education.Missing: return "Отсутствует";
                    case Education.Secondary: return "Среднее";
                    case Education.Higher: return "Высшее";
                }
                return null;
            }
        }
        /// <summary>
        /// Метод расстановки коэффициентов оплаты труда по критериям должности и образования
        /// </summary>
        public double PaymentRatios()
        {
            double edu;
            switch(_education)
            {
                case Education.Missing: edu = 0.7; break;
                case Education.Secondary: edu = 1; break;
                case Education.Higher: edu = 1.2; break;
                default: edu = 0; break;
            }
            double pos;
            switch (_position)
            {
                case Position.Workman: pos = 1.2; break;
                case Position.JuniorStaff: pos = 0.9; break;
                case Position.Engineer: pos = 1.4; break;
                case Position.OfficeWorker: pos = 1.5; break;
                default: pos = 0; break;
            }
            return edu * pos;
        }
        /// <summary>
        /// Базовый, пустой метод расчёта ежемесячной заработной платы сотрудника
        /// </summary>
        public virtual double FinalSalary()
        {
            return 0;
        }
    }
}
