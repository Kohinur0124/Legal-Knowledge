using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.Document.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LegalKnowledge.Application.UseCases.Document.Handlers
{
	public class PutDocumentCommandHandler :
		 IRequestHandler<PutDocumentCommand, bool>
	{

		private readonly IApplicationDbContext _context;

		public PutDocumentCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PutDocumentCommand request, CancellationToken cancellationToken)
		{
			try
			{

				var res = await _context.DBDocuments.
					FirstOrDefaultAsync(x => x.Id == request.Id);

				res.Title = request.Title;
				res.YearOfPublication = request.YearOdPublication;
				res.IsActive = res.IsActive;


				_context.DBDocuments.Update(res);

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
