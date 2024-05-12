using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LegalKnowledge.Domain.Entities
{
	[Table("Chapters", Schema = "dbo")]
	public class Chapters
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("Id")]
		public int Id { get; set; }
		[Column("Number")]
		public int Number { get; set; }
		[Column("Title")]
		public string Title { get; set; }
		[Column("DepartmentId")]
		[ForeignKey("DepartmentId")]
		public int DepartmentsId { get; set; }

		public ICollection<Substances> Substances { get; set; }
		public Departments Departments { get; set; }
	}
}
