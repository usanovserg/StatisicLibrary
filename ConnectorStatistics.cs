

namespace StatisticLibrary
{
    public class ConnectorStatistics
    {
        public ConnectorStatistics() { }

        public ExchangeType ExchangeType { get; set; } = ExchangeType.None;

        /// <summary>
        /// Кол-во совершенных сделок за все время
        /// </summary>
        public int TradesCount { get; set; }

        /// <summary>
        /// Кол-во совершенных убыточных сделок за все время
        /// </summary>
        public int PositionsLossCount { get; set; }

        /// <summary>
        /// Кол-во совершенных прибыльных сделок за все время
        /// </summary>
        public int PositionsProfitCount { get; set; }

        /// <summary>
        /// Общая прибыль за все время
        /// </summary>
        public decimal ProfitAccum { get; set; }

        /// <summary>
        /// Общий убыток за все время
        /// </summary>
        public decimal LossAccum { get; set; }

        /// <summary>
        /// Общая уплаченная комиссия по всем сделкам
        /// </summary>
        public decimal Commission { get; set; }

        /// <summary>
        /// Общее время пользования этим коннектором
        /// </summary>
        public TimeSpan AllTime { get; set; }
    }
}
