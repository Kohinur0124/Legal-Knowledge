using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LegalKnowledge.Domain.Entities
{
	[Table("Departments", Schema = "dbo")]
	public class Departments
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("Id")]
		public int Id { get; set; }
		[Column("DepartmentNumber")]
		public int DepartmentNumber { get; set; }
		[Column("Title")]
		public string Title { get; set; }
		[Column("DocumentsId")]
		[ForeignKey("DocumentsId")]
		public int DocumentsId { get; set; }

		public ICollection<Chapters> Chapters { get; set; }
		public Documents Documents { get; set; }
	}
}
