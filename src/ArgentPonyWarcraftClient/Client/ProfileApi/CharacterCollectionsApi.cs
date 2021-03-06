﻿using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<CharacterCollectionsIndex>> GetCharacterCollectionsIndexAsync(string realmSlug, string characterName, string @namespace)
        {
            return await GetCharacterCollectionsIndexAsync(realmSlug, characterName, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterCollectionsIndex>> GetCharacterCollectionsIndexAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CharacterCollectionsIndex>(region, $"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/collections?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterPetsCollectionSummary>> GetCharacterPetsCollectionSummaryAsync(string realmSlug, string characterName, string @namespace)
        {
            return await GetCharacterPetsCollectionSummaryAsync(realmSlug, characterName, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterPetsCollectionSummary>> GetCharacterPetsCollectionSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CharacterPetsCollectionSummary>(region, $"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/collections/pets?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterMountsCollectionSummary>> GetCharacterMountsCollectionSummaryAsync(string realmSlug, string characterName, string @namespace)
        {
            return await GetCharacterMountsCollectionSummaryAsync(realmSlug, characterName, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterMountsCollectionSummary>> GetCharacterMountsCollectionSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CharacterMountsCollectionSummary>(region, $"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/collections/mounts?namespace={@namespace}&locale={locale}");
        }
    }
}
