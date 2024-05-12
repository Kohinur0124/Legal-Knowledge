using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LegalKnowledge.Domain.Entities
{
	[Table("Documents", Schema = "dbo")]
	public class Documents
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("Id")]
		public int Id { get; set; }
		[Column("Title")]
		public string Title { get; set; }
		[Column("YearOfPublication")]
		public int YearOfPublication { get; set; }
		[Column("IsActive")]
		public bool IsActive { get; set; }

		public ICollection<Departments> Departments { get; set; }
	}
}
