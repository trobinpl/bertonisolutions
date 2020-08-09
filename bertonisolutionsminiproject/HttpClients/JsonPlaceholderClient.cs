using bertonisolutionsminiproject.HttpClients.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace bertonisolutionsminiproject.HttpClients
{
    public class JsonPlaceholderClient
    {
        private readonly HttpClient _client;
        private readonly ILogger<JsonPlaceholderClient> _logger;

        public JsonPlaceholderClient(ILogger<JsonPlaceholderClient> logger, HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
            _logger = logger;
        }


        public async Task<IEnumerable<Album>> LoadAlbums()
        {
            try
            {
                var responseString = await _client.GetStringAsync("albums");
                return JsonSerializer.Deserialize<List<Album>>(responseString);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Something went wrong while fetching albums");
                return new List<Album>();
            }
        }

        public async Task<IEnumerable<Photo>> LoadPhotosForAlbum(int albumId)
        {
            try
            {
                var responseString = await _client.GetStringAsync($"albums/{albumId}/photos");
                return JsonSerializer.Deserialize<List<Photo>>(responseString);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Something went wrong while fetching photos for album: @AlbumId", new { AlbumId = albumId });
                return new List<Photo>();
            }
        }

        public async Task<IEnumerable<Comment>> LoadComments(int photoId)
        {
            var builder = new UriBuilder(new Uri(_client.BaseAddress, "comments"));
            builder.Query = $"postId={photoId}";

            try
            {
                var responseString = await _client.GetStringAsync(builder.Uri);
                return JsonSerializer.Deserialize<List<Comment>>(responseString);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Something went wrong while fetching comments for photo: @PhotoId", new { PhotoId = photoId });
                return new List<Comment>();
            }
        }
    }
}
