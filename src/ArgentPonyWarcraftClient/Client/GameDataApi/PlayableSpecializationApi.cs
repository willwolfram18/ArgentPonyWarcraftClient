﻿using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<PlayableSpecializationsIndex>> GetPlayableSpecializationsIndexAsync(string @namespace)
        {
            return await GetPlayableSpecializationsIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PlayableSpecializationsIndex>> GetPlayableSpecializationsIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<PlayableSpecializationsIndex>(region, $"{host}/data/wow/playable-specialization/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<PlayableSpecialization>> GetPlayableSpecializationAsync(int specId, string @namespace)
        {
            return await GetPlayableSpecializationAsync(specId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PlayableSpecialization>> GetPlayableSpecializationAsync(int specId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<PlayableSpecialization>(region, $"{host}/data/wow/playable-specialization/{specId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<PlayableSpecializationMedia>> GetPlayableSpecializationMediaAsync(int specId, string @namespace)
        {
            return await GetPlayableSpecializationMediaAsync(specId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PlayableSpecializationMedia>> GetPlayableSpecializationMediaAsync(int specId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<PlayableSpecializationMedia>(region, $"{host}/data/wow/media/playable-specialization/{specId}?namespace={@namespace}&locale={locale}");
        }
    }
}
