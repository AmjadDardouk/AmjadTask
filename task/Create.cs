using System;
using task.Models;

namespace task
{
    public class Create
    {
        public static DbContext _context = new DbContext();

        public Create()
        {
        }

        public Create(string first_name, string last_name, string email, string password)
        {
            User new_user = new User { Email = email, FirstName = first_name, LastName = last_name, Password = password };
            _context.Users.Add(new_user);
        }
        public void CreateNewUser(string first_name, string last_name, string email, string password)
        {
            User new_user = new User { Email = email, FirstName = first_name, LastName = last_name, Password = password };
            _context.Users.Add(new_user);
        }


    }
}
