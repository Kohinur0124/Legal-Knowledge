using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.Document.Commands;
using LegalKnowledge.Domain.Entities;
using MediatR;

namespace LegalKnowledge.Application.UseCases.Document.Handlers
{
	public class PostDocumentCommandHandler :
		IRequestHandler<PostDocumentCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public PostDocumentCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PostDocumentCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = new Documents
				{
					Title = request.Title,
					YearOfPublication = request.YearOdPublication,
					IsActive = request.IsActive,

				};
				await _context.DBDocuments.AddAsync(res);
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
