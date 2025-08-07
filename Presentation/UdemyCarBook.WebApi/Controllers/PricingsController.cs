﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.PricingCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.PricingQueries;

namespace UdemyCarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PricingsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public PricingsController(IMediator mediator)
		{
			_mediator = mediator;
		}
		[HttpGet]
		public async Task<IActionResult> PricingList()
		{
			var values = await _mediator.Send(new GetPricingQuery());
			return Ok(values);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetPricing(int id)
		{
			var value = await _mediator.Send(new GetPricingByIdQuery(id));
			return Ok(value);
		}
		[HttpPost]
		public async Task<IActionResult> CreatePricing(CreatePricingCommand command)
		{
			await _mediator.Send(command);
			return Ok("Ödeme Türü Başarıyla Eklendi.");
		}
		[HttpDelete]
		public async Task<IActionResult> RemovePricing(RemovePricingCommand command)
		{
			await _mediator.Send(command);
			return Ok("Ödeme Türü Başarıyla Silindi.");
		}
		[HttpPut]
		public async Task<IActionResult> UpdatePricing(UpdatePricingCommand command)
		{
			await _mediator.Send(command);
			return Ok("Ödeme Türü Başarıyla Güncellendi.");
		}

	}
}
