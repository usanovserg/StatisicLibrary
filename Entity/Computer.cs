using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticLibrary.Entity
{
    public class Computer
    {


        #region Properties ===========================================================

        /// <summary>
        /// Индивидуальный id железа
        /// </summary>
        public string HwId { get; set; } = string.Empty;

        /// <summary>
        /// Список всех запущенных наших продуктов
        /// </summary>
        public List<RobotStatistics> Robots { get; set; } = new List<RobotStatistics>();

        /// <summary>
        /// Страна где находится компьютер
        /// </summary>
        public string Country { get; set; } = string.Empty;

        /// <summary>
        /// Часовой пояс
        /// </summary>
        public int TimeZone { get; set; } = 0;

        #endregion
    }
}
