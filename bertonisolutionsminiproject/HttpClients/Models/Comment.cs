using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace bertonisolutionsminiproject.HttpClients.Models
{
    public class Comment
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /* Posts don't belong to photos but for sake of this assignement 
         * I assume they do and to keep code more readable I rename postId returned from REST endpoint 
         * to AlbumId to keep it consistent 
         */
        [JsonPropertyName("postId")]
        public int PhotoId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("body")]
        public string Body { get; set; }
    }
}
