using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace chemex.Models
{
    [Index("Name", IsUnique = false,Name = "prjName")]
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        
        [Required]
        public DateTime CreationTime { get; set; }

        [Required]
        public DateTime LastModifiedTime { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public User? User { get; set; }

    }
}
