using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PaymentData
{
    /// <summary>
    /// Списки сотрудников предприятия
    /// </summary>
    [DataContract]
    public class Listing
    {
        /// <summary>
        /// Фактический список сотрудников
        /// </summary>
        [DataMember]
        public static List<BasicEmployeeData> listEmployees = new List<BasicEmployeeData>();
        /// <summary>
        /// Список-буфер для поиска, с ограниченным поиском временем жизни
        /// </summary>
        [IgnoreDataMember]
        public static List<BasicEmployeeData> findEmployees = new List<BasicEmployeeData>();
    }
}
