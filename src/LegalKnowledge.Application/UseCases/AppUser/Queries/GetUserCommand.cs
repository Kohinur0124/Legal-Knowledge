using LegalKnowledge.Domain.Entities;
using MediatR;

namespace LegalKnowledge.Application.UseCases.AppUser.Queries
{
	public class GetUserCommand : IRequest<List<User>>
	{
	}
}
