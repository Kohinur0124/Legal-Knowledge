using LegalKnowledge.Domain.Entities;
using MediatR;

namespace LegalKnowledge.Application.UseCases.Chapter.Queries
{
	public class GetChaptersCommand : IRequest<List<Chapters>>
	{
	}
}
