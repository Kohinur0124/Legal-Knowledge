using LegalKnowledge.Domain.Entities;
using MediatR;

namespace LegalKnowledge.Application.UseCases.TestQuestion.Queries
{
	public class GetTestQuestionsCommand : IRequest<List<TestQuestions>>
	{
	}
}
