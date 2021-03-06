﻿using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<ConnectedRealmsIndex>> GetConnectedRealmsIndexAsync(string @namespace)
        {
            return await GetConnectedRealmsIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<ConnectedRealmsIndex>> GetConnectedRealmsIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<ConnectedRealmsIndex>(region, $"{host}/data/wow/connected-realm/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<ConnectedRealm>> GetConnectedRealmAsync(int connectedRealmId, string @namespace)
        {
            return await GetConnectedRealmAsync(connectedRealmId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<ConnectedRealm>> GetConnectedRealmAsync(int connectedRealmId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<ConnectedRealm>(region, $"{host}/data/wow/connected-realm/{connectedRealmId}?namespace={@namespace}&locale={locale}");
        }
    }
}
