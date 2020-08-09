﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace bertonisolutionsminiproject.HttpClients.Models
{
    public class Photo
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("albumId")]
        public int AlbumId { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    }
}
