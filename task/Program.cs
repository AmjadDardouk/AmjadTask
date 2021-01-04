using System;
using Npgsql;
using System.Data;


namespace task
{

    class Program
    {
        public static bool isLogin;
        public static int userId =0;
        public static int postId;
        public static DbContext _context = new DbContext();

        static void Main(string[] args)
        {
            string firstName, lastName, email, password, posts;
            int Id;
            int x = 0;
            Posts post = new Posts();
            Console.WriteLine("Press (1) for Create New User" + Environment.NewLine +
               "Press (2) for Login" + Environment.NewLine +
               "Press (3) for Create New Post" + Environment.NewLine +
               "Press (4) for Edit existing posts by enter the post id" + Environment.NewLine +
               "Press (5) for Delete existing posts by enter the post id" + Environment.NewLine +
               "Press (0) for Exit" + Environment.NewLine);

            while (true)
            {
                x = Convert.ToInt32(Console.ReadLine());

                if (x == 1)
                {
                    Console.WriteLine("Create New User." + Environment.NewLine);
                    Create create = new Create();
                    Console.WriteLine("enter the firs name : ");
                    firstName=Console.ReadLine();
                    Console.WriteLine("enter the last name : ");
                    lastName = Console.ReadLine();
                    Console.WriteLine("enter the email : ");
                    email = Console.ReadLine();
                    Console.WriteLine("enter the password : ");
                    password = Console.ReadLine();
                    create.CreateNewUser(firstName, lastName, email, password);

                }
                if (x == 2)
                {
                    Console.WriteLine("Login." + Environment.NewLine);
                    Login login = new Login();
                    Console.WriteLine("enter the email : ");
                    email = Console.ReadLine();
                    Console.WriteLine("enter the password : ");
                    password = Console.ReadLine();

                    login.Userlogin(email, password);
                }
                if (x == 3)
                {
                    Console.WriteLine("Create New Post." + Environment.NewLine);
                    Console.WriteLine("enter the posts : ");
                    posts = Console.ReadLine();
                    int statusCode = post.CreatePost(posts);
                    Console.WriteLine("statusCode: " + statusCode);
                }
                if (x == 4)
                {
                    Console.WriteLine("Edit existing posts by enter the post id." + Environment.NewLine);
                    Console.WriteLine("enter the Id and the new post : ");
                    Id = Convert.ToInt32(Console.ReadLine());
                    posts = Console.ReadLine();
                    int statusCode = post.UpdatePost(Id,posts);
                    Console.WriteLine("statusCode: " + statusCode);
                }
                if (x == 5)
                {
                    Console.WriteLine("Delete existing posts by enter the post id." + Environment.NewLine);
                    Console.WriteLine("enter the Id and the new post : ");
                    Id = Convert.ToInt32(Console.ReadLine());
                    posts = Console.ReadLine();
                    int statusCode = post.UpdatePost(Id, posts);
                    Console.WriteLine("statusCode: " + statusCode);

                }
                if (x == 0)
                {
                    Console.WriteLine("Exit");
                    break;
                }



            }
        }
    }
}
