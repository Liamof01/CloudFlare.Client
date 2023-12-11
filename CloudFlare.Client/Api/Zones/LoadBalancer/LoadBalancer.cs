using System;
using CloudFlare.Client.Enumerators;
using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.LoadBalancer
{
    /// <summary>
    /// Load balancer
    /// </summary>
    public class LoadBalancer
    {
        /// <summary>
        /// Controls features that modify the routing of requests to pools and origins in response to dynamic conditions, such as during the interval between active health monitoring requests.
        /// </summary>
        [JsonProperty("adaptive_routing")]
        public AdaptiveRouting AdaptiveRouting { get; set; }

        // country_pools ...

        /// <summary>
        /// The date and time the load balancer was created.
        /// </summary>
        [JsonProperty("created_on")]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// A list of pool IDs ordered by their failover priority.
        /// Pools defined here are used by default, or when region_pools are not configured for a given region.
        /// </summary>
        [JsonProperty("default_pools")]
        public string[] DefaultPools { get; set; }

        /// <summary>
        /// Object description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Whether to enable (the default) this load balancer.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The pool ID to use when all other pools are detected as unhealthy.
        /// </summary>
        [JsonProperty("fallback_pool")]
        public string FallbackPool { get; set; }

        /// <summary>
        /// Load balancer identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Controls location-based steering for non-proxied requests.
        /// See steering_policy to learn how steering is affected.
        /// </summary>
        [JsonProperty("location_strategy")]
        public LocationStrategy LocationStrategy { get; set; }

        /// <summary>
        /// The date and time the load balancer was modified.
        /// </summary>
        [JsonProperty("modified_on")]
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// Name of the load balancer.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        // pop_pools ...

        /// <summary>
        /// Whether the hostname should be gray clouded (false) or orange clouded (true).
        /// </summary>
        [JsonProperty("proxied")]
        public bool Proxied { get; set; }

        // random_steering ...
        // region_pools ...
        // rules ...

        /// <summary>
        /// Specifies the type of session affinity the load balancer should use unless specified as "none" or "" (default).
        /// </summary>
        [JsonProperty("session_affinity")]
        public SessionAffinity SessionAffinity { get; set; }

        // session_affinity_attributes ...

        /// <summary>
        /// Time, in seconds, until a client's session expires after being created. Once the expiry time has been reached, subsequent requests may get sent to a different origin server.
        /// </summary>
        [JsonProperty("session_affinity_ttl")]
        public int? SessionAffinityTtl { get; set; }

        /// <summary>
        /// Steering Policy for this load balancer.
        /// </summary>
        [JsonProperty("steering_policy")]
        public SteeringPolicy SteeringPolicy { get; set; }

        /// <summary>
        /// Time to live (TTL) of the DNS entry for the IP address returned by this load balancer.
        /// This only applies to gray-clouded (unproxied) load balancers.
        /// </summary>
        [JsonProperty("ttl")]
        public int? Ttl { get; set; }
    }
}
