using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace bertonisolutionsminiproject.HttpClients.Models
{
    public class Album
    {
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
