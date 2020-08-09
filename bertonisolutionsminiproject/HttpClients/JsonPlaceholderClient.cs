using bertonisolutionsminiproject.HttpClients.Models;
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

        public JsonPlaceholderClient(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
        }

        public async Task<IEnumerable<Album>> LoadAlbums()
        {
            var responseString = await _client.GetStringAsync("albums");

            return JsonSerializer.Deserialize<List<Album>>(responseString);
        }

        public async Task<IEnumerable<Photo>> LoadPhotosForAlbum(int albumId)
        {
            var responseString = await _client.GetStringAsync($"albums/{albumId}/photos");

            return JsonSerializer.Deserialize<List<Photo>>(responseString);
        }

        public async Task<IEnumerable<Comment>> LoadComments(int photoId)
        {
            var builder = new UriBuilder(new Uri(_client.BaseAddress, "comments"));
            builder.Query = $"postId={photoId}";

            var responseString = await _client.GetStringAsync(builder.Uri);

            return JsonSerializer.Deserialize<List<Comment>>(responseString);
        }
    }
}
