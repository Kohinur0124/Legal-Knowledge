using LegalKnowledge.Application.UseCases.SubStance.Commands;
using LegalKnowledge.Application.UseCases.SubStance.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LegalKnowledge.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubstancesController : ControllerBase
{
	private readonly IMediator _mediator;

	public SubstancesController(IMediator mediator)
	{
		_mediator = mediator;
	}

	[HttpGet]
	public async ValueTask<IActionResult> GetAllSubstances()
	{
		var cards = await _mediator.Send(new GetSubStancesCommand());
		return Ok(cards);
	}



	[HttpPost]

	public async ValueTask<bool> AddSubstances(PostSubStancesCommand postCard)
	{
		var t = await _mediator.Send(postCard);
		return t;
	}
	[HttpPut]

	public async ValueTask<IActionResult> UpdateSubstance(PutSubStancesCommand postUser)
	{
		var t = await _mediator.Send(postUser);
		return Ok(t);
	}

	[HttpDelete]

	public async ValueTask<IActionResult> DeleteSubstance(DeleteSubStancesCommand postUser)
	{
		var t = await _mediator.Send(postUser);
		return Ok(t);
	}


}
