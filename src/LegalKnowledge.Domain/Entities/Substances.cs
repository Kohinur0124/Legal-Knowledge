using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LegalKnowledge.Domain.Entities
{
	[Table("Substances", Schema = "dbo")]
	public class Substances
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("Id")]
		public int Id { get; set; }
		[Column("Number")]
		public int Number { get; set; }
		[Column("Part")]
		public int Part { get; set; }
		[Column("Title")]
		public string Title { get; set; }
		[Column("Description")]
		public string Description { get; set; }
		[Column("ChaptersId")]
		[ForeignKey("ChaptersId")]
		public int ChaptersId { get; set; }

		public Chapters Chapters { get; set; }
		public ICollection<TestQuestions> TestQuestions { get; set; }
	}
}
