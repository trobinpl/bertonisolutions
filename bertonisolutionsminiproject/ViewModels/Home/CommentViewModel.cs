using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bertonisolutionsminiproject.ViewModels.Home
{
    public class CommentViewModel
    {
        public CommentViewModel(string name, string email, string body)
        {
            Name = name;
            Email = email;
            Body = body;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
    }
}
