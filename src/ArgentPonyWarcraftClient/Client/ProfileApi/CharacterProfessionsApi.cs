﻿using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<CharacterProfessionsSummary>> GetCharacterProfessionsSummaryAsync(string realmSlug, string characterName, string @namespace)
        {
            return await GetCharacterProfessionsSummaryAsync(realmSlug, characterName, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterProfessionsSummary>> GetCharacterProfessionsSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CharacterProfessionsSummary>(region, $"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/professions?namespace={@namespace}&locale={locale}");
        }
    }
}
