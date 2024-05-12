using MediatR;

namespace LegalKnowledge.Application.UseCases.SubStance.Commands
{
	public class DeleteSubStancesCommand : IRequest<bool>
	{
		public int Id { get; set; }
	}
}
