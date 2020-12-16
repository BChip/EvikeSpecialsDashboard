using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvikeSpecialSearch.Models
{
    public class Special
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("price")]
        public decimal Price { get; set; }
    }
}
