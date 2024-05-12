using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.SubStance.Commands;
using LegalKnowledge.Domain.Entities;
using MediatR;

namespace LegalKnowledge.Application.UseCases.SubStance.Handlers
{
	public class PostSubStancesCommandHandler :
		IRequestHandler<PostSubStancesCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public PostSubStancesCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PostSubStancesCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = new Substances
				{
					Number = request.Number,
					Title = request.Title,
					Part = request.Part,
					ChaptersId = request.ChaptersId,
					Description = request.Description,


				};
				await _context.DBSubstances.AddAsync(res);
				await _context.SaveChangesAsync(cancellationToken);
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
