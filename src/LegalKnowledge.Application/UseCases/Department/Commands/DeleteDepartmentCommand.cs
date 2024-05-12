using MediatR;

namespace LegalKnowledge.Application.UseCases.Department.Commands
{
	public class DeleteDepartmentCommand : IRequest<bool>
	{
		public int Id { get; set; }
	}
}
