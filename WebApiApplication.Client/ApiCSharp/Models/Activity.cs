// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace WebApplicationApiClient.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// </summary>
    public partial class Activity
    {
        /// <summary>
        /// Initializes a new instance of the Activity class.
        /// </summary>
        public Activity() { }

        /// <summary>
        /// Initializes a new instance of the Activity class.
        /// </summary>
        public Activity(int? id = default(int?), string name = default(string), string description = default(string), int? distance = default(int?), bool? isCommute = default(bool?))
        {
            Id = id;
            Name = name;
            Description = description;
            Distance = distance;
            IsCommute = isCommute;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Distance")]
        public int? Distance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCommute")]
        public bool? IsCommute { get; set; }

    }
}