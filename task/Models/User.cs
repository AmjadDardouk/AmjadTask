using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace task.Models
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string FirstName { get; set; }

        [StringLength(150)]
        public string LastName { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        [StringLength(150)]
        public string Password { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public ICollection<Post> Posts { get; set; }

        public virtual UserProfile UserProfile { get; set; }


    }
}