using Microsoft.EntityFrameworkCore;

using (var db = new BloggingContext())
{
    /*
    Console.WriteLine("Inserindo:");
    var umBlog = new Blog { Url = "http://blogs.msdn.com/adonet" };
    db.Blogs.Add(umBlog);
    db.SaveChanges();
    */

    /*
    Console.WriteLine("Consultando:");
    var blogs = db.Blogs.ToList();
    blogs.ForEach(b => Console.WriteLine($"{b.BlogId} - {b.Url}"));

    Console.WriteLine("Consultando:");
    var blog = db.Blogs.Find(2);
    Console.WriteLine($"{blog.BlogId} - {blog.Url}");

    Console.WriteLine("Alterando:");
    blog.Posts.Add(new Post { Title = "Novo Post", Content = "Novo conteúdo" });
    db.SaveChanges();
    */

    /*
    Console.WriteLine("Consultando Eager:");
    var blogs = db.Blogs.Include(b => b.Posts).OrderByDescending(b => b.BlogId).ToList();
    blogs.ForEach(b => {
        Console.WriteLine($"{b.BlogId} - {b.Url}");
        b.Posts.ForEach(p => Console.WriteLine($"\t{p.PostId} - {p.Title}"));
    });
    */
    /*
    Console.WriteLine("Consultando Explicit:");
    var blogs = db.Blogs.OrderByDescending(b => b.BlogId).ToList();
    blogs.ForEach(b =>
    {
        Console.WriteLine($"{b.BlogId} - {b.Url}");
        db.Entry(b).Collection(b => b.Posts).Load();
        b.Posts.ForEach(p => Console.WriteLine($"\t{p.PostId} - {p.Title}"));
    });
    */

    Console.WriteLine("Removendo:");
    var blog = db.Blogs.Find(1);
    if (blog != null)
    {
        db.Blogs.Remove(blog);
        db.SaveChanges();
    }

    Console.WriteLine("Consultando:");
    var blogs = db.Blogs.ToList();
    blogs.ForEach(b => Console.WriteLine($"{b.BlogId} - {b.Url}"));
}