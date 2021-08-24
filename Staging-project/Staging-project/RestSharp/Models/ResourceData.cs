using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.RestSharp.Models
{
    class ResourceData
    {
        [JsonProperty("data")]
        public Resource Data { get; set; }
    }
}
