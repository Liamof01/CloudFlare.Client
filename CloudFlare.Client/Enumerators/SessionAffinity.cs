using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CloudFlare.Client.Enumerators
{
    /// <summary>
    /// Represents session affinities
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SessionAffinity
    {
        /// <summary>
        /// Do not use session affinity.
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// On the first request to a proxied load balancer, a cookie is generated, encoding information of which origin the request will be forwarded to.
        /// Subsequent requests, by the same client to the same load balancer, will be sent to the origin server the cookie encodes, for the duration of the cookie and as long as the origin server remains healthy.
        /// If the cookie has expired or the origin server is unhealthy, then a new origin server is calculated and used.
        /// </summary>
        [EnumMember(Value = "cookie")]
        Cookie,

        /// <summary>
        /// Behaves the same as <see cref="Cookie"/> except the initial origin selection is stable and based on the client's ip address.
        /// </summary>
        [EnumMember(Value = "ip_cookie")]
        IpCookie,

        /// <summary>
        /// On the first request to a proxied load balancer, a session key based on the configured HTTP headers (see session_affinity_attributes.headers) is generated, encoding the request headers used for storing in the load balancer session state which origin the request will be forwarded to.
        /// Subsequent requests to the load balancer with the same headers will be sent to the same origin server, for the duration of the session and as long as the origin server remains healthy.
        /// If the session has been idle for the duration of session_affinity_ttl seconds or the origin server is unhealthy, then a new origin server is calculated and used.
        /// See headers in session_affinity_attributes for additional required configuration.
        /// </summary>
        [EnumMember(Value = "header")]
        Header
    }
}
