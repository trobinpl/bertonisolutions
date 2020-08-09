using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bertonisolutionsminiproject.HttpClients;
using bertonisolutionsminiproject.ViewModels.Home;

namespace bertonisolutionsminiproject.Controllers
{
    public class HomeController : Controller
    {
        private readonly JsonPlaceholderClient _jsonPlaceholderClient;

        public HomeController(JsonPlaceholderClient jsonPlaceholderClient)
        {
            _jsonPlaceholderClient = jsonPlaceholderClient;
        }

        public async Task<IActionResult> Index()
        {
            var albums = await _jsonPlaceholderClient.LoadAlbums();

            var viewModel = new HomeViewModel()
            {
                Albums = albums.Select(album => new HomeAlbumViewModel(album.Id, album.Title)).ToList(),
            };

            return View(viewModel);
        }

        public async Task<IActionResult> LoadAlbumDetails(int id)
        {
            var albumPhotos = await _jsonPlaceholderClient.LoadPhotosForAlbum(id);

            var viewModel = new AlbumPhotosViewModel()
            {
                AlbumId = id,
                Photos = albumPhotos.Select(photo => new AlbumPhotoViewModel(photo.Id, photo.Title, photo.Url, photo.ThumbnailUrl)).ToList(),
            };

            return PartialView("_AlbumPhotos", viewModel);
        }

        public async Task<IActionResult> LoadComments(int id)
        {
            var comments = await _jsonPlaceholderClient.LoadComments(id);

            var viewModel = new CommentsViewModel()
            {
                PhotoId = id,
                Comments = comments.Select(comment => new CommentViewModel(comment.Name, comment.Email, comment.Body)).ToList(),
            };

            return PartialView("_Comments", viewModel);
        }
    }
}
