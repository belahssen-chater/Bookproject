using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Bookproj.Models
{
	[Table("Comments")]
	public class Comment
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int Id { get; set; }

		

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Description")]
        public string? Content { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Display(Name ="Rate")]
		public int Rate { get; set; }

        [Required]
        public int BookId { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }
	}

}
