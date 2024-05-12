namespace LegalKnowledge.Domain.Entities
{
	public class Documents
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public int YearOdPublication { get; set; }
		public bool IsActive { get; set; }

		public ICollection<Departments> Departments { get; set; }
	}
}
