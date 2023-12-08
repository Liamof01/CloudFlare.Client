using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.LoadBalancer
{
    /// <summary>
    /// Load balancer
    /// </summary>
    public class LoadBalancer
    {
        /// <summary>
        /// Load balancer identifier
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the record
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Time to live (TTL) of the DNS entry for the IP address returned by this load balancer.
        /// This only applies to gray-clouded (unproxied) load balancers.
        /// </summary>
        [JsonProperty("ttl")]
        public int? Ttl { get; set; }
    }
}
