using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.RestSharp.Models
{
    class PostedUser
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("job")]
        public string Job { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
       
    }
}
