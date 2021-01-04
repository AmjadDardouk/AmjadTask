using System;
using task.Models;

namespace task
{
    public class Create
    {
        public static DbContext _context = new DbContext();
        DateTime currentDate = DateTime.Now;

        public Create()
        {
        }

        public Create(string first_name, string last_name, string email, string password)
        {
            CreateNewUser(first_name, last_name, email, password);
        }
        public void CreateNewUser(string first_name, string last_name, string email, string password)
        {
            User new_user = new User { Email = email, FirstName = first_name, LastName = last_name, Password = password ,Created = currentDate,Updated = currentDate};
            _context.Users.Add(new_user);
        }


    }
}
