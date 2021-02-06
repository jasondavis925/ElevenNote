using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenCategories.Data
{
    //[Required]
    //[Range(1, 5, ErrorMessage = "please choose a number between 1 and 5")]
    //[MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string Title { get; set; }

        //[Required]
        //public string Content { get; set; }

        //[Required]
        //public DateTimeOffset CreatedUtc { get; set; }

        //public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
