using LegalKnowledge.Domain.Entities;
using MediatR;

namespace LegalKnowledge.Application.UseCases.Document.Queries
{
	public class GetDocumentCommand : IRequest<List<Documents>>
	{
	}
}
