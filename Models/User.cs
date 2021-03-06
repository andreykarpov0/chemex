using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace chemex.Models{ 

    [Index("Login", IsUnique = true, Name = "idxLogin")]
    [Index("Email", IsUnique = true, Name = "idxEmail")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string Email { get; set; }

        [Required]
        [MaxLength(60)]
        public string Login { get; set; }
        
        [Required]
        [MaxLength(40)]
        public string Password { get; set; }

        public List<Project> Projects { get; set; } = new();
    }
}