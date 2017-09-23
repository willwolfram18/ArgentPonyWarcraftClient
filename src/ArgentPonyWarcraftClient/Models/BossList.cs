﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A list of bosses.
    /// </summary>
    public class BossList
    {
        /// <summary>
        /// Gets the bosses.
        /// </summary>
        [JsonProperty(PropertyName = "bosses")]
        public List<Boss> Bosses { get; set; }
    }
}