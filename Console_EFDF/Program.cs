using (var context = new Console_EFDF.Models.EF_DFContext()) {
    foreach (var post in context.Posts.ToList()) {
        Console.WriteLine(post.Title);
    }
}