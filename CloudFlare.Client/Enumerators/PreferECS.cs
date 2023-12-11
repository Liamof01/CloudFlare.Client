using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CloudFlare.Client.Enumerators
{
    /// <summary>
    /// Whether the EDNS Client Subnet (ECS) GeoIP should be preferred as the authoritative location.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PreferECS
    {
        /// <summary>
        /// Always prefer ECS.
        /// </summary>
        [EnumMember(Value = "always")]
        Always,

        /// <summary>
        /// Never prefer ECS.
        /// </summary>
        [EnumMember(Value = "never")]
        Never,

        /// <summary>
        /// Prefer ECS only when steering_policy="proximity".
        /// </summary>
        [EnumMember(Value = "proximity")]
        Proximity,

        /// <summary>
        /// Prefer ECS only when steering_policy="geo".
        /// </summary>
        [EnumMember(Value = "geo")]
        Geo
    }
}
