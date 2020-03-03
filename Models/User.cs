using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrightIdeas.Models
{
    public class User
    {
        [Key] // denotes PK, not needed if named ModelNameId
        public int UserId { get; set; }

        [Required(ErrorMessage = "is required.")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "No numbers.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "is required.")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "No numbers.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "is required.")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Letters and numbers only.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Alias")]
        public string Alias { get; set; }

        [Required(ErrorMessage = "is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(8, ErrorMessage = "must be at least 8 characters")]
        [DataType(DataType.Password)] // auto fills input type attr
        public string Password { get; set; }

        [NotMapped] // don't add to DB
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "doesn't match password")]
        [Display(Name = "Confirm Password")]
        public string PasswordConfirm { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        // Navigation property for the relationship
        public List<BrightIdea> BrightIdea { get; set; } // 1 User : M posts relationship
        public List<Like> Likes { get; set; } // 1 User : M votes relationship


        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}