﻿using CryptoExchange.Net.Converters;
using Kucoin.Net.Enums;
using Newtonsoft.Json;
using System;
using Kucoin.Net.Converters;

namespace Kucoin.Net.Objects.Futures
{
    /// <summary>
    /// Futures order info
    /// </summary>
    public class KucoinFuturesOrder: KucoinOrderBase
    {
        /// <summary>
        /// Value of the order
        /// </summary>
        [JsonProperty("value")]
        public decimal QuoteQantity { get; set; }
        /// <summary>
        /// Filled value
        /// </summary>
        [JsonProperty("filledValue")]
        public decimal QuoteQuantityFilled { get; set; }
        /// <summary>
        /// Filled quantity
        /// </summary>
        [JsonProperty("filledSize")]
        public decimal QuantityFilled { get; set; }
        /// <summary>
        /// The type of the stop order
        /// </summary>
        [JsonConverter(typeof(StopConditionConverter))]
        [JsonProperty("stop")]
        public StopCondition StopOrderType { get; set; }
        /// <summary>
        /// Stop price type
        /// </summary>
        [JsonConverter(typeof(StopPriceTypeConverter))]
        public StopPriceType? StopPriceType { get; set; }
        /// <summary>
        /// Leverage
        /// </summary>
        public int Leverage { get; set; }
        /// <summary>
        /// Force hold
        /// </summary>
        public bool ForceHold { get; set; }
        /// <summary>
        /// Close order
        /// </summary>
        public bool CloseOrder { get; set; }
        /// <summary>
        /// Reduce only
        /// </summary>
        public bool ReduceOnly { get; set; }
        /// <summary>
        /// Settle asset
        /// </summary>
        [JsonProperty("settleCurrency")]
        public string SettleAsset { get; set; } = string.Empty;
        /// <summary>
        /// The time the order was last updated
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("updatedAt")]
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// Order create time
        /// </summary>
        [JsonConverter(typeof(TimestampNanoSecondsConverter))]
        [JsonProperty("orderTime")]
        public DateTime? OrderTime { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; } = string.Empty;
    }
}