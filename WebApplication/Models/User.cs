using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "username cannot be empty")]
        [Display(Name = "username")]
        [StringLength(20, MinimumLength = 2)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "password cannot be empty")]
        [Display(Name = "password")]
        [StringLength(20, MinimumLength = 2)]
        public string UserPwd { get; set; }

    }


    public class UserContext : DbContext
    {
  
        public DbSet<User> user { get; set; }
    }
}