﻿using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<PlayableRacesIndex>> GetPlayableRacesIndexAsync(string @namespace)
        {
            return await GetPlayableRacesIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PlayableRacesIndex>> GetPlayableRacesIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<PlayableRacesIndex>(region, $"{host}/data/wow/playable-race/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<PlayableRace>> GetPlayableRaceAsync(int playableRaceId, string @namespace)
        {
            return await GetPlayableRaceAsync(playableRaceId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PlayableRace>> GetPlayableRaceAsync(int playableRaceId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<PlayableRace>(region, $"{host}/data/wow/playable-race/{playableRaceId}?namespace={@namespace}&locale={locale}");
        }
    }
}
