namespace LegalKnowledge.Domain.Entities
{
	public class TestQuestions
	{
		public int Id { get; set; }
		public string Events { get; set; }
		public string Punishment { get; set; }

		public int SubstancesId { get; set; }
		public Substances Substances { get; set; }
	}
}
