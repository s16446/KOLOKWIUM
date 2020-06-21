using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium.DTOs.Responses;
using Kolokwium.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium.Controllers
{
	[Route("api/musicians")]
	[ApiController]
	public class MusiciansController : ControllerBase
	{
		private readonly IMusicDbService _dbService;
		
		public MusiciansController(IMusicDbService dbService)
		{
			_dbService = dbService;
		}

		[HttpGet("{id}")]
		public IActionResult GetMusician(int id) 
		{
			//try 
			//{
				var musician = _dbService.GetMusician(id);
				return Ok(musician); // 204
			//}
			//catch(MusicianDoesNotExistException exc)
			//{
			//	return NotFound(exc.Message);
			//}
		}

		[HttpPost]
		public IActionResult AddMusician(MusicianTracksRequest request)
		{
			try 
			{
				var musician = _dbService.AddMusician(request);
				return Ok(musician);
			}
			catch(TrackAlreadyExistException exc)
			{
				return BadRequest(exc.Message);
			}
		}
	}
}
