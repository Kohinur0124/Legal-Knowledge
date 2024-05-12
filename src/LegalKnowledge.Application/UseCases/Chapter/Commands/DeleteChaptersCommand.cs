using MediatR;

namespace LegalKnowledge.Application.UseCases.Chapter.Commands
{
	public class DeleteChaptersCommand : IRequest<bool>
	{
		public int Id { get; set; }
	}
}
