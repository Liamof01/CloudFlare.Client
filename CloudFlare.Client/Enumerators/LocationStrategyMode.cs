using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CloudFlare.Client.Enumerators
{
    /// <summary>
    /// Determines the authoritative location when ECS is not preferred, does not exist in the request, or its GeoIP lookup is unsuccessful.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LocationStrategyMode
    {
        /// <summary>
        /// Use the Cloudflare PoP location.
        /// </summary>
        [EnumMember(Value = "pop")]
        PoP,

        /// <summary>
        /// Use the DNS resolver GeoIP location. If the GeoIP lookup is unsuccessful, use the Cloudflare PoP location.
        /// </summary>
        [EnumMember(Value = "resolver_ip")]
        ResolverIP
    }
}
