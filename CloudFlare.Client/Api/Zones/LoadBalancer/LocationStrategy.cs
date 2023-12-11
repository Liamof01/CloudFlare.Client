using CloudFlare.Client.Enumerators;
using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.LoadBalancer
{
    /// <summary>
    /// Controls location-based steering for non-proxied requests.
    /// See steering_policy to learn how steering is affected.
    /// </summary>
    public class LocationStrategy
    {
        /// <summary>
        /// Determines the authoritative location when ECS is not preferred, does not exist in the request, or its GeoIP lookup is unsuccessful.
        /// </summary>
        [JsonProperty("mode")]
        public LocationStrategyMode Mode { get; set; }

        /// <summary>
        /// Whether the EDNS Client Subnet (ECS) GeoIP should be preferred as the authoritative location.
        /// </summary>
        [JsonProperty("prefer_ecs")]
        public PreferECS PreferECS { get; set; }
    }
}
