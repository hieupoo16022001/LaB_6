using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SotaroWebsite.Models
{
    public class product
    {
        internal string Id;

        public string ID { set; get; }
       
        public string Maker { get; set; }
        
        [JsonPropertyName("img")]
        public string Image { get; set; }
        
        
        public string Url { get; set; }

        public string Title { get; set; }

        public string Desrciption { get; set; }

        public int[] Ratings { get; set; }

        public override string ToString() => JsonSerializer.Serialize<product>(this);
        
    }
}
