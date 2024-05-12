using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.SubStance.Queries;
using LegalKnowledge.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LegalKnowledge.Application.UseCases.SubStance.Handlers
{
	public class GetSubStancesCommandHandler :
		  IRequestHandler<GetSubStancesCommand, List<Substances>>
	{
		private readonly IApplicationDbContext _context;

		public GetSubStancesCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<Substances>> Handle(GetSubStancesCommand request, CancellationToken cancellationToken)
		{
			return await _context.DBSubstances.ToListAsync();
		}
	}
}
