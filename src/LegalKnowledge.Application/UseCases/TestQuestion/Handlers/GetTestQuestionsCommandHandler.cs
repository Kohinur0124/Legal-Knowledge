using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.TestQuestion.Queries;
using LegalKnowledge.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LegalKnowledge.Application.UseCases.TestQuestion.Handlers
{
	public class GetTestQuestionsCommandHandler :
		  IRequestHandler<GetTestQuestionsCommand, List<TestQuestions>>
	{
		private readonly IApplicationDbContext _context;

		public GetTestQuestionsCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<TestQuestions>> Handle(GetTestQuestionsCommand request, CancellationToken cancellationToken)
		{
			return await _context.DBTestQuestions.ToListAsync();

		}
	}
}
