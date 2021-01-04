using System;
using System.ComponentModel.DataAnnotations;

namespace task.Models
{
    public class Post
    {
        public int Id { get; set; }

        [StringLength(500)]
        public string PostContent { get; set; }

        public int UserId { get; set; }
        
        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}
