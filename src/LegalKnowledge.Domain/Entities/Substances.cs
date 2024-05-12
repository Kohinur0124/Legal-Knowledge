namespace LegalKnowledge.Domain.Entities
{
	public class Substances
	{
		public int Id { get; set; }
		public int Number { get; set; }
		public int Part { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }

		public int ChaptersId { get; set; }

		public Chapters Chapters { get; set; }
		public ICollection<TestQuestions> TestQuestions { get; set; }
	}
}
