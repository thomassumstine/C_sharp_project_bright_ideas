using System;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models
{
    public class Like
    {
        [Key] // denotes PK, not needed if named ModelNameId
        public int LikeId { get; set; } // PK
        // FK
        public int BrightIdeaId { get; set; }
        // FK
        public int UserId { get; set; }
        public bool IsLike { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdateAt { get; set; } = DateTime.Now;
        /* 
            Navigation properties
            Not stored in DB, just used
            by Entity Framework to be able
            to use .include to get the full
            info from related classes
        */
        public User Liker { get; set; }
        public BrightIdea BrightIdea { get; set; }
    }
}