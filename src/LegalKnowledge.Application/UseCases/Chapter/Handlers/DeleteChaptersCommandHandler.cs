using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.Chapter.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace LegalKnowledge.Application.UseCases.Chapter.Handlers
{
	public class DeleteChaptersCommandHandler :
		IRequestHandler<DeleteChaptersCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public DeleteChaptersCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(DeleteChaptersCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = await _context.DBChapters.FirstOrDefaultAsync(x => x.Id == request.Id);

				if (res == null)
				{
					return false;
				}

				_context.DBChapters.Remove(res);
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
