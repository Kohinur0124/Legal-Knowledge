using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.Chapter.Commands;
using LegalKnowledge.Domain.Entities;
using MediatR;

namespace LegalKnowledge.Application.UseCases.Chapter.Handlers
{
	public class PostChaptersCommandHandler :
		IRequestHandler<PostChaptersCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public PostChaptersCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PostChaptersCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = new Chapters
				{
					Title = request.Title,
					Number = request.Number,
					DepartmentsId = request.DepartmentsId,
				};
				await _context.DBChapters.AddAsync(res);
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
