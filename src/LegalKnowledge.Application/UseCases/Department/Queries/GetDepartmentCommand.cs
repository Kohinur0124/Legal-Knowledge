using LegalKnowledge.Domain.Entities;
using MediatR;

namespace LegalKnowledge.Application.UseCases.Department.Queries
{
	public class GetDepartmentCommand : IRequest<List<Departments>>
	{
	}
}
