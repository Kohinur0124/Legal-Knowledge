using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.Document.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace LegalKnowledge.Application.UseCases.Document.Handlers
{
	public class DeleteDocumentCommandHandler :
		IRequestHandler<DeleteDocumentCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public DeleteDocumentCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(DeleteDocumentCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = await _context.DBDocuments.FirstOrDefaultAsync(x => x.Id == request.Id);

				if (res == null)
				{
					return false;
				}

				_context.DBDocuments.Remove(res);
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
