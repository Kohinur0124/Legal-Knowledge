using MediatR;

namespace LegalKnowledge.Application.UseCases.AppUser.Commands
{
	public class DeleteUserCommand : IRequest<bool>
	{
		public int Id { get; set; }
	}
}
