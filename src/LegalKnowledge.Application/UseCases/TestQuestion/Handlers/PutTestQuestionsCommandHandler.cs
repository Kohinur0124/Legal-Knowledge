using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.TestQuestion.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LegalKnowledge.Application.UseCases.TestQuestion.Handlers
{
	public class PutTestQuestionsCommandHandler :
		 IRequestHandler<PutTestQuestionsCommand, bool>
	{

		private readonly IApplicationDbContext _context;

		public PutTestQuestionsCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PutTestQuestionsCommand request, CancellationToken cancellationToken)
		{
			try
			{

				var res = await _context.DBTestQuestions.
					FirstOrDefaultAsync(x => x.Id == request.Id);

				res.Events = request.Events;
				res.Punishment = request.Punishment;
				res.SubstancesId = request.SubstancesId;


				_context.DBTestQuestions.Update(res);

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
