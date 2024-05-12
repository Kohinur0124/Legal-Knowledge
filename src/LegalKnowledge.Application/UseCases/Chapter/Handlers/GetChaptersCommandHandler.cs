using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.Chapter.Queries;
using LegalKnowledge.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LegalKnowledge.Application.UseCases.Chapter.Handlers
{
	public class GetChaptersCommandHandler :
		  IRequestHandler<GetChaptersCommand, List<Chapters>>
	{
		private readonly IApplicationDbContext _context;

		public GetChaptersCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<Chapters>> Handle(GetChaptersCommand request, CancellationToken cancellationToken)
		{
			return await _context.DBChapters.ToListAsync();
		}
	}
}
