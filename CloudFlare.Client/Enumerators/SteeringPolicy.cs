using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CloudFlare.Client.Enumerators
{
    /// <summary>
    /// Represents steering policies
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SteeringPolicy
    {
        /// <summary>
        /// Use default_pools.
        /// </summary>
        [EnumMember(Value = "off")]
        Off,

        /// <summary>
        /// Use region_pools/country_pools/pop_pools.
        /// For non-proxied requests, the country for country_pools is determined by location_strategy.
        /// </summary>
        [EnumMember(Value = "geo")]
        Geo,

        /// <summary>
        /// Select a pool randomly.
        /// </summary>
        [EnumMember(Value = "random")]
        Random,

        /// <summary>
        /// Use round trip time to select the closest pool in default_pools (requires pool health checks).
        /// </summary>
        [EnumMember(Value = "dynamic_latency")]
        DynamicLatency,

        /// <summary>
        /// Use the pools' latitude and longitude to select the closest pool using the Cloudflare PoP location for proxied requests or the location determined by location_strategy for non-proxied requests.
        /// </summary>
        [EnumMember(Value = "proximity")]
        Proximity,

        /// <summary>
        /// Select a pool by taking into consideration random_steering weights, as well as each pool's number of outstanding requests.
        /// Pools with more pending requests are weighted proportionately less relative to others.
        /// </summary>
        [EnumMember(Value = "least_outstanding_requests")]
        LeastOutstandingRequests,

        /// <summary>
        /// Select a pool by taking into consideration random_steering weights, as well as each pool's number of open connections.
        /// Pools with more open connections are weighted proportionately less relative to others.
        /// Supported for HTTP/1 and HTTP/2 connections.
        /// </summary>
        [EnumMember(Value = "least_connections")]
        LeastConnections,

        /// <summary>
        /// Will map to "geo" if you use region_pools/country_pools/pop_pools otherwise "off".
        /// </summary>
        [EnumMember(Value = "")]
        GeoOrOff
    }
}
