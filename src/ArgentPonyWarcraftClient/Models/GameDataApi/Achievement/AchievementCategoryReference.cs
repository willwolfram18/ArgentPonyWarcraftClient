﻿using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to an achievement category.
    /// </summary>
    public class AchievementCategoryReference
    {
        /// <summary>
        /// Gets the key for this achievement category.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; private set; }

        /// <summary>
        /// Gets the name of this achievement category.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the ID of this achievement category.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; private set; }
    }
}
