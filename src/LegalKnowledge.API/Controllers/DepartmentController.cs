using LegalKnowledge.Application.UseCases.Department.Commands;
using LegalKnowledge.Application.UseCases.Department.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LegalKnowledge.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentController : ControllerBase
{
	private readonly IMediator _mediator;

	public DepartmentController(IMediator mediator)
	{
		_mediator = mediator;
	}

	[HttpGet]
	public async ValueTask<IActionResult> GetAllDepartments()
	{
		var cards = await _mediator.Send(new GetDepartmentCommand());
		return Ok(cards);
	}



	[HttpPost]

	public async ValueTask<bool> AddDepartments(PostDepartmentCommand postCard)
	{
		var t = await _mediator.Send(postCard);
		return t;
	}
	[HttpPut]

	public async ValueTask<IActionResult> UpdateDepartment(PutDepartmentCommand postUser)
	{
		var t = await _mediator.Send(postUser);
		return Ok(t);
	}

	[HttpDelete]

	public async ValueTask<IActionResult> DeleteDepartment(DeleteDepartmentCommand postUser)
	{
		var t = await _mediator.Send(postUser);
		return Ok(t);
	}


}
