using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.TestQuestion.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace LegalKnowledge.Application.UseCases.TestQuestion.Handlers
{
	public class DeleteTestQuestionsCommandHandler :
		IRequestHandler<DeleteTestQuestionsCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public DeleteTestQuestionsCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(DeleteTestQuestionsCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = await _context.DBTestQuestions.FirstOrDefaultAsync(x => x.Id == request.Id);

				if (res == null)
				{
					return false;
				}

				_context.DBTestQuestions.Remove(res);
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
