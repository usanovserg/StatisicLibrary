using MongoDB.Bson.Serialization.Attributes;

namespace StatisticLibrary
{
    public class RobotStatistics
    {
        public RobotStatistics()
        {

        }

        /// <summary>
        /// Индивидуальный id железа
        /// </summary>
        [BsonId]
        public string HwId { get; set; } = string.Empty;

        public LicenseType LicenseType { get; set; } = LicenseType.None;

        /// <summary>
        /// Дата экспирации лицензии
        /// </summary>
        public DateTime LicenseExpire { get; set; } = DateTime.MinValue;

        /// <summary>
        /// Общее время работы робота.
        /// </summary>
        public TimeSpan TotalWorkingTime { get; set; } = new TimeSpan();

        /// <summary>
        /// Статистика по коннекторам
        /// </summary>
        public List<ConnectorStatistics> ConnectorsStatistics { get; set; } = new List<ConnectorStatistics>();

        /// <summary>
        /// Последнее время запуска
        /// </summary>
        public DateTime LastDateTime { get; set; } = DateTime.MinValue;

        /// <summary>
        /// Кол-во запусков привода
        /// </summary>
        public int NumbersOfStarts { get; set; } = 0;
    }
}
