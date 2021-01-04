using System;
using System.Linq;
using task.Models;

namespace task
{
    

    public class Posts
    {
        DateTime currentDate = DateTime.Now;
        public int CreatePost(string post)
        {
            if (Program.userId == 0)
                return 401;
            Program._context.Posts.Add(new Models.Post {UserId=Program.userId, PostContent = post,Created= currentDate,Updated= currentDate });
            return 200;
        }
        public int UpdatePost(int id,string newPost)
        {
            if (Program.userId == 0)
                return 401;
            if (!Program._context.Posts.Any(post => post.Id == id && post => post.UserId == Program.userId))
                return 403;

            Post post = Program._context.Posts.Where(post => post.Id == id).First();
            post.PostContent = newPost;
            post.Created = currentDate;
            post.Updated = currentDate;
            Program._context.SaveChanges();
            return 200;
        }
        public int DeletePost(int id)
        {
            if (Program.userId == 0)
                return 401;
            if (!Program._context.Posts.Any(post => post.Id == id && post => post.UserId == Program.userId))
                return 403;

            Post post = Program._context.Posts.Where(post => post.Id == id).First();
            Program._context.Posts.Remove(post);
            return 200;
        }

    }
}
