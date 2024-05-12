using LegalKnowledge.Domain.Entities;
using MediatR;

namespace LegalKnowledge.Application.UseCases.SubStance.Queries
{
	public class GetSubStancesCommand : IRequest<List<Substances>>
	{
	}
}
