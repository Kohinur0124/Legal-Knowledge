using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.SubStance.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LegalKnowledge.Application.UseCases.SubStance.Handlers
{
	public class PutSubStancesCommandHandler :
		 IRequestHandler<PutSubStancesCommand, bool>
	{

		private readonly IApplicationDbContext _context;

		public PutSubStancesCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PutSubStancesCommand request, CancellationToken cancellationToken)
		{
			try
			{

				var res = await _context.DBSubstances.
					FirstOrDefaultAsync(x => x.Id == request.Id);

				res.Title = request.Title;
				res.Number = request.Number;
				res.Description = request.Description;
				res.Part = request.Part;
				res.ChaptersId = request.ChaptersId;



				_context.DBSubstances.Update(res);

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
