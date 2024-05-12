using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.TestQuestion.Commands;
using LegalKnowledge.Domain.Entities;
using MediatR;

namespace LegalKnowledge.Application.UseCases.TestQuestion.Handlers
{
	public class PostTestQuestionsCommandHandler :
		IRequestHandler<PostTestQuestionsCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public PostTestQuestionsCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PostTestQuestionsCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = new TestQuestions
				{
					Events = request.Events,
					Punishment = request.Punishment,
					SubstancesId = request.SubstancesId,


				};
				await _context.DBTestQuestions.AddAsync(res);
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
