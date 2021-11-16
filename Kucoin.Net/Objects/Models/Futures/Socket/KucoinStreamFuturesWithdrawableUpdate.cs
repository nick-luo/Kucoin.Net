﻿using System;
using CryptoExchange.Net.Converters;
using Newtonsoft.Json;

namespace Kucoin.Net.Objects.Models.Futures.Socket
{
    /// <summary>
    /// Update to funds wich are withdrawable
    /// </summary>
    public class KucoinStreamFuturesWithdrawableUpdate
    {
        /// <summary>
        /// Current frozen quantity for withdrawal
        /// </summary>
        public decimal WithdrawHold { get; set; }
        /// <summary>
        /// Asset
        /// </summary>
        [JsonProperty("currency")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        public DateTime Timestamp { get; set; }
    }
}
