using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.SubStance.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace LegalKnowledge.Application.UseCases.SubStance.Handlers
{
	public class DeleteSubStancesCommandHandler :
		IRequestHandler<DeleteSubStancesCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public DeleteSubStancesCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(DeleteSubStancesCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = await _context.DBSubstances.FirstOrDefaultAsync(x => x.Id == request.Id);

				if (res == null)
				{
					return false;
				}

				_context.DBSubstances.Remove(res);
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
