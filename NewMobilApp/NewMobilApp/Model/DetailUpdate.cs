using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace NewMobilApp.Model
{
    public class DetailUpdate
    {
        [JsonProperty("newDetails")]
        public string NewDetails { get; set; }
    }
}
