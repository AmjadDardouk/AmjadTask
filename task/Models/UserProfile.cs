using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace task.Models
{
    public class UserProfile
    { 
        public int Id { get; set; }

        public int UserId { get; set; }

        public Gender Gender {get; set;}

        public Marital Marital { get; set; }

        public DateTime DateOfBirth { get; set; }
        
        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public virtual User User { get; set; }
    }

    public enum Gender
    {
        Male,Female
    }
    public enum Marital
    {
        Unmarried , Married , Divorced , widow
    }
}
