using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace NewMobilApp.Model
{
    public partial class Ski
    {
        [JsonProperty("Resort")]
        public string resort { get; set; }

        [JsonProperty("Hotel")]
        public string hotel { get; set; }

        [JsonProperty("Dates")]
        public string dates { get; set; }
        [JsonProperty("Rooms")]
        public string rooms { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
    public partial class Ski
    {
        public static Ski[] FromJson(string json) => JsonConvert.DeserializeObject<Ski[]>(json, Converter.Settings);
    }
  
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore, 
            DateParseHandling = DateParseHandling.None, 
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}



