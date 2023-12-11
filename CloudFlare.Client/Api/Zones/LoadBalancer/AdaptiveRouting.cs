﻿using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.LoadBalancer
{
    /// <summary>
    /// Controls features that modify the routing of requests to pools and origins in response to dynamic conditions, such as during the interval between active health monitoring requests.
    /// For example, zero-downtime failover occurs immediately when an origin becomes unavailable due to HTTP 521, 522, or 523 response codes.
    /// If there is another healthy origin in the same pool, the request is retried once against this alternate origin.
    /// </summary>
    public class AdaptiveRouting
    {
        /// <summary>
        /// Extends zero-downtime failover of requests to healthy origins from alternate pools, when no healthy alternate exists in the same pool, according to the failover order defined by traffic and origin steering.
        /// When set false (the default) zero-downtime failover will only occur between origins within the same pool.
        /// See session_affinity_attributes for control over when sessions are broken or reassigned.
        /// </summary>
        [JsonProperty("failover_across_pools")]
        public bool FailoverAcrossPools { get; set; }
    }
}
