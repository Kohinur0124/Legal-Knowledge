using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.Chapter.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LegalKnowledge.Application.UseCases.Chapter.Handlers
{
	public class PutChaptersCommandHandler :
		 IRequestHandler<PutChaptersCommand, bool>
	{

		private readonly IApplicationDbContext _context;

		public PutChaptersCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PutChaptersCommand request, CancellationToken cancellationToken)
		{
			try
			{

				var res = await _context.DBChapters.
					FirstOrDefaultAsync(x => x.Id == request.Id);

				res.Number = request.Number;
				res.Title = request.Title;
				res.DepartmentsId = request.DepartmentsId;

				_context.DBChapters.Update(res);

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
