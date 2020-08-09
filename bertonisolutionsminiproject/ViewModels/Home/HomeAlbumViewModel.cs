using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bertonisolutionsminiproject.ViewModels.Home
{
    public class HomeAlbumViewModel
    {
        public HomeAlbumViewModel(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public int Id { get; set; }
        public string Title { get; set; }
    }
}
