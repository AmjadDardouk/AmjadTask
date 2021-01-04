using System;
using System.Linq;
using task.Models;

namespace task
{
    public class Login
    {
        public void Userlogin(string email,string password)
        {
            if (Program._context.Users.Any(user =>user.Email == email))
            {
                Program._context.Users.Any(user => user.Password == password);
                Program.isLogin = true;
                string id = (from user in Program._context.Users
                                  where user.Email == email
                                  select user.Id).ToString();
                Program.userId = int.Parse(id);

            }
            else Program.isLogin = false;
            
        }
    }
}
