﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bertonisolutionsminiproject.ViewModels.Home
{
    public class AlbumPhotosViewModel
    {
        public int AlbumId { get; set; }
        public List<AlbumPhotoViewModel> Photos { get; set; }
    }
}
