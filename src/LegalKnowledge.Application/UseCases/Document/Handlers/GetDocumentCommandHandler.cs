using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.Document.Queries;
using LegalKnowledge.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LegalKnowledge.Application.UseCases.Document.Handlers
{
	public class GetDocumentCommandHandler :
		  IRequestHandler<GetDocumentCommand, List<Documents>>
	{
		private readonly IApplicationDbContext _context;

		public GetDocumentCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<Documents>> Handle(GetDocumentCommand request, CancellationToken cancellationToken)
		{
			return await _context.DBDocuments.ToListAsync();
		}
	}
}
