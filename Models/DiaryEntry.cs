using System;
using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        [Key] // Optional if using conventions.
        public int Id { get; set; }

        [Required(ErrorMessage ="Please provide a title")]
        [StringLength(200, ErrorMessage = "Title cannot exceed 200 characters.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage="Please provide content for your entry")]
        public string Content { get; set; } = string.Empty;

        [Required(ErrorMessage ="Please enter the date of the event")]
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}

// using System.ComponentModel.DataAnnotations;

// namespace DiaryApp.Models
// {
//     public class DiaryEntry
//     {
//         [Key]
//         public int Id { get; set; }
//         [Required]
//         public string Title { get; set; } = string.Empty;
//         [Required]

//         public string Content { get; set; } = string.Empty;
//         [Required]

//         public DateTime DateCreated { get; set; } = DateTime.Now;
//     }
// }