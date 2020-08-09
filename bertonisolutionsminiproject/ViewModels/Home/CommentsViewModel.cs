using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bertonisolutionsminiproject.ViewModels.Home
{
    public class CommentsViewModel
    {
        public int PhotoId { get; set; }
        public List<CommentViewModel> Comments { get; set; }
    }
}
