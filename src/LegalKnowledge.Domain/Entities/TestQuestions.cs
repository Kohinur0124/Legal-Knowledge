using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LegalKnowledge.Domain.Entities
{
	[Table("TestQuestions", Schema = "dbo")]
	public class TestQuestions
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("Id")]
		public int Id { get; set; }
		[Column("Events")]
		public string Events { get; set; }
		[Column("Punishment")]
		public string Punishment { get; set; }
		[Column("SubstancesId")]
		[ForeignKey("SubstancesId")]
		public int SubstancesId { get; set; }
		public Substances Substances { get; set; }
	}
}
