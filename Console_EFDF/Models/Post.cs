using System;
using System.Collections.Generic;

namespace Console_EFDF.Models
{
    public partial class Post
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
    }
}
