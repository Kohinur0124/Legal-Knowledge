using MediatR;

namespace LegalKnowledge.Application.UseCases.TestQuestion.Commands
{
	public class DeleteTestQuestionsCommand : IRequest<bool>
	{
		public int Id { get; set; }
	}
}
