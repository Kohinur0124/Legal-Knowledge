using MediatR;

namespace LegalKnowledge.Application.UseCases.TestQuestion.Commands
{
	public class PostTestQuestionsCommand : IRequest<bool>
	{
		public string Events { get; set; }

		public string Punishment { get; set; }

		public int SubstancesId { get; set; }


	}
}
