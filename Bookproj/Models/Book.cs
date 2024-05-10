using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookproj.Models
{
    [Table("Books")]
    public class Book
	{
		[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int Id { get; set; }

		[Required]
		[Display(Name ="Title")]
		public string Title { get; set; } = string.Empty;

		[Required]
		[DataType(DataType.Text)]
		[Display(Name ="Description")]
		public string Description { get; set; }

		[Required]
		[Display(Name = "Quantity")]

		public int Quantity { get; set; } = 0;

		[Required]

        public int GenreId { get; set; }

		[ForeignKey("GenreId")]
        public Genre Genre { get; set; }

		[Required]
		public int AuthorId { get; set; }

		[ForeignKey("AuthorId")]
		public Author Author { get; set; }


	}

}
