using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bertonisolutionsminiproject.ViewModels.Home
{
    public class AlbumPhotoViewModel
    {
        public AlbumPhotoViewModel(int id, string title, string url, string thumbnailUrl)
        {
            Id = id;
            Title = title;
            Url = url;
            ThumbnailUrl = thumbnailUrl;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}
