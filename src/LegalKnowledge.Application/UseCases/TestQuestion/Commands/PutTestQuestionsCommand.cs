using MediatR;

namespace LegalKnowledge.Application.UseCases.TestQuestion.Commands
{
	public class PutTestQuestionsCommand : IRequest<bool>
	{
		public int Id { get; set; }

		public string Events { get; set; }

		public string Punishment { get; set; }

		public int SubstancesId { get; set; }


	}
}
