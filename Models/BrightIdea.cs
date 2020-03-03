using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrightIdeas.Models
{
    public class BrightIdea
    {
        [Key] // Primary Key
        public int BrightIdeaId { get; set; }

        // Foreign Key 
        public int UserId { get; set; }
        
        // Navigation property for the relationship
        public User Author {get; set; } // 1 user related to each Post
        public List<Like> Likes { get; set; } // 1 Post : M votes relationship

        [Required]
        [MinLength(5, ErrorMessage = "Must be more than 5 characters.")]
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}