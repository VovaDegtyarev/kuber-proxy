using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DAL.Models;

namespace WebApp.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BrokerController : ControllerBase
	{
		[HttpPost("SendBroker")]
		public async Task<IActionResult> SendMessage([FromBody] MessageModel message)
		{
			return Ok("Is working");
		}
	}
}
