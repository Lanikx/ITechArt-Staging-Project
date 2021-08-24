using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.Models
{
    class Users
    {
        
        public int page { get; set; }

        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }

        [JsonProperty("data")]
        List<User> data { get; set; }
    }
}
